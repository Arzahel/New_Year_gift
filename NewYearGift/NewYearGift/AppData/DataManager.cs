using NewYearGift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace NewYearGift.AppData
{
    public class DataManager : IDataManager
    {
        public void SaveXml<T>(ref T item, string fname)
        {
            AppendLog("Saving xml file " + fname + " from type: " + typeof(T).ToString());
            try {
                var writer = new XmlSerializer(typeof(T));
                FileStream file = File.Create(fname);
                writer.Serialize(file, item);
                file.Close();
            }
            catch { AppendLog("Error saving Json file!"); }
        }

        public T ReadXml<T>(string fname)
        {
            AppendLog("Reading Xml file " + fname + " in type: " + typeof(T).ToString());

            var reader = new XmlSerializer(typeof(T));
            StreamReader file = new StreamReader(fname);
            return (T)reader.Deserialize(file);
        }

        public void SaveJson<T>(ref T item, string fname)
        {
            AppendLog("Saving Json file " + fname + " from type: " + typeof(T).ToString());

            try {
                var jsonFormatter = new DataContractSerializer(typeof(T));
                using (FileStream fs = new FileStream(fname, FileMode.Create))
                {
                    jsonFormatter.WriteObject(fs, item);
                }
            }
            catch { AppendLog("Error saving Json file!"); }
        }

        public T ReadJson<T>(string fname)
        {
            AppendLog("Reading Json file " + fname + " in type: " + typeof(T).ToString());

            var jsonFormatter = new DataContractSerializer(typeof(T));

            using (FileStream fs = new FileStream(fname, FileMode.OpenOrCreate))
            {
                return (T)jsonFormatter.ReadObject(fs);
            }
        }

        public void AppendLog(string str)
        {
            using (StreamWriter sw = new StreamWriter("Log.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine(str + ". " + DateTime.Now.ToString());
            }
        }
    }
}
