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

namespace _9_3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text.Trim();
            string gender = "";
            string MariesStatus = "";
            List<string> Enjoy = new List<string>();
            if (name.Length == 0)
            {
                MessageBox.Show("Nhập đủ họ tên!");
                return;
            }
            foreach (RadioButton item in radGender.Children)
            {
                if (item.IsChecked == true)
                    gender = item.Content.ToString();
            }
            foreach (RadioButton item in radGetMarried.Children)
            {
                if (item.IsChecked == true)
                    MariesStatus = item.Content.ToString();
            }
            foreach (CheckBox item in cbEnjoy.Children)
            {
                if (item.IsChecked == true)
                    Enjoy.Add(item.Content.ToString());
            }
            string a = $"Họ tên: {name}\n Giới tính: {gender}\n Tình trạng hôn nhân: {MariesStatus}\n Sở thích: {Enjoy.Aggregate((a,b)=>a+","+b)}";
            lbItem.Items.Add(a);
            



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var resulf = MessageBox.Show("Bạn có muốn thoát không?", "thông báo", MessageBoxButton.OKCancel);
            if (resulf == MessageBoxResult.OK)
                App.Current.Shutdown();
        }
    }
}
