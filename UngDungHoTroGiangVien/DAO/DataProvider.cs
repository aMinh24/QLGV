using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UngDungHoTroGiangVien.DAO
{
    internal class DataProvider
    {
        private static DataProvider instance;
        private string sqlString = "Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=cnpmnhom17_QLGV;User ID=cnpmnhom17_QLGV;Password=cnpm;Persist Security Info=True;Encrypt=false;";

        internal static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }
            private set { instance = value; }
        }

        private DataProvider() { }

        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            try
            {
                DataTable data = new DataTable();
                using (SqlConnection connection = new SqlConnection(sqlString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (parameters != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, parameters[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    connection.Close();
                    adapter.Fill(data);
                }

                return data;
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                Console.WriteLine("Lỗi rồi: " + errorMessage);
                return null;
            }
        }

        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            try
            {
                int data = 0;
                using (SqlConnection connection = new SqlConnection(sqlString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (parameters != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, parameters[i]);
                                i++;
                            }
                        }
                    }
                    data = cmd.ExecuteNonQuery();
                    connection.Close();
                }
                return data;
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                Console.WriteLine("Lỗi rồi: " + errorMessage);
                return -1;
            }
        }

        public object ExecuteScalar(string query, object[] parameters = null)
        {
            try
            {
                object data = 0;
                using (SqlConnection connection = new SqlConnection(sqlString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (parameters != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                cmd.Parameters.AddWithValue(item, parameters[i]);
                                i++;
                            }
                        }
                    }
                    data = cmd.ExecuteScalar();
                    connection.Close();
                }
                return data;
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                Console.WriteLine("Lỗi rồi: " + errorMessage);
                return -1;
            }
        }
    }
}
