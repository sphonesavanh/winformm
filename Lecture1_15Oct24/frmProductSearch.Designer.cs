namespace Lecture1_15Oct24
{
    partial class frmProductSearch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowInstock = new System.Windows.Forms.Button();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnShowAll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnShowInstock);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1711, 86);
            this.panel1.TabIndex = 1;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAll.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnShowAll.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(1128, 23);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(292, 45);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "ສະແດງຂໍ້ມູນທັງໝົດ";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "ປ້ອນລະຫັດສິນຄ້າທີ່ຕ້ອງການຄົ້ນຫາ:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(359, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 34);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnShowInstock
            // 
            this.btnShowInstock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowInstock.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnShowInstock.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInstock.Location = new System.Drawing.Point(830, 23);
            this.btnShowInstock.Name = "btnShowInstock";
            this.btnShowInstock.Size = new System.Drawing.Size(292, 45);
            this.btnShowInstock.TabIndex = 0;
            this.btnShowInstock.Text = "ສະແດງຂໍ້ມູນສິນຄ້າໃກ້ຈະໝົດ";
            this.btnShowInstock.UseVisualStyleBackColor = false;
            this.btnShowInstock.Click += new System.EventHandler(this.btnShowInstock_Click);
            // 
            // dgvShowData
            // 
            this.dgvShowData.AllowUserToAddRows = false;
            this.dgvShowData.AllowUserToDeleteRows = false;
            this.dgvShowData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowData.Location = new System.Drawing.Point(1, 93);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.RowHeadersWidth = 51;
            this.dgvShowData.RowTemplate.Height = 24;
            this.dgvShowData.Size = new System.Drawing.Size(1430, 578);
            this.dgvShowData.TabIndex = 2;
            this.dgvShowData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShowData_CellMouseDoubleClick);
            // 
            // frmProductSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 671);
            this.Controls.Add(this.dgvShowData);
            this.Controls.Add(this.panel1);
            this.Name = "frmProductSearch";
            this.Text = "frmProductSearch";
            this.Load += new System.EventHandler(this.frmProductSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnShowInstock;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView dgvShowData;
    }
}