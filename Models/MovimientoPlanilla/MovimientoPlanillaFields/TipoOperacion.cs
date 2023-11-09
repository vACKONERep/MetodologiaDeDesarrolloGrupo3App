using Newtonsoft.Json;

namespace MetodologiaDeDesarrolloGrupo3App.Models.MovimientoPlanilla.MovimientoPlanillaFields
{
    public class TipoOperacion
    {
        public TipoOperacion()
        {
            
        }

        public TipoOperacion(string codigoTipooperacion, string nombreOperacion)
        {
            CodigoTipooperacion = codigoTipooperacion;
            NombreOperacion = nombreOperacion;
        }

        [JsonProperty("CodigoTipooperacion")]
        public string CodigoTipooperacion { get; set; }

        [JsonProperty("NombreOperacion")]
        public string NombreOperacion { get; set; }
    }
}
