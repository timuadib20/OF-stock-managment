namespace OF_stock_managment.Forms
{
    partial class FormImport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagridImport = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSheet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessotiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accJBladeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSSBJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spartPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cARBONBRUSHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRMTURNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fIELDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.handToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.cmdSubcatagory = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUOM = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridImport)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagridImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 345);
            this.panel1.TabIndex = 0;
            // 
            // datagridImport
            // 
            this.datagridImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridImport.Location = new System.Drawing.Point(0, 0);
            this.datagridImport.MinimumSize = new System.Drawing.Size(964, 345);
            this.datagridImport.Name = "datagridImport";
            this.datagridImport.Size = new System.Drawing.Size(964, 345);
            this.datagridImport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 140;
            this.label1.Text = "Path";
            // 
            // btnLoad
            // 
            this.btnLoad.FlatAppearance.BorderSize = 2;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.btnLoad.Location = new System.Drawing.Point(412, 243);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 31);
            this.btnLoad.TabIndex = 141;
            this.btnLoad.Text = "Import";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnImport
            // 
            this.btnImport.FlatAppearance.BorderSize = 2;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.btnImport.Location = new System.Drawing.Point(265, 240);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 34);
            this.btnImport.TabIndex = 142;
            this.btnImport.Text = "Browse";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel2.Location = new System.Drawing.Point(409, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 2);
            this.panel2.TabIndex = 147;
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(206)))), ((int)(((byte)(252)))));
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.txtPath.Location = new System.Drawing.Point(409, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(242, 22);
            this.txtPath.TabIndex = 146;
            this.txtPath.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPath_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel3.Location = new System.Drawing.Point(409, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 2);
            this.panel3.TabIndex = 150;
            // 
            // txtSheet
            // 
            this.txtSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(206)))), ((int)(((byte)(252)))));
            this.txtSheet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSheet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.txtSheet.Location = new System.Drawing.Point(409, 48);
            this.txtSheet.Name = "txtSheet";
            this.txtSheet.Size = new System.Drawing.Size(168, 22);
            this.txtSheet.TabIndex = 149;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(275, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 148;
            this.label2.Text = "Sheet No";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.btnSave.Location = new System.Drawing.Point(537, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 151;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(135, 48);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powerToolsToolStripMenuItem,
            this.accessotiToolStripMenuItem,
            this.spartPartsToolStripMenuItem,
            this.handToolsToolStripMenuItem,
            this.bearingToolStripMenuItem,
            this.otherToolStripMenuItem,
            this.newToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // powerToolsToolStripMenuItem
            // 
            this.powerToolsToolStripMenuItem.Name = "powerToolsToolStripMenuItem";
            this.powerToolsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.powerToolsToolStripMenuItem.Text = "Power Tools";
            // 
            // accessotiToolStripMenuItem
            // 
            this.accessotiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accJBladeToolStripMenuItem,
            this.hSSBJToolStripMenuItem,
            this.tCTToolStripMenuItem,
            this.aDDNEWToolStripMenuItem});
            this.accessotiToolStripMenuItem.Name = "accessotiToolStripMenuItem";
            this.accessotiToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.accessotiToolStripMenuItem.Text = "Accessories";
            // 
            // accJBladeToolStripMenuItem
            // 
            this.accJBladeToolStripMenuItem.Name = "accJBladeToolStripMenuItem";
            this.accJBladeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.accJBladeToolStripMenuItem.Text = "Acc.J.Blade";
            // 
            // hSSBJToolStripMenuItem
            // 
            this.hSSBJToolStripMenuItem.Name = "hSSBJToolStripMenuItem";
            this.hSSBJToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.hSSBJToolStripMenuItem.Text = "HSS BJ";
            // 
            // tCTToolStripMenuItem
            // 
            this.tCTToolStripMenuItem.Name = "tCTToolStripMenuItem";
            this.tCTToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.tCTToolStripMenuItem.Text = "TCT";
            // 
            // aDDNEWToolStripMenuItem
            // 
            this.aDDNEWToolStripMenuItem.Name = "aDDNEWToolStripMenuItem";
            this.aDDNEWToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.aDDNEWToolStripMenuItem.Text = "ADD NEW";
            // 
            // spartPartsToolStripMenuItem
            // 
            this.spartPartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gEARToolStripMenuItem,
            this.cARBONBRUSHToolStripMenuItem,
            this.aRMTURNToolStripMenuItem,
            this.fIELDToolStripMenuItem,
            this.aDDNEWToolStripMenuItem1});
            this.spartPartsToolStripMenuItem.Name = "spartPartsToolStripMenuItem";
            this.spartPartsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.spartPartsToolStripMenuItem.Text = "Spart Parts";
            // 
            // gEARToolStripMenuItem
            // 
            this.gEARToolStripMenuItem.Name = "gEARToolStripMenuItem";
            this.gEARToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.gEARToolStripMenuItem.Text = "GEAR";
            // 
            // cARBONBRUSHToolStripMenuItem
            // 
            this.cARBONBRUSHToolStripMenuItem.Name = "cARBONBRUSHToolStripMenuItem";
            this.cARBONBRUSHToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cARBONBRUSHToolStripMenuItem.Text = "CARBON BRUSH";
            // 
            // aRMTURNToolStripMenuItem
            // 
            this.aRMTURNToolStripMenuItem.Name = "aRMTURNToolStripMenuItem";
            this.aRMTURNToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.aRMTURNToolStripMenuItem.Text = "ARM TURN";
            // 
            // fIELDToolStripMenuItem
            // 
            this.fIELDToolStripMenuItem.Name = "fIELDToolStripMenuItem";
            this.fIELDToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.fIELDToolStripMenuItem.Text = "FIELD";
            // 
            // aDDNEWToolStripMenuItem1
            // 
            this.aDDNEWToolStripMenuItem1.Name = "aDDNEWToolStripMenuItem1";
            this.aDDNEWToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.aDDNEWToolStripMenuItem1.Text = "ADD NEW";
            // 
            // handToolsToolStripMenuItem
            // 
            this.handToolsToolStripMenuItem.Name = "handToolsToolStripMenuItem";
            this.handToolsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.handToolsToolStripMenuItem.Text = "Hand Tools";
            // 
            // bearingToolStripMenuItem
            // 
            this.bearingToolStripMenuItem.Name = "bearingToolStripMenuItem";
            this.bearingToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.bearingToolStripMenuItem.Text = "Bearing ";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.purchaseToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(275, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 153;
            this.label3.Text = "Sub.Catagory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.label4.Location = new System.Drawing.Point(275, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 152;
            this.label4.Text = "Catagory";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel4.Location = new System.Drawing.Point(409, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(168, 2);
            this.panel4.TabIndex = 154;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel5.Location = new System.Drawing.Point(409, 147);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(168, 2);
            this.panel5.TabIndex = 155;
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.AutoCompleteCustomSource.AddRange(new string[] {
            "ADD NEW Catagory"});
            this.cmbCatagory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(206)))), ((int)(((byte)(252)))));
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
            this.cmbCatagory.Location = new System.Drawing.Point(409, 86);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(168, 21);
            this.cmbCatagory.TabIndex = 183;
            // 
            // cmdSubcatagory
            // 
            this.cmdSubcatagory.AutoCompleteCustomSource.AddRange(new string[] {
            "ADD NEW Catagory"});
            this.cmdSubcatagory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(206)))), ((int)(((byte)(252)))));
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
            this.cmdSubcatagory.Location = new System.Drawing.Point(409, 125);
            this.cmdSubcatagory.Name = "cmdSubcatagory";
            this.cmdSubcatagory.Size = new System.Drawing.Size(168, 21);
            this.cmdSubcatagory.TabIndex = 184;
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
            this.cmbBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(206)))), ((int)(((byte)(252)))));
            this.cmbBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBrand.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Items.AddRange(new object[] {
            "Makita",
            "Irwin",
            "Add new"});
            this.cmbBrand.Location = new System.Drawing.Point(409, 156);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(168, 21);
            this.cmbBrand.TabIndex = 187;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel6.Location = new System.Drawing.Point(409, 178);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(168, 2);
            this.panel6.TabIndex = 186;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.label5.Location = new System.Drawing.Point(275, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 185;
            this.label5.Text = "Brand";
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
            this.cmbUOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(206)))), ((int)(((byte)(252)))));
            this.cmbUOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUOM.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUOM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.cmbUOM.FormattingEnabled = true;
            this.cmbUOM.Items.AddRange(new object[] {
            "Makita",
            "Irwin",
            "Add new"});
            this.cmbUOM.Location = new System.Drawing.Point(409, 192);
            this.cmbUOM.Name = "cmbUOM";
            this.cmbUOM.Size = new System.Drawing.Size(168, 21);
            this.cmbUOM.TabIndex = 190;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel7.Location = new System.Drawing.Point(409, 214);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(168, 2);
            this.panel7.TabIndex = 189;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.label6.Location = new System.Drawing.Point(275, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 188;
            this.label6.Text = "UOM";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.ForeColor = System.Drawing.Color.Red;
            this.lbState.Location = new System.Drawing.Point(689, 219);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(218, 25);
            this.lbState.TabIndex = 191;
            this.lbState.Text = "State something usefullll";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(409, 224);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(180, 20);
            this.txtDate.TabIndex = 201;
            this.txtDate.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.panel8.Location = new System.Drawing.Point(409, 244);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(168, 2);
            this.panel8.TabIndex = 200;
            this.panel8.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(273, 219);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 25);
            this.lblDate.TabIndex = 199;
            this.lblDate.Text = "Date";
            this.lblDate.Visible = false;
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(206)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(933, 600);
            this.ControlBox = false;
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.cmbUOM);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdSubcatagory);
            this.Controls.Add(this.cmbCatagory);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtSheet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormImport";
            this.Text = "FormImport";
            this.Load += new System.EventHandler(this.FormImport_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridImport)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSheet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagridImport;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessotiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accJBladeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSSBJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tCTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spartPartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cARBONBRUSHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRMTURNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fIELDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem handToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.ComboBox cmdSubcatagory;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUOM;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblDate;
    }
}