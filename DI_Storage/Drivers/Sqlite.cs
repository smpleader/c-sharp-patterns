using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Drawing;

namespace DI_Storage.Drivers
{
    internal class Sqlite
    {
        // TODO: create debug engine
        private SQLiteConnection? _connection;
        public Sqlite(string cnt) 
        {
            SQLiteConnection con = new SQLiteConnection(cnt);
            try
            {
                con.Open();
                _connection = con;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool Connected()
        {
            return _connection != null;
        }

        public void Disconnect()
        {
            _connection.Close();
        }

        private Dictionary<string, string> _values = new Dictionary<string, string>();
        public void addString(string key, string value)
        {
            _values.Add(key , value);
        }
        public void execute(string query)
        {
            using (SQLiteCommand cmd = _connection.CreateCommand())
            {
                cmd.Prepare();
                cmd.CommandText = query;
                if(_values.Count() > 0)
                {
                    foreach (KeyValuePair<string, string> entry in _values)
                    {
                        cmd.Parameters.Add(entry.Key, DbType.AnsiString).Value = entry.Value;
                    }
                    _values.Clear();
                }
                cmd.ExecuteNonQuery();
            }
        }

        public void safeExecute(string query)
        {
            using (SQLiteCommand cmd = _connection.CreateCommand())
            {
                cmd.Prepare();
                cmd.CommandText = query;
                SQLiteTransaction transaction = _connection.BeginTransaction();
                if (_values.Count() > 0)
                {
                    foreach (KeyValuePair<string, string> entry in _values)
                    {
                        cmd.Parameters.Add(entry.Key, DbType.AnsiString).Value = entry.Value;
                    }
                    _values.Clear();
                }
                cmd.ExecuteNonQuery();

                transaction.Commit();
            }
        }

        public long LastId()
        {
            return (long) executeScalar(@"SELECT last_insert_rowid()");
        }
        public void execute(string query, Func<SQLiteCommand, SQLiteCommand>? func = null)
        {
            using (SQLiteCommand cmd = _connection.CreateCommand())
            {
                cmd.Prepare();
                cmd.CommandText = query;
                if (null != func)
                {
                    func(cmd);
                }
                cmd.ExecuteNonQuery();
            }
        }
        public SQLiteDataReader query(string query)
        {
            SQLiteCommand cmd = _connection.CreateCommand();
            //cmd.Prepare();
            cmd.CommandText = query;
            return cmd.ExecuteReader();
        }

        public object executeScalar(string query)
        {
            using (SQLiteCommand cmd = _connection.CreateCommand())
            {
                cmd.Prepare();
                cmd.CommandText = query;
                if (_values.Count() > 0)
                {
                    foreach (KeyValuePair<string, string> entry in _values)
                    {
                        cmd.Parameters.Add(entry.Key, DbType.AnsiString).Value = entry.Value;
                    }
                    _values.Clear();
                }
                return cmd.ExecuteScalar();
            }
        }
    }
}
