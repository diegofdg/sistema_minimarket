namespace Sol_Minimarket.Presentacion.Reportes
{
    partial class Frm_Rpt_Marcas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSPListadomaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Minimarket = new Sol_Minimarket.Presentacion.Reportes.DataSet_Minimarket();
            this.uSP_Listado_maTableAdapter = new Sol_Minimarket.Presentacion.Reportes.DataSet_MinimarketTableAdapters.USP_Listado_maTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            this.USP_Listado_maBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadomaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Minimarket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_maBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_Listado_maBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_Minimarket.Presentacion.Reportes.Rpt_Marcas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.uSPListadomaBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Sol_Minimarket.Presentacion.Reportes.Rpt_Marcas.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(697, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(8, 8);
            this.reportViewer2.TabIndex = 1;
            // 
            // uSPListadomaBindingSource
            // 
            this.uSPListadomaBindingSource.DataMember = "USP_Listado_ma";
            this.uSPListadomaBindingSource.DataSource = this.dataSet_Minimarket;
            // 
            // dataSet_Minimarket
            // 
            this.dataSet_Minimarket.DataSetName = "DataSet_Minimarket";
            this.dataSet_Minimarket.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSP_Listado_maTableAdapter
            // 
            this.uSP_Listado_maTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(12, 35);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 2;
            this.txt_p1.Visible = false;
            // 
            // USP_Listado_maBindingSource
            // 
            this.USP_Listado_maBindingSource.DataMember = "USP_Listado_ma";
            this.USP_Listado_maBindingSource.DataSource = this.dataSet_Minimarket;
            // 
            // Frm_Rpt_Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Marcas";
            this.Text = "Frm_Rpt_Marcas";
            this.Load += new System.EventHandler(this.Frm_Rpt_Marcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadomaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Minimarket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_maBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource uSPListadomaBindingSource;
        private DataSet_Minimarket dataSet_Minimarket;
        private DataSet_MinimarketTableAdapters.USP_Listado_maTableAdapter uSP_Listado_maTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
        private System.Windows.Forms.BindingSource USP_Listado_maBindingSource;
    }
}