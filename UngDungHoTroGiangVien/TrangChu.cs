using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungHoTroGiangVien.Service;

namespace UngDungHoTroGiangVien
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = "";
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = openFileDialog.FileName;
                    pnLoading.Visible = true;
                    Task loadTask = new Task(() =>
                    {
                        LoadFile(filepath).Wait();
                        if (pnLoading.InvokeRequired)
                        {
                            pnLoading.BeginInvoke(new Action(() =>
                            {
                                pnLoading.Visible = false;
                            }));
                            progressChange(0);
                        }
                        else pnLoading.Visible = false;
                    });
                    loadTask.Start();
                }
            }
            catch { }
        }
        private async Task LoadFile(string filepath)
        {
            await MegaCloud.UploadFile(filepath, progressChange);
        }
        private void progressChange(double value)
        {
            if (pbUpload.InvokeRequired)
            {
                pbUpload.BeginInvoke(new Action(() => pbUpload.Value = (int)Math.Ceiling(value)));
            }
            else
                pbUpload.Value = (int)Math.Ceiling(value);
        }
    }
}
