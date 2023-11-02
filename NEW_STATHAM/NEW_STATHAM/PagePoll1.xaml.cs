using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
using NEW_STATHAM.Models;
using NEW_STATHAM.Services;

namespace NEW_STATHAM
{
    /// <summary>
    /// Логика взаимодействия для PagePoll1.xaml
    /// </summary>

    public partial class PagePoll1 : Page
    {
        private BindingList<allPolls2> _allPollsData;
        private BindingList<allPolls> _allPollsDataList;
        private List<allPolls.Item> _items = new List<allPolls.Item>();
        private readDataJson2 _dataJSON;
        private readDataJson _dataJSONList;
        public PagePoll1()
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
            dgFirstPoll.ItemsSource = _allPollsData[0].items;
            _allPollsData.ListChanged += _allPollsData_ListChanged;
        }

        private void _allPollsData_ListChanged(object sender, ListChangedEventArgs e)
        {
            if(e.ListChangedType==ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    //_dataJSON.SaveData(sender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
            saveItems(_items, 0);
            _dataJSON.SaveData(_items, path);
            dgFirstPoll.Visibility = Visibility.Collapsed;
            saveButton.Visibility = Visibility.Collapsed;
            framePage1.Content = new ALLPOLLS();
        }

    }
}
