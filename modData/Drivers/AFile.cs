using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace modData.Drivers
{
    internal class AFile
    {
        public static List<string> GetFiles(string path, List<string>? extList = null, bool fullPath = false)
        {
            List<string> strs = new List<string>();

            if (null == extList)
            {
                extList = new List<string> { "txt" };
            }

            foreach (string ext in extList)
            {
                foreach (string file in Directory.GetFiles(path, ext, SearchOption.AllDirectories))
                {
                    if (fullPath)
                    {
                        strs.Add(file);
                    }
                    else
                    {
                        strs.Add(Path.GetFileName(file).Trim());
                    }
                }
            }

            return strs;
        }

        public static List<T> loadJson<T>(string path) where T : class
        {
            List<T> items = new List<T>();
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<T>>(json);
            }
            return items;
        }

        public static void storeJson(object obj, string path)
        {
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, obj);
            }
        }
    }
}
