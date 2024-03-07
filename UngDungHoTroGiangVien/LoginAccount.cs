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
    public partial class LoginAccount : Form
    {
        public LoginAccount()
        {
            InitializeComponent();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string userNameEmail = tBoxLogin.Text;
            string password = tBoxPassword.Text;
            string[] username = userNameEmail.Split('@');

            if (login(username[0], password))
            {
                try
                {
                    Random ran = new Random();
                    string OTP = ran.Next(1000, 9999).ToString();
                    sendMail(userNameEmail, OTP);
                    VerifyOTP v = new VerifyOTP(OTP);
                    v.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login fail");
                }
                //MessageBox.Show("Login success");
                //TrangChu t = new TrangChu();
                //this.Hide();
                //t.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login fail");

            }
        }
        private async void sendMail(string to,string OTP)
        {
            Task send = new Task(() =>
            {
                EMail.Send(to, "Verify mail", "Verify your mail with code: "+OTP);
            });
            send.Start();
        }
        public bool login(string userName, string password)
        {
            return AccountDAO.Instance.Login(userName, password);
            
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            signIn s = new signIn();
            s.ShowDialog();
            
        }

        private void LoginAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
