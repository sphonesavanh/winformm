namespace Lecture1_15Oct24
{
    partial class frmrptProductViewer
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.viewProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsProducts = new Lecture1_15Oct24.dtsProducts();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_ProductsTableAdapter = new Lecture1_15Oct24.dtsProductsTableAdapters.View_ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewProductsBindingSource
            // 
            this.viewProductsBindingSource.DataMember = "View_Products";
            this.viewProductsBindingSource.DataSource = this.dtsProducts;
            // 
            // dtsProducts
            // 
            this.dtsProducts.DataSetName = "dtsProducts";
            this.dtsProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1396, 69);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "ປ້ອນລະຫັດສິນຄ້າທີ່ຕ້ອງການຄົ້ນຫາ:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(358, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 34);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1140, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "ສະແດງຂໍ້ມູນ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.viewProductsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Lecture1_15Oct24.rptProduct.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 87);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1393, 585);
            this.reportViewer1.TabIndex = 2;
            // 
            // view_ProductsTableAdapter
            // 
            this.view_ProductsTableAdapter.ClearBeforeFill = true;
            // 
            // frmrptProductViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 670);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmrptProductViewer";
            this.Text = "frmrptProductViewer";
            this.Load += new System.EventHandler(this.frmrptProductViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private dtsProducts dtsProducts;
        private System.Windows.Forms.BindingSource viewProductsBindingSource;
        private dtsProductsTableAdapters.View_ProductsTableAdapter view_ProductsTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}