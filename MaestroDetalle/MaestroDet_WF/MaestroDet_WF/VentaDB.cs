using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaestroDet_WF
{
    public class VentaDB
    {
        //Gestiona la insercion en BD
        private string cadenaConex =
            "Data Source=ASUSK555D\\SQLEXPRESS; Initial Catalog=MaestroDet; Integrated Security=True";

        public void Add(string Cliente)
        {
            string strSQL = "INSERT INTO tbVenta (cliente_vta, fecha_vta) VALUES (@cliente, @fecha)";
            using (SqlConnection sqlConex=new SqlConnection(cadenaConex))
            {
                SqlCommand cmdSQL = new SqlCommand(strSQL, sqlConex);
                cmdSQL.Parameters.AddWithValue("@cliente", Cliente);
                cmdSQL.Parameters.AddWithValue("@fecha", DateTime.Now);
                sqlConex.Open();
                cmdSQL.ExecuteNonQuery();
                sqlConex.Close();
            }
        }

    }
}
