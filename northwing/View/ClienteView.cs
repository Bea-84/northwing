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

namespace northwing
{
    public partial class ClienteView : Form
    {
        SqlConnection conection;
        ClienteController clienteController;
        DSNorthwing ds;

        public ClienteView(SqlConnection pconection, Object pclienteController, DSNorthwing pds)
        {
            InitializeComponent();
            conection = pconection;
            clienteController = (ClienteController)pclienteController;
            ds = pds;
        }
        private void btconsultar_Click(object sender, EventArgs e)
        {
            //botón consultar 

            ds = clienteController.consultaTablaCustomers(this.textBoxCustomer.Text);

            if (ds.Customers.Rows.Count == 0)
            {
                MessageBox.Show("Cliente no registrado,indique sus datos y pulse el botón ALTA CLIENTE");
                borrarDatos();
                this.lbmensajepais.Visible = false;
                this.btAlta.Visible = true; 
            }
            else
            {
                this.textBoxCustomer.Text = ds.Customers[0].CustomerID;
                this.textBoxnombre.Text = ds.Customers[0].CompanyName;
                this.textBoxdireccion.Text = ds.Customers[0].Address;
                this.textBoxciudad.Text = ds.Customers[0].City;
                this.textBoxpais.Text = ds.Customers[0].Country;

                this.btmodificar.Visible = true; 
                this.btEliminarCliente.Visible = true;
                this.lbmensajepais.Visible = true;
                this.btcancelar.Visible = true;
                MessageBox.Show("Si desea realizar otra consulta pulse BORRAR DATOS");
                
            }
            ds.Customers.Clear(); 

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            this.btAlta.Visible = false;
            this.btcancelar.Visible = false;
            this.btmodificar.Visible = false; 
            this.btEliminarCliente.Visible=false;
        }

        private void btAlta_Click(object sender, EventArgs e)
        {

            //alta cliente

            try
            {
                int nRows; 

                if (!this.textBoxCustomer.Text.Equals("") && !this.textBoxnombre.Text.Equals(""))
                {
                    nRows = clienteController.altaCliente(this.textBoxCustomer.Text, this.textBoxnombre.Text, this.textBoxdireccion.Text, this.textBoxciudad.Text, this.textBoxpais.Text);

                    if (nRows > 0)
                    {
                        MessageBox.Show("Se ha dado de alta correctamente,Bienvenid/@");
                        borrarDatos();
                        
                        this.btAlta.Visible = false; 
                        this.btmodificar.Visible=false;
                        this.btEliminarCliente.Visible=false;
                        this.btcancelar.Visible=false;
                        
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            borrarDatos();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void borrarDatos()
        {
            this.textBoxCustomer.Text = "";
            this.textBoxnombre.Text = "";
            this.textBoxdireccion.Text = "";
            this.textBoxciudad.Text = "";
            this.textBoxpais.Text = "";
        }

        private void btEliminarCliente_Click(object sender, EventArgs e)
        {

            //eliminar cliente
            //buscar si tiene pedido y si tiene no se puede eliminar 
            ds = clienteController.buscarCustomer(this.textBoxCustomer.Text);

            try
            {
                int nRows;
                if (ds.Orders.Rows.Count > 0)
                {
                    MessageBox.Show("No se puede dar de baja ya que tiene un pedido pendiente ");
                }
                else
                {
                    nRows = clienteController.eliminarCliente(this.textBoxCustomer.Text);
                    if (nRows > 0)
                    {
                        MessageBox.Show("Se ha dado de baja correctamente,esperamos verle pronto");
                        borrarDatos();
                        this.btmodificar.Visible = false;
                        this.btEliminarCliente.Visible = false;
                        this.btcancelar.Visible = false;
                        this.lbmensajepais.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            //modificar datos cliente

            try
            {
                int nRows;
                if (!this.textBoxCustomer.Text.Equals("") && !this.textBoxnombre.Text.Equals(""))
                {
                    nRows = clienteController.modificarCliente(this.textBoxCustomer.Text,this.textBoxpais.Text);
                    if (nRows > 0)
                    {
                        MessageBox.Show("Dato modificado con éxito");
                        borrarDatos();
                        this.lbmensajepais.Visible=false;
                        this.btEliminarCliente.Visible=false;
                        this.btmodificar.Visible=false; 
                        this.btcancelar.Visible=false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        private void textBoxCustomer_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxciudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxpais_TextChanged(object sender, EventArgs e)
        {

        }   


    }  
}
