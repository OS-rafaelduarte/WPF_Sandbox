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

namespace WPF_Sandbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height = 600;
            this.Width = 900;
            this.Top = 50;
            this.Left = 50;
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            OpenSecondWindow();
        }

        private async Task OpenSecondWindow()
        {
            var secondWindow = new SecondWindow();
            secondWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            secondWindow.Owner = this;
            secondWindow.Height = 200;
            secondWindow.Width = 200;

            await Task.Delay(3000);
            secondWindow.Show();
        }
    }
}
