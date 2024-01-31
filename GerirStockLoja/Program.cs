using GerirStockLoja.conexao;
using System;
using System.Windows.Forms;

namespace GerirStockLoja
{
    internal static class Program
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
            //Application.Run(new FrmTrabalhadores());
        }
    }
}
