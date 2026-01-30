using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Data
{
    public class DataAccess
    {
        private readonly string _ConnectionString = "Data Source = .\\Gestor_Encargos.db";

        private SqliteConnection _Connection;
        private SqliteCommand _Cmd;
        private SqliteDataReader _Reader = null;
        private SqliteTransaction _Transaction;

        public SqliteDataReader Reader
        {
            get { return _Reader; }
        }

        public DataAccess() 
        {
            _Connection = new SqliteConnection(_ConnectionString);
            _Cmd = new SqliteCommand();

            using (var Pragma = _Connection.CreateCommand()) 
            {
                Pragma.CommandText = "PRAGMA foreign_keys = ON;";
                Pragma.Connection.Open();   
                Pragma.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar()
        {
            _Cmd.Connection = _Connection;

            try
            {
                _Connection.Open();
                return _Cmd.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void BeginTransaction()
        {

            _Cmd.Connection = _Connection;

            try
            {

                _Connection.Open();

                _Transaction = _Connection.BeginTransaction();
                _Cmd.Transaction = _Transaction;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Commit()
        {
            _Transaction?.Commit();
        }

        public void Rollback()
        {
            _Transaction?.Rollback();
        }

        public void SetQuery(string Query)
        {
            _Cmd.CommandType = System.Data.CommandType.Text;
            _Cmd.CommandText = Query;
        }

        public void ExecuteReader()
        {
            _Cmd.Connection = _Connection;

            try
            {
                _Connection.Open();
                _Reader = _Cmd.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ExecuteNonQuery()
        {
            _Cmd.Connection = _Connection;

            try
            {

                _Connection.Open();
                _Cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SetParameter(string Parameter, object value)
        {
            if (value != null && value.GetType().IsEnum)
                value = (int)value;

            _Cmd.Parameters.AddWithValue(Parameter, value);
        }

        public void ConnectionClose()
        {

            if (_Reader != null) 
                _Reader.Close();

            _Connection.Close();

        }
    }
}
