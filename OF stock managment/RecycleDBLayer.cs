using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace OF_stock_managment
{
    class RecycleDBLayer
    {
        string conStr = "server=.;database=Stock Managment;uid=OFlogin;pwd=12345;";
        //public static string conStr;
        SqlConnection conn;

        public void openConnection()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
        }

        public void closeConnection()
        {
            conn.Close();
        }

        public DataTable ViewRecycleBinDB(string tablename,string operation)
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspViewRecoverTable", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@tablename", tablename);
                da.SelectCommand.Parameters.AddWithValue("@operation", operation);

                DataSet ds = new DataSet();
                da.Fill(ds, "dtRecyclebin");

                DataTable dt = ds.Tables["dtRecyclebin"];
                return dt;
            }
            closeConnection();

        }

        public void ResetSupplierDB(int tinnumber)
        {
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("upsRecoverTableSupplier", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", tinnumber);
                
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                    MessageBox.Show("Succesfully Reseted! ");
                else
                    MessageBox.Show("ERROR! ");
                closeConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
