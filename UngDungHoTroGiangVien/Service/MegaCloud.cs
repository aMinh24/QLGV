using CG.Web.MegaApiClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungHoTroGiangVien.Service
{
    public class MegaCloud
    {

        public static async Task UploadFile(string pathFile, Action<double> progressChange)
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

        }
    }
}
