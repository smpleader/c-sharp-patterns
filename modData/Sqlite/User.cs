
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UserEntity = modData.Sqlite.Entities.User.Schema;
using UserSqlite = modData.Sqlite.Entities.User.Sqlite;
using modData.Sqlite.Entities;

namespace modData.Sqlite
{
    public class User : SqliteTable
    {
        protected override string _table { get; set; } = "user";
        protected override string _pk { get; set; } = "Id";
        protected override Drivers.Sqlite _db { get; set; }
        protected override IEntity _row { get; set; } = new UserSqlite();

        public override bool Ready()
        {
            // TODO: catch exception this query
            _db.execute(
                @"CREATE TABLE IF NOT EXISTS user ( " +
                @"""Id"" integer NOT NULL PRIMARY KEY AUTOINCREMENT," +
                @"""UserName"" text NOT NULL," +
                @"""Name"" text NOT NULL," +
                @"""Email"" text NOT NULL," +
                @"""Password"" text NULL" +
                @")"
                );
            return true;
        }

        public User(Drivers.Sqlite drv)
        {
            _db = drv;

            if (!Ready())
            {
                //MessageBox.Show("Table user is not ready to use");
            }
        }
        public User Bind(UserSqlite ent)
        {
            _row = ent;
            return this;
        }
        public User Bind(UserEntity ent)
        {
            _row = new UserSqlite(ent);
            return this;
        }

        public long Save(UserEntity ent)
        {
            Bind(ent);
            return Pk() > 0 ? Update() : Insert();

        }

        public List<UserEntity> List()
        {
            List<UserEntity> ls = new List<UserEntity>();

            SQLiteDataReader reader = _db.query(@"SELECT * FROM " + _table + " ORDER BY " + _pk + " ASC");

            while (reader.Read())
            {
                ls.Add(new UserEntity(new UserSqlite(reader)));
            }

            return ls;
        }

        public UserEntity ById(string id)
        {
            if (id == "first")
            {
                return GetRow(@"SELECT * FROM " + _table + " ORDER BY  " + _pk + " ASC LIMIT 0,1");
            }

            if (id == "last")
            {
                return GetRow(@"SELECT * FROM " + _table + " ORDER BY  " + _pk + " DESC LIMIT 0,1");
            }

            return new UserEntity();
        }
        public UserEntity ById(long id)
        {
            return GetRow(@"SELECT * FROM " + _table + " WHERE  " + _pk + " = " + id + " LIMIT 0,1");
        }
        public UserEntity GetRow(string query)
        {
            SQLiteDataReader reader = _db.query(query);

            while (reader.Read())
            {
                return new UserEntity(new UserSqlite(reader));
            }

            return new UserEntity();
        }
    }
}
