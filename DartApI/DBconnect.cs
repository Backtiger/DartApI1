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
        
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TKOPMES\\SQLEXPRESS;Initial Catalog=stock;Integrated Security=True");
       // SqlConnection con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = Stock; Integrated Security = True"); 
        DataTable dt = new DataTable();
     
        int flag;

        public int ExcuteNonquery(string query)
        {
            try
            {
                DataTable dt = new DataTable();

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
              
            }
            catch(Exception ex)
            {             
                con.Close();
                System.Windows.Forms.MessageBox.Show(query);
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
                        
             return flag;

        }

        public DataTable DataAdapter(string query)
        {
            try
            {

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                da.Dispose();
                con.Close();
             
            }
            catch (Exception ex) 
            {         
                con.Close();

                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            return dt;
        }

    }
}


