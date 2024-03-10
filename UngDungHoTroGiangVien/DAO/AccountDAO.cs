using UngDungHoTroGiangVien.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungHoTroGiangVien.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Register(string username, string password , string email)
        {
            //string queryCheck = string.Format("select * from Account where username = {0}", username);
            //DataTable t = DataProvider.Instance.ExecuteQuery(queryCheck);
            //int check = t.Rows.Count;
            //if (check > 0)
            //{
            //    return false;
            //}
            string query = "InsertAccount @username , @password , @email";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, password ,email}) >0;
        }
        public bool Login(string username, string password)
        {
            string query = "Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }
    }
}
