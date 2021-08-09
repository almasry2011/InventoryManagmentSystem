using AutoMapper;
 
using InventoryManagement.Persistence;
using InventoryManagement.Service.Contract;
using InventoryManagement.Service.Dto.FileUploader;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Implementation
{
    public class FileUploaderService : IFileUploaderService
    {
        //private readonly ApplicationDbContext _context;
        //private readonly IMapper _Mapper;
        private readonly string basePath;
        private readonly IHttpContextAccessor _httpContextAccessor;

        //private readonly IConfiguration _config;

        public FileUploaderService(ApplicationDbContext context, IMapper mapper, IConfiguration config, IHttpContextAccessor httpContextAccessor)
        {
            //_context = context;
            //_Mapper = mapper;
            //_config = config;

            basePath = config["AppSettings:FileRooTPath"];
            _httpContextAccessor = httpContextAccessor;
        }


        //public async Task<IActionResult> UploadToDatabase(FileUploaderDto model)
        //{
        //    foreach (var file in model. files)
        //    {
        //        var fileName = Path.GetFileNameWithoutExtension(file.FileName);
        //        var extension = Path.GetExtension(file.FileName);
        //        var fileModel = new FileOnDatabaseModel
        //        {
        //            CreatedOn = DateTime.UtcNow,
        //            FileType = file.ContentType,
        //            Extension = extension,
        //            Name = fileName,
        //            Description = description
        //        };
        //        using (var dataStream = new MemoryStream())
        //        {
        //            await file.CopyToAsync(dataStream);
        //            fileModel.Data = dataStream.ToArray();
        //        }
        //        context.FilesOnDatabase.Add(fileModel);
        //        context.SaveChanges();
        //    }
        //    TempData["Message"] = "File successfully uploaded to Database";
        //    return RedirectToAction("Index");
        //}


        public async Task<List<FileReturnModelDto>> UploadFileAsync(List<IFormFile> Files, string module, string subFolder = "")
        {
            // var basePath = _config["AppSettings:FileRooTPath"];

            var res = new List<FileReturnModelDto>();

            if (Files != null)
            {
                foreach (IFormFile file in Files)
                {
                    var _path = "";

                    if (!string.IsNullOrEmpty(subFolder))
                    {
                        _path = Path.Combine(basePath + $"/{module}" + $"/{subFolder}");
                    }
                    else
                    {
                        _path = Path.Combine(basePath + $"/{module}");
                    }

                    //var basePath = Path.Combine(_config["AppSettings:FileRooTPath"] + $"/{module}");

                    bool _pathExists = System.IO.Directory.Exists(_path);
                    if (!_pathExists) Directory.CreateDirectory(_path);

                    //   var fileName = Path.GetFileNameWithoutExtension(file.FileName);

                    var extension = Path.GetExtension(file.FileName);


                    var filePath = Path.Combine(@$"{_path}", Path.GetRandomFileName())
                        .Replace(".", "").Trim().Replace("\\", "/").Replace(" ", "") + extension;


                    var RelPath = filePath.Replace(basePath, "");


                    if (!System.IO.File.Exists(filePath))
                    {
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                        string host = _httpContextAccessor.HttpContext.Request.Host.Value;


                        res.Add(new FileReturnModelDto
                        {
                            RelativePath = RelPath,
                            AbsolutePath = filePath,
                            Extension = extension,
                            MimeType = file.ContentType,
                            HttpFilePath = $"https://{host}{RelPath}"
                        });

                    }
                }
            }
            return res;
        }

        public async Task<FileReturnModelDto> UploadFileAsync(IFormFile file, string module="", string subFolder = "")
        {

            var res = new FileReturnModelDto();

            if (file != null)
            {
                
                    var _path = "";

                    if (!string.IsNullOrEmpty(subFolder))
                    {
                        _path = Path.Combine(basePath + $"/{module}" + $"/{subFolder}");
                    }
                    else
                    {
                        _path = Path.Combine(basePath + $"/{module}");
                    }

                    //var basePath = Path.Combine(_config["AppSettings:FileRooTPath"] + $"/{module}");

                    bool _pathExists = System.IO.Directory.Exists(_path);
                    if (!_pathExists) Directory.CreateDirectory(_path);

                    //   var fileName = Path.GetFileNameWithoutExtension(file.FileName);

                    var extension = Path.GetExtension(file.FileName);


                    var filePath = Path.Combine(@$"{_path}", Path.GetRandomFileName())
                        .Replace(".", "").Trim().Replace("\\", "/").Replace(" ", "") + extension;


                    var RelPath = filePath.Replace(basePath, "");


                    if (!System.IO.File.Exists(filePath))
                    {
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                        string host = _httpContextAccessor.HttpContext.Request.Host.Value;


                        res=new FileReturnModelDto
                        {
                            RelativePath = RelPath,
                            AbsolutePath = filePath,
                            Extension = extension,
                            MimeType = file.ContentType,
                            HttpFilePath = $"https://{host}{RelPath}"
                        };

                    }
                
            }
            return res;
        }

 

        public string GetFileFullURl(string filepath)
        {
            // var basePath = _config["AppSettings:FileRooTPath"];
            var filePath = Path.Combine(basePath, filepath).Trim().Replace("\\", "/").Replace(" ", "");
            return filePath;
        }



        //public async Task<bool> DeleteFileFromFileSystem(int id)
        //{
        //    var file = await context.FilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
        //    if (file == null) return null;
        //    if (System.IO.File.Exists(file.FilePath))
        //    {
        //        System.IO.File.Delete(file.FilePath);
        //    }
        //    context.FilesOnFileSystem.Remove(file);
        //    context.SaveChanges();
        //    //TempData["Message"] = $"Removed {file.Name + file.Extension} successfully from File System.";
        //    //return RedirectToAction("Index");
        //}



        //public async Task<IActionResult> DeleteFileFromFileSystem(int id)
        //{
        //    var file = await context.FilesOnFileSystem.Where(x => x.Id == id).FirstOrDefaultAsync();
        //    if (file == null) return null;
        //    if (System.IO.File.Exists(file.FilePath))
        //    {
        //        System.IO.File.Delete(file.FilePath);
        //    }
        //    context.FilesOnFileSystem.Remove(file);
        //    context.SaveChanges();
        //    TempData["Message"] = $"Removed {file.Name + file.Extension} successfully from File System.";
        //    return RedirectToAction("Index");
        //}


    }


}
