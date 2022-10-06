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
    class ItemDBLayer
    {
        string conStr = "server=LAPTOP-H56820RN;database=Stock Managment;uid=OFlogin;pwd=12345;";
        //public static string conStr;
        SqlConnection conn;
        static int rowCount;

        public ItemDBLayer()
        {
          //rowCount = 0;
        }

        public int RowCount
        {
            set { rowCount = value; }
            get { return rowCount; }
        }

        public void openConnection()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
        }

        public void closeConnection()
        {
            conn.Close();
        }

        public string InsertItemDB(Item i)
        {
            string state="";
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("uspInsertItem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ItemCode", i.ItemCode);
                cmd.Parameters.AddWithValue("@itemDescription", i.ItemDescription);
                cmd.Parameters.AddWithValue("@quantity", i.Quantity);
                cmd.Parameters.AddWithValue("@catagory", i.CatagoryName);
                cmd.Parameters.AddWithValue("@subcatagory", i.SubCatagory);
                cmd.Parameters.AddWithValue("@UOM", i.UOM);
                cmd.Parameters.AddWithValue("@unitPrice", i.UnitPrice);
                cmd.Parameters.AddWithValue("@brandName", i.BrandName);

                int row = cmd.ExecuteNonQuery();

                if (rowCount == 0)
                {
                    if (row > 0)
                    {

                        state = "Saved succesfully! ";
                    }

                    else
                        MessageBox.Show("ERROR! ");
                }
                else if (row == rowCount)
                {
                    state ="All are succesfully saved ! ";
                }
                else
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


        public string InsertManyItemDB(Item i)
        {
            //string con = "server=.;database=Stock Managment;uid=lab;pwd=123;Connection Timeout= 3600";
            int row = 0;
            string state = "";
            try
            {
               
                    openConnection();
                    SqlCommand cmd = new SqlCommand("uspInsertItem", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ItemCode", i.ItemCode);
                    cmd.Parameters.AddWithValue("@itemDescription", i.ItemDescription);
                    cmd.Parameters.AddWithValue("@quantity", i.Quantity);
                    cmd.Parameters.AddWithValue("@catagory", i.CatagoryName);
                    cmd.Parameters.AddWithValue("@subcatagory", i.SubCatagory);
                    cmd.Parameters.AddWithValue("@UOM", i.UOM);
                    cmd.Parameters.AddWithValue("@unitPrice", i.UnitPrice);
                    cmd.Parameters.AddWithValue("@brandName", i.BrandName);
                    cmd.CommandTimeout = 30 * 70;
                     row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                   state= "All are succesfully saved ! ";
                }
                else
                {
                    state = "Not saved!";
                }
               
                closeConnection();
            }
            catch (SqlException e)
            {

               return  e.Message;

            }
            catch (Exception e)
            {

                return e.Message;

            }
            return state;
        }


        public string  UpdateItemDB(Item i)
        {
            string state = "";
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("uspUpdateItem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", i.Id);
                cmd.Parameters.AddWithValue("@ItemCode", i.ItemCode);
                cmd.Parameters.AddWithValue("@itemDescription", i.ItemDescription);
                cmd.Parameters.AddWithValue("@quantity", i.Quantity);
                cmd.Parameters.AddWithValue("@catagory", i.CatagoryName);
                cmd.Parameters.AddWithValue("@subcatagory", i.SubCatagory);
                cmd.Parameters.AddWithValue("@UOM", i.UOM);
                cmd.Parameters.AddWithValue("@unitPrice", i.UnitPrice);
                cmd.Parameters.AddWithValue("@brandName", i.BrandName);

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                    state="Updated succesfully! ";
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

        public string  DeleteItemDB(int id)
        {
            string state = "";
            try
            {
                openConnection();
                SqlCommand cmd = new SqlCommand("uspDeleteItem", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                    state="Deleted succesfully! ";
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

        public DataTable SearchItemByItemCodeDB(string itemcode)
        {

            using (conn = new SqlConnection(conStr))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("uspSearchItemByItemCode", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@val", itemcode);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtItem");

                    DataTable dt = ds.Tables["dtItem"];
                    return dt;
                }
            }

        }

        public DataTable SearchItemByItemCodeOrItemDescDB(string val)
        {

            using (conn = new SqlConnection(conStr))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("uspSearchItemByItemCodeAndDescribtion", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@val", val);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtItem");

                    DataTable dt = ds.Tables["dtItem"];
                    return dt;
                }
            }

        }

        public DataTable SearchItemByCatagoryDB(string catagory)
        {

            using (conn = new SqlConnection(conStr))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("uspSearchItemByCatagory", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@val", catagory);

                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtItem");

                    DataTable dt = ds.Tables["dtItem"];
                    return dt;
                }
            }
        }

        public DataTable ViewItemDB()
        {

            using (conn = new SqlConnection(conStr))
            {
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = new SqlCommand("uspViewItem", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet ds = new DataSet();
                da.Fill(ds, "dtItem");

                DataTable dt = ds.Tables["dtItem"];
                return dt;
            }
            }

        }



        public DataTable loadCatagory()
        {

            using (conn = new SqlConnection(conStr))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("loadCatagory", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtCatagory");

                    DataTable dt = ds.Tables["dtCatagory"];
                    return dt;
                }
            }
        }

        public DataTable loadSubCatagory()
        {

            using (conn = new SqlConnection(conStr))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("loadSubCatagory", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtSubCatagory");

                    DataTable dt = ds.Tables["dtSubCatagory"];
                    return dt;
                }
            }
        }

        public DataTable loadBrand()
        {

            using (conn = new SqlConnection(conStr))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("loadbrand", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtBrand");

                    DataTable dt = ds.Tables["dtBrand"];
                    return dt;
                }
            }
        }

        public DataTable loadUOM()
        {

            using (conn = new SqlConnection(conStr))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("loadUOM", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtUOM");

                    DataTable dt = ds.Tables["dtUOM"];
                    return dt;
                }
            }
        }
    }
}
