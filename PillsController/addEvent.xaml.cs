using System;
using System.Data.SQLite;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace PillsController
{
    /// <summary>
    /// Логика взаимодействия для addEvent.xaml
    /// </summary>
    public partial class addEvent : Window
    {

        Window MainWindow;
        string PillName; 
        int Frequency;
        DateTime StartDateTime;
        DateTime EndDateTime;


        public addEvent()
        {
            InitializeComponent();
        }

        
        private void Confirmation_Button(object sender, MouseButtonEventArgs e)
        {
            try
            {
                PillName = NameBox.Text;
                Frequency = Int32.Parse(FrequencyBox.Text);
                StartDateTime = Convert.ToDateTime(StartDatePicker.Text);
                EndDateTime = Convert.ToDateTime(EndDatePicker.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Введите корректные данные.");
            }
            

            SQLiteConnection sqLite_connection = CreateConnection();
            CreateTable(sqLite_connection);
            InsertData(sqLite_connection, PillName, Convert.ToString(StartDateTime), Convert.ToString(EndDateTime), Frequency);
        }

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

        public void CreateTable(SQLiteConnection conn)
        {

            SQLiteCommand sqlcmd;
            string createTableCmd = "CREATE TABLE IF NOT EXISTS Information(ID INTEGER NOT NULL UNIQUE, NAME TEXT NOT NULL,START_DATE TEXT NOT NULL, END_DATE TEXT NOT NULL,FREQUENCY INTEGER NOT NULL, PRIMARY KEY(ID AUTOINCREMENT)); ";
            sqlcmd = conn.CreateCommand();

            sqlcmd.CommandText = createTableCmd;
            sqlcmd.ExecuteNonQuery();

        }

        public void InsertData(SQLiteConnection conn, string name, string startDate, string endDate, int frequency)
        {
            SQLiteCommand sqlcmd = new SQLiteCommand($"INSERT INTO Information (NAME, START_DATE, END_DATE, FREQUENCY) VALUES('{name}', '{startDate}', '{endDate}', {frequency});", conn);
            sqlcmd.ExecuteNonQuery();
        }

        private void NameTBox_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Введите название, которое будет отображаться в напоминании.");
        }

        private void FrequencyTBox_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Выберите как часто вы будете принимать таблетки за сутки.");

        }

        private void LeftArrowImage_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

    }
}
