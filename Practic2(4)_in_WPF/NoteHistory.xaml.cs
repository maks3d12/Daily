using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Xml.Linq;

namespace Practic2_4__in_WPF
{
    /// <summary>
    /// Логика взаимодействия для NoteHistory.xaml
    /// </summary>
    public partial class NoteHistory : Window
    {

        public NoteHistory()
        {
            InitializeComponent();
        }
        bool delete = false;

        List<Note> notes = new List<Note>();
        List<string> names_notes = new List<string>();
        string path = "Notes.json";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            notes = SerealizedorDeserealized.MyDeserialize<List<Note>>(path);
            names_notes.Clear();
            foreach (var Note in notes)
            {
                names_notes.Add(Note.name);
            }
            table.ItemsSource = names_notes;
        }
                private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(delete)
            {
                int index_delete = table.SelectedIndex;
                for (int i = 0; i < table.Items.Count; i++)
                {
                    if (i == index_delete)
                    {
                        notes.RemoveAt(i);
                        SerealizedorDeserealized.MySerialize(path, notes);
                        MessageBox.Show($"Заметка удалена");
                        break;
                    }
                }
               
            }
            else {
                NoteCreateWindow window1 = new NoteCreateWindow();
                int index = table.SelectedIndex;
                for (int i = 0; i < table.Items.Count; i++)
                {
                    if (i == index)
                    {
                        window1.NameNote.Text = notes[i].name;
                        window1.Bank_Text.Text = notes[i].bank;
                        window1.DateNote.Text = notes[i].time;
                        window1.Save.Content = " Сохранить изменения";
                        notes.RemoveAt(i);
                        SerealizedorDeserealized.a = true;
                        break;
                    }
                }
                window1.Show();
                Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            delete = true; // ГЕНИАЛЬНО! (Не использовать такое удаление без дедлайна)
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow window1 = new MainWindow();
            window1.Show();
            Close();
        }
    }
    }

