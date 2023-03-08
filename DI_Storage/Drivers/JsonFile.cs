using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Storage.Drivers
{
    internal class JsonFile
    {
        public static List<T> load<T>(string path) where T : class
        {
            List<T> items = new List<T>();
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<T>>(json);
            }
            return items;
        }
    }
}
