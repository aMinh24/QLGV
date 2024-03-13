using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungHoTroGiangVien.CONST
{
    public static class CONST
    {
        public static string CHROME = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe", "", null);
        public static string DOWNLOADS = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
        public static string EXCEL = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\App Paths\excel.exe", "", null);
        public static string PPT = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\App Paths\powerpnt.exe", "", null);
        public static string WORD = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\App Paths\Winword.exe", "", null);
    }
}
