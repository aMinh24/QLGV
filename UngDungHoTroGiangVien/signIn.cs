using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungH0oTroGiangVien.DAO;

namespace UngDungHoTroGiangVien
{
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string userNameEmail = tBoxLogin.Text;
            string passengerName = tBoxPassword.Text;
            string passwordAgain = tBoxNhapLaiMK.Text;
            string[] username = userNameEmail.Split('@');
            //if (passengerName.Length < 6 || !userNameEmail.Contains('@') || !userNameEmail.Contains('.'))
            //{
            //    MessageBox.Show("kiem tra lai thong tin");
            //}
            if (passengerName != passwordAgain)
            {
                MessageBox.Show("Mat khau khong trung khop");
                return;
            }
            if (Register(username[0], passengerName, userNameEmail))
            {
                MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK);
                this.Hide();


            }

        }
        public bool Register(string username, string password, string email)
        {

            return AccountDAO.Instance.Register(username,password,email);

        }

        private void signIn_Load(object sender, EventArgs e)
        {


        }
    }
}
