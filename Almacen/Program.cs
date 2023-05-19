using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtileriasFuncionesLESP;

namespace Almacen
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CEstructuraGral ep = new CEstructuraGral();
            ep.Ip = "127.0.0.1";
            ep.BaseDeDatos = "almacen";
            ep.Usuario = "almacen";
            ep.IpMaquina = FuncionesLESP.consultarsIp();
            ep.Pass = FuncionesLESP.GeneraPassWord(ep.Usuario, ep.BaseDeDatos); // df86f48c52ea61268a86f38fadf9447e

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAltaArticulos(ep));
        }
    }
}
