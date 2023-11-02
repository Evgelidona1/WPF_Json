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
    /// Логика взаимодействия для PageReduct4.xaml
    /// </summary>
    public partial class PageReduct4 : Page
    {
        private BindingList<allPolls> _allPollsData;
        private readDataJson _dataJSON;
        public PageReduct4()
        {
            InitializeComponent();
        }

        private void changeButton_Click(object sender, RoutedEventArgs e)
        {
            dgFourdReduct.Visibility = Visibility.Collapsed;
            changeButton.Visibility = Visibility.Collapsed;
            _dataJSON.SaveData(_allPollsData, "form.json");
            framePage4.Content = new PagePoll1();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _dataJSON = new readDataJson("form.json");
            try
            {
                _allPollsData = _dataJSON.loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgFourdReduct.ItemsSource = _allPollsData[3].items;
        }
    }
}
