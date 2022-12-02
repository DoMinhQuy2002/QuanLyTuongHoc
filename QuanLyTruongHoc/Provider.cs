using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace QuanLyTruongHoc
{
    class Provider
    {
        static string ConnectionString = @"Data Source=LAPTOP-JAU1H11A\SQLEXPRESS;Initial Catalog=QuanLyTruongHocDB;Integrated Security=True";

        SqlConnection? Connection { get; set; }

        public void Connect()
        {
            try
            {
                if (Connection == null)
                    Connection = new SqlConnection(ConnectionString);
                if (Connection.State != ConnectionState.Closed)
                    Connection.Close();

                Connection.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void DisConect()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
                Connection.Close();
        }

        public int ExecuteNonQuery(CommandType cmdType, string strSql, params SqlParameter[] parameters)
        {
            int nRow = 0;
            try
            {
                Connect();
                SqlCommand command = Connection.CreateCommand();
                command.CommandType = cmdType;
                command.CommandText = strSql;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                nRow = command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConect();
            }
            return nRow;
        }

        public DataTable Select(CommandType cmdType, string strSql, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand command = Connection.CreateCommand();
                command.CommandType = cmdType;
                command.CommandText = strSql;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConect();
            }
            return dt;
        }
    }
}

