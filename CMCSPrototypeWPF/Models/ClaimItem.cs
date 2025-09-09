using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCSPrototypeWPF.Models
{
    public class ClaimItem
    {
        public string Description { get; set; }    // Description of task or lecture
        public decimal Hours { get; set; }         // Number of hours
        public decimal HourlyRate { get; set; }    // Rate per hour

        // Calculated property
        public decimal Amount => Hours * HourlyRate;
    }
}
