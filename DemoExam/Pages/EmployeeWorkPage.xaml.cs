using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DemoExam.Pages.EmployeePages;

namespace DemoExam.Pages
{
    /// <summary>
    /// Логика взаимодействия для EmployeeWorkPage.xaml
    /// </summary>
    public partial class EmployeeWorkPage : Page
    {
        public EmployeeWorkPage()
        {
            InitializeComponent();
        }

        private void BRequests_Click(object sender, RoutedEventArgs e)
        {
            WorkFrame.Navigate(new RequestsListViewPage());
        }

        private void BStats_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BAddRequest_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddRequestPage());
        }

        private void BChangeRequest_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
