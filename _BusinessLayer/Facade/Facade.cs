using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BusinessLayer.Facade
{
    public class Facade
    {
        System1Control system1 = new System1Control();
        System2Operations system2 = new System2Operations();
        public string Kontrol(string username, string password, string mail, string question, string answer, int? authorize)
        {
            int deger = system2.InsertUser(username, password, mail, question, answer, authorize);
            if (deger==1)
            {
                return "Kullanıcı İsmi Bulunamadı";
            }
            else if(deger==2)
            {
                return "Şifrenizi Yanlış Girdiniz";
            }
            else if (deger == 3)
            {
                return "Gizli Sorunuzu Yanlış Girdiniz";
            }
            else if (deger == 4)
            {
                return "Gizli Soru Cevabınızı Yanlış Girdiniz";
            }
            else if (deger == 5)
            {
                return "E-Mailinizi Yanlış Girdiniz";
            }
            else if (deger == 6)
            {
                return "Böyle Bir Kullanıcı İsmi Mevcut";
            }
            else if (deger > 6)
            {
                return "Beklenmedik Bir sorun Oluştu";
            }
            return null;
        }
        public string Register(string username, string password, string mail, string question, string answer, int? authorize)
        {
            string degisken = Kontrol(username,password,mail,question,answer,authorize);
            if (degisken==null && system1.AuthorizeControl(authorize))
            {
                return "Başarılı";
            }
            else
            {
                var user = system2.GetUser(username);
                if (user!=null)
                {
                    system2.DeleteUser(user.UserName);
                    return degisken;
                }
                return degisken;

            }
        }
        public bool Check(string username,string password)
        {
           return system2.IsValidUser(username, password);
        }
    }
}
