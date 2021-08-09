using InventoryManagement.Service.Contract;
using InventoryManagement.Service.Dto.FileUploader;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
 
        private readonly IFileUploaderService _fileUploader;

        public FileController( IFileUploaderService fileUploader)
        {
            _fileUploader = fileUploader;
        }

        //[HttpPost, Route("UploadFiles")]
        ////public async Task<IActionResult> UploadFiles(List<IFormFile> Files, FileUploaderDto model)
        //public async Task<IActionResult> UploadFiles(FileUploaderDto model)
        //{
        //    ////var result = model;
        //    var result = await _fileUploader.UploadFileAsync(model, "Products", "Product1");
        //    return Ok(result);
        //}

        [HttpPost, Route("UploadFiles1")]
        //public async Task<IActionResult> UploadFiles(List<IFormFile> Files, FileUploaderDto model)
        public async Task<IActionResult> UploadFiles1(List<IFormFile> Files, [FromForm] string key)
        {
            var result = await _fileUploader.UploadFileAsync(Files, "Products", "Product1");
            return Ok(result);
        }

        [HttpPost, Route("UploadFiles")]
        public async Task<IActionResult> UploadFiles(IFormFile File, [FromForm]string key="")
        {
            var result = await _fileUploader.UploadFileAsync(File, "Products", "Product1");
               return Ok(result);
        }



    }
}
