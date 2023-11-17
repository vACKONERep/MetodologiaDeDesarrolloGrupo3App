using Newtonsoft.Json;

namespace MetodologiaDeDesarrolloGrupo3App.Models.Nomina
{
    public class GestionCuentaContableNomina
    {
        public GestionCuentaContableNomina()
        {
        }

        public GestionCuentaContableNomina(int sucursal, int codigoConceptoNomina, string descripcionConcepto, int codigoCategoriaocupacional, string descripcionCategoria, string codigoOperacion, string codigoCuentaContable, int codigoTipoCuenta, string descripcionCuenta, string mensaje)
        {
            Sucursal = sucursal;
            CodigoConceptoNomina = codigoConceptoNomina;
            DescripcionConcepto = descripcionConcepto;
            CodigoCategoriaocupacional = codigoCategoriaocupacional;
            DescripcionCategoria = descripcionCategoria;
            CodigoOperacion = codigoOperacion;
            CodigoCuentaContable = codigoCuentaContable;
            CodigoTipoCuenta = codigoTipoCuenta;
            DescripcionCuenta = descripcionCuenta;
            Mensaje = mensaje;
        }

        [JsonProperty("Sucursal")]
        public int Sucursal { get; set; }

        [JsonProperty("CodigoConceptoNomina")]
        public int CodigoConceptoNomina { get; set; }

        [JsonProperty("DescripcionConcepto")]
        public string DescripcionConcepto { get; set; }

        [JsonProperty("CodigoCategoriaocupacional")]
        public int CodigoCategoriaocupacional { get; set; }

        [JsonProperty("DescripcionCategoria")]
        public string DescripcionCategoria { get; set; }

        [JsonProperty("CodigoOperacion")]
        public string CodigoOperacion { get; set; }

        [JsonProperty("CodigoCuentaContable")]
        public string CodigoCuentaContable { get; set; }

        [JsonProperty("CodigoTipoCuenta")]
        public int CodigoTipoCuenta { get; set; }

        [JsonProperty("DescripcionCuenta")]
        public string DescripcionCuenta { get; set; }

        [JsonProperty("Mensaje")]
        public string Mensaje { get; set; }
    }
}
