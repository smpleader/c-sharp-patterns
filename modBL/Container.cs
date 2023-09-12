using BaseInterface;
using System.Reflection;

namespace modBL
{
    public class Container : IModBL
    {
        private Dictionary<string, ICell> _instance = new Dictionary<string, ICell>();
        public bool exists(string name) { return _instance.ContainsKey(name); }
        public ICell Get(string name) {
            if(_instance.Keys.Contains(name)) return _instance[name];
            return new DefaultCell(new Option());
        }
        public void Init()
        {
            string targetNamespace = "modBL.prime";
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
                    var constructor = classType.GetConstructor(new Type[] { typeof(Option) });

                    if (constructor != null)
                    {
                        // Tạo mảng parameter truyền vào constructor
                        object[] parameters = new object[] { new Option() };

                        // Tạo instance của class sử dụng constructor và parameter
                        var instance = (ACell)constructor.Invoke(parameters);

                        // Thêm vào dic 
                        _instance[instance.UName] = instance;
                    }

                }
            }
        }
    }
}
