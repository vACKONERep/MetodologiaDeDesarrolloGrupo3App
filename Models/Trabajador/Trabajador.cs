using Newtonsoft.Json;

namespace MetodologiaDeDesarrolloGrupo3App.Models.Trabajador
{
    public class Trabajador
    {
        [JsonProperty("COMP_Codigo")]
        public int COMP_Codigo { get; set; }

        [JsonProperty("Id_Trabajador")]
        public int Id_Trabajador { get; set; }

        [JsonProperty("Tipo_trabajador")]
        public string Tipo_trabajador { get; set; }

        [JsonProperty("Apellido_Paterno")]
        public string Apellido_Paterno { get; set; }

        [JsonProperty("Apellido_Materno")]
        public string Apellido_Materno { get; set; }

        [JsonProperty("Nombres")]
        public string Nombres { get; set; }

        [JsonProperty("Identificacion")]
        public string Identificacion { get; set; }

        [JsonProperty("Entidad_Bancaria")]
        public string Entidad_Bancaria { get; set; }

        [JsonProperty("CarnetIESS")]
        public string CarnetIESS { get; set; }

        [JsonProperty("Direccion")]
        public string Direccion { get; set; }

        [JsonProperty("Telefono_Fijo")]
        public string Telefono_Fijo { get; set; }

        [JsonProperty("Telefono_Movil")]
        public string Telefono_Movil { get; set; }

        [JsonProperty("Genero")]
        public string Genero { get; set; }

        [JsonProperty("Nro_Cuenta_Bancaria")]
        public string Nro_Cuenta_Bancaria { get; set; }

        [JsonProperty("Codigo_Categoria_Ocupacion")]
        public string Codigo_Categoria_Ocupacion { get; set; }

        [JsonProperty("Ocupacion")]
        public string Ocupacion { get; set; }

        [JsonProperty("Centro_Costos")]
        public string Centro_Costos { get; set; }

        [JsonProperty("Nivel_Salarial")]
        public string Nivel_Salarial { get; set; }

        [JsonProperty("EstadoTrabajador")]
        public string EstadoTrabajador { get; set; }

        [JsonProperty("Tipo_Contrato")]
        public string Tipo_Contrato { get; set; }

        [JsonProperty("Tipo_Cese")]
        public string Tipo_Cese { get; set; }

        [JsonProperty("EstadoCivil")]
        public string EstadoCivil { get; set; }

        [JsonProperty("TipodeComision")]
        public string TipodeComision { get; set; }

        [JsonProperty("FechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [JsonProperty("FechaIngreso")]
        public DateTime FechaIngreso { get; set; }

        [JsonProperty("FechaCese")]
        public DateTime FechaCese { get; set; }

        [JsonProperty("PeriododeVacaciones")]
        public int PeriododeVacaciones { get; set; }

        [JsonProperty("FechaReingreso")]
        public DateTime FechaReingreso { get; set; }

        [JsonProperty("Fecha_Ult_Actualizacion")]
        public DateTime Fecha_Ult_Actualizacion { get; set; }

        [JsonProperty("EsReingreso")]
        public string EsReingreso { get; set; }

        [JsonProperty("BancoCTA_CTE")]
        public string BancoCTA_CTE { get; set; }

        [JsonProperty("Tipo_Cuenta")]
        public string Tipo_Cuenta { get; set; }

        [JsonProperty("RSV_Indem_Acumul")]
        public int RSV_Indem_Acumul { get; set; }

        [JsonProperty("Año_Ult_Rsva_Indemni")]
        public int Año_Ult_Rsva_Indemni { get; set; }

        [JsonProperty("Mes_Ult_Rsva_Indemni")]
        public int Mes_Ult_Rsva_Indemni { get; set; }

        [JsonProperty("FormaCalculo13ro")]
        public int FormaCalculo13ro { get; set; }

        [JsonProperty("FormaCalculo14ro")]
        public int FormaCalculo14ro { get; set; }

        [JsonProperty("BoniComplementaria")]
        public int BoniComplementaria { get; set; }

        [JsonProperty("BoniEspecial")]
        public int BoniEspecial { get; set; }

        [JsonProperty("Remuneracion_Minima")]
        public int Remuneracion_Minima { get; set; }

        [JsonProperty("CuotaCuentaCorriente")]
        public int CuotaCuentaCorriente { get; set; }

        [JsonProperty("Fondo_Reserva")]
        public string Fondo_Reserva { get; set; }

        [JsonProperty("Mensaje")]
        public string Mensaje { get; set; }
    }
}
