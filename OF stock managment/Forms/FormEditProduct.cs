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
    public partial class FormEditProduct : Form
    {
        string tempCode;
        string tempDescribtion;
        string tempCatagory;
        string tempSubCatgory;
        double temQuantity;
        double tempPrice;
        string tempUom;
        string temBrandName;
        public FormEditProduct()
        {
            InitializeComponent();
            txtItemCode.Text = tempCode;
            txtItemDescription.Text = tempDescribtion;
            cmbCatagory.Text = tempCatagory;
            cmbSubcatagory.Text = tempSubCatgory;
            txtQuantity.Text = Convert.ToString(temQuantity);
            txtUnitPrice.Text = Convert.ToString(tempPrice);
            cmbUOM.Text = tempUom;
            cmbBrand.Text = temBrandName;
            lblState.Text = "";
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
        public string ItemCode
        {
            get { return tempCode; }
            set {
                tempCode = value;
                txtItemCode.Text = tempCode;
            }
        }
        public string Description
        {
            get { return tempDescribtion; }
            set { tempDescribtion = value;
            txtItemDescription.Text = tempDescribtion;
            }
        }
        public string Category
        {
            get { return tempCatagory; }
            set { tempCatagory = value;
            cmbCatagory.Text = tempCatagory;
            }
        }
        public string SubCategory
        {
            get { return tempSubCatgory; }
            set { tempSubCatgory = value;
            cmbSubcatagory.Text = tempSubCatgory;
            }
        }
        public double Quantity
        {
            set { temQuantity = value;
            txtQuantity.Text = Convert.ToString(temQuantity);
            }
            get { return temQuantity;}
        }

        public double UnitPrice
        {
            set { tempPrice =value;
            txtUnitPrice.Text = Convert.ToString(tempPrice);
            }
            get { return tempPrice; }
        }
        public string Uom
        {
            get { return tempUom; }
            set { tempUom = value;
            cmbUOM.Text = tempUom;
            }
        }
       
        public string BrandName
        {
            get { return temBrandName; }
            set { temBrandName = value;
            cmbBrand.Text = tempUom;
            }
        }
        public int ID
        {
            set { txtId.Text = Convert.ToString(value); }
            get { return Convert.ToInt32(txtId.Text); }
        }
        private void FormEditProduct_Load(object sender, EventArgs e)
        {
            Item i = new Item();
            cmbCatagory.DataSource = i.loadCatagory();
            cmbCatagory.DisplayMember = "Catagory";
            cmbCatagory.ValueMember = "Catagory";

            cmbSubcatagory.DataSource = i.loadSubCatagory();
            cmbSubcatagory.DisplayMember = "sub_catagory";
            cmbSubcatagory.ValueMember = "sub_catagory";

            cmbBrand.DataSource = i.loadBrand();
            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.ValueMember = "BrandName";

            cmbUOM.DataSource = i.loadUOM();
            cmbUOM.DisplayMember = "UOM";
            cmbUOM.ValueMember = "UOM";

            cmbCatagory.Text = "";
            cmbSubcatagory.Text = "";
            cmbBrand.Text = " ";
            cmbUOM.Text = " ";
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string state = "";

            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to edit the following information", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {

                Item i = new Item(Convert.ToInt32(txtId.Text), txtItemCode.Text, txtItemDescription.Text, Convert.ToDouble(txtQuantity.Text), cmbUOM.Text, cmbBrand.Text, Convert.ToDouble(txtUnitPrice.Text), cmbCatagory.Text, cmbSubcatagory.Text);
               state = i.updateProduct();
               if (state == "Updated succesfully! ")
               {
                   lblState.ForeColor = System.Drawing.Color.Green;
                   lblState.Text =state;
               }
               else
               {
                   lblState.ForeColor = System.Drawing.Color.Red;
                   lblState.Text = state;
               }
            }

        }

        private void txtItemDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtItemCode.Text = tempCode;
            txtItemDescription.Text = tempDescribtion;
            cmbCatagory.Text = tempCatagory;
            cmbSubcatagory.Text = tempSubCatgory;
            txtQuantity.Text = Convert.ToString(temQuantity);
            txtUnitPrice.Text = Convert.ToString(tempPrice);
            cmbUOM.Text = tempUom;
            cmbBrand.Text = temBrandName;
            lblState.ForeColor = System.Drawing.Color.Green;
            Item i = new Item(Convert.ToInt32(txtId.Text), txtItemCode.Text, txtItemDescription.Text, Convert.ToDouble(txtQuantity.Text), cmbUOM.Text, cmbBrand.Text, Convert.ToDouble(txtUnitPrice.Text), cmbCatagory.Text, cmbSubcatagory.Text);
            i.updateProduct();
            lblState.Text = "Resetted !";
        }

        private void FormEditProduct_MouseDown(object sender, MouseEventArgs e)
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

        private void txtBrandName_TextChanged(object sender, EventArgs e)
        {

        }

        //private void lblDescribtion_Click(object sender, EventArgs e)
        //{

        //}

        //private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
