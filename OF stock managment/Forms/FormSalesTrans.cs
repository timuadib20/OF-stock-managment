using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OF_stock_managment
{
    public partial class FormSalesTrans : Form
    {
        int id;
        public FormSalesTrans()
        {
            InitializeComponent();
            lblState.Text = "";
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            datagridItem.DataSource = t.searchItem(txtItemCode.Text);
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            datagridItem.DataSource = t.searchItem(txtItemCode.Text);
        }

        private void datagridItem_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(datagridItem.CurrentRow.Cells[0].Value.ToString());
            txtItemCode.Text = datagridItem.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = datagridItem.CurrentRow.Cells[2].Value.ToString();
            if (datagridItem.CurrentRow.Cells[3].Value.ToString() == null)
                cmbUOM.Text = "";
            else
                cmbUOM.Text = datagridItem.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction t = new Transaction(0, Convert.ToDouble(txtQuantity.Text), Convert.ToInt32(txtInvoiceNo.Text), txtDate.Text, 0, "", txtItemCode.Text, txtDescription.Text, 0.00);
                string nothing = t.insertTransaction();
                txtStock.Text = t.totalStock(id);
            }
            catch (NoNullAllowedException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormAddProduct f = new FormAddProduct();
            f.Show();
        }

        private void datagridItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = Convert.ToInt32(datagridItem.CurrentRow.Cells[0].Value.ToString());
            txtItemCode.Text = datagridItem.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = datagridItem.CurrentRow.Cells[2].Value.ToString();
            if (datagridItem.CurrentRow.Cells[3].Value.ToString() == null)
                cmbUOM.Text = "";
            else
                cmbUOM.Text = datagridItem.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtQuantity.Clear();
        }
    }
}
