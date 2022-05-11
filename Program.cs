using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class Combo
    {
        public static string Combobox1 { get; set; }
        public static string Combobox2 { get; set; }
        public static string Combobox3 { get; set; }
        public static string Combobox4 { get; set; }
        public static string Links { get; set; }
    }
}
