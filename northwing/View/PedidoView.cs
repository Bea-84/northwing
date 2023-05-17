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
    public partial class PedidoView : Form
    {

        SqlConnection connection;
        PedidoController pedidoController;
        DSNorthwing ds;

        public PedidoView(SqlConnection pconnection, object ppedidoController, DSNorthwing pds)
        {
            InitializeComponent();
            connection=pconnection;
            pedidoController =(PedidoController) ppedidoController;
            ds = pds;
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            //botón consultar

            try
            {
                decimal id = decimal.Parse(this.textBoxorderID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dato introducido incorrecto,por favor introduzca un valor numérico");
                borrarDatos();
                return;
            } 

            ds = pedidoController.consultaTablaPedidos(this.textBoxorderID.Text);

            if (ds.Orders.Rows.Count == 0)
            {
                MessageBox.Show("El pedido no existe, si lo desea rellene los datos a continuación y pulse el botón CREAR PEDIDO");
                borrarDatos();
                this.textBoxorderID.Enabled = false; //método para impedir acceso a usuario
                this.btAlta.Visible = true;
                this.panel1.Visible = true;
                this.lbinstruccion.Visible = true;
                this.lbsubtitulo.Visible = true;
                this.lbmensajemodificar.Visible = false;

                this.textBoxcustomerID.Enabled = true;
                this.cbEmployeID.Enabled = true;
                this.textBoxorderdate.Enabled = true;
                this.textBoxdireccion.Enabled = true;
                this.textBoxCP.Enabled = true;

            }
            else 
            {
                this.textBoxcustomerID.Text = ds.Orders[0].CustomerID;
                this.textBoxemployeID.Text = ds.Orders[0].EmployeeID.ToString();
                this.textBoxorderdate.Text = ds.Orders[0].OrderDate.ToString();
                this.textBoxdireccion.Text = ds.Orders[0].ShipAddress;
                this.textBoxCP.Text = ds.Orders[0].ShipPostalCode;
                //si el dato que queremos grabar en la BBDD es null asi le diremos al programa 
                //que añada dato igualmente 
                if (!ds.Orders[0].IsShipCountryNull())
                {
                    this.textBoxcountry.Text = "" + ds.Orders[0].ShipCountry;
                }
                
                this.bteliminarpedido.Visible = true;
                this.btmodificar.Visible = true;
                this.btCancelar.Visible = true;
                this.lbmensajemodificar.Visible = true;
                this.panel1.Visible = true;
                this.lbinstruccion.Visible = false;
                this.lbsubtitulo.Visible = true;

                this.textBoxcustomerID.Enabled = false;
                this.cbEmployeID.Enabled = false;
                this.textBoxorderdate.Enabled = false;
                this.textBoxdireccion.Enabled = false;
                this.textBoxCP.Enabled = false;
                MessageBox.Show("Si desea realizar otra consulta pulse BORRAR DATOS"); 
            }
            ds.Orders.Clear();   
        } 

        private void btAlta_Click(object sender, EventArgs e)
        {
            //botón alta  

            ds = pedidoController.buscarCustomer(this.textBoxcustomerID.Text);

            try
            {
                int nRows;

                if (ds.Customers.Rows.Count >0 ) 
                {
                    nRows = pedidoController.altaPedido(this.textBoxcustomerID.Text,this.textBoxemployeID.Text, this.textBoxorderdate.Text,this.textBoxdireccion.Text, this.textBoxCP.Text, this.textBoxcountry.Text);

                    if (nRows > 0)
                    {
                        MessageBox.Show("Pedido realizado con éxito");
                        borrarDatos();
                        this.btAlta.Visible = false;
                        this.btmodificar.Visible = false;
                        this.bteliminarpedido.Visible = false;
                        this.btCancelar.Visible = false;
                    }
                     
                }
                else
                {
                    MessageBox.Show("El cliente no existe,debe darse de alta para poder hacer pedido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //botón cancelar
            borrarDatos();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            //botón salir
            this.Dispose();
        }

        private void PedidoView_Load(object sender, EventArgs e)
        {
            //load diseño

            this.btAlta.Visible= false;
            this.btCancelar.Visible = false;
            this.btmodificar.Visible = false;
            this.bteliminarpedido.Visible = false;
            this.textBoxemployeID.Enabled = false;
            this.panel1.Visible = false;
            if(ds.Employees.Rows.Count == 0)
            {
                string query = "SELECT EmployeeID,LastName,FirstName FROM Employees;"; //tres valores not null

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataRow row = ds.Employees.NewRow();
                row[0] = 0;
                row[1] = "Seleccione empleado";
                row[2] = " "; //añadimos fila para valor not null, que en este caso tenemos tres
                ds.Employees.Rows.InsertAt(row, 0);
                adapter.Fill(ds.Employees);

                this.cbEmployeID.DataSource = ds.Employees;

                this.cbEmployeID.DisplayMember = "LastName"; //lo que ve usuario
                this.cbEmployeID.ValueMember = "EmployeeID"; //valor que guarda el programa
                this.cbEmployeID.SelectedIndex = 0;
                this.textBoxemployeID.Text = string.Empty;
            }
            else
            {
                this.cbEmployeID.DataSource = ds.Employees;

                this.cbEmployeID.DisplayMember = "LastName"; //lo que ve usuario
                this.cbEmployeID.ValueMember = "EmployeeID"; //valor que guarda el programa
                this.cbEmployeID.SelectedIndex = 0;
                this.textBoxemployeID.Text = string.Empty; 
            }
         
        }  

        private void cbEmployeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combo box
            if (cbEmployeID.SelectedIndex > 0)
            {
                this.textBoxemployeID.Text = cbEmployeID.SelectedValue.ToString();
            }
            else
            {
                this.textBoxemployeID.Text = "";
            }
        }

        private void bteliminarpedido_Click(object sender, EventArgs e)
        {
            //botón eliminar pedido
            try
            {
                int nRows;
                if (!this.textBoxorderID.Text.Equals(""))
                {
                    string mensaje = "¿Seguro que deseas eliminar el pedido?";
                    string titulo = "Eliminar pedido";
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, titulo, botones);

                    if (result == DialogResult.Yes) 
                    {
                        nRows = pedidoController.eliminarPedido(this.textBoxorderID.Text);
                        if (nRows > 0)
                        {
                            MessageBox.Show("Pedido eliminado con éxito");
                            borrarDatos();
                            this.btAlta.Visible = false;
                            this.btmodificar.Visible = false;
                            this.bteliminarpedido.Visible = false;
                            this.btCancelar.Visible = false;
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
            //botón modificar datos

            try
            {
                int nRows;
                if (!this.textBoxorderID.Text.Equals(""))
                {
                    string mensaje = "¿Seguro que desea modificar su pais?";
                    string titulo = "Modificar Dato";
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, titulo, botones);

                    if (result == DialogResult.Yes)
                    {
                        nRows = pedidoController.modificarPedido(this.textBoxorderID.Text, this.textBoxcountry.Text);
                        if (nRows > 0)
                        {
                            MessageBox.Show("Dato modificado con éxito");
                            borrarDatos();
                            this.btAlta.Visible = false;
                            this.btmodificar.Visible = false;
                            this.bteliminarpedido.Visible = false;
                            this.btCancelar.Visible = false;
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

        private void borrarDatos()
        {
            this.textBoxorderID.Text = "";
            this.textBoxcustomerID.Text = "";
            this.textBoxemployeID.Text = "";
            this.textBoxorderdate.Text = "";
            this.textBoxdireccion.Text = "";
            this.textBoxCP.Text = "";
            this.textBoxcountry.Text = "";
        }
    }  
}
