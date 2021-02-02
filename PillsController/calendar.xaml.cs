using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
    /// Логика взаимодействия для calendar.xaml
    /// </summary>
    public partial class calendar : Window
    {
        public calendar()
        {
            InitializeComponent();
        }

        private Window mainWindow;

        public SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlconn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            try
            {
                sqlconn.Open();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error: " + Convert.ToString(Ex));
            }
            return sqlconn;
        }

        public void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM SampleTable";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                Console.WriteLine(myreader);
            }
            conn.Close();
        }

        private void Image2_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
