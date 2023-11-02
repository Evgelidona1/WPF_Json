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
    /// Логика взаимодействия для ALLPOLLS.xaml
    /// </summary>
    public partial class ALLPOLLS : Page
    {
        public readonly string PATH = $"{Environment.CurrentDirectory}\\form.json";
        public BindingList<allPolls> _allPollsData;
        public readDataJson _dataJSON;
        public ALLPOLLS()
        {
            InitializeComponent();
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
            dgPollList.ItemsSource = _allPollsData;
        }

        private void dgPollList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ModalChoice modalChoice = new ModalChoice();
            var id = dgPollList.SelectedIndex;
            if (e.ChangedButton == MouseButton.Left)
            {
                //var item = sender as ListViewItem;
                //PagePoll1 poll = new PagePoll1();
                dgPollList.Visibility = Visibility.Collapsed;
                if (id == 0)
                {
                    modalChoice.ShowDialog();
                    if (modalChoice.DialogResult.HasValue && modalChoice.DialogResult.Value)
                    {
                        frame.Content = new PagePoll1();
                    }
                    else
                    {
                        frame.Content = new PageReduct1();
                    }
                }
                if (id == 1)
                {
                    modalChoice.ShowDialog();
                    if (modalChoice.DialogResult.HasValue && modalChoice.DialogResult.Value)
                    {
                        frame.Content = new PagePoll2();
                    }
                    else
                    {
                        frame.Content = new PageReduct2();
                    }
                }
                if (id == 2)
                {
                    modalChoice.ShowDialog();
                    if (modalChoice.DialogResult.HasValue && modalChoice.DialogResult.Value)
                    {
                        frame.Content = new PagePoll3();
                    }
                    else
                    {
                        frame.Content = new PageReduct3();
                    }
                }
                if (id == 3)
                {
                    modalChoice.ShowDialog();
                    if (modalChoice.DialogResult.HasValue && modalChoice.DialogResult.Value)
                    {
                        frame.Content = new PagePoll4();
                    }
                    else
                    {
                        frame.Content = new PageReduct4();
                    }
                }             
            }
        }
    }
}
