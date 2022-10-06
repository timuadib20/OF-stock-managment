using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace OF_stock_managment
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {

            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(@"Username"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(@""))
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(@"Password"))
            {
                txtPassword.Text = "";
                txtPassword.isPassword = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(@""))
            {
                txtPassword.Text = "Password";
                txtPassword.isPassword = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User u = new User();
            string validation = u.checkUser(txtUsername.Text, txtPassword.Text);
            if (validation.CompareTo("Not  Valid") != 0)
            {
                //TransactionDBLayer.conStr = "server=.;database=Stock Managment ;uid=LocalUSER;pwd=123;";
                //SupplierDBLayer.conStr= "server=.;database=Stock Managment ;uid=LocalUSER;pwd=123;";
                //UserDBLayer.conStr= "server=.;database=Stock Managment ;uid=LocalUSER;pwd=123;";
                //TransactionDBLayer.conStr="server=.;database=Stock Managment ;uid=LocalUSER;pwd=123;";
                //ItemDBLayer.conStr="server=.;database=Stock Managment ;uid=LocalUSER;pwd=123;";
                //RecycleDBLayer.conStr = "server=.;database=Stock Managment ;uid=LocalUSER;pwd=123;";


                new FormMain().Show();
                this.Hide();


            }
            else
            {
                lblIncorrect.Text = "InCorrect username or password!";
                lblIncorrect.Show();

            }
           
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //private void btnLogin_Enter(object sender, EventArgs e)
        //{
        //    User u = new User();
        //    string validation = u.checkUser(txtUsername.Text, txtPassword.Text);
        //}
    }
}
