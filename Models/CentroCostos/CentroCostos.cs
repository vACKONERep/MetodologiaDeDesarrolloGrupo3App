using Newtonsoft.Json;

namespace MetodologiaDeDesarrolloGrupo3App.Models.CentroCostos
{
    public class CentroCostos
    {
        public CentroCostos(int Code, string Name)
        {
            Codigo = Code;
            NombreCentroCostos = Name;
        }
        public CentroCostos()
        {    
        }

        [JsonProperty("Codigo")]
        public int Codigo { get; set; }

        [JsonProperty("NombreCentroCostos")]
        public string NombreCentroCostos { get; set; }

        [JsonProperty("Mensaje")]
        public string Mensaje { get; set; }


    }
}
