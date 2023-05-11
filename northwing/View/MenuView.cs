using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using northwing.Controller;
using northwing.Model;

namespace northwing.View
{
    public partial class MenuView : Form
    {
        SqlConnection conection;
        MenuController menuController;
        DSNorthwing ds;

        public MenuView (SqlConnection pconection,Object controlador, DSNorthwing pds)
        {
            InitializeComponent();
            conection = pconection;
            ds=pds;
            menuController=(MenuController)controlador;
        } 
        private void btgestioncliente_Click(object sender, EventArgs e)
        {
            //gestión clientes 
            menuController.gestionClientes();
        }

        private void btgestionproductos_Click(object sender, EventArgs e)
        {
            //gestión productos
            menuController.gestionProductos();
        }

        private void btcrearpedido_Click(object sender, EventArgs e)
        {
            //crear pedido
            menuController.crearPedido();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            //salir
            this.Dispose();
        }
    } 
}
