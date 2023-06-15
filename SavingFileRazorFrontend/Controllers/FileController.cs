using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using SavingFileRazorFrontend.Models;
using SavingFileRazorFrontend.Services;

namespace SavingFileRazorFrontend.Controllers
{
    public class FileController : Controller
    {
        public CrudService _crudService;

        public FileController()
        {
            _crudService = new CrudService();
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            var token = HttpContext.Request.Cookies["jwt"];

            string url = "https://localhost:44391/file";

            var result = await _crudService.GetById<FileModel>(url, id, token);
            ViewData["Message"] = "";
            return View(result);
        }

        public IActionResult UploadFile()
        {
            var status = HttpContext.Request.Cookies["jwt"];
            if (string.IsNullOrEmpty(status))
            {
                ViewData["Message"] = "NoAuth";
            }

            return View();
        }

        public async Task<IActionResult> UploadedFile()
        {
            if (HttpContext.Request.Cookies["role"] == "admin")
            {
                ViewData["Message"] = "Auth";
            }

            var fileModel = new FileSearchModel();
            var email = HttpContext.Request.Cookies["email"];
            if (!string.IsNullOrEmpty(email))
            {

                fileModel.FileName = Request.Form["search"];
                fileModel.Email = email;
  
            }
            else if (string.IsNullOrEmpty(email))
            {
                fileModel.FileName = Request.Form["search"];
                fileModel.Email = Request.Form["email"];
            }
            
            string url = "https://localhost:44391/file/search";

            var response = await _crudService.SearchNoAuth<SavingFileRazorFrontend.Models.FileSearchModel, FileModel>(url, fileModel);

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Index([Bind("Email, FileName")] SavingFileRazorFrontend.Models.FileSearchModel model)
        {
            model.FileName = Request.Form["search"];
            model.Email = Request.Form["email"];

            string url = "https://localhost:44391/file/search";

            var response = await _crudService.SearchNoAuth<SavingFileRazorFrontend.Models.FileSearchModel, FileModel>(url, model);

            return RedirectToAction("UploadedFile","File",  response);
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(FileModel model)
        {

            var statusFile = Request.Form["StatusFile"];
            if (string.IsNullOrEmpty(statusFile))
            {
                model.StatusFile = "Public";
            }
            else if (!string.IsNullOrEmpty(statusFile))
            {
                model.StatusFile = statusFile;
            }

            if (model.File.Length > 0)
            {
                using var ms = new MemoryStream();
                model.File.CopyTo(ms);
                var fileBytes = ms.ToArray();
                model.Photo = fileBytes;
            }

            string url = "https://localhost:44391/file/nologin";

            var response = await _crudService.CreateNoLogin<FileModel>(url, model);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            string url = "https://localhost:44391/file";
            var token = HttpContext.Request.Cookies["jwt"];

            await _crudService.Delete(url, token, id);

            throw new NotImplementedException();
        }

        public async Task<IActionResult> EditModel(int id, FileModel model)
        {
            model.UpdatedByLogin = HttpContext.Request.Cookies["email"];
            var token = HttpContext.Request.Cookies["jwt"];
            string url = "https://localhost:44391/file";

            var response = await _crudService.Edit(url, id, token, model);

            return RedirectToAction(nameof(Index));
        }
    }
}
