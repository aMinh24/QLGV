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
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    progressChange(5);
                    filepath = openFileDialog.FileName;
                    pnLoading.Visible = true;
                    Task loadTask = new Task(async () =>
                    {
                        //Task<string> loadFile = LoadFile(filepath);
                        //loadFile.Wait();
                        string txt = await LoadFile(filepath);
                        if (txbLink.InvokeRequired)
                        {
                            txbLink.BeginInvoke(new Action(() =>
                            {
                                //txbLink.Text = loadFile.Result;
                                txbLink.Text = txt;
                            }));
                        }
                        else
                        {
                            //txbLink.Text = loadFile.Result;
                            txbLink.Text = txt;
                        }
                        ShowPanel(pnLoading, false);
                        progressChange(0);
                        openFileDialog.Dispose();
                    });
                    loadTask.Start();
                }
            }
            catch { }
        }
        private async Task<String> LoadFile(string filepath)
        {
            return await MegaCloud.UploadFile(filepath, progressChange);
        }
        private async Task DownloadFile(string filepath)
        {
            await MegaCloud.DownloadFile(filepath, progressChangeDownload);
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
        private void progressChangeDownload(double value)
        {
            if (pgBDownload.InvokeRequired)
            {
                pgBDownload.BeginInvoke(new Action(() => pgBDownload.Value = (int)Math.Ceiling(value)));
            }
            else
                pgBDownload.Value = (int)Math.Ceiling(value);
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txbLink.Text)) return;
                Task downTask = new Task(async () =>
                {
                    ShowPanel(pnlDownload, true);
                    progressChangeDownload(5);
                    await DownloadFile(txbLink.Text);
                    ShowPanel(pnlDownload, false);
                    progressChangeDownload(0);
                });
                downTask.Start();
            }
            catch { }
        }
        private void ShowPanel(Panel pnl,bool visible)
        {
            if (pnl.InvokeRequired)
            {
                pnl.BeginInvoke(new Action(() =>
                {
                    pnl.Visible = visible;
                }));
            }
            else pnl.Visible = visible;
        }

        private void btnOpenPDF_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ViewPdf viewPdf = new ViewPdf(openFileDialog.FileName);
                    viewPdf.ShowDialog();
                }
            }
            catch { }
        }
    }
}
