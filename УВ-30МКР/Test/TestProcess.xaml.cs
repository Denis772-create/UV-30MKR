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
using УВ_30МКР.Test;

namespace УВ_30МКР
{
    /// <summary>
    /// Interaction logic for TestMainWindow.xaml
    /// </summary>
    public partial class TestProcess : Window
    {
        public TestProcess()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Quations quations = new Quations();
            quations.QuestionAndAnswerNumberOne();
            A.Content = quations.answer[1];
            B.Content = quations.answer[2];
            C.Content = quations.answer[3];
            D.Content = quations.answer[4];
        }
    }
}
