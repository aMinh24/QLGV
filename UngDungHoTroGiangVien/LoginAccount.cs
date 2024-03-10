using Meziantou.Framework.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungHoTroGiangVien.DAO;

namespace UngDungHoTroGiangVien
{
    public partial class LoginAccount : Form
    {
        List<Credential> _credentialList = new List<Credential>();
        public LoginAccount()
        {
            InitializeComponent();
            LoadCredentials();
        }
        public void LoadCredentials()
        {
            _credentialList = CredentialManager.EnumerateCredentials().ToList();
            _credentialList = CredentialManager.EnumerateCredentials().Where(x => x.ApplicationName.StartsWith("CredentialAccount")).ToList();
            cbUsername.DataSource = _credentialList;
            cbUsername.DisplayMember = "UserName";
            cbUsername.SelectedItem = null;
        }
        private void SaveCredential(string username, string password)
        {
            if (checkboxRemember.Checked)
            {
                CredentialManager.WriteCredential(
                applicationName: "CredentialAccount_" + username,
                userName: username,
                secret: password,
                comment: "",
                persistence: CredentialPersistence.LocalMachine);
            }
            else
            {
                try
                {
                    CredentialManager.DeleteCredential("CredentialAccount_" + username);
                }
                catch { }
            }

        }
        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            //string userNameEmail = tBoxLogin.Text;
            string userNameEmail = cbUsername.Text;
            string password = tBoxPassword.Text;
            string[] username = userNameEmail.Split('@');

            if (login(username[0], password))
            {
                try
                {
                    SaveCredential(userNameEmail, password);
                    Random ran = new Random();
                    string OTP = ran.Next(1000, 9999).ToString();
                    titleDN.Text = "Sent";
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
        private async void sendMail(string to, string OTP)
        {
            Task send = new Task(() =>
            {
                EMail.Send(to, "Verify mail", "Verify your mail with code: " + OTP);
            });
            send.Start();
            titleDN.Text = "Done";
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

        private void cbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((Credential)cbUsername.SelectedItem == null)
                {
                    tBoxPassword.Text = "";
                }
                else tBoxPassword.Text = ((Credential)cbUsername.SelectedItem).Password;
            }
            catch { }
        }
    }
}
