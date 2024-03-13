using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

public class EMail
{
    public static string Address = "yamchahuyvs@gmail.com"; //Địa chỉ email của bạn
    public static string Password = "nbkfrmilgukmjdnp"; //Mật khẩu ứng dụng

    public static void Send(string sendTo, string subject, string message)
    {
        using (SmtpClient smtp = new SmtpClient())
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential(Address, Password);
            smtp.SendAsync(Address, sendTo, subject, message,null);
        }
    }
    public static async void sendMailOTP(string to, string OTP)
    {
        Task send = new Task(() =>
        {
            Send(to, "Verify mail", "Verify your mail with code: " + OTP);
        });
        send.Start();
    }
}
