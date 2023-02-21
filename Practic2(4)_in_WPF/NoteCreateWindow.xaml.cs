using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Practic2_4__in_WPF
{
    /// <summary>
    /// Логика взаимодействия для NoteCreateWindow.xaml
    /// </summary>
    public partial class NoteCreateWindow : Window, CRUD
    {
        public NoteCreateWindow()
        {
            InitializeComponent();
        }
        List<Note> notes = new List<Note>();
        string path = "C:\\Users\\Fantasm\\Desktop\\Example\\Notes.json";
        public void Create()
        {
            string Bank = Bank_Text.Text;
            string name = NameNote.Text;
            DateTime date;
            try
            {
                if (SerealizedorDeserealized.a != true)
                {
                date = Convert.ToDateTime(DateNote.Text);
                string date1 = date.ToShortDateString();
                Note note = new Note(name, Bank, date1);
                notes.Add(note);
                SerealizedorDeserealized.MySerialize(path, notes);
                MessageBox.Show($"Заметка {name} создана");
                }
                else
                {
                    MessageBox.Show($"Заметка {name} измененена");
                }
            }
            catch (Exception ex) 
            {   
                MessageBox.Show("Вы не ввели дату, попробуйте еще раз"); }
            }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            notes = SerealizedorDeserealized.MyDeserialize<List<Note>>(path);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window1 = new MainWindow();
            window1.Show();
            Close();
        }

        private void SaveNote(object sender, RoutedEventArgs e)
        {
            try { notes = SerealizedorDeserealized.MyDeserialize<List<Note>>(path); }
            catch { }
            Create();
        }

        private void Bank_Text_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

