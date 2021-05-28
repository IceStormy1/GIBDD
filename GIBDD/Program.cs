using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace yt_DesignUI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения..
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Present first = new Present();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(3);
            first.Show();
            while (end>DateTime.Now)
            {
                Application.DoEvents();
            }
            first.Close();
            first.Dispose();
            Application.Run(new FormMain());
        }
    }
}
