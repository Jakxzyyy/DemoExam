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

namespace DemoExam.Pages.ClientPages
{
    /// <summary>
    /// Логика взаимодействия для CommentsPage.xaml
    /// </summary>
    public partial class CommentsPage : Page
    {
        public CommentsPage(List<Comments> source)
        {
            InitializeComponent();
            LVComments.ItemsSource = source;
        }

        private void LVComments_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (LVComments.SelectedItem != null)
            {
                Comments selectedComment = LVComments.SelectedItem as Comments;
                MessageBoxButton button = MessageBoxButton.YesNo;
                if (MessageBox.Show("Пометить коментарий как 'прочитанный' и убрать из списка?", "Подтверждение", button) == MessageBoxResult.Yes)
                {
                    App.DB.Comments.Remove(selectedComment);
                    App.DB.SaveChanges();
                    LVComments.Items.Refresh();
                }
            }
        }
    }
}
