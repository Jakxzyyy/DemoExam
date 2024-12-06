using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

namespace DemoExam.Pages.EmployeePages
{
    /// <summary>
    /// Логика взаимодействия для RequestsListViewPage.xaml
    /// </summary>
    public partial class RequestsListViewPage : Page
    {
        public RequestsListViewPage()
        {
            InitializeComponent();
            if (App.LoggedUser.UserTypeID == 2)
            {
                DGRequests.ItemsSource = App.DB.Requests.Where(x => x.Users1.UserID == App.LoggedUser.UserID).ToList();
            }
            if (App.LoggedUser.UserTypeID == 3)
            {
                DGRequests.ItemsSource = App.DB.Requests.ToList();
            }
        }
    }
}
