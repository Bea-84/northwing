using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using northwing.View;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using northwing.Model;
using System.Collections.Specialized;

namespace northwing.Controller
{
    internal class MenuController
    {
        SqlConnection conection;
        DSNorthwing ds;

        public MenuController(SqlConnection pconection,DSNorthwing pds)
        {
            ds = pds;
            conection = pconection;
            Application.Run(new MenuView(conection,this, ds)); 
        
        }  

        public void gestionClientes()
        {
            ClienteController clienteController = new ClienteController(conection,ds);

            ClienteView clienteView = new ClienteView(conection,clienteController,ds); 

            clienteView.Show(); 
        } 

        public void mostrarClienteById(string id)
        {
            ClienteController clienteController = new ClienteController(conection, ds);
            ClienteView clienteView = new ClienteView(conection, clienteController, ds);
            clienteView.Show();
            clienteView.cambiarTextoID(id);
            clienteView.btncosultarClickAux();

        }

        public void gestionProductos()
        {
            ProductoController productoController = new ProductoController(conection,ds); 

            ProductoView productoView = new ProductoView(conection, productoController,ds); 

            productoView.Show();
        }

         public void mostrarProductoById(string id)
        {
            ProductoController productoController = new ProductoController(conection,ds); 

            ProductoView productoView = new ProductoView(conection, productoController,ds); 

            productoView.Show();
            productoView.cambiarTextoId(id);
            productoView.btnConsultarClickAux();
        }


        public void crearPedido()
        {
            PedidoController pedidoController = new PedidoController(conection,ds);

            PedidoView pedidoView = new PedidoView(conection, pedidoController, ds);

            pedidoView.Show();
        }

        public void mostrarPedidoById(string id)
        {

            PedidoController pedidoController = new PedidoController(conection, ds);

            PedidoView pedidoView = new PedidoView(conection, pedidoController, ds);

            pedidoView.Show();
            pedidoView.cambiarTextoId(id);
            pedidoView.btnConsultarClickAux();
        }

        public void mostrarTablas()
        {
            MostrarTablasController mostrarTablasController = new MostrarTablasController(conection, ds);

            MostrarTablasView mostrarTablasView = new MostrarTablasView(conection, ds, mostrarTablasController,this);

            mostrarTablasView.Show();
        }
     
    }  
}
