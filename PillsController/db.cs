using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillsController
{
    class db
    {

        public SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlconn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            try
            {
                sqlconn.Open();
            }
            catch (Exception Ex)
            {

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

        public void InsertData(SQLiteConnection conn, string name, string startDate, string endDate, int frequency, int quantityOfDays)
        {

            for (int i = 0; i < quantityOfDays; i++)
            {
                for (int a = 0; a < frequency; a++)
                {
                    SQLiteCommand sqlcmd = new SQLiteCommand($"INSERT INTO Information (NAME, START_DATE, END_DATE, FREQUENCY) VALUES({name}, '{startDate}', '{endDate}', {frequency});", conn);

                    sqlcmd.ExecuteNonQuery();
                }
            }

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
    }
}
