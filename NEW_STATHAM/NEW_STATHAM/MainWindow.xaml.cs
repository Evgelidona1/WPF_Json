using NEW_STATHAM.Models;
using NEW_STATHAM.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace NEW_STATHAM
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public readonly string PATH = $"{Environment.CurrentDirectory}\\form.json";
        //public BindingList<allPolls> _allPollsData;
        //public readDataJson _dataJSON;
        public MainWindow()
        {
            InitializeComponent();
            frame.Content = new ALLPOLLS();
        }

        private void dgPollList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            }
        private void startButton_Click(object sender, RoutedEventArgs e)
        {
        }
    }

}

