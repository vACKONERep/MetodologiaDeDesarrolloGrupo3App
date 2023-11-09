using MetodologiaDeDesarrolloGrupo3App.Models.MovimientoPlanilla.MovimientoPlanillaFields;
using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;

namespace MetodologiaDeDesarrolloGrupo3App.Models.MovimientoPlanilla
{
    public class MovimientoPlanilla
    {
        public MovimientoPlanilla()
        {
                
        }

        public MovimientoPlanilla(int codigoConcepto, string concepto, int prioridad, string tipoOperacion, string cuenta1, string cuenta2, string cuenta3, string cuenta4, string movimientoExcepcion1, string movimientoExcepcion2, string movimientoExcepcion3, string aplica_iess, string aplica_imp_renta, string empresa_Afecta_Iess, string mensaje)
        {
            CodigoConcepto = codigoConcepto;
            Concepto = concepto;
            Prioridad = prioridad;
            TipoOperacion = tipoOperacion;
            Cuenta1 = cuenta1;
            Cuenta2 = cuenta2;
            Cuenta3 = cuenta3;
            Cuenta4 = cuenta4;
            MovimientoExcepcion1 = movimientoExcepcion1;
            MovimientoExcepcion2 = movimientoExcepcion2;
            MovimientoExcepcion3 = movimientoExcepcion3;
            Aplica_iess = aplica_iess;
            Aplica_imp_renta = aplica_imp_renta;
            Empresa_Afecta_Iess = empresa_Afecta_Iess;
            Mensaje = mensaje;
        }

        [JsonProperty("CodigoConcepto")]
        public int CodigoConcepto { get; set; }

        [JsonProperty("Concepto")]
        public string Concepto { get; set; }

        [JsonProperty("Prioridad")]
        public int Prioridad { get; set; }

        [JsonProperty("TipoOperacion")]
        public string TipoOperacion { get; set; }
        public string TipoOperacionAPI { get; set; }

        [JsonProperty("Cuenta1")]
        public string Cuenta1 { get; set; }

        [JsonProperty("Cuenta2")]
        public string Cuenta2 { get; set; }

        [JsonProperty("Cuenta3")]
        public string Cuenta3 { get; set; }

        [JsonProperty("Cuenta4")]
        public string Cuenta4 { get; set; }

        [JsonProperty("MovimientoExcepcion1")]
        public string MovimientoExcepcion1 { get; set; }
        public string MovimientoExcepcion1API { get; set; }

        [JsonProperty("MovimientoExcepcion2")]
        public string MovimientoExcepcion2 { get; set; }
        public string MovimientoExcepcion2API { get; set; }

        [JsonProperty("MovimientoExcepcion3")]
        public string MovimientoExcepcion3 { get; set; }
        public string MovimientoExcepcion3API { get; set; }

        [JsonProperty("Aplica_iess")]
        public string Aplica_iess { get; set; }
        public string Aplica_iessAPI { get; set; }

        [JsonProperty("Aplica_imp_renta")]
        public string Aplica_imp_renta { get; set; }
        public string Aplica_imp_rentaAPI { get; set; }

        [JsonProperty("Empresa_Afecta_Iess")]
        public string Empresa_Afecta_Iess { get; set; }

        [JsonProperty("Mensaje")]
        public string Mensaje { get; set; }

        public List<TipoOperacion> TipoOperacionList { get; set; }
        public List<MovimientosExcepcion1y2> MovimientosExcepcion1y2List { get; set; }
        public List<MovimientosExcepcion3> MovimientosExcepcion3List { get; set; }

    }
}
