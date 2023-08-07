using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Worksheet.modData.Entities;

namespace Worksheet.modData.Sqlite
{
    abstract class ATable
    {
        string _table;
        string _pk;
        Drivers.Sqlite _db;
        IEntity _row;

        public abstract bool Ready();
        public abstract int Pk();
        public abstract int Save(IEntity ent);
        public abstract void Bind(IEntity ent);
        public abstract IEntity ById(int id);
    }
}
