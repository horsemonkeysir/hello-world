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

namespace WpfApp20200817
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void showAnswer1_Click(object sender, RoutedEventArgs e)
        {
            this.Answer1.Text = "斯坦利 库布里克";
        }

        private void showAnswer2_Click(object sender, RoutedEventArgs e)
        {
            this.Answer2.Text = "1928年7月26日";
        }

        private void showAnswer3_Click(object sender, RoutedEventArgs e)
        {
            this.Answer3.Text = "1968年";
        }
    }
}
