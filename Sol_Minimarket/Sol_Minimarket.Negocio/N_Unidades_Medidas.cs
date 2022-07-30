﻿using Sol_Minimarket.Datos;
using Sol_Minimarket.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Minimarket.Negocio
{
    public class N_Unidades_Medidas
    {
        public static DataTable Listado_um(string cTexto)
        {
            D_Unidades_Medidas Datos = new D_Unidades_Medidas();
            return Datos.Listado_um(cTexto);
        }

        public static string Guardar_um(int nOpcion, E_Unidades_Medidas oUm)
        {
            D_Unidades_Medidas Datos = new D_Unidades_Medidas();
            return Datos.Guardar_um(nOpcion, oUm);
        }

        public static string Eliminar_um(int Codigo_um)
        {
            D_Unidades_Medidas Datos = new D_Unidades_Medidas();
            return Datos.Eliminar_um(Codigo_um);
        }
    }
}
