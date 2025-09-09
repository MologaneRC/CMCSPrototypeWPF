using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCSPrototypeWPF.Models
{
    public class Document
    {
        public string FileName { get; set; }       // Name of the uploaded file
        public string UploadedBy { get; set; }     // Lecturer or user who uploaded the file
    }
}
