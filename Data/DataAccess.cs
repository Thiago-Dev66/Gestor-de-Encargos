using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataAccess : IDisposable
    {
        private readonly string _ConnectionString = DataPathManager.GetConnectionString();

        private SqliteConnection _Connection;
        private SqliteCommand _Cmd;
        private SqliteDataReader _Reader;
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

                if ((Pragma.Connection.State != ConnectionState.Open))
                    Pragma.Connection.Open();

                Pragma.ExecuteNonQuery();

                Pragma.CommandText = "PRAGMA journal_mode=WAL;";
                Pragma.ExecuteNonQuery();

                if (Pragma.Connection.State == ConnectionState.Open)
                    Pragma.Connection.Close();

                //Pragma.CommandText = "table_info(Clientes)";
            }
        }
        public void Dispose()
        {
            try
            {
                if (_Connection.State == ConnectionState.Open)
                    _Connection.Close();

                _Connection?.Dispose();
                _Transaction?.Dispose();
                _Reader?.Dispose();
                _Cmd?.Dispose();
            }
            catch { }
        }

        public object ExecuteScalar()
        {
            if (_Cmd.Connection == null)
                _Cmd.Connection = _Connection;

            if (_Reader != null && !_Reader.IsClosed)
            {
                _Reader.Close();
                _Reader.Dispose();
            }

            if (_Connection.State != ConnectionState.Open)
                _Connection.Open();

            return _Cmd.ExecuteScalar();
        }

        public void BeginTransaction()
        {

            _Cmd.Connection = _Connection;

            try
            {
                if (_Connection.State != ConnectionState.Open)
                    _Connection.Open();

                if (_Transaction == null)
                {
                    _Transaction = _Connection.BeginTransaction();
                    _Cmd.Transaction = _Transaction;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Commit()
        {
            _Transaction?.Commit();
            _Transaction?.Dispose();
            _Transaction = null;    
        }

        public void Rollback()
        {
            _Transaction?.Rollback();
            _Transaction?.Dispose();
            _Transaction = null;
        }

        public void SetQuery(string Query)
        {
            if (_Reader != null && !_Reader.IsClosed)
            {
                _Reader.Close();
                _Reader.Dispose();
            }

            _Cmd.Parameters.Clear();
            _Cmd.CommandType = System.Data.CommandType.Text;
            _Cmd.CommandText = Query;
        }

        public void ExecuteReader()
        {
            _Cmd.Connection = _Connection;

            try
            {
                if (_Connection.State != ConnectionState.Open)
                    _Connection.Open();

                if (_Reader != null && !_Reader.IsClosed)
                {
                    _Reader.Close();
                    _Reader.Dispose();
                }
                    
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
                if (_Connection.State != ConnectionState.Open)
                    _Connection.Open();

                if (_Reader != null && !_Reader.IsClosed)
                {
                    _Reader.Close();
                    _Reader.Dispose();
                }

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
            try
            {
                if (_Reader != null && !_Reader.IsClosed)
                {
                    _Reader.Close();
                    _Reader.Dispose();
                }

                _Connection.Close();
                _Transaction = null;
            }
            catch { }
        }
    }
}
