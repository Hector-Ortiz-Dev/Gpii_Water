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
    public class Contrato
    {
		public int num_ref { get; set; }
		public int medidor { get; set; }
		public string tipo { get; set; }
		public string categoria { get; set; }
		public string municipio { get; set; }
        public string zona { get; set; }
		public int cod_postal { get; set; }
		public string colonia { get; set; }
		public string calle { get; set; }
		public int num_ext { get; set; }
		public string activo { get; set; }
        public int fk_cliente { get; set; }

        public Contrato() { }

        public Contrato(int medidor, string tipo, string categoria, string fk_ciudad, int cod_postal, string colonia, string calle, int num_ext)
        {
            this.medidor = medidor;
            this.tipo = tipo.ToUpper();
            this.categoria = categoria;
            this.municipio = fk_ciudad.ToUpper();
            this.cod_postal = cod_postal;
            this.colonia = colonia.ToUpper();
            this.calle = calle.ToUpper();
            this.num_ext = num_ext;
        }

        public Contrato(int num_ref)
        {
            this.num_ref = num_ref;
        }

        public Contrato(int medidor, string tipo, string categoria, string fk_ciudad, int cod_postal, string colonia, string calle, int num_ext, int fk_cliente) : this(medidor, tipo, categoria, fk_ciudad, cod_postal, colonia, calle, num_ext)
        {
            this.fk_cliente = fk_cliente;
        }

        public static void sp_get_contratos(DataGridView dg, string id)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Contrato>("sp_get_contratos",
                new { id_cliente = id },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            dg.DataSource = data.ToList();
        }

        public static void sp_alta_contrato(Contrato contrato)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Contrato>("sp_gestion_contrato",
                new {
                    @Opc = "AGREGAR",
                    @num_ref = 0,
                    @medidor = contrato.medidor,
                    @tipo = contrato.tipo,
                    @categoria = contrato.categoria,
                    @municipio = contrato.municipio,
                    @cod_postal = contrato.cod_postal,
                    @colonia = contrato.colonia,
                    @calle = contrato.calle,
                    @num_ext = contrato.num_ext,
                    @id_cliente = contrato.fk_cliente
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }

        public static void sp_modificar_contrato(Contrato contrato)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Contrato>("sp_gestion_contrato",
                new
                {
                    @Opc = "MODIFICAR",
                    @num_ref = contrato.num_ref,
                    @medidor = contrato.medidor,
                    @tipo = contrato.tipo,
                    @categoria = contrato.categoria,
                    @municipio = contrato.municipio,
                    @cod_postal = contrato.cod_postal,
                    @colonia = contrato.colonia,
                    @calle = contrato.calle,
                    @num_ext = contrato.num_ext,
                    @id_cliente = 0
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }

        public static void sp_baja_contrato(Contrato contrato)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Contrato>("sp_gestion_contrato",
                new
                {
                    @Opc = "ELIMINAR",
                    @num_ref = contrato.num_ref,
                    @medidor = 0,
                    @tipo = "",
                    @categoria = "",
                    @municipio = "",
                    @cod_postal = "",
                    @colonia = "",
                    @calle = "",
                    @num_ext = 0,
                    @id_cliente = 0
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }

        public static void sp_reactiva_contrato(Contrato contrato)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Contrato>("sp_reactiva_contrato",
                new
                {
                    @num_ref = contrato.num_ref
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
        }

        public static Contrato sp_get_contrato_single(int num_ref)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Contrato>("sp_get_contrato_single",
                new
                {
                    @num_ref = num_ref
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
