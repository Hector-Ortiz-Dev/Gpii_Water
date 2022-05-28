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
    public class Tarifa
    {
        public int id { get; set; }
		public int zona { get; set; }
		public int año { get; set; }
		public int mes { get; set; }
		public float basico { get; set; }
		public float intermedio { get; set; }
		public float excedente { get; set; }
		public float cuota { get; set; }

		public Tarifa() { }

        public Tarifa(int zona, int año, int mes, float basico, float intermedio, float excedente, float cuota)
        {
            this.zona = zona;
            this.año = año;
            this.mes = mes;
            this.basico = basico;
            this.intermedio = intermedio;
            this.excedente = excedente;
            this.cuota = cuota;
        }

        public Tarifa(int id)
        {
            this.id = id;
        }

        public static void sp_get_tarifas(DataGridView dg, string año)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Tarifa>("sp_get_tarifas",
                new { año = año },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();

            dg.DataSource = data.ToList();
        }

        public static bool sp_get_tarifas_valid(string zona, int mes, int año)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Tarifa>("sp_get_tarifas_valid",
                new {
                    @zona = zona,
                    @mes = mes,
                    @año = año,
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();

            if (data.ToList().Count >= 1)
                return true;
            else
                return false;
        }

        public static void sp_agregar_tarifa(string zona, int año, int mes, float cuota, float basico, float intermedio, float excedente)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Tarifa>("sp_gestion_tarifa",
                new
                {
                    @Opc = "AGREGAR",
                    @id = 0,
                    @zona = zona,
                    @año = año,
                    @mes = mes,
                    @cuota = cuota,
                    @basico = basico,
                    @intermedio = intermedio,
                    @excedente = excedente
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }

        public static void sp_modificar_tarifa(Tarifa tarifa)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Tarifa>("sp_gestion_tarifa",
                new
                {
                    @Opc = "MODIFICAR",
                    @id = tarifa.id,
                    @zona = tarifa.zona,
                    @año = tarifa.año,
                    @mes = tarifa.mes,
                    @cuota = tarifa.cuota,
                    @basico = tarifa.basico,
                    @intermedio = tarifa.intermedio,
                    @excedente = tarifa.excedente
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }

        public static void sp_eliminar_tarifa(Tarifa tarifa)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Tarifa>("sp_gestion_tarifa",
                new
                {
                    @Opc = "ELIMINAR",
                    @id = tarifa.id,
                    @zona = "",
                    @año = "",
                    @mes = "",
                    @cuota = 0,
                    @basico = 0,
                    @intermedio = 0,
                    @excedente = 0
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }

        public static void sp_masiva_tarifa(Tarifa tarifa)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Tarifa>("sp_gestion_tarifa",
                new
                {
                    @Opc = "MASIVA",
                    @id = tarifa.zona,
                    @zona = "",
                    @año = tarifa.año,
                    @mes = tarifa.mes,
                    @cuota = tarifa.cuota,
                    @basico = tarifa.basico,
                    @intermedio = tarifa.intermedio,
                    @excedente = tarifa.excedente
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }

        public static bool sp_get_tarifa_masiva(Tarifa tarifa)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Tarifa>("sp_get_tarifa_masiva",
                new
                {
                    @zona = tarifa.zona,
                    @mes = tarifa.mes,
                    @año = tarifa.año
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();

            if (data.ToList().Count >= 1)
                return true;
            else
                return false;
        }

        public static Tarifa sp_get_tarifas_single(string zona, int año, int mes)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Tarifa>("sp_get_tarifas_valid",
                new
                {
                    @zona = zona,
                    @mes = mes,
                    @año = año
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();

            if (data.ToList().Count >= 1)
                return data.ToList()[0];
            else
                return null;
        }
    }
}
