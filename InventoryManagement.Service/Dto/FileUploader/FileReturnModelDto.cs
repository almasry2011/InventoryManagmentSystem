using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Dto.FileUploader
{
    public class FileReturnModelDto
    {

        public long Id { get; set; } 
        public string AbsolutePath { get; set; } //Fulpath
        public string RelativePath { get; set; }
        public string HttpFilePath { get; set; }
        public string MimeType { get; set; }
        public string Extension { get; set; }

    }
}
