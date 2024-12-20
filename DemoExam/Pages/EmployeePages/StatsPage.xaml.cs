using DemoExam.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace DemoExam.Pages.EmployeePages
{
    /// <summary>
    /// Логика взаимодействия для StatsPage.xaml
    /// </summary>
    public partial class StatsPage : Page
    {
        public StatsPage()
        {
            InitializeComponent();
            TBRequestCount.Text = App.DB.Requests.Count().ToString();

            List<Requests> requests = App.DB.Requests.Where(x => x.ComplitionDate != null).ToList();
            List<long> avg = new List<long>();
            foreach (var req in requests)
            {
                avg.Add(req.ComplitionDate.Value.Ticks - req.StartDate.Value.Ticks);
            }
            Nullable<int> amount = avg.Count();
            DateTime dt = new DateTime();
            foreach (var time in avg)
            {
                dt = dt.AddTicks(time);
            }
            long? avgTime = dt.Ticks / amount;
            TimeSpan days = TimeSpan.FromTicks(avgTime.Value);
            TBAverageTime.Text = days.Days.ToString() + " дней";

            var govno = App.DB.Requests
                .GroupBy(x => x.TechTypes)
                .Select(req => new { TechTypes = req.Key, Count = req.Count() })
                .OrderByDescending(obd => obd.Count)
                .ToList();



            TBMostRequestable.Text = govno.First().TechTypes.TechType.ToString();
        }
    }
}
