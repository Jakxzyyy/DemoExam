using DemoExam.DataBase;
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
            if (App.LoggedUser.UserTypeID == 3)
            {
                DGRequests.ItemsSource = App.DB.Requests.Where(x => x.Users1.UserID == App.LoggedUser.UserID).ToList();
            }
            if (App.LoggedUser.UserTypeID == 1)
            {
                DGRequests.ItemsSource = App.DB.Requests.ToList();
            }
            if (App.LoggedUser.UserTypeID == 4)
            {
                DGRequests.ItemsSource = App.DB.Requests.Where(x => x.Users.UserID == App.LoggedUser.UserID).ToList();
            }

            RequestStatuses all = new RequestStatuses();
            all.Status = "Все";
            List<RequestStatuses> requestStatuses = new List<RequestStatuses>();
            requestStatuses.Add(all);
            requestStatuses.AddRange(App.DB.RequestStatuses.ToList());
            CBRequestStatuses.ItemsSource = requestStatuses;
            CBRequestStatuses.SelectedIndex = 0;
        }

        private void DGRequests_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (DGRequests.SelectedCells.Count > 1)
            {
                DGRequests.SelectedCells.ToList().Last();
            }
            App.RequestToEdit = DGRequests.SelectedValue as Requests;
        }

        private void CBRequestStatuses_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeSource();
        }
        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChangeSource();
        }

        private void ChangeSource()
        {
            var source = App.DB.Requests.ToList();
            if (App.LoggedUser.UserTypeID == 4)
            {
                source = App.DB.Requests.Where(x => x.Users.UserID == App.LoggedUser.UserID).ToList();
            }
            if (App.LoggedUser.UserTypeID == 2)
            {
                source = App.DB.Requests.Where(x => x.Users1.UserID == App.LoggedUser.UserID).ToList();
            } 
            if (CBRequestStatuses.SelectedIndex != 0)
            {
                source = source.Where(x => x.RequestStatuses == CBRequestStatuses.SelectedItem).ToList();
            }
            if (!String.IsNullOrWhiteSpace(TBSearch.Text))
            {
                source = source.Where(x => x.TechModel.Contains(TBSearch.Text)).ToList();
            }
            DGRequests.ItemsSource = source;
        }

    }
}
