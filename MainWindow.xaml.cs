using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace pr_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string firstStroke = "aa aba abba abbba abca abea";
        string secondStroke = "aea aba agga avea afa acas asa";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №11\n" +
                "Даанов Шахмар ИСП-34\n" +
                "Дана строка 'aa aba abba abbba abca abea'. Напишите регулярное выражение, которое найдет строки aa, aba, abba, abbba, не захватив abca abea.\n" +
                "Напишите регулярное выражение, которое найдет строки следующего вида: по краям стоят буквы 'a', а между ними - буква от a до f .", "О прошрамме"
                , MessageBoxButton.OK);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void applyFirstFilter_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"\bab*a\b");
            MatchCollection matches = regex.Matches(firstStroke);
            object[] regexArray = new object[matches.Count];
            matches.CopyTo(regexArray, 0);
            firstListBox.ItemsSource = regexArray;
        }

        private void applySecondFilter_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"\ba[a-f]a\b");
            MatchCollection matches = regex.Matches(secondStroke);
            object[] regexArray = new object[matches.Count];
            matches.CopyTo(regexArray, 0);
            secondListBox.ItemsSource = regexArray;
        }
    }
}
