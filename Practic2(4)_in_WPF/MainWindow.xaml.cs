using System;
using System.Collections.Generic;
using System.IO;
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

namespace Practic2_4__in_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    

    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Create_New_Note(object sender, RoutedEventArgs e)
        {
            NoteCreateWindow window1 = new NoteCreateWindow();
            window1.Show();
            Close();
        }
        private void Secret_Note_Click(object sender, RoutedEventArgs e)
        {
            NoteHistory window2 = new NoteHistory();
            window2.Show();
            Close();
        } 


     
    }
}
