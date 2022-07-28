using Sol_Minimarket.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sol_Minimarket.Presentacion
{
    public partial class Frm_Categorias : Form
    {
        public Frm_Categorias()
        {
            InitializeComponent();
        }

        #region "Mis Variables"
        int Codigo_ca = 0;
        int Estadoguarda = 0; //Sin ninguna acción
        #endregion

        #region "Mis Métodos"
        private void Formato_ca()
        {
            Dgv_principal.Columns[0].Width = 100;
            Dgv_principal.Columns[0].HeaderText = "CÓDIGO_CA";
            Dgv_principal.Columns[1].Width = 300;
            Dgv_principal.Columns[1].HeaderText = "CATEGORIA";
        }

        private void Listado_ca(string cTexto)
        {
            try
            {
                Dgv_principal.DataSource = N_Categorias.Listado_ca(cTexto);
                this.Formato_ca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Estado_Botonesprincipales(bool lEstado)
        {
            
        }

        private void Estado_Botonesprocesos(bool lEstado)
        {
            
        }

        private void Selecciona_item()
        {
            

        }
        #endregion

        private void Frm_Categorias_Load(object sender, EventArgs e)
        {
            this.Listado_ca("%");
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void Dgv_principal_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void Btn_retornar_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
