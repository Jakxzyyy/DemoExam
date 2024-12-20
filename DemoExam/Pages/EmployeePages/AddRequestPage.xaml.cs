using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Channels;
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
        Requests newRequest = new Requests();
        bool isNew = false;
        public AddRequestPage()
        {
            InitializeComponent();
            TBMainLabel.Text = "Добавление заявки";
            BAddRequest.Content = "Добавить";
            isNew = true;
            foreach (FrameworkElement obj in SPMain.Children)
            { 
               obj.IsEnabled = true;
            }
            newRequest.RequestID = App.DB.Requests.OrderByDescending(x => x.RequestID).First().RequestID + 1;
        }

        public AddRequestPage(Requests requestToEdit)
        {
            InitializeComponent();
            isNew = false;
            newRequest = requestToEdit;
            TBMainLabel.Text = "Редактирование заявки";
            BAddRequest.Content = "Сохранить";
            foreach (FrameworkElement obj in SPMain.Children)
            {
                if (obj.Tag != null)
                {
                    obj.IsEnabled = true;
                }
                else
                {
                    obj.IsEnabled = false;
                }
            }
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CBClient.ItemsSource = App.DB.Users.Where(x => x.UserTypeID == 4).ToList();
            CBMaster.ItemsSource = App.DB.Users.Where(x => x.UserTypeID == 2).ToList();
            CBStatus.ItemsSource = App.DB.RequestStatuses.ToList();
            CBTechType.ItemsSource = App.DB.TechTypes.ToList();
            DataContext = newRequest;
        }

        private void BAddRequest_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = string.Empty;
            if (newRequest.MasterID == null)
            {
                errorMessage += "\nВыберите техника";
            }
            if (newRequest.ClientID == null)
            {
                errorMessage += "\nВыберите клиента";
            }
            if (newRequest.TechTypeID == null)
            {
                errorMessage += "\nВыберите вид устройства";
            }
            if (String.IsNullOrWhiteSpace(newRequest.TechModel))
            {
                errorMessage += "Укажите название устройства";
            }
            if (String.IsNullOrWhiteSpace(newRequest.Description))
            {
                errorMessage += "\nУкажите описание";
            }
            if (newRequest.RequestStatusID == null)
            {
                errorMessage += "\nВыберите статус заказа";
            }
            if (newRequest.StartDate == null)
            {
                errorMessage += "\nВыберите дату начала ремонта";
            }
            if (String.IsNullOrEmpty(errorMessage))
            {
                if (isNew == true)
                {
                    App.DB.Requests.Add(newRequest);
                    App.DB.SaveChanges();
                    newRequest = null;
                    MessageBox.Show("Заявка добавлена");
                }
                else
                {
                    App.DB.SaveChanges();
                    App.RequestToEdit = null;
                    MessageBox.Show("Заявка изменена");
                }
                return;
            }
            MessageBox.Show(errorMessage, "Ошибка!");
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            App.RequestToEdit = null;
            newRequest = null;
            NavigationService.GoBack();
        }
    }
}
