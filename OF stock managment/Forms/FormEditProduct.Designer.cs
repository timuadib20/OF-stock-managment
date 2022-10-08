namespace OF_stock_managment.Forms
{
    partial class FormEditProduct
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblUOM = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblSubcatagory = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.lblDescribtion = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.cmbSubcatagory = new System.Windows.Forms.ComboBox();
            this.cmbUOM = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(234, 633);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 58);
            this.btnSave.TabIndex = 184;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.btnSave;
            // 
            // lblUOM
            // 
            this.lblUOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUOM.AutoSize = true;
            this.lblUOM.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUOM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.lblUOM.Location = new System.Drawing.Point(694, 263);
            this.lblUOM.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(111, 51);
            this.lblUOM.TabIndex = 183;
            this.lblUOM.Text = "UOM";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel11.Location = new System.Drawing.Point(956, 213);
            this.panel11.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(316, 4);
            this.panel11.TabIndex = 182;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Silver;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.txtQuantity.Location = new System.Drawing.Point(956, 169);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(316, 43);
            this.txtQuantity.TabIndex = 181;
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
            this.lblQuantity.Location = new System.Drawing.Point(694, 163);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(167, 51);
            this.lblQuantity.TabIndex = 180;
            this.lblQuantity.Text = "Quantity";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(952, 498);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 4);
            this.panel1.TabIndex = 179;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(952, 402);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 4);
            this.panel2.TabIndex = 177;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.Color.Silver;
            this.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.txtUnitPrice.Location = new System.Drawing.Point(952, 358);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(316, 43);
            this.txtUnitPrice.TabIndex = 176;
            this.txtUnitPrice.Text = "0.00";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel8.Location = new System.Drawing.Point(952, 308);
            this.panel8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(316, 4);
            this.panel8.TabIndex = 175;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel9.Location = new System.Drawing.Point(318, 508);
            this.panel9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(316, 4);
            this.panel9.TabIndex = 173;
            // 
            // lblBrand
            // 
            this.lblBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.lblBrand.Location = new System.Drawing.Point(694, 469);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(230, 51);
            this.lblBrand.TabIndex = 171;
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
            this.lblUnitPrice.Location = new System.Drawing.Point(694, 369);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(183, 51);
            this.lblUnitPrice.TabIndex = 170;
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
            this.lblSubcatagory.Location = new System.Drawing.Point(10, 469);
            this.lblSubcatagory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSubcatagory.Name = "lblSubcatagory";
            this.lblSubcatagory.Size = new System.Drawing.Size(230, 51);
            this.lblSubcatagory.TabIndex = 169;
            this.lblSubcatagory.Text = "Subcatagory";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel12.Location = new System.Drawing.Point(314, 317);
            this.panel12.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(316, 4);
            this.panel12.TabIndex = 168;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.BackColor = System.Drawing.Color.Silver;
            this.txtItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.txtItemDescription.Location = new System.Drawing.Point(316, 275);
            this.txtItemDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(316, 43);
            this.txtItemDescription.TabIndex = 167;
            this.txtItemDescription.TextChanged += new System.EventHandler(this.txtItemDescription_TextChanged);
            // 
            // lblDescribtion
            // 
            this.lblDescribtion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescribtion.AutoSize = true;
            this.lblDescribtion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribtion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.lblDescribtion.Location = new System.Drawing.Point(8, 263);
            this.lblDescribtion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescribtion.Name = "lblDescribtion";
            this.lblDescribtion.Size = new System.Drawing.Size(299, 51);
            this.lblDescribtion.TabIndex = 166;
            this.lblDescribtion.Text = "Item Description";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Location = new System.Drawing.Point(316, 413);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 4);
            this.panel4.TabIndex = 165;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Location = new System.Drawing.Point(314, 208);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 4);
            this.panel3.TabIndex = 163;
            // 
            // txtItemCode
            // 
            this.txtItemCode.BackColor = System.Drawing.Color.Silver;
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.txtItemCode.Location = new System.Drawing.Point(316, 163);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(316, 43);
            this.txtItemCode.TabIndex = 162;
            // 
            // lblItemCode
            // 
            this.lblItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.lblItemCode.Location = new System.Drawing.Point(10, 160);
            this.lblItemCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(196, 51);
            this.lblItemCode.TabIndex = 161;
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
            this.lblCatagory.Location = new System.Drawing.Point(10, 369);
            this.lblCatagory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(172, 51);
            this.lblCatagory.TabIndex = 160;
            this.lblCatagory.Text = "Catagory";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::OF_stock_managment.Properties.Resources.icons8_macos_close_60;
            this.btnClose.Location = new System.Drawing.Point(1410, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 62);
            this.btnClose.TabIndex = 185;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Location = new System.Drawing.Point(328, 127);
            this.panel5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(316, 4);
            this.panel5.TabIndex = 188;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Silver;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.txtId.Location = new System.Drawing.Point(330, 83);
            this.txtId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(316, 43);
            this.txtId.TabIndex = 187;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(16, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 51);
            this.label1.TabIndex = 186;
            this.label1.Text = "Id";
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
            this.cmbCatagory.Location = new System.Drawing.Point(318, 371);
            this.cmbCatagory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(316, 38);
            this.cmbCatagory.TabIndex = 189;
            // 
            // cmbSubcatagory
            // 
            this.cmbSubcatagory.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.cmbSubcatagory.BackColor = System.Drawing.Color.Silver;
            this.cmbSubcatagory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubcatagory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubcatagory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.cmbSubcatagory.FormattingEnabled = true;
            this.cmbSubcatagory.Items.AddRange(new object[] {
            "Acc.J.Blade",
            "Hss.B.J",
            "TcT",
            "Gear",
            "Add New"});
            this.cmbSubcatagory.Location = new System.Drawing.Point(324, 465);
            this.cmbSubcatagory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbSubcatagory.Name = "cmbSubcatagory";
            this.cmbSubcatagory.Size = new System.Drawing.Size(316, 38);
            this.cmbSubcatagory.TabIndex = 190;
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
            this.cmbUOM.Location = new System.Drawing.Point(956, 263);
            this.cmbUOM.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbUOM.Name = "cmbUOM";
            this.cmbUOM.Size = new System.Drawing.Size(316, 38);
            this.cmbUOM.TabIndex = 191;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(486, 633);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 58);
            this.btnReset.TabIndex = 192;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.cmbBrand.Location = new System.Drawing.Point(952, 456);
            this.cmbBrand.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(316, 38);
            this.cmbBrand.TabIndex = 193;
            // 
            // lblState
            // 
            this.lblState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Red;
            this.lblState.Location = new System.Drawing.Point(820, 633);
            this.lblState.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(304, 51);
            this.lblState.TabIndex = 194;
            this.lblState.Text = "Description state";
            // 
            // FormEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1478, 713);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cmbUOM);
            this.Controls.Add(this.cmbSubcatagory);
            this.Controls.Add(this.cmbCatagory);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblUOM);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblSubcatagory);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.lblDescribtion);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.lblCatagory);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditProduct";
            this.Load += new System.EventHandler(this.FormEditProduct_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormEditProduct_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUOM;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblSubcatagory;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label lblDescribtion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblCatagory;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.ComboBox cmbSubcatagory;
        private System.Windows.Forms.ComboBox cmbUOM;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label lblState;

    }
}