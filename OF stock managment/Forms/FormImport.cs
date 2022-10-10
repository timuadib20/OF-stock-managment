using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace OF_stock_managment.Forms
{
    public partial class FormImport : Form, IEditableObject
    {
        string fileextention = "";
        string name;
       
        public FormImport(string name)
        {
            InitializeComponent();
             this.name =name;
            if (this.name == "Product")
            {
                lblDate.Visible = false;
                txtDate.Visible = false;
                panel8.Visible = false;
            }
            else if(this.name == "Sales")
            {
                lblDate.Visible = true;
                txtDate.Visible = true;
                panel8.Visible = true;
            }

        }


        private void btnLoad_Click(object sender, EventArgs e)
        {


            //if (this.fileextention.CompareTo(".xls") == 0 || this.fileextention.CompareTo(".xlsx") == 0)
            //{
            string path = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtPath.Text + ";Extended Properties='Excel 12.0;HDR=NO';";

            try
            {
                OleDbConnection cnn = new OleDbConnection(path);
                OleDbDataAdapter adptr = new OleDbDataAdapter("Select * from [" + txtSheet.Text + "$]", cnn);
                DataTable dt = new DataTable();
                adptr.Fill(dt);
                
                datagridImport.DataSource = dt;
               datagridImport.Columns[0].HeaderText = "Item Code";
              //  datagridImport.Columns[1].HeaderText = "Describtion";
                datagridImport.Columns[2].HeaderText = "UMO";
               datagridImport.Columns[2].HeaderText = "Quantity";
               datagridImport.Columns[3].HeaderText = "U_Price";

            }
            catch (OleDbException o)
            {
                MessageBox.Show(o.Message);
            }
            catch(ArgumentOutOfRangeException o)
            {
                MessageBox.Show(o.Message);
            }
            //}
            //else
            //{
            //    MessageBox.Show("Please choose .xls or .xlsx file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error  


            //}



        }

        

        private void btnImport_Click(object sender, EventArgs e)
        {
            try 
            {
                OpenFileDialog opn = new OpenFileDialog();
                if (opn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.txtPath.Text = opn.FileName;
                    this.fileextention = Path.GetExtension(this.txtPath.Text);

                }
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
            
        }

        private void datagridImport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void BeginEdit()
        {
            throw new NotImplementedException();
        }

        public void CancelEdit()
        {
            throw new NotImplementedException();
        }

        public void EndEdit()
        {
            throw new NotImplementedException();
        }

      

       

      

        private void FormImport_Load(object sender, EventArgs e)
        {
            Item i = new Item();
           cmbCatagory.DataSource= i.loadCatagory();
           cmbCatagory.DisplayMember = "catagory";
           cmbCatagory.ValueMember = "catagory";
           cmbCatagory.Text = " ";
           cmdSubcatagory.DataSource = i.loadSubCatagory();
           cmdSubcatagory.DisplayMember = "sub_catagory";
           cmdSubcatagory.ValueMember = "sub_catagory";
           cmdSubcatagory.Text = " ";

           cmbBrand.DataSource = i.loadBrand();
           cmbBrand.DisplayMember = "BrandName";
           cmbBrand.ValueMember = "BrandName";
           cmbBrand.Text = "";
           cmbUOM.DataSource = i.loadUOM();
           cmbUOM.DisplayMember = "UOM";
           cmbUOM.ValueMember = "UOM";
           cmbUOM.Text = " ";
           lbState.Text = "";
            



        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Item itm;
            double unitPrice = 0;
            double quty = 0.00;
            FormProducts ii = new FormProducts();
            string state="";

            try
            {
                for (int i = 0; i <= (datagridImport.Rows.Count - 2); i++)
                {
                    if ((double.TryParse(datagridImport.Rows[i].Cells["F4"].Value.ToString(), out unitPrice)))
                    {
                        unitPrice = Convert.ToDouble(datagridImport.Rows[i].Cells["F4"].Value.ToString());
                    }
                    if ((double.TryParse(datagridImport.Rows[i].Cells["F3"].Value.ToString(), out quty)))
                    {
                        quty = Convert.ToDouble(datagridImport.Rows[i].Cells["F3"].Value.ToString());
                    }


                    // MessageBox.Show(i + " pstion");
                    itm = new Item(datagridImport.Rows[i].Cells["F1"].Value.ToString(),
                          datagridImport.Rows[i].Cells["F2"].Value.ToString(),
                          quty,
                          cmbUOM.Text,
                          cmbBrand.Text,
                           unitPrice,
                          cmbCatagory.Text,
                          cmdSubcatagory.Text);
                            state = itm.insertManyProduct();
                      
                    
                  
                   if (state != "All are succesfully saved ! ")
                   {
                       MessageBox.Show(" Item Describtion  " + datagridImport.Rows[i].Cells["f2"].Value.ToString() + " Item Code" + datagridImport.Rows[i].Cells["f1"].Value.ToString(), state);
                   }
                   else{
                       lbState.ForeColor = System.Drawing.Color.Green;
                       lbState.Text = state + "Row " + i + " /" + (datagridImport.Rows.Count-1);
                   }
                }

            }
            catch (NullReferenceException n)
            {
                MessageBox.Show(n.Message);
                
            }
            catch (ArgumentException n)
            {
                MessageBox.Show(n.Message);
            }
              }

        

        private void txtPath_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            if (opn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtPath.Text = opn.FileName;
                this.fileextention = Path.GetExtension(this.txtPath.Text);

            }
        }

        //private void showState_Click(object sender, EventArgs e)
        //{

        //}

        //private void cmbCatagory_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    

//        private void contextMenuStrip2_MouseClick(object sender, MouseEventArgs e)
//        {
//            if(powerToolsToolStripMenuItem.Checked)
//            {
//                catagory = powerToolsToolStripMenuItem.Text;
//            }
//            else if (accessotiToolStripMenuItem.Checked)
//            {
//                catagory = accessotiToolStripMenuItem.Text;
//                if(accJBladeToolStripMenuItem.Checked)
//                {
//                    subCat= accJBladeToolStripMenuItem.Text;
//                }
//                else if(hSSBJToolStripMenuItem.Checked)
//                {
//                    subCat = hSSBJToolStripMenuItem.Text;
//                }
//                else if (tCTToolStripMenuItem.Checked)
//                {
//                    subCat = tCTToolStripMenuItem.Text;
//                }
//                else if(aDDNEWToolStripMenuItem.Checked)
//                {

//                }
//            }
//            else if(spartPartsToolStripMenuItem.Checked){
//                catagory= spartPartsToolStripMenuItem.Text;
//                if (gEARToolStripMenuItem.Checked)
//                {
//                    subCat = gEARToolStripMenuItem.Text;
//                }
//                else if (cARBONBRUSHToolStripMenuItem.Checked)
//                {
//                    subCat = cARBONBRUSHToolStripMenuItem.Text;
//                }
//                else if (aRMTURNToolStripMenuItem.Checked)
//                {
//                    subCat = aRMTURNToolStripMenuItem.Text;
//                }
//                else if (fIELDToolStripMenuItem.Checked)
//                {
//                    subCat = fIELDToolStripMenuItem.Text;
//                }
//                else if(aDDNEWToolStripMenuItem1.Checked)
//                {

//                }
//            }
//            else if(handToolsToolStripMenuItem.Checked)
//            {
//                catagory = handToolsToolStripMenuItem.Text;
//            }
//            else if (bearingToolStripMenuItem.Checked)
//            {
//                catagory = bearingToolStripMenuItem.Text;
//            }
//            else if (otherToolStripMenuItem.Checked)
//            {
//                catagory = otherToolStripMenuItem.Text;
//            }
//            else if(newToolStripMenuItem.Checked)
//            { }

//        }

//        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            Item itm;
//            double unitPrice=0;
            
//            try
//            {
//                for (int i = 1; i < datagridImport.Rows.Count; i++)
//                {
//                    if ((double.TryParse(datagridImport.Rows[i].Cells["f4"].Value.ToString(), out unitPrice)))
//                    {
//                          unitPrice = Convert.ToDouble(datagridImport.Rows[i].Cells["f4"].Value.ToString());
//                    };

//                    itm = new Item(datagridImport.Rows[i].Cells["f1"].Value.ToString(),
//                        datagridImport.Rows[i].Cells["f2"].Value.ToString(),
//                        Convert.ToDouble(datagridImport.Rows[i].Cells["f3"].Value.ToString()),
//                        "UMO",
//                        "makita",
//                         unitPrice,
//                        "Spare Parts",
//                        "");
//                    itm.insertProduct();
//                }
//            }
//            catch(NullReferenceException n)
//            {
//                MessageBox.Show(n.Message);
//            }
//            //catch (Exception n)
//            //{
//            //    MessageBox.Show(n.Message);
//            //}
//            //MessageBox.Show(datagridImport.Rows[6].Cells["f1"].Value.ToString());
//        }

//        private void contextMenuStrip2_MouseDoubleClick(object sender, MouseEventArgs e)
//        {
//            Item itm;
//            double unitPrice = 0;

//            try
//            {
//                for (int i = 1; i < datagridImport.Rows.Count; i++)
//                {
//                    if ((double.TryParse(datagridImport.Rows[i].Cells["f4"].Value.ToString(), out unitPrice)))
//                    {
//                        //  unitPrice = Convert.ToDouble(datagridImport.Rows[i].Cells["f4"].Value.ToString());
//                    };

//                    itm = new Item(datagridImport.Rows[i].Cells["f1"].Value.ToString(),
//                        datagridImport.Rows[i].Cells["f2"].Value.ToString(),
//                        Convert.ToDouble(datagridImport.Rows[i].Cells["f3"].Value.ToString()),
//                        "UMO",
//                        "makita",
//                         unitPrice,
//                        "Spare Parts",
//                        "");
//                    itm.insertProduct();
//                }
//            }
//            catch (NullReferenceException n)
//            {
//                MessageBox.Show(n.Message);
//            }
//        }

        
   }
}
