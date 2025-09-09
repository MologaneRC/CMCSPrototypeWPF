using System.Collections.Generic;
using System.Windows;
using CMCSPrototypeWPF.Models;

namespace CMCSPrototypeWPF
{
    public partial class CoordinatorWindow : Window
    {
        public CoordinatorWindow()
        {
            InitializeComponent();
            LoadMockClaims();
        }

        private void LoadMockClaims()
        {
            var claims = new List<Claim>
            {
                new Claim { ClaimId=2, Lecturer=new User{FullName="Dr. Jane Smith"}, ClaimMonth="2025-09", TotalHours=8, TotalAmount=800, Status="Submitted"},
                new Claim { ClaimId=3, Lecturer=new User{FullName="Mr. Mark Reader"}, ClaimMonth="2025-09", TotalHours=6, TotalAmount=600, Status="Submitted"}
            };
            ClaimsDataGrid.ItemsSource = claims;
        }
    }
}
