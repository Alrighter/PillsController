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

namespace PillsController
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Window _window1;
        private Window _window2;

        private void SetNewEventMainButton_OnClick(object sender, RoutedEventArgs e)
        {
            _window1 = new addEvent();
            _window1.Show();
            this.Close();
        }

        private void ShowEventsMainButton_OnClick(object sender, RoutedEventArgs e)
        {
            _window2 = new calendar();
            _window2.Show();
            this.Close();
        }
    }
}
