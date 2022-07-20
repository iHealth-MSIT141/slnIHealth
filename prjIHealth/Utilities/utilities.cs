using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace HealthyLifeApp
{
    class utilities
    {
        public static string Smtp = "smtp.gmail.com";
        public static  int Port = 587;

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz234567890!~@#$%^&*";
            var random = new Random();
            Thread.Sleep(1);
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string getCryptPWD(string pwd, string userName, string birthday)
        {
            char[] passwordChar = pwd.ToCharArray();//string convert to char
            string str1 = new string(passwordChar);//convert char to string 
            //==================================================
            byte[] passwordAscii = Encoding.ASCII.GetBytes(pwd);//convert string to ascii
            string str_password = "";
            for (int i = 0; i < passwordAscii.Length; i++)//pwd convert to char add( i+1)*2  salt define
            {
                char cha1 = (char)(passwordAscii[i]);
                char cha = (char)(passwordAscii[i] + (i + 1) * 2);
                str_password += cha1.ToString() + cha.ToString();
            }
            //==================================================
            byte[] userNameAscii = Encoding.ASCII.GetBytes(userName);//userName
            string str_userName = "";
            for (int j = 0; j < userName.Length; j++)
            {
                char cha_userName = (char)(userNameAscii[j]);
                char cha_userNameSalt = (char)(userNameAscii[j] + (j + 2) * 3);
                str_userName += cha_userName + cha_userNameSalt;
            }
            //==================================================
            byte[] birthdayAscii = Encoding.ASCII.GetBytes(birthday);//userName
            string str_birthday = "";
            for (int k = 0; k < birthday.Length; k++)
            {
                char cha_birthday = (char)(birthdayAscii[k]);
                char cha_birthdaySalt = (char)(birthday[k] + (k + 3) * 2);
                str_birthday += cha_birthday + cha_birthdaySalt;
            }
            Cryptographys cryp = new Cryptographys();
            string pwdCryp = cryp.SHA256Encode(str_password + str_userName+str_birthday);
            return pwdCryp;
        }
        public  bool CheckedPassword(string password)//with Regex to check password
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+"); 
            var hasLowerChar = new Regex(@"[a-z]+"); 
            var hasSymbol = new Regex(@"[!@#~$%^&*]+"); 
            if (password.Length >= 6 && password.Length <= 15)
            {
                var isValidated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasLowerChar.IsMatch(password);
                  return true;
            }
            else {  return false; };
        }
        public static void sendMail(string AccountName, string userMail) {
            MailMessage mm = new MailMessage("charleschou54138@gmail.com",userMail);
            mm.Subject = $"{AccountName} 您的密碼已重設, 請登入後,重新修改密碼";
            mm.Body = $"{AccountName}您好, 重設的密碼為登入帳號,請登入後, 進入會員資料修改您的密碼,以保障您帳號的使用安全\n  HealthyLife 敬上";
            //mm.Attachments.Add(new Attachment(""));//attachment
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            //smtp.Host = utilities.Smtp;
            //smtp.Port = utilities.Port;
            System.Net.NetworkCredential nc = new NetworkCredential("charleschou54138@gmail.com", "bsdzdnzgoxgyegde");
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(mm);
        }
        public static void sendVerifiedMail() { }

}
}
