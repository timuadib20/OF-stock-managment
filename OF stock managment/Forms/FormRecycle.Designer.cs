namespace OF_stock_managment.Forms
{
    partial class FormRecycle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewRecycle = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearchOperation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecycle)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRecycle
            // 
            this.dataGridViewRecycle.AllowUserToAddRows = false;
            this.dataGridViewRecycle.AllowUserToDeleteRows = false;
            this.dataGridViewRecycle.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.dataGridViewRecycle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewRecycle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRecycle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecycle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.dataGridViewRecycle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRecycle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewRecycle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRecycle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewRecycle.ColumnHeadersHeight = 43;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRecycle.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewRecycle.DoubleBuffered = true;
            this.dataGridViewRecycle.EnableHeadersVisualStyles = false;
            this.dataGridViewRecycle.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.dataGridViewRecycle.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewRecycle.Location = new System.Drawing.Point(62, 163);
            this.dataGridViewRecycle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridViewRecycle.Name = "dataGridViewRecycle";
            this.dataGridViewRecycle.ReadOnly = true;
            this.dataGridViewRecycle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRecycle.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewRecycle.RowHeadersVisible = false;
            this.dataGridViewRecycle.RowHeadersWidth = 82;
            this.dataGridViewRecycle.RowTemplate.Height = 30;
            this.dataGridViewRecycle.RowTemplate.ReadOnly = true;
            this.dataGridViewRecycle.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRecycle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecycle.Size = new System.Drawing.Size(2094, 810);
            this.dataGridViewRecycle.TabIndex = 89;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.dataGridViewRecycle;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(56, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 36);
            this.label2.TabIndex = 92;
            this.label2.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.textBox1.Location = new System.Drawing.Point(62, 85);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(568, 50);
            this.textBox1.TabIndex = 90;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.BackgroundImage = global::OF_stock_managment.Properties.Resources.icons8_search_64px_12;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(636, 85);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 56);
            this.btnSearch.TabIndex = 91;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cmbSearchOperation
            // 
            this.cmbSearchOperation.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.cmbSearchOperation.BackColor = System.Drawing.Color.Silver;
            this.cmbSearchOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSearchOperation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.cmbSearchOperation.FormattingEnabled = true;
            this.cmbSearchOperation.Items.AddRange(new object[] {
            "Insert",
            "Update",
            "Delete"});
            this.cmbSearchOperation.Location = new System.Drawing.Point(792, 87);
            this.cmbSearchOperation.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.cmbSearchOperation.Name = "cmbSearchOperation";
            this.cmbSearchOperation.Size = new System.Drawing.Size(446, 49);
            this.cmbSearchOperation.TabIndex = 93;
            this.cmbSearchOperation.SelectedIndexChanged += new System.EventHandler(this.cmbSearchOperation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(786, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 36);
            this.label1.TabIndex = 94;
            this.label1.Text = "Type";
            // 
            // FormRecycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1896, 1000);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSearchOperation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridViewRecycle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormRecycle";
            this.Text = "FormRecycle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecycle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewRecycle;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearchOperation;
        private System.Windows.Forms.Label label1;
    }
}