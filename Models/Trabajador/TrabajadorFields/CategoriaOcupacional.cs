using Newtonsoft.Json;

namespace MetodologiaDeDesarrolloGrupo3App.Models.Trabajador.TrabajadorFileds
{
    public class CategoriaOcupacional
    {
        [JsonProperty("Codigo")]
        public string Codigo { get; set; }

        [JsonProperty("Descripcion")]
        public string Descripcion { get; set; }
    }
}
