using northwing.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace northwing.Controller
{
    internal class PedidoController
    {
        SqlConnection conection;
        DSNorthwing ds;
        public PedidoController(SqlConnection pConexion, DSNorthwing pds)
        {
            conection = pConexion;
            ds = pds;
        } 

        public DSNorthwing consultaTablaPedidos(string OrderID)  
        {
            ds.Orders.Clear();
            string select = "select * from orders where OrderID=" + OrderID + ";";

            SqlCommand comando = new SqlCommand(select, conection);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            adaptador.Fill(ds.Orders);

            return ds;
        }

        public int altaPedido(string customerID,string employeeID,string orderDate,string direccion,string codPostal,string ciudad)
        {
            int nRows = 0;

            string insert = "insert into orders(CustomerID,EmployeeID,OrderDate,ShipAddress,ShipPostalCode,ShipCountry)values";
            insert += "('"+customerID+"',"+employeeID+",'"+DateTime.Parse(orderDate)+"','"+direccion+"','"+codPostal+"','"+ciudad+"');";

            SqlCommand comando = new SqlCommand(insert, conection);
            nRows = comando.ExecuteNonQuery();
            //este método se utiliza cuando no queremos que nos devuelva ningun dato
            //es decir para un select no,pero si para insert,update,delete....
            //orderID es incremental x lo que la BBDD le asigna numero automaticamente
            //x lo tanto no lo ponemos en el insert

            return nRows; 
        }

        public DSNorthwing buscarCustomer(string customerID)
        {
            string select = "select * from customers where CustomerID='" + customerID + "';";

            SqlCommand comando = new SqlCommand(select, conection);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            adaptador.Fill(ds.Customers);

            return ds; 
        } 

        public int eliminarPedido(string OrderID)
        {
            int nRows = 0;

            string delete = "Delete from orders where OrderID=" + OrderID + ";";

            SqlCommand comando = new SqlCommand(delete, conection);
            nRows = comando.ExecuteNonQuery();

            return nRows;
        } 

        public int modificarPedido(string orderID, string country)
        {
            int nRows = 0;

            string update = "Update orders set ShipCountry='" + country + "' where OrderID = " + orderID + ";";

            SqlCommand comando = new SqlCommand(update, conection);
            nRows = comando.ExecuteNonQuery();

            return nRows;
        }  
    }
}
