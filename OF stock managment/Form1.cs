using OF_stock_managment.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OF_stock_managment
{
    public partial class FormMain : Form
    {
        private Form activeForm;
        private Button currentButton;
        public FormMain()
        {
            
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
        }
        public FormMain(Form childForm, object btnSender)
        {
          
            openChildForm( childForm,  btnSender);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            currentButton = (Button)btnSender;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPan.Controls.Add(childForm);
            this.panelDesktopPan.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Visible = true;
            lblTitle.Text = childForm.Text;
        }

        //private void navigate()
        //{
        //    pnlNavv.Visible = true;
        //    pnlNavv.Show();
        //    pnlNavv.Height = currentButton.Height;
        //    pnlNavv.Top = currentButton.Top;
        //    pnlNavv.Left = currentButton.Left;
        //}
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    //currentButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));   
                }
            }
        }
        private void DisableButton()
        {
            try
            {
                foreach (Control previosBtn in panelMenuBar.Controls)
                {
                    if (previosBtn.GetType() == typeof(Button))
                    {
                        previosBtn.BackColor = Color.FromArgb(36, 63, 74);
                        previosBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                }
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormSupplier(), sender);
            //navigate();
        }

      
      
        public static void Exit(string ans)
        {
            if (ans == "Yes")
            {
                Application.Exit();
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {

            Forms.FormExit exit = new Forms.FormExit();
            exit.Show();

            
            //DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //    Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;

            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTopbar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormLogin().Show();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            pnlImport.Size = pnlImport.MinimumSize;
            pnlTransaction.Size = pnlTransaction.MinimumSize;
            pnlRecycle.Size = pnlRecycle.MinimumSize;
            openChildForm(new Forms.FormDashboard(), sender);
           // navigate();

        }

        private void btnPurchase_Click_1(object sender, EventArgs e)
        {
            pnlImport.Size = pnlImport.MinimumSize;
            pnlTransaction.Size = pnlTransaction.MinimumSize;
            pnlRecycle.Size = pnlRecycle.MinimumSize;
            openChildForm(new FormPurchaseTrans(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlImport.Size = pnlImport.MinimumSize;
            pnlTransaction.Size = pnlTransaction.MinimumSize;
            pnlRecycle.Size = pnlRecycle.MinimumSize;
            openChildForm(new Forms.FormTransaction(), sender);
        }

     

        private void btnTransaction_Click_1(object sender, EventArgs e)
        {
            if (pnlTransaction.Size == pnlTransaction.MaximumSize)
            {
                pnlTransaction.Size = pnlTransaction.MinimumSize;
            }
            else
            {
                pnlTransaction.Size = pnlTransaction.MaximumSize;
                pnlImport.Size = pnlImport.MinimumSize;
                pnlRecycle.Size = pnlRecycle.MinimumSize;
            }
            //navigate();
        }


      

        private void btnNotification_Click(object sender, EventArgs e)
        {
            pnlImport.Size = pnlImport.MinimumSize;
            pnlTransaction.Size = pnlTransaction.MinimumSize;
            pnlRecycle.Size = pnlRecycle.MinimumSize;
            if (pnlNotification.Visible == false)
            {
                pnlNotification.Visible = true;
                pnlNotification.BringToFront();
            }
            else
                pnlNotification.Visible = false;
        }

        private void panelDesktopPan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRecycle_Click(object sender, EventArgs e)
        {
            if (pnlRecycle.Size == pnlRecycle.MaximumSize)
            {
                pnlRecycle.Size = pnlRecycle.MinimumSize;
            }
            else
            {
                pnlRecycle.Size = pnlRecycle.MaximumSize;
                pnlImport.Size = pnlImport.MinimumSize;
                pnlTransaction.Size = pnlTransaction.MinimumSize;
               

            }
        }

        private void btnRecycleProduct_Click(object sender, EventArgs e)
        {
            FormRecycle r = new FormRecycle("tblitem","empty");
            openChildForm(r,sender);
        }

        private void btnRecycleTransaction_Click(object sender, EventArgs e)
        {
            FormRecycle r = new FormRecycle("tbltranction", "empty");
            openChildForm(r, sender);
        }

        private void btnRecycleSupplier_Click(object sender, EventArgs e)
        {
            FormRecycle r = new FormRecycle("tblSupplier", "empty");
            openChildForm(r, sender);

        }

        //private void Import_Click(object sender, EventArgs e)
        //{
        //    FormImport i = new FormImport();
        //    openChildForm(i, sender);

        //}

       

      

        
        private void btnProducts_Click_2(object sender, EventArgs e)
        {
            pnlImport.Size = pnlImport.MinimumSize;
            pnlTransaction.Size = pnlTransaction.MinimumSize;
            pnlRecycle.Size = pnlRecycle.MinimumSize;
            openChildForm(new Forms.FormProducts(), sender);
        }

        private void btnTransaction_Click_2(object sender, EventArgs e)
        {
            if (pnlTransaction.Size == pnlTransaction.MaximumSize)
            {
                pnlTransaction.Size = pnlTransaction.MinimumSize;
            }
            else
            {
                pnlTransaction.Size = pnlTransaction.MaximumSize;
                pnlImport.Size = pnlImport.MinimumSize;
                pnlRecycle.Size = pnlRecycle.MinimumSize;
            }
        }

      
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            pnlImport.Size = pnlImport.MinimumSize;
            pnlTransaction.Size = pnlTransaction.MinimumSize;
            pnlRecycle.Size = pnlRecycle.MinimumSize;
            openChildForm(new FormPurchaseTrans(), sender);

        }

        private void btnSells_Click_1(object sender, EventArgs e)
        {
            pnlImport.Size = pnlImport.MinimumSize;
            pnlTransaction.Size = pnlTransaction.MinimumSize;
            pnlRecycle.Size = pnlRecycle.MinimumSize;
            openChildForm(new FormSalesTrans(), sender);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            pnlImport.Size = pnlImport.MinimumSize;
            pnlTransaction.Size = pnlTransaction.MinimumSize;
            pnlRecycle.Size = pnlRecycle.MinimumSize;
            openChildForm(new Forms.FormTransaction(), sender);
        }

        private void btnImportProduct_Click_1(object sender, EventArgs e)
        {
            FormImport i = new FormImport("Product");
            openChildForm(i, sender);
        }

        private void btnImport_Click_1(object sender, EventArgs e)
        {
            if (pnlImport.Size == pnlImport.MaximumSize)
            {
                pnlImport.Size = pnlImport.MinimumSize;
            }
            else
            {
                pnlImport.Size = pnlImport.MaximumSize;
                pnlTransaction.Size = pnlTransaction.MinimumSize;
                pnlRecycle.Size = pnlRecycle.MinimumSize;

            }
        }



        private void BtnImportPurchase_Click_1(object sender, EventArgs e)
        {
            FormImport i = new FormImport("Sales");
            openChildForm(i, sender);
        }

        private void btnSupplier_Click_2(object sender, EventArgs e)
        {
            pnlImport.Size = pnlImport.MinimumSize;
            pnlTransaction.Size = pnlTransaction.MinimumSize;
            pnlRecycle.Size = pnlRecycle.MinimumSize;
            openChildForm(new Forms.FormSupplier(), sender);
        }
    }
}
