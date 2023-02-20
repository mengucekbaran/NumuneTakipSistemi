using SampleManagmentSystem.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleManagmentSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
            
        }
    }

    //LOGIN YAPAN KULLANICI BİLGİSİNE HER FORMDAN ERİŞİLMESİNİ SAĞLAR
    public class ActiveUser
    {
        // Bu sınıfın yalnızca bir örneği olmalı, bu yüzden _instance statik olarak tanımlanır
        // ve sadece bu sınıf içinde erişilebilir.
        private static ActiveUser _instance;
        // Çoklu threadler arasında uyumsuzlukları önlemek için kilit mekanizması kullanılır.
        private static readonly object Padlock = new object();
        // Yapıcı metod özel olarak belirtilir. Bu, sınıfın yalnızca bir kez oluşturulmasını sağlar.
        private ActiveUser()
        {
        }
        // Kullanıcı kimliği, kullanıcı adı ve yetkilendirme bilgilerini tutan özellikler belirtilir.
        public string Guid { get; set; }
        public int UserNo { get; set; }
        public string UserName { get; set; }
        public bool YetkiDüzeltme { get; set; }
        public bool YetkiSilme { get; set; }
        public bool YetkiEkleme { get; set; }
        public bool YetkiSonucEkleme { get; set; }
        public bool YetkiListeleme { get; set; } // tüm numuneleri listeleme
        //public string Password { get; set; }

        // ActiveUser sınıfının tek örneğine erişmek için kullanılacak olan statik bir özellik belirtilir.
        public static ActiveUser Instance
        {
            get
            {
                // Eşzamanlılık problemlerini önlemek için kilit mekanizması kullanılır.
                lock (Padlock)
                {
                    // _instance değişkeni kontrol edilir, örneği null ise bir örnek oluşturulur.
                    if (_instance == null)
                    {
                        _instance = new ActiveUser();
                    }
                    // Aksi takdirde, zaten bir örneği var demektir, var olan örnek geri döndürülür.
                    return _instance;
                }
            }
        }
    }
}

