using Newtonsoft.Json;
using System.IO;


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
