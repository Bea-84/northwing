using northwing.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace northwing.Controller
{
    internal class MostrarTablasController
    {
        SqlConnection conection;
        DSNorthwing ds;
        public MostrarTablasController(SqlConnection pConexion, DSNorthwing pds)
        {
            conection = pConexion;
            ds = pds;
        }

        public DSNorthwing mostrarCustomers()
        {
            ds.Customers.Clear();
            string select = "select * from customers";

            SqlCommand comando = new SqlCommand(select, conection);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            adaptador.Fill(ds.Customers);
            //this.dataGridView1.DataSource = ds.Customers;
            return ds; 
        }

        public DSNorthwing mostrarProducts()
        {   ds.Products.Clear();
            string select = "select * from products";

            SqlCommand comando = new SqlCommand(select, conection);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            adaptador.Fill(ds.Products);
            //this.dataGridView1.DataSource = ds.Products;
            return ds;
        }

        public DSNorthwing mostrarPedidos()
        {
            ds.Orders.Clear();
            string select = "select * from orders";

            SqlCommand comando = new SqlCommand(select, conection);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            adaptador.Fill(ds.Orders);
            //this.dataGridView1.DataSource = ds.Orders;
            return ds;
        }

    } 
}
