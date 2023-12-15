using Newtonsoft.Json;

namespace MetodologiaDeDesarrolloGrupo3App.Models.Trabajador.TrabajadorFields
{
    public class TipoComision
    {
        public TipoComision(string _Codigo, string _Descripcion)
        {
            Codigo = _Codigo;
            Descripcion = _Descripcion;
        }

        [JsonProperty("Codigo")]
        public string Codigo { get; set; }

        [JsonProperty("Descripcion")]
        public string Descripcion { get; set; }
    }
}
