using CG.Web.MegaApiClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungHoTroGiangVien.CONSTDATA;
namespace UngDungHoTroGiangVien.Service
{
    public static class MegaCloud
    {

        public static async Task<String> UploadFile(string pathFile, Action<double> progressChange)
        {
            MegaApiClient client = new MegaApiClient();
            client.Login("yamchahuyvs@gmail.com", "Minh.2004");
            IEnumerable<INode> nodes = client.GetNodes();
            INode myFolder = nodes.Single(x => x.Type == NodeType.Directory && x.Name == "Minh");
            Progress<double> progress = new Progress<double>();
            progress.ProgressChanged += (sender, e) => progressChange(e);
            INode myFile = null;
            Task<INode> task = client.UploadFileAsync(pathFile, myFolder, progress);
            myFile = await task;
            Uri downloadLink = client.GetDownloadLink(myFile);
            client.Logout();
            task.Dispose();
            GC.Collect();
            return downloadLink.ToString();
        }
        public static async Task DownloadFile(string pathFile, Action<double> progressChange)
        {

            MegaApiClient client = new MegaApiClient();
            client.LoginAnonymous();
            Uri imgLink = new Uri(pathFile);
            INode file = client.GetNodeFromLink(imgLink);
            string downloadPath = CONST.DOWNLOADS + "\\" + file.Name;
            if (File.Exists(downloadPath))
            {
                MessageBox.Show("File Exist"); 
                return;
            }
            Progress<double> progress = new Progress<double>();
            progress.ProgressChanged += (sender, e) => progressChange(e);
            await client.DownloadFileAsync(file, downloadPath, progress);
            await Task.Delay(500);
        }
    }
}
