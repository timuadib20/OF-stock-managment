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
    class UserDBLayer
    {
        string conStr = "server=LAPTOP-H56820RN;database=Stock Managment;uid=OFlogin;pwd=12345;";
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


        public string checkUserDBLayer(string username,string pwd)
        {
            string validation = "";
            //try
            //{
                openConnection();
                SqlCommand cmd = new SqlCommand("uspCheckUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pwd);


                Object rolObject = cmd.ExecuteScalar();
                closeConnection();

                if (rolObject != null)
                    validation = rolObject.ToString();
                else
                    validation = "Not  Valid";
                return validation;

                //if (row > 0)
                //    MessageBox.Show("Saved succesfully! ");
                //else
                //    MessageBox.Show("ERROR! ");
               
          //  }
        //    catch (SqlException e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //    return validation;
        }
    }
}
