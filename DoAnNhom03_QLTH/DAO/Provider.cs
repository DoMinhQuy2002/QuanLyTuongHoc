﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace DAO
{
    public class Provider
    {

        static string ConnectionString = @"Data Source=LAPTOP-JAU1H11A\SQLEXPRESS;Initial Catalog=QuanLyTruongHocDB;Integrated Security=True";
        private SqlConnection connection;

        private SqlConnection GetConnection()
        {
            return connection;
        }

        private void SetConnection(SqlConnection value)
        {
            connection = value;
        }

        public void Connect()
        {
            try
            {
                if (GetConnection() == null)
                    SetConnection(new SqlConnection(ConnectionString));
                if (GetConnection().State != ConnectionState.Closed)
                    GetConnection().Close();

                GetConnection().Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void DisConect()
        {
            if (GetConnection() != null && GetConnection().State == ConnectionState.Open)
                GetConnection().Close();
        }

        public int ExecuteNonQuery(CommandType cmdType, string strSql, params SqlParameter[] parameters)
        {
            int nRow = 0;
            try
            {
                Connect();
                SqlCommand command = GetConnection().CreateCommand();
                command.CommandType = cmdType;
                command.CommandText = strSql;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                nRow = command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw;
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
                SqlCommand command = GetConnection().CreateCommand();
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
