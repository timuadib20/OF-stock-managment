using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OF_stock_managment.Forms
{
    public partial class FormTransaction : Form
    {
        int id;
        public FormTransaction()
        {
            
            string day = "Today";
            InitializeComponent();
            Transaction t = new Transaction();
            dataGridViewTransaction.DataSource = t.viewTransaction(day);
            lblstate.Text = "";
            //MessageBox.Show("First date" + dateOne.ToString() + "Second date" + dateTworvf.Text);
        }

        private void dataGridViewTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           // new FormAddTransaction().Show();
        }

        private void cmbSearchCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            
        }

        private void txtItemDescribtion_TextChanged(object sender, EventArgs e)
        {
            //Transaction t = new Transaction();
            //dataGridViewTransaction.DataSource = t.searchByInvoiceNumbe(int.Parse(txtInvoice.Text));
        }

        private void btnSet_Click_1(object sender, EventArgs e)
        {
            
            MessageBox.Show("First date" + dateOne.Text+ "Second date" + dateTwo.Value.Date);
            Transaction t = new Transaction();
            dataGridViewTransaction.DataSource = t.searchByDateInterval(dateOne.Value.ToString(), dateTwo.Value.ToString());
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction t = new Transaction();
                dataGridViewTransaction.DataSource = t.searchByInvoiceNumbe(int.Parse(txtInvoice.Text));
            }
            catch (InvalidCastException c)
            {
                MessageBox.Show(c.Message);
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                FormEditTranaction t = new FormEditTranaction();
                t.Show();
                id = int.Parse(dataGridViewTransaction.CurrentRow.Cells[0].Value.ToString());
                t.ItemCode = dataGridViewTransaction.CurrentRow.Cells[1].Value.ToString();
                t.Description = dataGridViewTransaction.CurrentRow.Cells[2].Value.ToString();
                t.Price = double.Parse(dataGridViewTransaction.CurrentRow.Cells[4].Value.ToString());
                t.Purchase = double.Parse(dataGridViewTransaction.CurrentRow.Cells[8].Value.ToString());
                t.Sales = double.Parse(dataGridViewTransaction.CurrentRow.Cells[9].Value.ToString());
                t.Invoice = int.Parse(dataGridViewTransaction.CurrentRow.Cells[10].Value.ToString());
                t.Date = dataGridViewTransaction.CurrentRow.Cells[11].Value.ToString();
                t.SupplierName = dataGridViewTransaction.CurrentRow.Cells[13].Value.ToString();
            }
            catch (NullReferenceException a)
            {
                MessageBox.Show(a.Message);
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string state = "";
            Transaction t = new Transaction();
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure? ", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                id = int.Parse(dataGridViewTransaction.CurrentRow.Cells[0].Value.ToString());
               state= t.deleteTransaction(id);
            }
            if (state == "Deleted succesfully! ")
            {
                lblstate.ForeColor = System.Drawing.Color.Green;
                lblstate.Text = state;
            }
            else
            {
                lblstate.ForeColor = System.Drawing.Color.Red;
                lblstate.Text = state;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application excelExpot = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook= excelExpot.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            excelExpot.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";

            for (int i = 1; i < dataGridViewTransaction.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewTransaction.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i <= dataGridViewTransaction.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridViewTransaction.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewTransaction.Rows[i].Cells[j].Value.ToString();
                }
            }  

        }

        private void cmbPeriod_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
           dataGridViewTransaction.DataSource = t.viewTransaction(cmbPeriod.Text);
        }

        private void cmbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            dataGridViewTransaction.DataSource = t.viewTransaction(cmbPeriod.Text);
        }

       
    }
}
