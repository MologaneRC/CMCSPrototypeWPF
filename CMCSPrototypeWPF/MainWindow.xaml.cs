using System.Collections.Generic;
using System.Windows;
using CMCSPrototypeWPF.Models;

namespace CMCSPrototypeWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadMockClaims();
        }

        private void LoadMockClaims()
        {
            var lecturer = new User { FullName = "Dr. Jane Smith", Role = "Lecturer" };
            var claims = new List<Claim>
            {
                new Claim { ClaimId=1, Lecturer=lecturer, ClaimMonth="2025-08", TotalHours=12, TotalAmount=1200, Status="Settled"},
                new Claim { ClaimId=2, Lecturer=lecturer, ClaimMonth="2025-09", TotalHours=8, TotalAmount=800, Status="Submitted"}
            };
            ClaimsDataGrid.ItemsSource = claims;
        }

        private void NewClaim_Click(object sender, RoutedEventArgs e)
        {
            var newClaimWindow = new NewClaimWindow();
            newClaimWindow.Show();
        }
    }
}
