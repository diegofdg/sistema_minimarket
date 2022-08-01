namespace Sol_Minimarket.Presentacion.Reportes
{
    partial class Frm_Rpt_Clientes
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSPListadoclBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Minimarket = new Sol_Minimarket.Presentacion.Reportes.DataSet_Minimarket();
            this.uSP_Listado_clTableAdapter = new Sol_Minimarket.Presentacion.Reportes.DataSet_MinimarketTableAdapters.USP_Listado_clTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoclBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Minimarket)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPListadoclBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_Minimarket.Presentacion.Reportes.Rpt_Clientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // uSPListadoclBindingSource
            // 
            this.uSPListadoclBindingSource.DataMember = "USP_Listado_cl";
            this.uSPListadoclBindingSource.DataSource = this.dataSet_Minimarket;
            // 
            // dataSet_Minimarket
            // 
            this.dataSet_Minimarket.DataSetName = "DataSet_Minimarket";
            this.dataSet_Minimarket.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSP_Listado_clTableAdapter
            // 
            this.uSP_Listado_clTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(12, 39);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 3;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Clientes";
            this.Text = "Frm_Rpt_Clientes";
            this.Load += new System.EventHandler(this.Frm_Rpt_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoclBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Minimarket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPListadoclBindingSource;
        private DataSet_Minimarket dataSet_Minimarket;
        private DataSet_MinimarketTableAdapters.USP_Listado_clTableAdapter uSP_Listado_clTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}