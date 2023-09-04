
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using modData.Sqlite.Entities;

namespace modData.Sqlite
{
    public class SqliteTable
    {
        protected virtual string _table { get; set; } = "sqlite_table";
        protected virtual string _pk { get; set; } = "pk_id";
        protected virtual Drivers.Sqlite _db { get; set; }
        protected virtual IEntity _row { get; set; }

        /*  public SqliteTable(Sqlite drv){  _db = drv; }  */

        public virtual bool Ready() { return true; }

        public SqliteTable Bind(IEntity ent)
        {
            _row = ent;
            return this;
        }

        public bool TableExist()
        {
            object rd = _db.executeScalar(@"SELECT name FROM sqlite_master WHERE type='table' AND name='" + _table + "'");
            return Convert.ToString(rd) == _table;
        }

        public void TableInfo()
        {
            SQLiteDataReader rd = _db.query(@"SELECT * FROM sqlite_master WHERE type='table' AND name='" + _table + "'");

            //MessageBox.Show(ObjFnc.print(rd));
        }
        public virtual long Pk()
        {
#pragma warning disable CS8605 // Unboxing a possibly null value.
            return (long)_row.GetType().GetProperties()
                             .Single(pi => pi.Name == _pk)
                               .GetValue(_row, null);
#pragma warning restore CS8605 // Unboxing a possibly null value.
        }

        public long Update()
        {
            if (_row is IEntity)
            {
                string q = @"UPDATE " + _table + " SET ";
                string w = @" WHERE " + _pk + "=";
                long id = -1;
                List<string> str = new List<string>();
                foreach (var prop in _row.GetType().GetProperties())
                {
                    string tryVal = prop.GetValue(_row, null).ToString();
                    if (prop.Name != _pk)
                    {
                        _db.addString("@" + prop.Name, tryVal);
                        str.Add(prop.Name + "= @" + prop.Name);
                    }
                    else
                    {
                        id = (long)prop.GetValue(_row, null);
                        w += tryVal;
                    }
                }
                q += string.Join(", ", str.ToArray()) + w;
                //MessageBox.Show(q);
                _db.execute(q);
                return id;
            }
            else
            {
                //MessageBox.Show("Row is not ready");
                return -1;
            }

        }

        public long Update(IEntity ent)
        {
            Bind(ent);
            return Update();
        }

        public long Insert()
        {
            if (_row is IEntity)
            {
                string q = @"INSERT INTO " + _table + " ";
                List<string> fields = new List<string>();
                foreach (var prop in _row.GetType().GetProperties())
                {
                    if (prop.Name != _pk)
                    {
                        string tryVal = prop.GetValue(_row, null).ToString();
                        _db.addString("@" + prop.Name, tryVal);
                        fields.Add(prop.Name);
                    }

                }
                q += "( `" + string.Join("`, `", fields.ToArray()) + "` )";
                q += " VALUES ( @" + string.Join(", @", fields.ToArray()) + " )";

                //MessageBox.Show(q);
                _db.execute(q);
                return _db.LastId();
            }
            else
            {
                //MessageBox.Show("Row is not ready");
                return -1;
            }
        }
        public long Insert(IEntity ent)
        {
            Bind(ent);
            return Insert();
        }

        public long Save(IEntity ent)
        {
            Bind(ent);
            return Pk() > 0 ? Update() : Insert();
        }
        public bool Remove(IEntity ent)
        {
            Bind(ent);
            _db.execute(@"DELETE FROM " + _table + "  WHERE " + _pk + "=" + Pk().ToString());
            return true;
        }
    }
}
