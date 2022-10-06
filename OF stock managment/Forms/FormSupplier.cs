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
    public partial class FormSupplier : Form
    {
        int tinnumber;
        public FormSupplier()
        {
            InitializeComponent();
            Supplier s= new Supplier();
            dataGridViewSupplier.DataSource = s.ViewSupplier();
            lblState.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           Forms.FormAddSupplier f =  new Forms.FormAddSupplier();
           f.Show();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Forms.FormAddSupplier f = new Forms.FormAddSupplier();
            f.Show();
            f.Tinnumber = int.Parse(dataGridViewSupplier.CurrentRow.Cells[0].Value.ToString());
            f.SupplierName = dataGridViewSupplier.CurrentRow.Cells[1].Value.ToString();
            f.Date = dataGridViewSupplier.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            dataGridViewSupplier.DataSource = s.SearchSupplierByName(textBox1.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string state = "";
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to delete the following information", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Supplier s = new Supplier();
                tinnumber = int.Parse(dataGridViewSupplier.CurrentRow.Cells[0].Value.ToString());
              state = s.DeleteSupplier(tinnumber);
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

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            lblState.Text = "";
        }

      
       
    }
}
