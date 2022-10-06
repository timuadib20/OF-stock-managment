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
    public partial  class FormRecycle : Form
    {
        Recycle r;
        string tablename;
        string operation;
        public FormRecycle(string tablename,string operation)
        {
            InitializeComponent();
            this.tablename = tablename;
            this.operation = operation;
            r = new Recycle();
            dataGridViewRecycle.DataSource = r.viewRecycle(tablename, operation);
        }

        private void cmbSearchOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            r = new Recycle();
            dataGridViewRecycle.DataSource = r.viewRecycle(tablename, cmbSearchOperation.Text);
        }



    }
}
