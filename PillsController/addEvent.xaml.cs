using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Shapes;

namespace PillsController
{
    /// <summary>
    /// Логика взаимодействия для addEvent.xaml
    /// </summary>
    public partial class addEvent : Window
    {
        private ApplicationContext db;

        private Window mainWindow;
        private string _pillName;
        private byte _quontityPerDay;
        private byte _duration;
        private int _pillNum;

        public string PillName { get { return _pillName; } set { _pillName = PillName; } }
        public byte QuontityPerDay { get { return _quontityPerDay; } set { _quontityPerDay = QuontityPerDay; } }
        public byte Duration { get { return _duration; } set { _duration = Duration; } }
        public int PillNum { get { return _pillNum; } set { _pillNum = PillNum; } }

        public addEvent()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        

        private void TypeName_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Введите название, которое будет отображаться в напоминании.");
        }

        private void ChooseQuantity_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Выберите как часто вы будете принимать таблетки за сутки.");
            
        }

        private void ChoosePeriodTXT_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Введите количество дней, сколько вам нужно принимать таблетки.");
        }

        private void Image2_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Confirm(object sender, MouseButtonEventArgs e)
        {
            PillName = Convert.ToString(typeNameBox.Text);
            
            try
            {
                QuontityPerDay = Convert.ToByte(quontityPerDayCB.Text);
                Duration = Convert.ToByte(DurationBox.Text);

                Database.SetInitializer<ApplicationContext>(null);
                Pill pill = new Pill(PillName, DateTime.UtcNow, DateTime.UtcNow.AddDays(Duration), QuontityPerDay);

                db.Pills.Add(pill);
                db.SaveChanges();
            }

            catch (Exception exception)
            {
                MessageBox.Show("Введите корректные данные. " + exception);
            }

        }
    }
}
