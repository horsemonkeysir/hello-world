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

namespace WpfApp20200819
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAnswer1_Click(object sender, RoutedEventArgs e)
        {
            this.Answer1.Text = "git clone 仓库地址";
        }

        private void ButtonAnswer2_Click(object sender, RoutedEventArgs e)
        {
            this.Answer2.Text = "cd 仓库文件夹名字";
        }

        private void ButtonAnswer3_Click(object sender, RoutedEventArgs e)
        {
            this.Answer3.Text = "git add .";
        }

        private void ButtonAnswer4_Click(object sender, RoutedEventArgs e)
        {
            this.Answer4.Text = "git commit -m “提交信息”（备注：引号中的信息内容必须填写）";
        }

        private void ButtonAnswer5_Click(object sender, RoutedEventArgs e)
        {
            this.Answer5.Text = "git push -u origin master";
        }
    }
}
