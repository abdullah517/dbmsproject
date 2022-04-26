using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP1
{
    class function
    {
        protected SqlConnection getconnection()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Data source =DESKTOP-OPJPDI0;database=hostel;integrated security=true";
            return cnn;
        }

        public DataSet GetData(string query)
        {
            SqlConnection cnn = getconnection();
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public void setdata(string query,string msg)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand(query,cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
