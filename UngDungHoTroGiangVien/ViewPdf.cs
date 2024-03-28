using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungHoTroGiangVien.CONSTDATA;

namespace UngDungHoTroGiangVien
{
    public partial class ViewPdf : Form
    {
        public ViewPdf(string file)
        {
            InitializeComponent();
            //System.Diagnostics.Process.Start(CONST.CHROME, file);
            pdfViewer1.LoadFromFile(file);
            //Thread.Sleep(100);
        }
    
    }
}
