using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace TheGameOfLifeApp
{
    internal class JsonSerializerService
    {
        public void savearrayAsJSON(bool[,] array) {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Zapisz planszę poczatkową";
            saveFileDialog1.Filter = "JSON|*.json";
            saveFileDialog1.ShowDialog();

            string path = saveFileDialog1.FileName;

            string json;
            
            json = JsonConvert.SerializeObject(array, Formatting.Indented);

             File.WriteAllText(path, json);
           

        }

        internal bool[,] openJsonAsArray()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Wybierz plik JSON";
            openFileDialog1.Filter = "JSON|*.json";
            openFileDialog1.ShowDialog();
            string localization = openFileDialog1.FileName;

            string json =File.ReadAllText(localization);

           return JsonConvert.DeserializeObject<bool[,]>(json);


            




        }
    }
}