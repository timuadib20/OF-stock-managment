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
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
            lblstate.Text = " ";
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            Item i = new Item();
            cmbCatagory.DataSource = i.loadCatagory();
            cmbCatagory.DisplayMember = "Catagory";
            cmbCatagory.ValueMember = "Catagory";
           
            cmdSubcatagory.DataSource = i.loadSubCatagory();
            cmdSubcatagory.DisplayMember = "sub_catagory";
            cmdSubcatagory.ValueMember = "sub_catagory";

            cmbBrand.DataSource = i.loadBrand();
            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.ValueMember = "BrandName";

            cmbUOM.DataSource = i.loadUOM();
            cmbUOM.DisplayMember = "UOM";
            cmbUOM.ValueMember = "UOM";

            cmbCatagory.Text = "";
            cmdSubcatagory.Text = "";
            cmbBrand.Text = " ";
            cmbUOM.Text = " ";
           
        }

        //private void btnSave_Click(object sender, EventArgs e)
        //{
           
        //    Item i = new Item(txtItemCode.Text, txtItemDescription.Text, Convert.ToDouble(txtQuantity.Text), cmbUOM.Text, cmbBrand.Text, Convert.ToDouble(txtUnitPrice.Text), cmbCatagory.Text, cmdSubcatagory.Text);
        //    i.insertProduct();
        //    Clear();

        //}

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            cmbBrand.Text = "";
            cmbCatagory.Text = "";
            txtItemCode.Clear();
            txtItemDescription.Clear();
            cmdSubcatagory.Text = "";
            txtQuantity.Text = "0.00";
            txtUnitPrice.Text = "0.00";
            cmbUOM.Text = "";

        }

        private void txtCatagory_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDescribtion_Click(object sender, EventArgs e)
        {

        }

        private void pnlAddProduct_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void txtUnitPrice_MouseClick(object sender, MouseEventArgs e)
        {
            txtUnitPrice.Clear();
        }

        private void txtQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtQuantity.Clear();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Item i = new Item(txtItemCode.Text, txtItemDescription.Text, Convert.ToDouble(txtQuantity.Text), cmbUOM.Text, cmbBrand.Text, Convert.ToDouble(txtUnitPrice.Text), cmbCatagory.Text, cmdSubcatagory.Text);
            string state = i.insertProduct();
            if (state == "Saved succesfully! ")
            {
                lblstate.ForeColor = System.Drawing.Color.Green;
                lblstate.Text = state;
            }
            else
            {
                lblstate.ForeColor = System.Drawing.Color.Red;
                lblstate.Text = state;
            }
            Clear();
        }

        
       
        
    }
}
