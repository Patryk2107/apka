using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SavingApiMenager.Contracts;
using SavingApiMenager.Models;
using SavingApiMenager.Services;

namespace SavingApiMenager.Controllers
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
        [Authorize(Roles = "admin, user")]
        public ActionResult Create([FromBody] FileModel model)
        {
            var result = _service.Create<FileModel>(model);

            return Ok(result);
        }

        [HttpPost]
        [Route("nologin")]
        [AllowAnonymous]
        public ActionResult CreateNoLogin([FromBody] FileModel model)
        {
            var result = _service.CreateNoLogin<FileModel>(model);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin, user")]
        public ActionResult Delete([FromRoute] int id)
        {
            var result = _service.Delete(id);
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "admin, user")]
        public ActionResult GetById([FromRoute] int id)
        {
            var result = _service.GetById<FileModel>(id);
            return Ok(result);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult<List<FileModel>> Get()
        {
            var result = _service.Get<FileModel>();
            return Ok(result);
        }

        [HttpPost]
        [Route("extended")]
        [AllowAnonymous]
        public ActionResult<List<FileModel>> GetExtended([FromBody] FileModelQuery query)
        {
            var result = _service.GetGetExtended<FileModel>(query);
            return Ok(result);
        }
        
        [HttpPost]
        [Route("search")]
        [AllowAnonymous]
        public ActionResult<FileModel> GetByFileName([FromBody] FileSearchModel model)
        {
            var result = _service.GetByFileName(model);
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
