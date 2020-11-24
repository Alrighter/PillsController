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

        private void Image2_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
