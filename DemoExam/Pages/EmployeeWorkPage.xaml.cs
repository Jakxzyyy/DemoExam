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
using DemoExam.Pages.EmployeePages;
using DemoExam.Pages.ClientPages;
using MessagingToolkit.QRCode.Codec;
using System.Windows.Interop;

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
            if (App.LoggedUser.UserTypeID == 1)
            {
                BChangeRequest.Visibility = Visibility.Collapsed;
                BComments.Visibility = Visibility.Collapsed;
                IQR.Visibility = Visibility.Collapsed;
            }
            if (App.LoggedUser.UserTypeID == 2)
            {
                BAddRequest.Visibility = Visibility.Collapsed;
                BComments.Visibility = Visibility.Collapsed;
                BStats.Visibility = Visibility.Collapsed;
                IQR.Visibility = Visibility.Collapsed;
            }
            if (App.LoggedUser.UserTypeID == 3)
            {
                BAddRequest.Visibility = Visibility.Collapsed;
                BComments.Visibility = Visibility.Collapsed;
                BStats.Visibility = Visibility.Collapsed;
                IQR.Visibility = Visibility.Collapsed;
            }
            if (App.LoggedUser.UserTypeID == 4)
            {
                BStats.Visibility = Visibility.Collapsed;
                BStats.Visibility = Visibility.Collapsed;
                BChangeRequest.Visibility = Visibility.Collapsed;
            }
            WorkFrame.Navigate(new RequestsListViewPage());

            var encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            var image = encoder.Encode("https://docs.google.com/forms/d/e/1FAIpQLSdhZcExx6LSIXxk0ub55mSu-WIh23WYdGG9HY5EZhLDo7P8eA/viewform?usp=sf_link");
            IQR.Source = Imaging.CreateBitmapSourceFromHBitmap(image.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, null);
        }

        private void BAddRequest_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddRequestPage());
        }

        private void BChangeRequest_Click(object sender, RoutedEventArgs e)
        {
            if (App.RequestToEdit == null)
            {
                MessageBox.Show("Выберите заявку для редактирования");
                return;
            }
            NavigationService.Navigate(new AddRequestPage(App.RequestToEdit));
        }

        private void BComments_Click(object sender, RoutedEventArgs e)
        {
            var source = App.DB.Comments.Where(x => x.UserID == App.LoggedUser.UserID).ToList();
            if (source == null)
            {
                MessageBox.Show("Коментариев нет");
                return;
            }
            WorkFrame.Navigate(new CommentsPage(source));
        }

        private void BStats_Click(object sender, RoutedEventArgs e)
        {
            WorkFrame.Navigate(new StatsPage());
        }

        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack == true)
            {
                NavigationService.GoBack();
            }
        }
    }
}
