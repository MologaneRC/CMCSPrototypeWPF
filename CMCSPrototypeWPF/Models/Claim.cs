using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCSPrototypeWPF.Models
{
    public class Claim
    {
        public int ClaimId { get; set; }           // Unique claim ID
        public User Lecturer { get; set; }         // Lecturer who submitted the claim
        public string ClaimMonth { get; set; }     // Claim month, e.g., "2025-09"
        public decimal TotalHours { get; set; }    // Total hours worked
        public decimal TotalAmount { get; set; }   // Total claim amount
        public string Status { get; set; }         // e.g., "Submitted", "Approved", "Settled"
        public List<ClaimItem> Items { get; set; } = new();      // List of claim items
        public List<Document> Documents { get; set; } = new();   // Supporting documents
    }
}