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
    public partial class FormProducts : Form
    {
        Item i;
        int id;
        public FormProducts()
        {
            InitializeComponent();
            i = new Item();
            dataGridViewProduct.DataSource = i.viewProduct();
            lblState.Text = "";
        }
        public string CMBSearchCatagory
        {
            set
            {
                cmbSearchCatagory.Items.Add(value);
            }

        }
        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbSearchCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item i = new Item();
            dataGridViewProduct.DataSource = i.searchCatagory(cmbSearchCatagory.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FormAddProduct().Show();
        }

        private void dataGridViewProduct_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

        }

        private void dataGridViewProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //FormExit fx = new FormExit();
            //fx.Show();
            
            FormEditProduct p = new FormEditProduct();
            p.Show();
            p.ID = int.Parse(dataGridViewProduct.CurrentRow.Cells[0].Value.ToString());
            p.ItemCode = dataGridViewProduct.CurrentRow.Cells[1].Value.ToString();
            p.Description = dataGridViewProduct.CurrentRow.Cells[2].Value.ToString();
            p.Quantity = double.Parse(dataGridViewProduct.CurrentRow.Cells[3].Value.ToString());
            p.Category = dataGridViewProduct.CurrentRow.Cells[4].Value.ToString();
            p.SubCategory = dataGridViewProduct.CurrentRow.Cells[5].Value.ToString();
            p.Uom = dataGridViewProduct.CurrentRow.Cells[6].Value.ToString();
            p.UnitPrice = double.Parse(dataGridViewProduct.CurrentRow.Cells[7].Value.ToString());
            p.BrandName = dataGridViewProduct.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            i = new Item();
          dataGridViewProduct.DataSource =  i.searchItemDescribtion(txtSearchItem.Text);
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            i = new Item();
            dataGridViewProduct.DataSource = i.searchItemDescribtion(txtSearchItem.Text);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string state = "";
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Deleting the following information will also affect the information in  transaction ", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                i = new Item();
                id = int.Parse(dataGridViewProduct.CurrentRow.Cells[0].Value.ToString());
               state= i.deleteProduct(id);
               if (state == "Deleted succesfully! ")
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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application excelExpot = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excelExpot.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            excelExpot.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";

            for (int i = 1; i < dataGridViewProduct.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewProduct.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i <=  dataGridViewProduct.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridViewProduct.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewProduct.Rows[i].Cells[j].Value.ToString();
                }
            }  
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            Item i = new Item();
            cmbSearchCatagory.DataSource = i.loadCatagory();
            cmbSearchCatagory.DisplayMember = "Catagory";
            cmbSearchCatagory.ValueMember = "Catagory";

            cmbSearchCatagory.Text = " ";

        }

        
    }
}
