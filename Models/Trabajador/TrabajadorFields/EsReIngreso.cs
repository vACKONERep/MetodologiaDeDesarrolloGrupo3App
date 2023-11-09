using Newtonsoft.Json;

namespace MetodologiaDeDesarrolloGrupo3App.Models.Trabajador.TrabajadorFields
{
    public class EsReIngreso
    {
        [JsonProperty("Codigo")]
        public string Codigo { get; set; }

        [JsonProperty("Descripcion")]
        public string Descripcion { get; set; }
    }
}
