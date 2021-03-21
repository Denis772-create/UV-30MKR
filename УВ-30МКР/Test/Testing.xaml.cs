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
using System.Windows.Shapes;

namespace УВ_30МКР
{
    /// <summary>
    /// Interaction logic for Testing.xaml
    /// </summary>
    public partial class Testing : Window
    {
        TestProcess testProcess;
        public Testing()
        {
            InitializeComponent();
        }

        private void start_test_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            testProcess = new TestProcess();
            testProcess.ShowDialog();
        }
    }
}
