﻿namespace Sol_Minimarket.Presentacion.Reportes
{
    partial class Frm_Rpt_Entrada_Productos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Minimarket = new Sol_Minimarket.Presentacion.Reportes.DataSet_Minimarket();
            this.uSPListadoepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_Listado_epTableAdapter = new Sol_Minimarket.Presentacion.Reportes.DataSet_MinimarketTableAdapters.USP_Listado_epTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Minimarket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoepBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.uSPListadoepBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_Minimarket.Presentacion.Reportes.Rpt_Entrada_Productos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Minimarket
            // 
            this.dataSet_Minimarket.DataSetName = "DataSet_Minimarket";
            this.dataSet_Minimarket.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPListadoepBindingSource
            // 
            this.uSPListadoepBindingSource.DataMember = "USP_Listado_ep";
            this.uSPListadoepBindingSource.DataSource = this.dataSet_Minimarket;
            // 
            // uSP_Listado_epTableAdapter
            // 
            this.uSP_Listado_epTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(12, 35);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 3;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Entrada_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Entrada_Productos";
            this.Text = "Frm_Rpt_Entrada_Productos";
            this.Load += new System.EventHandler(this.Frm_Rpt_Entrada_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Minimarket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoepBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPListadoepBindingSource;
        private DataSet_Minimarket dataSet_Minimarket;
        private DataSet_MinimarketTableAdapters.USP_Listado_epTableAdapter uSP_Listado_epTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}