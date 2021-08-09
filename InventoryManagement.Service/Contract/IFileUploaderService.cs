using InventoryManagement.Service.Dto.FileUploader;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Contract
{
    public interface IFileUploaderService
    {
        Task<List<FileReturnModelDto>> UploadFileAsync(List<IFormFile> Files, string module, string subFolder = "");
      Task<FileReturnModelDto> UploadFileAsync(IFormFile File, string module="", string subFolder = "");
 
        string GetFileFullURl(string filepath);
    }
}
