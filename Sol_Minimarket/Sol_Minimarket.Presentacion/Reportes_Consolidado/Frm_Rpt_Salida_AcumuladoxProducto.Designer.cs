﻿namespace Sol_Minimarket.Presentacion.Reportes_Consolidado
{
    partial class Frm_Rpt_Salida_AcumuladoxProducto
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Reportes_Consolidado = new Sol_Minimarket.Presentacion.Reportes_Consolidado.DataSet_Reportes_Consolidado();
            this.uSPReporteSalidaAcumuladoxProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_Reporte_Salida_AcumuladoxProductoTableAdapter = new Sol_Minimarket.Presentacion.Reportes_Consolidado.DataSet_Reportes_ConsolidadoTableAdapters.USP_Reporte_Salida_AcumuladoxProductoTableAdapter();
            this.txt_p2 = new System.Windows.Forms.TextBox();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Reportes_Consolidado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPReporteSalidaAcumuladoxProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sol_Minimarket.Presentacion.Reportes_Consolidado.Rpt_Salida_AcumuladoxProducto.rd" +
    "lc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.uSPReporteSalidaAcumuladoxProductoBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Sol_Minimarket.Presentacion.Reportes_Consolidado.Rpt_Salida_AcumuladoxProducto.rd" +
    "lc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(800, 450);
            this.reportViewer2.TabIndex = 1;
            // 
            // dataSet_Reportes_Consolidado
            // 
            this.dataSet_Reportes_Consolidado.DataSetName = "DataSet_Reportes_Consolidado";
            this.dataSet_Reportes_Consolidado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPReporteSalidaAcumuladoxProductoBindingSource
            // 
            this.uSPReporteSalidaAcumuladoxProductoBindingSource.DataMember = "USP_Reporte_Salida_AcumuladoxProducto";
            this.uSPReporteSalidaAcumuladoxProductoBindingSource.DataSource = this.dataSet_Reportes_Consolidado;
            // 
            // uSP_Reporte_Salida_AcumuladoxProductoTableAdapter
            // 
            this.uSP_Reporte_Salida_AcumuladoxProductoTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p2
            // 
            this.txt_p2.Location = new System.Drawing.Point(12, 59);
            this.txt_p2.Name = "txt_p2";
            this.txt_p2.Size = new System.Drawing.Size(100, 20);
            this.txt_p2.TabIndex = 7;
            this.txt_p2.Visible = false;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(12, 33);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 6;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Salida_AcumuladoxProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_p2);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Salida_AcumuladoxProducto";
            this.Text = "Frm_Rpt_Salida_AcumuladoxProducto";
            this.Load += new System.EventHandler(this.Frm_Rpt_Salida_AcumuladoxProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Reportes_Consolidado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPReporteSalidaAcumuladoxProductoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource uSPReporteSalidaAcumuladoxProductoBindingSource;
        private DataSet_Reportes_Consolidado dataSet_Reportes_Consolidado;
        private DataSet_Reportes_ConsolidadoTableAdapters.USP_Reporte_Salida_AcumuladoxProductoTableAdapter uSP_Reporte_Salida_AcumuladoxProductoTableAdapter;
        public System.Windows.Forms.TextBox txt_p2;
        public System.Windows.Forms.TextBox txt_p1;
    }
}