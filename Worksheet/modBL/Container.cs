using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Worksheet.modData.Memories.Pointer;

namespace Worksheet.modBL
{
    internal class Container
    {
        private static Dictionary<string, ICell> _instance = new Dictionary<string, ICell>(); 
        public static bool exists(string name) { return _instance.ContainsKey(name); }
        public static ICell Get(string name) {  return _instance[name]; }

        public static void init()
        {
            string targetNamespace = "Worksheet.modBL.prime"; 
            
            // Lấy tất cả các namespace con
            var subNamespaces = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => type.Namespace != null && type.Namespace.StartsWith(targetNamespace))
                .Select(type => type.Namespace)
                .Distinct()
                .OrderBy(ns => ns)
                .ToList();

            foreach (var subNamespace in subNamespaces)
            {
                // Lấy tất cả các class trong namespace
                var classesInNamespace = Assembly.GetExecutingAssembly().GetTypes()
                    .Where(type => type.Namespace == subNamespace && type.IsClass)
                    .ToList();
                foreach (var classType in classesInNamespace)
                {
                    // Tìm constructor với 1 parameter có kiểu Option
                    var constructor = classType.GetConstructor(new Type[] { typeof(Worksheet.modBL.Option)});

                    if (constructor != null)
                    {
                        // Tạo mảng parameter truyền vào constructor
                        object[] parameters = new object[] { new Worksheet.modBL.Option() };

                        // Tạo instance của class sử dụng constructor và parameter
                        var instance = (ACell) constructor.Invoke(parameters);

                        // Thêm vào dic 
                        _instance[instance.UName] = instance;
                    }
                    
                }
            }
        }
    }
}
