using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Dto.FileUploader
{
   public class FileUploaderDto
    {
        public List<IFormFile> Files { get; set; }
        public IFormCollection Files1 { get; set; }
        public string Description { get; set; }
    }
}
