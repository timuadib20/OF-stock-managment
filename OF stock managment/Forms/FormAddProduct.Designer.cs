namespace OF_stock_managment
{
    partial class FormAddProduct
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
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlAddProduct = new System.Windows.Forms.Panel();
            this.lblstate = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.cmbUOM = new System.Windows.Forms.ComboBox();
            this.cmdSubcatagory = new System.Windows.Forms.ComboBox();
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUOM = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblSubcatagory = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.lblDescribtion = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.pnlAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::OF_stock_managment.Properties.Resources.icons8_macos_close_60;
            this.btnClose.Location = new System.Drawing.Point(1430, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 62);
            this.btnClose.TabIndex = 159;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlAddProduct
            // 
            this.pnlAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlAddProduct.Controls.Add(this.lblstate);
            this.pnlAddProduct.Controls.Add(this.cmbBrand);
            this.pnlAddProduct.Controls.Add(this.cmbUOM);
            this.pnlAddProduct.Controls.Add(this.cmdSubcatagory);
            this.pnlAddProduct.Controls.Add(this.cmbCatagory);
            this.pnlAddProduct.Controls.Add(this.btnSave);
            this.pnlAddProduct.Controls.Add(this.lblUOM);
            this.pnlAddProduct.Controls.Add(this.panel11);
            this.pnlAddProduct.Controls.Add(this.txtQuantity);
            this.pnlAddProduct.Controls.Add(this.lblQuantity);
            this.pnlAddProduct.Controls.Add(this.panel2);
            this.pnlAddProduct.Controls.Add(this.panel3);
            this.pnlAddProduct.Controls.Add(this.txtUnitPrice);
            this.pnlAddProduct.Controls.Add(this.lblBrand);
            this.pnlAddProduct.Controls.Add(this.lblUnitPrice);
            this.pnlAddProduct.Controls.Add(this.lblSubcatagory);
            this.pnlAddProduct.Controls.Add(this.panel12);
            this.pnlAddProduct.Controls.Add(this.txtItemDescription);
            this.pnlAddProduct.Controls.Add(this.lblDescribtion);
            this.pnlAddProduct.Controls.Add(this.panel4);
            this.pnlAddProduct.Controls.Add(this.txtItemCode);
            this.pnlAddProduct.Controls.Add(this.lblItemCode);
            this.pnlAddProduct.Controls.Add(this.lblCatagory);
            this.pnlAddProduct.Controls.Add(this.btnClose);
            this.pnlAddProduct.Location = new System.Drawing.Point(4, 4);
            this.pnlAddProduct.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlAddProduct.Name = "pnlAddProduct";
            this.pnlAddProduct.Size = new System.Drawing.Size(1508, 685);
            this.pnlAddProduct.TabIndex = 160;
            this.pnlAddProduct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlAddProduct_MouseDown);
            // 
            // lblstate
            // 
            this.lblstate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblstate.AutoSize = true;
            this.lblstate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstate.ForeColor = System.Drawing.Color.Red;
            this.lblstate.Location = new System.Drawing.Point(924, 535);
            this.lblstate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(358, 51);
            this.lblstate.TabIndex = 195;
            this.lblstate.Text = " Description of state";
            // 
            // cmbBrand
            // 
            this.cmbBrand.AutoCompleteCustomSource.AddRange(new string[] {
            "Power Tool",
            "Access.J.Blade",
            "Access.HSS B.J",
            "Spare.Gear",
            "Spare.Carbon Brush",
            "Spare.Armitum",
            "Spare.Field",
            "HandTool",
            "Bearing",
            "Others",
            "ADD NEW Catagory"});
            this.cmbBrand.BackColor = System.Drawing.Color.Silver;
            this.cmbBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBrand.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Items.AddRange(new object[] {
            "Makita",
            "Irwin",
            "Add new"});
            this.cmbBrand.Location = new System.Drawing.Point(1056, 379);
            this.cmbBrand.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(316, 38);
            this.cmbBrand.TabIndex = 194;
            // 
            // cmbUOM
            // 
            this.cmbUOM.AutoCompleteCustomSource.AddRange(new string[] {
            "Power Tool",
            "Access.J.Blade",
            "Access.HSS B.J",
            "Spare.Gear",
            "Spare.Carbon Brush",
            "Spare.Armitum",
            "Spare.Field",
            "HandTool",
            "Bearing",
            "Others",
            "ADD NEW Catagory"});
            this.cmbUOM.BackColor = System.Drawing.Color.Silver;
            this.cmbUOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUOM.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUOM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.cmbUOM.FormattingEnabled = true;
            this.cmbUOM.Location = new System.Drawing.Point(1056, 188);
            this.cmbUOM.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbUOM.Name = "cmbUOM";
            this.cmbUOM.Size = new System.Drawing.Size(316, 38);
            this.cmbUOM.TabIndex = 184;
            // 
            // cmdSubcatagory
            // 
            this.cmdSubcatagory.AutoCompleteCustomSource.AddRange(new string[] {
            "Power Tool",
            "Access.J.Blade",
            "Access.HSS B.J",
            "Spare.Gear",
            "Spare.Carbon Brush",
            "Spare.Armitum",
            "Spare.Field",
            "HandTool",
            "Bearing",
            "Others",
            "ADD NEW Catagory"});
            this.cmdSubcatagory.BackColor = System.Drawing.Color.Silver;
            this.cmdSubcatagory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSubcatagory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSubcatagory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.cmdSubcatagory.FormattingEnabled = true;
            this.cmdSubcatagory.Items.AddRange(new object[] {
            "Acc.J.Blade",
            "Hss.B.J",
            "TcT",
            "Gear",
            "Add New"});
            this.cmdSubcatagory.Location = new System.Drawing.Point(424, 388);
            this.cmdSubcatagory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdSubcatagory.Name = "cmdSubcatagory";
            this.cmdSubcatagory.Size = new System.Drawing.Size(316, 38);
            this.cmdSubcatagory.TabIndex = 183;
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.AutoCompleteCustomSource.AddRange(new string[] {
            "Power Tool",
            "Access.J.Blade",
            "Access.HSS B.J",
            "Spare.Gear",
            "Spare.Carbon Brush",
            "Spare.Armitum",
            "Spare.Field",
            "HandTool",
            "Bearing",
            "Others",
            "ADD NEW Catagory"});
            this.cmbCatagory.BackColor = System.Drawing.Color.Silver;
            this.cmbCatagory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCatagory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatagory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.cmbCatagory.FormattingEnabled = true;
            this.cmbCatagory.Items.AddRange(new object[] {
            "Power Tools",
            "Accessers",
            "Spare Parts",
            "HandTools",
            "Bearing",
            "Other",
            "Add new"});
            this.cmbCatagory.Location = new System.Drawing.Point(426, 294);
            this.cmbCatagory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(316, 38);
            this.cmbCatagory.TabIndex = 182;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(602, 533);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 58);
            this.btnSave.TabIndex = 181;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // lblUOM
            // 
            this.lblUOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUOM.AutoSize = true;
            this.lblUOM.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUOM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.lblUOM.Location = new System.Drawing.Point(802, 187);
            this.lblUOM.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(111, 51);
            this.lblUOM.TabIndex = 180;
            this.lblUOM.Text = "UOM";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel11.Location = new System.Drawing.Point(1064, 137);
            this.panel11.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(316, 4);
            this.panel11.TabIndex = 179;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Silver;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.txtQuantity.Location = new System.Drawing.Point(1064, 92);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(316, 43);
            this.txtQuantity.TabIndex = 178;
            this.txtQuantity.Text = "0.00";
            this.txtQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantity_MouseClick);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.lblQuantity.Location = new System.Drawing.Point(802, 87);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(167, 51);
            this.lblQuantity.TabIndex = 177;
            this.lblQuantity.Text = "Quantity";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(1060, 421);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 4);
            this.panel2.TabIndex = 176;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Location = new System.Drawing.Point(1060, 325);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 4);
            this.panel3.TabIndex = 174;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.Color.Silver;
            this.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.txtUnitPrice.Location = new System.Drawing.Point(1060, 281);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(316, 43);
            this.txtUnitPrice.TabIndex = 173;
            this.txtUnitPrice.Text = "0.00";
            this.txtUnitPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUnitPrice_MouseClick);
            // 
            // lblBrand
            // 
            this.lblBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.lblBrand.Location = new System.Drawing.Point(802, 392);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(230, 51);
            this.lblBrand.TabIndex = 172;
            this.lblBrand.Text = "Brand Name";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.lblUnitPrice.Location = new System.Drawing.Point(802, 292);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(183, 51);
            this.lblUnitPrice.TabIndex = 171;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblSubcatagory
            // 
            this.lblSubcatagory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubcatagory.AutoSize = true;
            this.lblSubcatagory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubcatagory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.lblSubcatagory.Location = new System.Drawing.Point(118, 392);
            this.lblSubcatagory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSubcatagory.Name = "lblSubcatagory";
            this.lblSubcatagory.Size = new System.Drawing.Size(230, 51);
            this.lblSubcatagory.TabIndex = 170;
            this.lblSubcatagory.Text = "Subcatagory";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel12.Location = new System.Drawing.Point(422, 240);
            this.panel12.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(316, 4);
            this.panel12.TabIndex = 169;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.BackColor = System.Drawing.Color.Silver;
            this.txtItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.txtItemDescription.Location = new System.Drawing.Point(424, 198);
            this.txtItemDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(316, 43);
            this.txtItemDescription.TabIndex = 168;
            // 
            // lblDescribtion
            // 
            this.lblDescribtion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescribtion.AutoSize = true;
            this.lblDescribtion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribtion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.lblDescribtion.Location = new System.Drawing.Point(116, 187);
            this.lblDescribtion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescribtion.Name = "lblDescribtion";
            this.lblDescribtion.Size = new System.Drawing.Size(299, 51);
            this.lblDescribtion.TabIndex = 167;
            this.lblDescribtion.Text = "Item Description";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Location = new System.Drawing.Point(422, 131);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 4);
            this.panel4.TabIndex = 166;
            // 
            // txtItemCode
            // 
            this.txtItemCode.BackColor = System.Drawing.Color.Silver;
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.txtItemCode.Location = new System.Drawing.Point(424, 87);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(316, 43);
            this.txtItemCode.TabIndex = 165;
            // 
            // lblItemCode
            // 
            this.lblItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.lblItemCode.Location = new System.Drawing.Point(118, 83);
            this.lblItemCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(196, 51);
            this.lblItemCode.TabIndex = 164;
            this.lblItemCode.Text = "Item Code";
            // 
            // lblCatagory
            // 
            this.lblCatagory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.lblCatagory.Location = new System.Drawing.Point(118, 292);
            this.lblCatagory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(172, 51);
            this.lblCatagory.TabIndex = 163;
            this.lblCatagory.Text = "Catagory";
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1516, 692);
            this.Controls.Add(this.pnlAddProduct);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddProduct";
            this.Load += new System.EventHandler(this.FormAddProduct_Load);
            this.pnlAddProduct.ResumeLayout(false);
            this.pnlAddProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlAddProduct;
        private System.Windows.Forms.ComboBox cmbUOM;
        private System.Windows.Forms.ComboBox cmdSubcatagory;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUOM;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblSubcatagory;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label lblDescribtion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label lblstate;
    }
}