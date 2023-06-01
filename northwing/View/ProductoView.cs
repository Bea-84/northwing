using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using northwing.Controller;
using northwing.Model;


namespace northwing
{
    public partial class ProductoView : Form
    {
        SqlConnection connection;
        ProductoController productoController;
        DSNorthwing ds;

        public ProductoView(SqlConnection pconection, object pproductoController, DSNorthwing pds)
        {
            InitializeComponent();
            connection = pconection;
            productoController = (ProductoController)pproductoController;
            ds = pds;   
        }
        public void cambiarTextoId(string  id)
        {
            textBoxproductID.Text = id;
        }
        public void btnConsultarClickAux()
        {
            
            try
            {
                decimal id = decimal.Parse(this.textBoxproductID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dato introducido incorrecto,por favor introduzca un valor numérico");
                borrarDatos();
                return;
            }
            
            ds = productoController.consultaTablaProductos(this.textBoxproductID.Text);

            if (ds.Products.Rows.Count == 0)
            {
                MessageBox.Show("El producto no existe,si desea añadir un producto rellene los datos y pulse el botón AÑADIR PRODUCTO");
                borrarDatos();
                this.textBoxproductID.Enabled = false; //método para impedir acceso a usuario
                this.btañadirproducto.Visible = true;
                this.panel1.Visible = true;
                this.lbinstruccion.Visible = true;
                this.lbsubtitulo.Visible = true;
                this.lbmensajemodificar.Visible = false;

                this.textBoxproductName.Enabled = true;
                this.textBoxsupplierID.Enabled = true;
                this.cbCategorias.Enabled = true;
                this.textBoxcantidad.Enabled = true;
            }
            else
            {
                this.textBoxproductName.Text = ds.Products[0].ProductName;
                this.textBoxsupplierID.Text = ds.Products[0].SupplierID.ToString();
                this.textBoxcategoryID.Text = ds.Products[0].CategoryID.ToString();
                this.textBoxcantidad.Text = ds.Products[0].QuantityPerUnit.ToString();
                this.textBoxprecioxunidad.Text = ds.Products[0].UnitPrice.ToString();

                this.bteliminarproducto.Visible = true;
                this.btModificar.Visible = true;
                this.btCancelar.Visible = true;
                this.panel1.Visible = true;
                this.lbinstruccion.Visible = false;
                this.lbsubtitulo.Visible = true;
                this.lbmensajemodificar.Visible = true;

                this.textBoxproductName.Enabled = false;
                this.textBoxsupplierID.Enabled = false;
                this.cbCategorias.Enabled = false;
                this.textBoxcantidad.Enabled = false;

                MessageBox.Show("Si desea realizar otra consulta pulse BORRAR DATOS");
            }
            
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            btnConsultarClickAux();
            
        } 

        private void btcancelar_Click(object sender, EventArgs e)
        {
            //botón cancelar
            borrarDatos();
        }

        private void btAlta_Click(object sender, EventArgs e)
        {
            //botón alta

            try
            {
                int nRows;
                if (!this.textBoxproductName.Text.Equals(""))
                {
                    nRows = productoController.altaProducto(this.textBoxproductName.Text,this.textBoxsupplierID.Text,this.textBoxcategoryID.Text,this.textBoxcantidad.Text,this.textBoxprecioxunidad.Text);

                    if (nRows > 0)
                    {
                        MessageBox.Show("Producto añadido con éxito");
                        borrarDatos();
                        this.btañadirproducto.Visible=false;
                        this.btModificar.Visible = false;
                        this.bteliminarproducto.Visible = false;
                        this.btCancelar.Visible = false;
                        
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        } 

        private void btSalir_Click(object sender, EventArgs e)
        {
            //botón salir
            this.Dispose();
        }

        private void borrarDatos() 
        {
            this.textBoxproductID.Text = "";
            this.textBoxproductName.Text = "";
            this.textBoxsupplierID.Text = "";
            this.textBoxcategoryID.Text = "";
            this.textBoxcantidad.Text = "";
            this.textBoxprecioxunidad.Text = "";
        }

        private void Products_Load(object sender, EventArgs e)
        {
            this.btañadirproducto.Visible = false;
            this.btCancelar.Visible = false;
            this.btModificar.Visible = false;
            this.bteliminarproducto.Visible = false;
            this.textBoxcategoryID.Enabled = false;
            this.panel1.Visible = false;
            if (ds.Categories.Rows.Count == 0)
            {
                string query = "SELECT CategoryID, CategoryName FROM Categories;";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataRow row = ds.Categories.NewRow();
                row[0] = 0;
                row[1] = "Elige categoria";
                ds.Categories.Rows.InsertAt(row, 0);
                adapter.Fill(ds.Categories);

                this.cbCategorias.DataSource = ds.Categories;

                this.cbCategorias.DisplayMember = "CategoryName"; //lo que ve usuario
                this.cbCategorias.ValueMember = "CategoryID"; //valor que guarda el programa
                this.cbCategorias.SelectedIndex = 0;
                this.textBoxcategoryID.Text = string.Empty;
            }
            else
            {

                this.cbCategorias.DataSource = ds.Categories;

                this.cbCategorias.DisplayMember = "CategoryName"; //lo que ve usuario
                this.cbCategorias.ValueMember = "CategoryID"; //valor que guarda el programa
                this.cbCategorias.SelectedIndex = 0;
                this.textBoxcategoryID.Text = string.Empty; 
            }
            
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (cbCategorias.SelectedIndex > 0)
            {
                this.textBoxcategoryID.Text = cbCategorias.SelectedValue.ToString();   
            }
            else
            {
                this.textBoxcategoryID.Text = "";
            }
        } 

        private void bteliminarproducto_Click(object sender, EventArgs e)
        {
            try
            {
                int nRows;
                if (!this.textBoxproductID.Text.Equals("") )
                {

                    string mensaje = "¿Seguro que deseas eliminar el producto?";
                    string titulo = "Eliminar producto";
                    MessageBoxButtons botones=MessageBoxButtons.YesNo;
                    DialogResult result;
                    result=MessageBox.Show(mensaje, titulo, botones);
                    
                    if (result == DialogResult.Yes)
                    {
                        
                        nRows = productoController.eliminarProducto(this.textBoxproductID.Text);
                        if (nRows > 0)
                        {
                            MessageBox.Show("Producto eliminado con éxito");
                            borrarDatos();
                            this.btañadirproducto.Visible = false;
                            this.btModificar.Visible = false;
                            this.bteliminarproducto.Visible = false;
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

        private void btModificar_Click(object sender, EventArgs e)
        {
            //botón modificar datos
            try
            {
                int nRows;
                if(!this.textBoxproductID.Text.Equals(""))
                {
                    string mensaje = "¿Seguro que deseas modificar el precio del producto?";
                    string titulo = "Modificar Dato";
                    MessageBoxButtons botones = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, titulo, botones);

                    if (result == DialogResult.Yes)
                    {
                        nRows = productoController.modificarProducto(this.textBoxproductID.Text, this.textBoxprecioxunidad.Text);
                        if (nRows > 0)
                        {
                            MessageBox.Show("Precio producto modificado con éxito");
                            borrarDatos();
                            this.btañadirproducto.Visible = false;
                            this.btModificar.Visible = false;
                            this.bteliminarproducto.Visible = false;
                            this.btCancelar.Visible = false;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Modifique sus datos cuando necesite");
                    }

                 
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void textBoxproductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //te metes en diseño en el text box que necesites, pulsas rayo(eventos) y seleccionas KEY PRESS
            //pulsas dos veces al text box y en el código ponemos lo siguiente
            //de esta manera el usuario no podrá introducir un valor no valido
            //e.Handled = !char.IsDigit(e.KeyChar);
            
            //if (!char.IsDigit(e.KeyChar))
            //{
            //    textBoxproductID.Text = "";
            //}

            if(e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                try
                {
                    decimal id = decimal.Parse(this.textBoxproductID.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dato introducido incorrecto,por favor introduzca un valor numérico");
                    borrarDatos();
                    return;
                }

                ds = productoController.consultaTablaProductos(this.textBoxproductID.Text);

                if (ds.Products.Rows.Count == 0)
                {
                    MessageBox.Show("El producto no existe,si desea añadir un producto rellene los datos y pulse el botón AÑADIR PRODUCTO");
                    borrarDatos();
                    this.textBoxproductID.Enabled = false; //método para impedir acceso a usuario
                    this.btañadirproducto.Visible = true;
                    this.panel1.Visible = true;
                    this.lbinstruccion.Visible = true;
                    this.lbsubtitulo.Visible = true;
                    this.lbmensajemodificar.Visible = false;

                    this.textBoxproductName.Enabled = true;
                    this.textBoxsupplierID.Enabled = true;
                    this.cbCategorias.Enabled = true;
                    this.textBoxcantidad.Enabled = true;
                }
                else
                {
                    this.textBoxproductName.Text = ds.Products[0].ProductName;
                    this.textBoxsupplierID.Text = ds.Products[0].SupplierID.ToString();
                    this.textBoxcategoryID.Text = ds.Products[0].CategoryID.ToString();
                    this.textBoxcantidad.Text = ds.Products[0].QuantityPerUnit.ToString();
                    this.textBoxprecioxunidad.Text = ds.Products[0].UnitPrice.ToString();

                    this.bteliminarproducto.Visible = true;
                    this.btModificar.Visible = true;
                    this.btCancelar.Visible = true;
                    this.panel1.Visible = true;
                    this.lbinstruccion.Visible = false;
                    this.lbsubtitulo.Visible = true;
                    this.lbmensajemodificar.Visible = true;

                    this.textBoxproductName.Enabled = false;
                    this.textBoxsupplierID.Enabled = false;
                    this.cbCategorias.Enabled = false;
                    this.textBoxcantidad.Enabled = false;

                    MessageBox.Show("Si desea realizar otra consulta pulse BORRAR DATOS");
                }
            }
            
        } 

        private void textBoxproductID_TextChanged(object sender, EventArgs e)
        {
            //textBoxproductID.SelectionStart = textBoxproductID.Text.Length;
            //string auxCambiar = "";
            //if (textBoxproductID.Text.Length > 0)
            //{
            //    int i = 0;
            //    foreach(char c in textBoxproductID.Text)
            //    {
            //        if (!char.IsDigit(textBoxproductID.Text[i]))
            //        {
            //             auxCambiar = textBoxproductID.Text.Substring(0, textBoxproductID.Text.Length - 1);
            //        }
            //        else
            //        {
            //            auxCambiar = textBoxproductID.Text;
            //        }
            //        i++;
            //    }

            //    textBoxproductID.Text = auxCambiar;
            //}

        }

        private void textBoxprecioxunidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    int nRows;
                    if (!this.textBoxproductName.Text.Equals(""))
                    {
                        nRows = productoController.altaProducto(this.textBoxproductName.Text, this.textBoxsupplierID.Text, this.textBoxcategoryID.Text, this.textBoxcantidad.Text, this.textBoxprecioxunidad.Text);

                        if (nRows > 0)
                        {
                            MessageBox.Show("Producto añadido con éxito");
                            borrarDatos();
                            this.btañadirproducto.Visible = false;
                            this.btModificar.Visible = false;
                            this.bteliminarproducto.Visible = false;
                            this.btCancelar.Visible = false;

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
        }
    }  
}
