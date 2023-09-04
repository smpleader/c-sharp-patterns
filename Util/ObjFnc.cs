using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    internal class ObjFnc
    {
        public static List<string> getFields<T>()
        {
            PropertyInfo[] propertyInfos;
            List<string> ls = new List<string>();

            propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in propertyInfos)
            {
                ls.Add(prop.Name);
            }

            return ls;
        }
        public static string print(object obj)
        {
            List<string> str = new List<string>();
            foreach (var prop in obj.GetType().GetProperties())
            {
                str.Add(prop.Name + "=" + prop.GetValue(obj, null));
            }
            return string.Join(" \r\n ", str.ToArray());
        }
        /*
         * Example:
            ObjFnc.Read<String>(data, "SoftwareCode00"), 
            ObjFnc.Read<Int32>(data, "MachineID"));
         */
        public static T Read<T>(DbDataReader DataReader, string FieldName)
        {
            int FieldIndex;
            try { FieldIndex = DataReader.GetOrdinal(FieldName); }
            catch { return default; }

            if (DataReader.IsDBNull(FieldIndex))
            {
                return default;
            }
            else
            {
                object readData = DataReader.GetValue(FieldIndex);
                if (readData is T)
                {
                    return (T)readData;
                }
                else
                {
                    try
                    {
                        return (T)Convert.ChangeType(readData, typeof(T));
                    }
                    catch (InvalidCastException)
                    {
                        return default;
                    }
                }
            }
        }
        public static string print(SQLiteDataReader reader)
        {
            List<string> str = new List<string>();
            while (reader.Read())
            {
                for (int inc = 0; inc < reader.FieldCount; inc++)
                {
                    str.Add(reader.GetName(inc) + " = " + Convert.ToString(reader.GetValue(inc)));
                }
            }
            return string.Join(" \r\n ", str.ToArray());
        }

        public static string print<T>(SqlDataReader reader) where T : new()
        {
            List<string> str = new List<string>();
            while (reader.Read())
            {
                for (int inc = 0; inc < reader.FieldCount; inc++)
                {
                    T t = new T();
                    Type type = t.GetType();
                    string name = reader.GetName(inc);
                    PropertyInfo prop = type.GetProperty(name);
                    if (prop != null)
                    {
                        if (name == prop.Name)
                        {
                            var value = reader.GetValue(inc);
                            if (value != DBNull.Value)
                            {
                                prop.SetValue(t, Convert.ChangeType(value, prop.PropertyType), null);
                            }
                            //prop.SetValue(t, value, null);
                        }
                    }
                }
            }
            return string.Join(" \r\n ", str.ToArray());
        }
    }
}
