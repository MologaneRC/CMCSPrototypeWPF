using System.Collections.Generic;
using System.Windows;
using CMCSPrototypeWPF.Models;

namespace CMCSPrototypeWPF
{
    public partial class NewClaimWindow : Window
    {
        public NewClaimWindow()
        {
            InitializeComponent();
            LoadMockItems();
        }

        private void LoadMockItems()
        {
            var items = new List<ClaimItem>
            {
                new ClaimItem{ Description="Lecture: Intro to AI", Hours=4, HourlyRate=100},
                new ClaimItem{ Description="Tutorial: Lab", Hours=4, HourlyRate=100}
            };
            ItemsDataGrid.ItemsSource = items;
        }
    }
}
