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
    class SupplierDBLayer
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

        public string InsertSupplierDB(Supplier s)
        {
            string state = "";
            try
            {
                openConnection();
                if ( s.Tinnumber.ToString().Length == 10)
                {
                    SqlCommand cmd = new SqlCommand("uspInsertSupplier", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tinumber", s.Tinnumber);
                    cmd.Parameters.AddWithValue("@suppliername", s.SupplierName);
                    cmd.Parameters.AddWithValue("@date", s.Date);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                        state = "Saved succesfully! ";
                    else
                        state = "ERROR! ";
                    closeConnection();
                }
                else
                {
                    state = "TinNumber is 10 digits only";
                }
               
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return state;
        }

        public string UpdateSupplierDB(Supplier s)
        {
            string state = "";
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("uspupdateSupplier", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tinumber", s.Tinnumber);
                cmd.Parameters.AddWithValue("@suppliername", s.SupplierName);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                   state="Updated succesfully! ";
                else
                    state= "ERROR! ";
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
            return state;
        }

        public string  DeleteSupplierDB(int tinnumber)
        {
            string state ="";
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("uspDeleteSupplier", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tinnumber", tinnumber);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                    state="Deleted succesfully! ";
                else
                    state="ERROR! ";
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
            return state;
        }


        public DataTable SearchSupplierByTinnumberDB(int tinNumber)
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspSearchSupplierByTinnumber", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@tinumber", tinNumber);

                DataSet ds = new DataSet();
                da.Fill(ds, "dtSupplier");

                DataTable dt = ds.Tables["dtSupplier"];
                return dt;
            }
            closeConnection();

        }

        public DataTable SearchSupplierBynameDB(string supplierName)
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspSearchSupplierByname", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@suppliername", supplierName);


                DataSet ds = new DataSet();
                da.Fill(ds, "dtSupplier");

                DataTable dt = ds.Tables["dtSupplier"];
                return dt;

            }
        }

        public DataTable ViewSupplierDB()
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspViewSupplier", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataSet ds = new DataSet();
                da.Fill(ds, "dtSupplier");

                DataTable dt = ds.Tables["dtSupplier"];
                return dt;

            }
        }


    }
}
