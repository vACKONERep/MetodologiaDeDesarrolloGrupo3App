using Newtonsoft.Json;

namespace MetodologiaDeDesarrolloGrupo3App.Models.Trabajador.TrabajadorFileds
{
    public class PeriodoVacaciones
    {
        public PeriodoVacaciones(string _Codigo, string _Descripcion)
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
