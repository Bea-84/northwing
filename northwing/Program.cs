using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using northwing.Controller;
using northwing.Model;

namespace northwing
{
    internal static class Program
    { 
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string ordena clase
            //string conexionBaseDatos = "Data Source=DESKTOP-HQISU85\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            //string ordenador mio
            string conexionBaseDatos="Data Source=LAPTOP-4SE0MAVK\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

            SqlConnection conexion = new SqlConnection(conexionBaseDatos);
            conexion.Open();
            DSNorthwing ds = new DSNorthwing();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MenuController controller = new MenuController(conexion,ds); 
        }  
    } 
}
