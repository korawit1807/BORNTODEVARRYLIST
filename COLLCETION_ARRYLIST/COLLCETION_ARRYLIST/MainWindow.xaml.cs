using System;
using System.Collections;
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

namespace COLLCETION_ARRYLIST
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList; 
        public MainWindow()
        {
            InitializeComponent();
            arrayList =  new ArrayList();
        }
            private void SHOWBTN_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Sort();
            foreach (int data in arrayList)
            {               
                MessageBox.Show(data.ToString());
            }
            
        }

        private void ADDBTN_Click(object sender, RoutedEventArgs e)
        {                        
                arrayList.Add(int.Parse(txtdata.Text));
                txtdata.Text = " ";
                MessageBox.Show("ADD DATA SUCCESS");
        }

        private void REMOVEBTN_Click(object sender, RoutedEventArgs e)
        {
            int remove = int.Parse(txtdata.Text);
            arrayList.Remove(remove);
            txtdata.Text = " ";
            MessageBox.Show("REMOVE SUCCESS");
        }
    }
}
