using Newtonsoft.Json;

namespace MetodologiaDeDesarrolloGrupo3App.Models.MovimientoPlanilla.MovimientoPlanillaFields
{
    public class TrabAfecImpuestoRenta
    {
        public TrabAfecImpuestoRenta()
        {
        }

        public TrabAfecImpuestoRenta(string codigoMovimientoExce, string desripMovimientoExce)
        {
            CodigoMovimientoExce = codigoMovimientoExce;
            DesripMovimientoExce = desripMovimientoExce;
        }

        [JsonProperty("CodigoMovimientoExce")]
        public string CodigoMovimientoExce { get; set; }

        [JsonProperty("DesripMovimientoExce")]
        public string DesripMovimientoExce { get; set; }
    }
}
