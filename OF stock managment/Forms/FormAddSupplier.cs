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


namespace OF_stock_managment.Forms
{
    public partial class FormAddSupplier : Form
    {
        int tempTin;
        string tempName;
        string tempDate;
        public FormAddSupplier()
        {
            InitializeComponent();
            lblState.Text = "";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public int Tinnumber
        {
            set
            {
                tempTin = value;
                txtITInNo.Text = Convert.ToString(tempTin);
            }
            get { return tempTin; }
        }

        public string SupplierName
        {
            set
            {
                tempName = value;
                txtSupplierName.Text = tempName;
            }
            get { return tempName; }
        }

        public string Date
        {
            set
            {
                tempDate = value;
                dateSupplier.Text = tempDate; }
            get { return tempDate; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string state = "";
        
            Supplier s = new Supplier(int.Parse(txtITInNo.Text), txtSupplierName.Text, dateSupplier.Text); 
             state= s.INsertSupplier();
               if (state == "Saved succesfully! ")
               {
                   lblState.ForeColor = System.Drawing.Color.Green;
                   lblState.Text = state;
               }
               else
               {
                   lblState.ForeColor = System.Drawing.Color.Red;
                   lblState.Text = state;
               }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string state = "";
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to edit the following information", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Supplier s = new Supplier(int.Parse(txtITInNo.Text), txtSupplierName.Text, dateSupplier.Text);
               state = s.UpdateSupplier();
            }
            if (state == "Updated succesfully! ") 
            {
                lblState.ForeColor = System.Drawing.Color.Green;
                lblState.Text = state;
            }
            else
            {
                lblState.ForeColor = System.Drawing.Color.Red;
                lblState.Text = state;
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtITInNo.Text = Convert.ToString(tempTin);
            txtSupplierName.Text = tempName;
            dateSupplier.Text = tempDate;
            Supplier s = new Supplier(int.Parse(txtITInNo.Text), txtSupplierName.Text, dateSupplier.Text);
            s.UpdateSupplier();
            lblState.ForeColor = System.Drawing.Color.Green;
            lblState.Text = "Reseted succesfully!";
        }

        private void FormAddSupplier_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
