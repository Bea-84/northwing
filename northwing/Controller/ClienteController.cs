using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using northwing.Model;


namespace northwing.Controller
{
    internal class ClienteController
    {
        SqlConnection conection;
        DSNorthwing ds;
        public ClienteController(SqlConnection pConexion, DSNorthwing pds)
        {
            conection = pConexion;
            ds = pds;
        } 

        public DSNorthwing consultaTablaCustomers(String CustomerID)
        {
            string select = "select * from customers where CustomerID='" + CustomerID + "';";

            SqlCommand comando = new SqlCommand(select, conection);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            adaptador.Fill(ds.Customers);

            return ds;
        }
        public int altaCliente(String pCustomerID, String pCompanyName, String pAddress, String pCity, String pCountry)
        {
            int nRows = 0;

            string insert = "insert into customers(CustomerID,CompanyName,Address,City,Country)values";
            insert += "('" + pCustomerID + "','" + pCompanyName + "','" + pAddress + "','" + pCity + "','" + pCountry + "');";

            SqlCommand comando = new SqlCommand(insert, conection);
            nRows = comando.ExecuteNonQuery();
            //este método se utiliza cuando no queremos que nos devuelva ningun dato
            //es decir para un select no pero si para insert,update,delete....

            return nRows;
        }

        public int eliminarCliente(string pCustomerID)
        {
            int nRows = 0;

            string delete = "Delete from Customers where CustomerID='" + pCustomerID + "';";

            SqlCommand comando = new SqlCommand(delete, conection);
            nRows = comando.ExecuteNonQuery();
           
            return nRows;

        }

        public DSNorthwing buscarCustomer(string customerID)
        {
            string select = "select * from orders where CustomerID='" + customerID + "';";

            SqlCommand comando = new SqlCommand(select, conection);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            adaptador.Fill(ds.Orders);

            return ds;
        }

        public int modificarCliente(String CustomerID, string Country)
        {
            int nRows = 0;

            string update = "Update Customers set Country='" + Country + "' where CustomerID = '" + CustomerID + "';";

            SqlCommand comando = new SqlCommand(update, conection);
            nRows = comando.ExecuteNonQuery();

            return nRows;
        }   
    }  
}
