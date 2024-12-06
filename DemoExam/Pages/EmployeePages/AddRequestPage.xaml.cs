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
using DemoExam.DataBase;

namespace DemoExam.Pages.EmployeePages
{
    /// <summary>
    /// Логика взаимодействия для AddRequestPage.xaml
    /// </summary>
    public partial class AddRequestPage : Page
    {
        Requests newRequest;
        public AddRequestPage()
        {
            InitializeComponent();
            CBClient.ItemsSource = App.DB.Users.ToList();
            CBMaster.ItemsSource = App.DB.Users.Where(x => x.UserTypeID == 2).ToList();
            CBTechType.ItemsSource = App.DB.TechTypes.ToList();
            DataContext = newRequest;
        }

        private void BAddRequest_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = string.Empty;
            if (CBMaster.SelectedValue == null)
            {
                errorMessage += "\nВыберите техника";
                return;
            }
            if (CBClient.SelectedValue == null)
            {
                errorMessage += "\nВыберите клиента";
                return;
            }
            if (CBTechType.SelectedValue == null)
            {
                errorMessage += "\nВыберите вид устройства";
                return;
            }
            if (String.IsNullOrWhiteSpace(TBTechModel.Text))
            {
                errorMessage += "Укажите название устройства";
                return;
            }
            if (String.IsNullOrWhiteSpace(TBDescription.Text))
            {
                errorMessage += "Укажите описание";
                return;
            }
            if (String.IsNullOrEmpty(errorMessage))
            {
                newRequest.StartDate = DateTime.Now;
                newRequest.RequestStatusID = 3;
                App.DB.Requests.Add(newRequest);
                App.DB.SaveChanges();
                return;
            }
            MessageBox.Show(errorMessage);
        }
    }
}
