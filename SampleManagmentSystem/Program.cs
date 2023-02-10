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
        private static ActiveUser _instance;
        private static readonly object Padlock = new object();

        private ActiveUser()
        {
        }
        public string Guid { get; set; }
        public string UserName { get; set; }
        public bool YetkiDüzeltme { get; set; }
        public bool YetkiSilme { get; set; }
        public bool YetkiEkleme { get; set; }
        public bool YetkiSonucEkleme { get; set; }
        //public string Password { get; set; }

        public static ActiveUser Instance
        {
            get
            {
                lock (Padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new ActiveUser();
                    }
                    return _instance;
                }
            }
        }
    }
}

