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

namespace УВ_30МКР
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Testing testing;
        LearnMainWindow learnMain;
        public MainWindow()
        {
            InitializeComponent();
        }   

        private void test_Click(object sender, RoutedEventArgs e)
        {
            testing = new Testing();
            testing.ShowDialog();
           
        }

        private void learn_Click(object sender, RoutedEventArgs e)
        {
            learnMain = new LearnMainWindow();
            learnMain.ShowDialog();
        }

       
    }
}
