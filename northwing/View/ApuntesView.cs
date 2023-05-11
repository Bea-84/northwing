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

namespace northwing
{
    public partial class ApuntesView : Form
    {

        SqlConnection conection;//declaro atributo
        DSNorthwing ds;

        public ApuntesView(SqlConnection pconection,DSNorthwing ds) //paso por parámetro conexión y tabla 
        {
            InitializeComponent();
            conection = pconection; 
            this.ds = ds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //botón 

            //instrucción que ejecutará el programa
            string select = "select * from customers where City= '" + this.textBoxciudad.Text+"';";
            //select * from Customers where City='Madrid';sin comillas cuando es número

            //creacion del comando para ejecutar la consulta
            SqlCommand comando = new SqlCommand(select, conection);

            //creación del data adapter per obtener datos(es lo que ejecuta la instrucción anterior)
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);//tengo los datos aqui BBDD

            //creación dataset para almacenar datos
            DataSet dataSet = new DataSet(); //vendria a ser una tabla
            adaptador.Fill(dataSet);//y paso datos aqui(tabla)

            //--------------------------------------------------------------------------------

            //después de esta línea cambiará cuando vayamos a hacer página web

            //asignación dataset al DataGRidView del formulario
            dataGridView1.DataSource = dataSet.Tables[0];
            //relleno este datagridview1 con los datos BBDD
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //tabla
        }

        private void textBoxciudad_TextChanged(object sender, EventArgs e)
        {
            //box ciudad 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Formulario
            
            //instrucción que ejecutará el programa
            string select = "select * from customers";

            //creacion del comando para ejecutar la consulta
            SqlCommand comando = new SqlCommand(select, conection);

            //creación del data adapter per obtener datos(es lo que ejecuta la instrucción anterior)
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);//tengo los datos aqui BBDD

            //creación dataset para almacenar datos
            DataSet dataSet = new DataSet(); //vendria a ser una tabla
            adaptador.Fill(dataSet);//y paso datos aqui(tabla)

            //El sqlconnection,sqlcomand cambiará la primera parte ejemplo: oracleconection,
            //oraclecomand según la BBDD que vayamos a utilizar.

            //--------------------------------------------------------------------------------

            //despues de esta linea cambiará cuando vayamos a hacer página web

            //asignación dataset al DataGRidView del formulario
            dataGridView1.DataSource = dataSet.Tables[0]; //hago referencia a data set genérico
            //relleno este datagridview1 con los datos BBDD

            //-----------------------------------------------------------------------------------
            
            //data view 2 (DSNorthwing)
            //DSNorthwing ds=new DSNorthwing();
            adaptador.Fill(ds.Customers);
            this.dataGridView1.DataSource = ds.Customers; 
            //hago referencia a un data set específico

        } 

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    } 
}
