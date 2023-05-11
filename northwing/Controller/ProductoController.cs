using northwing.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace northwing.Controller
{
    internal class ProductoController
    {
        SqlConnection conection;
        DSNorthwing ds;
        public ProductoController(SqlConnection pConexion,DSNorthwing pds)
        {
            conection = pConexion; 
            ds = pds;   
        }

        public DSNorthwing consultaTablaProductos(string ProductID)
        {
            string select = "select * from products where ProductID=" + ProductID + ";";

            SqlCommand comando = new SqlCommand(select, conection);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            adaptador.Fill(ds.Products); 

            return ds; 
        }

        public int altaProducto(string ProductName,string SupplierID,string CategoryID,string QuantitytXUnit,string UnitPrice )
        {
            int nRows = 0;

            string insert = "insert into products(ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,Discontinued) values";
            insert += "('" + ProductName+ "'," + SupplierID + "," + CategoryID+ ",'" + QuantitytXUnit + "'," + UnitPrice + ",0);";

            SqlCommand comando = new SqlCommand(insert, conection);
            nRows = comando.ExecuteNonQuery();
            //este método se utiliza cuando no queremos que nos devuelva ningun dato
            //es decir para un select no,pero si para insert,update,delete....
            //productID es incremental x lo que la BBDD le asigna numero automaticamente
            //x lo tanto no lo ponemos en el insert

            return nRows;
        } 

        public int eliminarProducto(string ProductID)
        {
            int nRows = 0;

            string delete = "Delete from Products where ProductID=" + ProductID + ";";

            SqlCommand comando = new SqlCommand(delete, conection);
            nRows = comando.ExecuteNonQuery();

            return nRows; 
        } 

        public int modificarProducto(string ProductID,string UnitPrice)
        {
            int nRows = 0;

            string update = "Update Products set UnitPrice='" + UnitPrice + "' where ProductID = '" + ProductID + "';";

            SqlCommand comando=new SqlCommand(update, conection);
            nRows=comando.ExecuteNonQuery();

            return nRows;
        } 
    }
}
