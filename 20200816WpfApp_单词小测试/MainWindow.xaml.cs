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

namespace WpfApp20200816
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

        private void ButtonshowTheTranslation1_Click(object sender, RoutedEventArgs e)
        {
            this.showTheTranslation1.Text = "常见的！";
        }

        private void ButtonshowTheTranslation2_Click(object sender, RoutedEventArgs e)
        {
            this.showTheTranslation2.Text = "控制台！";
        }

        private void ButtonshowTheTranslation3_Click(object sender, RoutedEventArgs e)
        {
            this.showTheTranslation3.Text = "对话！";
        }

        private void ButtonshowTheTranslation4_Click(object sender, RoutedEventArgs e)
        {
            this.showTheTranslation4.Text = "项目！";
        }

        private void ButtonshowTheTranslation5_Click(object sender, RoutedEventArgs e)
        {
            this.showTheTranslation5.Text = "参考，目录！";
        }

        private void ButtonshowTheTranslation6_Click(object sender, RoutedEventArgs e)
        {
            this.showTheTranslation6.Text = "调试！";
        }

        private void ButtonshowTheScore_Click(object sender, RoutedEventArgs e)
        {
            this.showTheScore.Text = "100分！恭喜！";
        }
    }
}
