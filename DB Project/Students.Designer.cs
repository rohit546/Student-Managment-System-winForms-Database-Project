namespace DB_Project
{
    partial class Students
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

        #region Component Designer generated code

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.S_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_coulmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fee_stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.S_id,
            this.name_coulmn,
            this.contact_column,
            this.address_Column1,
            this.gender_col,
            this.email_column,
            this.fee_stat,
            this.ok});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.Coral;
            this.dataGridView1.Location = new System.Drawing.Point(-17, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Emoji", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 660);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // S_id
            // 
            this.S_id.HeaderText = "ID";
            this.S_id.MinimumWidth = 8;
            this.S_id.Name = "S_id";
            this.S_id.Width = 72;
            // 
            // name_coulmn
            // 
            this.name_coulmn.HeaderText = "Name";
            this.name_coulmn.MinimumWidth = 8;
            this.name_coulmn.Name = "name_coulmn";
            this.name_coulmn.Width = 111;
            // 
            // contact_column
            // 
            this.contact_column.HeaderText = "Contact";
            this.contact_column.MinimumWidth = 8;
            this.contact_column.Name = "contact_column";
            this.contact_column.Width = 130;
            // 
            // address_Column1
            // 
            this.address_Column1.HeaderText = "Address";
            this.address_Column1.MinimumWidth = 8;
            this.address_Column1.Name = "address_Column1";
            this.address_Column1.Width = 134;
            // 
            // gender_col
            // 
            this.gender_col.HeaderText = "Gender";
            this.gender_col.MinimumWidth = 8;
            this.gender_col.Name = "gender_col";
            this.gender_col.Width = 127;
            // 
            // email_column
            // 
            this.email_column.HeaderText = "Blood Group";
            this.email_column.MinimumWidth = 8;
            this.email_column.Name = "email_column";
            this.email_column.Width = 184;
            // 
            // fee_stat
            // 
            this.fee_stat.HeaderText = "Fees Status";
            this.fee_stat.MinimumWidth = 8;
            this.fee_stat.Name = "fee_stat";
            this.fee_stat.Width = 168;
            // 
            // ok
            // 
            this.ok.HeaderText = "Reg_Date";
            this.ok.MinimumWidth = 8;
            this.ok.Name = "ok";
            this.ok.Width = 149;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "Students";
            this.Size = new System.Drawing.Size(1102, 663);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_coulmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn fee_stat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ok;
    }
}
