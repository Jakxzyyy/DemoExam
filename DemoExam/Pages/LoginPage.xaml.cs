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

namespace DemoExam.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            App.LoggedUser = App.DB.Users.FirstOrDefault(x => x.UserLogin == TBLogin.Text && x.UserPassword == PBPassword.Password);
            if (App.LoggedUser != null )
            {
                NavigationService.Navigate(new EmployeeWorkPage());
            }
            else
            {
                MessageBox.Show("Учетные данные не верны!\n\n Проверьте раскладку и CapsLock.");
            }
        }
    }
}
