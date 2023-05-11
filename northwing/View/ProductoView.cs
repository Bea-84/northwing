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

        private void btConsulta_Click(object sender, EventArgs e)
        {
            //botón consultar

            ds = productoController.consultaTablaProductos(this.textBoxproductID.Text);
            
            if (ds.Products.Rows.Count == 0)
            {
                MessageBox.Show("El producto no existe,si desea añadir un producto rellene los datos y pulse el botón AÑADIR PRODUCTO");
                borrarDatos();
                this.textBoxproductID.Enabled = false; //método para impedir acceso a usuario
                this.btAlta.Visible = true;
                this.lbmensajemodificar.Visible = false;
               
            }
            else
            {    
                this.textBoxproductName.Text = ds.Products[0].ProductName;
                this.textBoxsupplierID.Text = ds.Products[0].SupplierID.ToString();
                this.textBoxcategoryID.Text = ds.Products[0].CategoryID.ToString();
                this.textBoxcantidad.Text = ds.Products[0].QuantityPerUnit.ToString();
                this.textBoxprecioxunidad.Text = ds.Products[0].QuantityPerUnit.ToString();

                this.bteliminarproducto.Visible=true;
                this.btModificar.Visible=true;
                this.lbmensajemodificar.Visible = true;
                this.btCancelar.Visible = true;
                MessageBox.Show("Si desea realizar otra consulta pulse BORRAR DATOS");
            }
            ds.Products.Clear(); 
            
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
                    nRows = productoController.altaProducto(textBoxproductName.Text,textBoxsupplierID.Text,textBoxcategoryID.Text,textBoxcantidad.Text,textBoxprecioxunidad.Text);

                    if (nRows > 0)
                    {
                        MessageBox.Show("Producto añadido con éxito");
                        borrarDatos();
                        this.btAlta.Visible=false;
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
            this.btAlta.Visible = false;
            this.btCancelar.Visible = false;
            this.btModificar.Visible = false;
            this.bteliminarproducto.Visible = false;    

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

                    nRows = productoController.eliminarProducto(textBoxproductID.Text);
                    if (nRows > 0)
                    {
                        MessageBox.Show("Producto eliminado con éxito");
                        borrarDatos();
                        this.btAlta.Visible = false;
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

        private void btModificar_Click(object sender, EventArgs e)
        {
            //botón modificar datos
            try
            {
                int nRows;
                if(!this.textBoxproductID.Text.Equals(""))
                {
                    nRows = productoController.modificarProducto(textBoxproductID.Text,textBoxprecioxunidad.Text);
                    if (nRows > 0)
                    {
                        MessageBox.Show("Precio producto modificado con éxito"); 
                        borrarDatos();
                        this.btAlta.Visible = false;
                        this.btModificar.Visible = false;
                        this.bteliminarproducto.Visible = false;
                        this.btCancelar.Visible = false;

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }  
}
