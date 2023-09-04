using SimpleInjector;
using System.Reflection;

namespace modDisplay
{
    public class SimpleInjectionDI
    {
        public static Container dynamicContainer = new Container();
        public static void ConfigureDynamicServices(string path)
        {
            //dynamicContainer = new Container();
            // Đảm bảo rằng Container đã được tải vào ứng dụng
            // Ví dụ, sử dụng Assembly.LoadFrom để tải Container từ file DLL.
            var assembly = Assembly.LoadFrom(path);

            // Tìm kiếm type có tên là "Container" trong DLL vừa tải
            var classType = assembly.GetTypes().FirstOrDefault(t => t.Name == "Container");

            if (classType != null && typeof(BaseInterface.IModBL).IsAssignableFrom(classType))
            {
                // Đăng ký IBaseInterface với classType
                dynamicContainer.Register(typeof(BaseInterface.IModBL), classType, Lifestyle.Singleton);
            }
            else
            {
                // Xử lý trường hợp không tìm thấy hoặc không phù hợp.
                // Ví dụ: log lỗi, thông báo người dùng, vv.
            }

            dynamicContainer.Verify();
        }
    }
}
