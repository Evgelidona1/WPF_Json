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
    /// Логика взаимодействия для PagePoll3.xaml
    /// </summary>
    public partial class PagePoll3 : Page
    {
        private BindingList<allPolls2> _allPollsData;
        private List<allPolls.Item> _items = new List<allPolls.Item>();
        private readDataJson2 _dataJSON;
        private BindingList<allPolls> _allPollsDataList;
        private readDataJson _dataJSONList;
        public PagePoll3()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _dataJSON = new readDataJson2("form.json");
            _dataJSONList = new readDataJson("form.json");
            try
            {
                _allPollsData = _dataJSON.loadData();
                _allPollsDataList = _dataJSONList.loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgThirdPoll.ItemsSource = _allPollsData[2].items;
        }
        private void saveItems(List<allPolls.Item> _items, int id)
        {
            int count = _allPollsDataList[id].items.Count;
            for (int i = 0; i < count; i++)
            {
                _items.Add(new allPolls.Item
                {
                    description = _allPollsDataList[id].items[i].description,
                    isDone = _allPollsDataList[id].items[i].isDone
                });
            }
        }
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            string path = $@"{DateTime.Now.Ticks}.json";

            //_dataJSON.SaveData(_allPollsData, path);
            saveItems(_items, 2);
            _dataJSON.SaveData(_items, path);
            dgThirdPoll.Visibility = Visibility.Collapsed;
            saveButton.Visibility = Visibility.Collapsed;
            framePage3.Content = new ALLPOLLS();
        }
    }
}
