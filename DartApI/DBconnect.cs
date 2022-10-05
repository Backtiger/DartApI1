using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartApI
{
    class DBconnect
    {
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = test; Integrated Security = True");
        DataTable dt = new DataTable();

        public DataTable ExcuteNonquery(string query)
        {
            try
            {
                DataTable dt = new DataTable();

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            
            
            return dt;
        }

        public DataTable ExcuteDataAdapter(string query)
        {
            

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.Fill(dt);            
            
            con.Close();
            return dt;
        }

    }
}
