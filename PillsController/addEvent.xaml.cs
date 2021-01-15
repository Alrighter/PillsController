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

        private Window mainWindow;
        private string _pillName;
        private int _quontityPerDay;
        private int _duration;

        public string PillName { get { return _pillName; } set { _pillName = PillName; } }
        public int QuontityPerDay { get { return _quontityPerDay; } set { _quontityPerDay = QuontityPerDay; } }
        public int Duration { get { return _duration; } set { _duration = Duration; } }



        public addEvent()
        {
            InitializeComponent();
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
                QuontityPerDay = Convert.ToInt32(quontityPerDayCB.Text);
                Duration = Convert.ToInt32(DurationBox.Text);
            }
            
            catch (Exception exception)
            {
                MessageBox.Show("Введите корректные данные. " + exception);
            }

            SQLiteConnection sqlite_conn;
            sqlite_conn = db.CreateConnection();
            db.CreateTable(sqlite_conn);

            DateTime myDateTime = DateTime.Now;
            DateTime endDateTime = myDateTime.AddDays(Duration);
            string startSqlFormattedDate = Convert.ToString(myDateTime);
            string endSqlFormattedDate = Convert.ToString(endDateTime);

            db.InsertData(sqlite_conn, PillName, startSqlFormattedDate, endSqlFormattedDate, QuontityPerDay, Duration);

            MessageBox.Show("Done!");
        }
    } 
}
