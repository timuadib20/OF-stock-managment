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
    public partial class FormEditTranaction : Form
    {
        string tempCode;
        string tempDescribtion;
        double tempSales;
        double tempPurchase;
        double tempPrice;
        string tempSupplierName;
        int temptinNumber;
        string tempdate;
        int tempInvoice;
       
        public FormEditTranaction()
        {
            InitializeComponent();
            lblState.Text = "";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
      
        public string ItemCode
        {
            get { return tempCode; }
            set
            {
                tempCode = value;
                txtItemCode.Text = tempCode; 
            }
        }
        public string Description
        {
            get { return tempDescribtion; }
            set
            {
                tempDescribtion= value;
                txtDescription.Text = tempDescribtion;

            }
        }
        public double Sales
        {
            get { return Convert.ToDouble(tempSales); }
            set
            {
                tempSales = value;
                txtSales.Text = Convert.ToString(tempSales);
            }
        }
        public double Purchase
        {
            get { return Convert.ToDouble(tempPurchase); }
            set
            {
                tempPurchase = value;
                txtPurchase.Text = Convert.ToString(tempPurchase); 
            }
        }
        public double Price
        {
            set
            {
                tempPrice = value;
                txtUPrice.Text = Convert.ToString(tempPrice); }
            get { return Convert.ToDouble(tempPrice); }
        }

        
        public string SupplierName
        {
            get { return tempSupplierName; }
            set
            {
                tempSupplierName = value;
                txtSupplierName.Text =tempSupplierName; }
        }

        public string Date
        {
            get { return tempdate; }
            set
            {
                tempdate = value;
                txtDate.Text = tempdate; }
        }
        public int TinNumber
        {
            set
            {
                temptinNumber = value;
                txtTinNumber.Text = Convert.ToString(temptinNumber); }
            get { return Convert.ToInt32(temptinNumber); }
        }

        public int Invoice
        {
            set
            {
                tempInvoice = value;
                txtInvoiceNo.Text = Convert.ToString(tempInvoice); }
            get { return Convert.ToInt32(tempInvoice); }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string state = "";
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to edit the following information", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Transaction t = new Transaction(Purchase, Sales, Invoice, Date, TinNumber, SupplierName, ItemCode, Description, Price);
                state = t.updateTransaction();
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
            string state = "";
            txtItemCode.Text = tempCode;
            txtDescription.Text = tempDescribtion;
            txtSales.Text = Convert.ToString(tempSales);
            txtPurchase.Text = Convert.ToString(tempPurchase);
            txtUPrice.Text = Convert.ToString(tempPrice);
            txtSupplierName.Text = tempSupplierName;
            txtDate.Text = tempdate;
            txtTinNumber.Text = Convert.ToString(temptinNumber);
            txtInvoiceNo.Text = Convert.ToString(tempInvoice);

            Transaction t = new Transaction(Purchase, Sales, Invoice, Date, TinNumber, SupplierName, ItemCode, Description, Price);
             state = t.updateTransaction();
           
            if (state == "Updated succesfully! ")
            {
                lblState.ForeColor = System.Drawing.Color.Green;
                lblState.Text = "Resetted succesfully! ";
            }
            else
            {
                lblState.ForeColor = System.Drawing.Color.Red;
                lblState.Text = state;
            }

        }

        private void FormEditTranaction_Load(object sender, EventArgs e)
        {

        }

        private void FormEditTranaction_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtPurchase_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
