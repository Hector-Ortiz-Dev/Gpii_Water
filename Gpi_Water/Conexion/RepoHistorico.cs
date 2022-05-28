using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gpi_Water.Conexion
{
    public class RepoHistorico
    {
        public int año { get; set; }
        public int mes { get; set; }
        public int consumo { get; set; }
        public float total_pago { get; set; }
        public float cant_pagada { get; set; }
        public float pendiente_pago { get; set; }

        public RepoHistorico()
        {
        }

        public static void sp_reporte_historico(DataGridView dg, string año, string num_ref)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<RepoHistorico>("sp_reporte_historico",
                new
                {
                    @año = año,
                    @num_ref = num_ref
                },
                commandType: CommandType.StoredProcedure); ; ;

            Conexion.Disconnect();

            dg.DataSource = data.ToList();
        }

        public static void sp_reporte_historico_cliente(DataGridView dg, int id)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<RepoHistorico>("sp_reporte_historico_cliente",
                new
                {
                    @id_usuario = id
                },
                commandType: CommandType.StoredProcedure); ; ; ;

            Conexion.Disconnect();

            dg.DataSource = data.ToList();
        }

    }
}
