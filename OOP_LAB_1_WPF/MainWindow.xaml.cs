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

namespace OOP_LAB_1_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int buf = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Properties.Settings setings = Properties.Settings.Default;
            string message = Properties.Resources.ResHello + ", " + setings.Name;
            label1.Content = message;
            MessageBox.Show(message);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Properties.Settings setings = Properties.Settings.Default;
            string message = Properties.Resources.ResGoodbye + ", " + setings.Name;
            label1.Content = message;
            MessageBox.Show(message);
            buf++;
            if (buf >= 3)
                e.Cancel = false;
        }
    }
}
