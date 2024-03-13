using Meziantou.Framework.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungHoTroGiangVien.Service
{
    public static class SavePassword
    {
        public static List<Credential> LoadCredential()
        {
            return CredentialManager.EnumerateCredentials().Where(x => x.ApplicationName.StartsWith("CredentialAccount")).ToList();
        }
        public static void SaveCredential(string username, string password, bool cb)
        {
            if (cb)
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
    }
}
