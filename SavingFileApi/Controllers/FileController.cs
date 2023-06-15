using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SavingFileApi.Interfaces;
using SavingFileApi.Models;
using SavingFileApi.Services;

namespace SavingFileApi.Controllers
{
    [ApiController]
    [Route("file")]
    [Authorize]
    public class FileController : ControllerBase
    {
        private ICrudScheme<FileService> _service;

        public FileController(ICrudScheme<FileService> service)
        {
            _service = service;
        }

        [HttpPost]
        [AllowAnonymous]
        //[Authorize(Roles = "admin, user")]
        public ActionResult Create([FromBody] FileModel model)
        {
            var result = _service.Create<FileModel>(model);

            return Ok(result);
        }

        //[HttpPost]
        //[Route("file/nologin")]
        //[AllowAnonymous]
        //public ActionResult CreateNoLogin([FromBody] FileModel model)
        //{
        //    var result = _service.CreateNoLogin<FileModel>(model);

        //    return Ok(result);
        //}

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin, user")]
        public ActionResult Delete([FromRoute] int id)
        {
            var result = _service.Delete(id);
            return Ok(result);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult<List<FileModel>> Get()
        {
            var result = _service.Get<FileModel>();
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "admin, user")]
        public ActionResult<FileModel> GetById([FromRoute] int id)
        {
            var result = _service.GetById<FileModel>(id);
            return Ok(result);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "admin")]
        public ActionResult Update([FromBody] FileModel dto, [FromRoute] int id)
        {
            var result = _service.Update(id, dto);

            return Ok(result);
        }
    }
}
