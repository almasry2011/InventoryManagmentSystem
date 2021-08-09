using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Domain.Entities
{
  public  class FIles:BaseEntity<long>
    {
        public int MyProperty { get; set; }
        public string AbsolutePath { get; set; } //Fulpath
        public string RelativePath { get; set; }
        public string HttpFilePath { get; set; }
        public string MimeType { get; set; }
        public string Extension { get; set; }
        public DateTime UploadDate { get; set; } = DateTime.Now;

        public long ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }

    }
}
