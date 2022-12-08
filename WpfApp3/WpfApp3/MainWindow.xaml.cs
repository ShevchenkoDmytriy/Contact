using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> phones;
        public MainWindow()
        {
            InitializeComponent();
            phones = new ObservableCollection<string>();
            phoneList.ItemsSource = phones;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string phone = add.Text;
            phones.Add(phone);
        }

        private void add_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            add.Clear();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string phone = add.Text;
            phones.Remove(phone);
        }
    }
}
