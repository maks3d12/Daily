using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
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

namespace Practic2_4__in_WPF
{
    public class SerealizedorDeserealized
    {
        public static bool a = false; // я засунул сюда переменную для проверки надобности изменения
        public static T MyDeserialize<T>(string path)
            {
             string ReadsNotes = File.ReadAllText(path);
             T notes = JsonConvert.DeserializeObject<T>(ReadsNotes);
             return notes;
            }
        public static void MySerialize<T>(string path, T notes)
        {
            string json = JsonConvert.SerializeObject(notes);
            File.WriteAllText(path, json);  // удаляю и добавляю новый лист из-за того что при добавление дополнительного листа в файлик, их там будет 2 а не 1
        }
    }
}
