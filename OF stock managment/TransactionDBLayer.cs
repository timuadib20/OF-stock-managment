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
    class TransactionDBLayer
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

        public string InsertTranctionDB(Transaction t)
        {
            string ave = "";
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("uspinsertTranction", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@purchase", t.Purchased);
                cmd.Parameters.AddWithValue("@sells", t.Sells);
                cmd.Parameters.AddWithValue("@invoicenumber", t.InvoiceNumber);
                cmd.Parameters.AddWithValue("@date", t.Date);
                cmd.Parameters.AddWithValue("@itemcode", t.ItemCode);
                cmd.Parameters.AddWithValue("@itemdescribtion", t.Description);
                cmd.Parameters.AddWithValue("@tinNumber", t.Tinnumber);
                cmd.Parameters.AddWithValue("@supplierName", t.SupplierName);
                cmd.Parameters.AddWithValue("@uprice", t.NewPrice);

                cmd.Parameters.Add("@output", SqlDbType.Char, 500);
                cmd.Parameters["@output"].Direction = ParameterDirection.Output;
                int row = cmd.ExecuteNonQuery();
                if (cmd.Parameters["@output"].Value != DBNull.Value)
                {
                    ave = (string)cmd.Parameters["@output"].Value;
                }

                if (row > 0)
                    MessageBox.Show("Saved succesfully! ");
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
            return ave;
        }

        public string totalStockDB(int id)
        {
            string stock = "";
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("uspTotalstock", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
               

                cmd.Parameters.Add("@totalStock", SqlDbType.Char, 500);
                cmd.Parameters["@totalStock"].Direction = ParameterDirection.Output;
                int row = cmd.ExecuteNonQuery();
                stock = (string)cmd.Parameters["@totalStock"].Value;

              
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
            return stock;
        }

        public string UpdateTranctionDB(Transaction t)
        {
            string state = "";
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("uspupdateTranction", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tranid", t.Id);
                cmd.Parameters.AddWithValue("@purchase", t.Purchased);
                cmd.Parameters.AddWithValue("@sells", t.Sells);
                cmd.Parameters.AddWithValue("@invoicenumber", t.InvoiceNumber);
                cmd.Parameters.AddWithValue("@date", t.Date);
                cmd.Parameters.AddWithValue("@itemcode", t.ItemCode);
                cmd.Parameters.AddWithValue("@itemdescribtion", t.Description);
                cmd.Parameters.AddWithValue("@supplierName", t.SupplierName);

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                    state="Updated succesfully! ";
                else
                   state ="ERROR! ";
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

        public string DeleteTranctionDB(int id)
        {
            string state = "";
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("uspdeleteTransaction", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tranid", id);

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                   state ="Deleted succesfully! ";
                else
                    state ="ERROR! ";
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

        public DataTable SearchTransactionByItemCodeDB(string itemcode)
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspSearchTransactionByItemCode", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@val", itemcode);


                DataSet ds = new DataSet();
                da.Fill(ds, "dtTransaction");

                DataTable dt = ds.Tables["dtTransaction"];
                return dt;
            }
            closeConnection();

        }

        public DataTable SearchTransactionByItemDescAndCodenDB(string itemcode)
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspSearchTransactionByItemDescribtion", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@val", itemcode);


                DataSet ds = new DataSet();
                da.Fill(ds, "dtTransaction");

                DataTable dt = ds.Tables["dtTransaction"];
                return dt;
            }
            closeConnection();

        }

        public DataTable SearchTransactionByCatagory(string catagory)
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspSearchTransactionByCatagory", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Catagory", catagory);


                DataSet ds = new DataSet();
                da.Fill(ds, "dtTransaction");

                DataTable dt = ds.Tables["dtTransaction"];
                return dt;
                closeConnection();
            }
        }

        public DataTable searchItem(string val)
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspSearchPurchaseItemByItemCodeAndDescribtion", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@val", val);


                DataSet ds = new DataSet();
                da.Fill(ds, "dtTransaction");

                DataTable dt = ds.Tables["dtTransaction"];
                return dt;
            }
        }


        public DataTable searchByInvoiceNumberDB(int invoiceNumber)
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspSearchTransactionByInvoice", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@invoiceNumber", invoiceNumber);


                DataSet ds = new DataSet();
                da.Fill(ds, "dtTransaction");

                DataTable dt = ds.Tables["dtTransaction"];
                return dt;
            }
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


        public DataTable SearchTransactionByyDateInterval(string dateone, string datetwo)
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspSearchTransactionByDateInterval", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@dateOne", dateone);
                da.SelectCommand.Parameters.AddWithValue("@dateTwo", datetwo);


                DataSet ds = new DataSet();
                da.Fill(ds, "dtTransaction");

                DataTable dt = ds.Tables["dtTransaction"];
                return dt;
                closeConnection();
            }
        }
        public DataTable ViewTransactionDB(string period)
        {

            openConnection();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspSearchTransactionByPeriod", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@period", period);

                DataSet ds = new DataSet();
                da.Fill(ds, "dtTransaction");

                DataTable dt = ds.Tables["dtTransaction"];
                return dt;
                closeConnection();
            }
        }

        public double CalculateAvgSalaryDB(double newPrice,double newquantity,int id)
        {
            double avgPrice=0.0;
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("dbo.calculateAvagerSalary", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter par = new SqlParameter("@Newunitprice", SqlDbType.Float);
                SqlParameter par2 = new SqlParameter("@newquantity", SqlDbType.Float);
                SqlParameter par3 = new SqlParameter("@id", SqlDbType.Int);
                SqlParameter par4 = new SqlParameter("@avgprice", SqlDbType.Float);

                par.Direction = ParameterDirection.Input;
                par2.Direction = ParameterDirection.Input;
                par3.Direction = ParameterDirection.Input;
                par4.Direction = ParameterDirection.ReturnValue;

                par.Value = newPrice;
                par2.Value = newquantity;
                par3.Value = id;
                    cmd.Parameters.Add(par);
                    cmd.Parameters.Add(par2);
                    cmd.Parameters.Add(par3);


                 cmd.ExecuteNonQuery();
                if(par4.Value != DBNull.Value )
                {
                    avgPrice = Convert.ToDouble(par4.Value);
                }
                return avgPrice;


                //if (row > 0)
                //    MessageBox.Show("Updated succesfully! ");
                //else
                //    MessageBox.Show("ERROR! ");
                //closeConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return avgPrice;

        }


    }
}
