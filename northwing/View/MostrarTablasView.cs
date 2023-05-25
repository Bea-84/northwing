using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using northwing.Model;
using northwing.Controller;


namespace northwing
{
    public partial class MostrarTablasView : Form
    {
        MenuController menuControler;
        SqlConnection conection;
        DSNorthwing ds;
        MostrarTablasController mostrarTablasController; 

        public MostrarTablasView(SqlConnection pconection,DSNorthwing ds,object mostrarClienteController,object pmenuController)  
        {
            InitializeComponent();
            conection = pconection; 
            this.ds = ds;
            menuControler = (MenuController)pmenuController;
            mostrarTablasController=(MostrarTablasController)mostrarClienteController;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //tabla
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            //botón salir
            this.Dispose();
        }

        private void btCustomer_Click(object sender, EventArgs e)
        {
            //botón customers
            ds=mostrarTablasController.mostrarCustomers();
            if(ds.Customers.Rows.Count==0)
            {
                MessageBox.Show("Tabla sin datos");
            }
            else
            {
                this.dataGridView1.DataSource = ds.Customers;
            }
        }

        private void btmostrarproductos_Click(object sender, EventArgs e)
        {
            //botón productos
            ds=mostrarTablasController.mostrarProducts();
            if (ds.Products.Rows.Count == 0)
            {
                MessageBox.Show("Tabla sin datos");
            }
            else
            {
                this.dataGridView1.DataSource = ds.Products;
            }

        }

        private void btmostrarpedidos_Click(object sender, EventArgs e)
        {
            //botón pedidos
            ds = mostrarTablasController.mostrarPedidos();
            if (ds.Orders.Rows.Count == 0)
            {
                MessageBox.Show("Tabla sin datos");
            }
            else
            {
                this.dataGridView1.DataSource = ds.Orders; 
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e) 
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if(dataGridView1.DataSource == ds.Customers)
            {
                menuControler.mostrarClienteById( id);
            }
            else if(dataGridView1.DataSource == ds.Products)
            {
                menuControler.mostrarProductoById(id);
            }
            else if(dataGridView1.DataSource == ds.Orders)
            {
                menuControler.mostrarPedidoById(id);
            }
        } 
    }  
}
