using Microsoft.Win32;
using System;
namespace UngDungHoTroGiangVien.CONSTDATA
{
    public static class CONST
    {
        //private static CONST instance;
        //public static CONST Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new CONST();
        //        }
        //        return instance;
        //    }
        //}
        public static string DOWNLOADS = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
    }
    //public static class CONSTExtention
    //{
    //    public static string CHROME(this object o)
    //    {
    //        return CONST.Instance.CHROME;
    //    }
    //    public static string DOWNLOADS(this object o)
    //    {
    //        return CONST.Instance.DOWNLOADS;
    //    }
    //}
}
