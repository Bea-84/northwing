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
        public void cambiarTextoID(string id)
        {
            textBoxCustomer.Text = id;
        }
        private void btconsultar_Click(object sender, EventArgs e)
        {
            //botón consultar 
            btncosultarClickAux(); 
        } 

        public void btncosultarClickAux()
        {
            
            ds = clienteController.consultaTablaCustomers(this.textBoxCustomer.Text);

            if (ds.Customers.Rows.Count == 0)
            {

                MessageBox.Show("Cliente no registrado,indique sus datos y pulse el botón ALTA CLIENTE");
                borrarDatos();
                this.btAlta.Visible = true;
                this.panel1.Visible = true;
                this.lbsubtitulo.Visible = true;
                this.lbinstruccion.Visible = true;
                this.lbmensajepais.Visible = false;

                this.textBoxnombre.Enabled = true;
                this.textBoxdireccion.Enabled = true;
                this.textBoxciudad.Enabled = true;

            }
            else
            {
                this.textBoxCustomer.Text = ds.Customers[0].CustomerID;
                this.textBoxnombre.Text = ds.Customers[0].CompanyName;
                this.textBoxdireccion.Text = ds.Customers[0].Address;
                this.textBoxciudad.Text = ds.Customers[0].City;
                this.textBoxpais.Text = ds.Customers[0].Country;

                this.btmodificar.Visible = true;
                this.btbajaCliente.Visible = true;
                this.btborrardatos.Visible = true;
                this.panel1.Visible = true;
                this.lbmensajepais.Visible = true;
                this.lbsubtitulo.Visible = true;
                this.lbinstruccion.Visible = false;

                this.textBoxnombre.Enabled = false;
                this.textBoxdireccion.Enabled = false;
                this.textBoxciudad.Enabled = false;
                MessageBox.Show("Si desea realizar otra consulta pulse BORRAR DATOS");

            }
            
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            this.btAlta.Visible = false;
            this.btborrardatos.Visible = false;
            this.btmodificar.Visible = false; 
            this.btbajaCliente.Visible=false;
            this.panel1.Visible = false;
            this.lbmensajepais.Visible = false; 
        }

        private void btAlta_Click(object sender, EventArgs e)
        {

            // Botón alta cliente

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
                        this.btbajaCliente.Visible=false;
                        this.btborrardatos.Visible=false;
                        
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

            // botón eliminar cliente
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
                    string mensaje = "¿Seguro que deseas darte de baja?";
                    string titulo = "Baja cliente";
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, titulo, botones);

                    if (result == DialogResult.Yes)
                    {
                        nRows = clienteController.eliminarCliente(this.textBoxCustomer.Text);
                        if (nRows > 0)
                        {
                            MessageBox.Show("Se ha dado de baja correctamente,esperamos verle pronto");
                            borrarDatos();
                            this.btmodificar.Visible = false;
                            this.btbajaCliente.Visible = false;
                            this.btborrardatos.Visible = false;
                            this.lbmensajepais.Visible = false;
                        } 
                    }
                    else
                    {
                        MessageBox.Show("Gracias por confiar en nosotros");
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
            // Botón modificar datos cliente

            try
            {
                int nRows;
                if (!this.textBoxCustomer.Text.Equals("") && !this.textBoxnombre.Text.Equals(""))
                {
                    string mensaje = "¿Seguro que desea modificar su pais?";
                    string titulo = "Modificar Dato";
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, titulo, botones);

                    if (result == DialogResult.Yes)
                    {
                        nRows = clienteController.modificarCliente(this.textBoxCustomer.Text, this.textBoxpais.Text);
                        if (nRows > 0)
                        {
                            MessageBox.Show("Dato modificado con éxito");
                            borrarDatos();
                            this.lbmensajepais.Visible = false;
                            this.btbajaCliente.Visible = false;
                            this.btmodificar.Visible = false;
                            this.btborrardatos.Visible = false;
                        } 
                    }
                    else
                    {
                        MessageBox.Show("Modifique sus datos cuando necesite");
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
