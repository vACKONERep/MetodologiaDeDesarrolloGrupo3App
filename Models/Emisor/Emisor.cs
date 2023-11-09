using Newtonsoft.Json;

namespace MetodologiaDeDesarrolloGrupo3App.Models.Emisor
{
    public class Emisor
    {
        public Emisor() { }

        [JsonProperty("Codigo")]
        public Int32 Codigo { get; set; }

        [JsonProperty("NombreEmisor")]
        public string NombreEmisor { get; set; }

        [JsonProperty("Ruc")]
        public string NumeroRuc { get; set; }

    }
}
