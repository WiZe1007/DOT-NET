using Lab_11_Task_5;
using System;
using System.Windows.Forms;

namespace Lab_11_Task_5
{
    static class Program
    {
        /// <summary>
        /// Головна точка входу для застосунку.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
