using System;
using System.CodeDom;
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
using System.Windows.Shapes;

namespace NEW_STATHAM
{
    /// <summary>
    /// Логика взаимодействия для ModalChoice.xaml
    /// </summary>
    public partial class ModalChoice : Window
    {
        public ModalChoice()
        {
            InitializeComponent();
        }
        public bool a;
        public int b;
        public bool? DialogResult { get; set; }
        //public int doDo0()
        //{
        //    a = 0;
        //    return a;
        //}
        //public int doDo1()
        //{
        //    a = 1;
        //    return a;
        //}
        private void reduct_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false; 
            this.Close();
        }

        public void opros_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
