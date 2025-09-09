using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCSPrototypeWPF.Models
{
    public class User
    {
        public string FullName { get; set; }    // Lecturer/Coordinator/Manager name
        public string Role { get; set; }        // "Lecturer", "Coordinator", "Manager"
    }
}
