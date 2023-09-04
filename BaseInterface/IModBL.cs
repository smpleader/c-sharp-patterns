using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BaseInterface
{
    public interface IModBL
    {
        static Dictionary<string, ICell> _instance;
        abstract bool exists(string name);
        abstract ICell Get(string name);
        abstract void Init();
    }
}
