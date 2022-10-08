namespace OF_stock_managment
{
    partial class FormSalesTrans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnInsert = new System.Windows.Forms.Button();
            this.datagridItem = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblTStock = new System.Windows.Forms.Label();
            this.lblUOM = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.tblQuatity = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUOM = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblState = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.datagridItem)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.SeaGreen;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(808, 6);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(200, 58);
            this.btnInsert.TabIndex = 131;
            this.btnInsert.Text = "New";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // datagridItem
            // 
            this.datagridItem.AllowUserToAddRows = false;
            this.datagridItem.AllowUserToDeleteRows = false;
            this.datagridItem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.datagridItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.datagridItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datagridItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridItem.ColumnHeadersHeight = 43;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridItem.DoubleBuffered = true;
            this.datagridItem.EnableHeadersVisualStyles = false;
            this.datagridItem.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.datagridItem.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridItem.Location = new System.Drawing.Point(6, 6);
            this.datagridItem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.datagridItem.Name = "datagridItem";
            this.datagridItem.ReadOnly = true;
            this.datagridItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridItem.RowHeadersVisible = false;
            this.datagridItem.RowHeadersWidth = 82;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.datagridItem.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridItem.RowTemplate.DividerHeight = 1;
            this.datagridItem.RowTemplate.Height = 30;
            this.datagridItem.RowTemplate.ReadOnly = true;
            this.datagridItem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridItem.Size = new System.Drawing.Size(790, 258);
            this.datagridItem.TabIndex = 36;
            this.datagridItem.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridItem_RowHeaderMouseDoubleClick);
            this.datagridItem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.datagridItem_MouseDoubleClick);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.Silver;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.ForeColor = System.Drawing.Color.Red;
            this.txtStock.Location = new System.Drawing.Point(1244, 606);
            this.txtStock.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(336, 43);
            this.txtStock.TabIndex = 155;
            this.txtStock.Text = "0.00";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel10.Location = new System.Drawing.Point(1244, 652);
            this.panel10.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(336, 4);
            this.panel10.TabIndex = 153;
            // 
            // lblTStock
            // 
            this.lblTStock.AutoSize = true;
            this.lblTStock.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.lblTStock.Location = new System.Drawing.Point(986, 606);
            this.lblTStock.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTStock.Name = "lblTStock";
            this.lblTStock.Size = new System.Drawing.Size(202, 51);
            this.lblTStock.TabIndex = 154;
            this.lblTStock.Text = "Total Stock";
            // 
            // lblUOM
            // 
            this.lblUOM.AutoSize = true;
            this.lblUOM.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUOM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.lblUOM.Location = new System.Drawing.Point(260, 604);
            this.lblUOM.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(111, 51);
            this.lblUOM.TabIndex = 147;
            this.lblUOM.Text = "UOM";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel4.Location = new System.Drawing.Point(502, 542);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 4);
            this.panel4.TabIndex = 146;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel2.Location = new System.Drawing.Point(502, 448);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 4);
            this.panel2.TabIndex = 145;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel3.Location = new System.Drawing.Point(502, 729);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 4);
            this.panel3.TabIndex = 144;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Silver;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.txtQuantity.Location = new System.Drawing.Point(502, 683);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(336, 43);
            this.txtQuantity.TabIndex = 143;
            this.txtQuantity.Text = "0.00";
            this.txtQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantity_MouseClick);
            // 
            // tblQuatity
            // 
            this.tblQuatity.AutoSize = true;
            this.tblQuatity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblQuatity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.tblQuatity.Location = new System.Drawing.Point(258, 696);
            this.tblQuatity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tblQuatity.Name = "tblQuatity";
            this.tblQuatity.Size = new System.Drawing.Size(167, 51);
            this.tblQuatity.TabIndex = 142;
            this.tblQuatity.Text = "Quantity";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Silver;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.txtDescription.Location = new System.Drawing.Point(502, 497);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(336, 43);
            this.txtDescription.TabIndex = 141;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.label4.Location = new System.Drawing.Point(252, 508);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 51);
            this.label4.TabIndex = 140;
            this.label4.Text = "Description";
            // 
            // txtItemCode
            // 
            this.txtItemCode.BackColor = System.Drawing.Color.Silver;
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.txtItemCode.Location = new System.Drawing.Point(502, 404);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(336, 43);
            this.txtItemCode.TabIndex = 139;
            this.txtItemCode.TextChanged += new System.EventHandler(this.txtItemCode_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(258, 410);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 51);
            this.label3.TabIndex = 138;
            this.label3.Text = "Item Code";
            // 
            // cmbUOM
            // 
            this.cmbUOM.BackColor = System.Drawing.Color.Silver;
            this.cmbUOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUOM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUOM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.cmbUOM.FormattingEnabled = true;
            this.cmbUOM.Items.AddRange(new object[] {
            "Sell",
            "Purchase"});
            this.cmbUOM.Location = new System.Drawing.Point(502, 606);
            this.cmbUOM.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbUOM.Name = "cmbUOM";
            this.cmbUOM.Size = new System.Drawing.Size(332, 53);
            this.cmbUOM.TabIndex = 137;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel7.Location = new System.Drawing.Point(1244, 540);
            this.panel7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(336, 4);
            this.panel7.TabIndex = 136;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel8.Location = new System.Drawing.Point(1244, 454);
            this.panel8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(336, 4);
            this.panel8.TabIndex = 133;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1086, 492);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 51);
            this.label7.TabIndex = 131;
            this.label7.Text = "Date";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(818, 856);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 58);
            this.btnSave.TabIndex = 130;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BackColor = System.Drawing.Color.Silver;
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.txtInvoiceNo.Location = new System.Drawing.Point(1244, 410);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(336, 43);
            this.txtInvoiceNo.TabIndex = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(936, 404);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 51);
            this.label1.TabIndex = 124;
            this.label1.Text = "Invoice Number";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.datagridItem);
            this.flowLayoutPanel1.Controls.Add(this.btnInsert);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1866, 302);
            this.flowLayoutPanel1.TabIndex = 157;
            // 
            // lblState
            // 
            this.lblState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Red;
            this.lblState.Location = new System.Drawing.Point(1116, 863);
            this.lblState.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(260, 45);
            this.lblState.TabIndex = 197;
            this.lblState.Text = "Description state";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(1244, 502);
            this.txtDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(356, 31);
            this.txtDate.TabIndex = 198;
            // 
            // FormSalesTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1866, 1131);
            this.ControlBox = false;
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.lblTStock);
            this.Controls.Add(this.lblUOM);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.tblQuatity);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbUOM);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormSalesTrans";
            this.Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)(this.datagridItem)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridItem;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblTStock;
        private System.Windows.Forms.Label lblUOM;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label tblQuatity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUOM;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.DateTimePicker txtDate;
    }
}