using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungHoTroGiangVien
{
    public partial class VerifyOTP : Form
    {
        string OTP = null;
        public VerifyOTP()
        {
            InitializeComponent();
        }
        public VerifyOTP(string OTP)
        {
            InitializeComponent();
            this.OTP = OTP;
        }
        private void VerifyOTP_Load(object sender, EventArgs e)
        {

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == OTP)
            {
                MessageBox.Show("Login success");
                TrangChu t = new TrangChu();
                this.Hide();
                t.Show();
            }
            else
            {
                MessageBox.Show("Wrong OTP");
            }
        }
    }
}
