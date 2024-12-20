using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DemoExam.DataBase;

namespace DemoExam
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static TechRepairEntities DB = new TechRepairEntities();
        public static Users LoggedUser;
        public static Requests RequestToEdit;

        public static RequestStatuses RequestStatus;
    }
}
