using MetodologiaDeDesarrolloGrupo3App.Models.Emisor;
using MetodologiaDeDesarrolloGrupo3App.Models.Trabajador;
using MetodologiaDeDesarrolloGrupo3App.Models.Trabajador.TrabajadorFields;
using MetodologiaDeDesarrolloGrupo3App.Models.Trabajador.TrabajadorFileds;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MetodologiaDeDesarrolloGrupo3App.Controllers
{
    public class TrabajadorController : Controller
    {
        public List<Trabajador> TrabajadorList = new List<Trabajador>();
        public List<TipoTrabajador> TipoTrabajadorList = new List<TipoTrabajador>();
        public List<Genero> GenerosList = new List<Genero>();
        public List<EstadoTrabajador> EstadoTrabajadorList = new List<EstadoTrabajador>();
        public List<PeriodoVacaciones> PeriodoVacacionesList = new List<PeriodoVacaciones>();
        public List<TipoComision> TipoComisionList = new List<TipoComision>();
        public List<DecimoTerceroDecimoCuarto> DecimoTerceroDecimoCuartoList = new List<DecimoTerceroDecimoCuarto>();
        public List<FondoReserva> FondoReservaList = new List<FondoReserva>();
        public List<TipoContrato> TipoContratoList = new List<TipoContrato>();
        public List<TipoCese> TipoCeseList = new List<TipoCese>();
        public List<EstadoCivil> EstadoCivilList = new List<EstadoCivil>();
        public List<EsReIngreso> EsReIngresoList = new List<EsReIngreso>();
        public List<TipoCuenta> TipoCuentaList = new List<TipoCuenta>();
        public List<Ocupacion> OcupacionList = new List<Ocupacion>();
        public List<CategoriaOcupacional> CategoriaOcupacionalList = new List<CategoriaOcupacional>();
        public List<NivelSalarial> NivelSalarialList = new List<NivelSalarial>();
        public List<PlanDeCuentas> PlanDeCuentasList = new List<PlanDeCuentas>();


        HttpClient httpClient;
        public TrabajadorController()
        {
            httpClient = new HttpClient(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }, }, false);
            httpClient.Timeout = TimeSpan.FromSeconds(7);
            httpClient.BaseAddress = new Uri("http://apiservicios.ecuasolmovsa.com:3009/api/");

        }

        public async Task<List<Trabajador>> GetTrabajadoresByCode(int CODIGO_EMISOR)
        {
            try
            {
                /****TRABAJADORES*****/
                HttpResponseMessage httpResponseTrabajadores = await httpClient.GetAsync($"Varios/TrabajadorSelect?sucursal="+ CODIGO_EMISOR);
                string TrabajadoresToString = await httpResponseTrabajadores.Content.ReadAsStringAsync();
                TrabajadorList = JsonConvert.DeserializeObject<List<Trabajador>>(TrabajadoresToString);

                /****TIPO TRABAJADOR*****/
                HttpResponseMessage httpResponseTipoTrabajador = await httpClient.GetAsync($"Varios/TipoTrabajador");
                string TipoTrabajadorToString = await httpResponseTipoTrabajador.Content.ReadAsStringAsync();
                TipoTrabajadorList = JsonConvert.DeserializeObject<List<TipoTrabajador>>(TipoTrabajadorToString);

                /****GÉNERO*****/
                HttpResponseMessage httpResponseGeneros = await httpClient.GetAsync($"Varios/Genero");
                string GenerosToString = await httpResponseGeneros.Content.ReadAsStringAsync();
                GenerosList = JsonConvert.DeserializeObject<List<Genero>>(GenerosToString);

                /****ESTADO TRABAJADOR*****/
                HttpResponseMessage httpResponseEstadoTrabajador = await httpClient.GetAsync($"Varios/EstadoTrabajador");
                string EstadosTrabajadorToString = await httpResponseEstadoTrabajador.Content.ReadAsStringAsync();
                EstadoTrabajadorList = JsonConvert.DeserializeObject<List<EstadoTrabajador>>(EstadosTrabajadorToString);

                /****PERIODO VACACIONES*****/
                HttpResponseMessage httpResponsePeriodoVacaciones = await httpClient.GetAsync($"Varios/PeriodoVacaciones");
                string PeriodoVacacionesToString = await httpResponsePeriodoVacaciones.Content.ReadAsStringAsync();
                PeriodoVacacionesList = JsonConvert.DeserializeObject<List<PeriodoVacaciones>>(PeriodoVacacionesToString);

                /****TIPO COMISION*****/
                HttpResponseMessage httpResponseTipoComision = await httpClient.GetAsync($"Varios/TipoComision");
                string TipoComisionToString = await httpResponseTipoComision.Content.ReadAsStringAsync();
                TipoComisionList = JsonConvert.DeserializeObject<List<TipoComision>>(TipoComisionToString);

                /*****DECIMO TERCERO DECIMO CUARTO*****/
                HttpResponseMessage httpResponseDecimoTerceroDecimoCuarto = await httpClient.GetAsync($"Varios/DecimoTerceroDecimoCuarto");
                string DecimoTerceroDecimoCuartoToString = await httpResponseDecimoTerceroDecimoCuarto.Content.ReadAsStringAsync();
                DecimoTerceroDecimoCuartoList = JsonConvert.DeserializeObject<List<DecimoTerceroDecimoCuarto>>(DecimoTerceroDecimoCuartoToString);

                /****FONDO RESERVA*****/
                HttpResponseMessage httpResponseFondoReserva = await httpClient.GetAsync($"Varios/FondoReserva");
                string FondoReservaToString = await httpResponseFondoReserva.Content.ReadAsStringAsync();
                FondoReservaList = JsonConvert.DeserializeObject<List<FondoReserva>>(FondoReservaToString);

                /****TIPO CONTRATO*****/
                HttpResponseMessage httpResponseTipoContrato = await httpClient.GetAsync($"Varios/TipoContrato");
                string TipoContratoToString = await httpResponseTipoContrato.Content.ReadAsStringAsync();
                TipoContratoList = JsonConvert.DeserializeObject<List<TipoContrato>>(TipoContratoToString);

                /****TIPO CESE*****/
                HttpResponseMessage httpResponseTipoCese = await httpClient.GetAsync($"Varios/TipoCese");
                string TipoCeseToString = await httpResponseTipoCese.Content.ReadAsStringAsync();
                TipoCeseList = JsonConvert.DeserializeObject<List<TipoCese>>(TipoCeseToString);

                /****ESTADO CIVIL*****/
                HttpResponseMessage httpResponseEstadoCivil = await httpClient.GetAsync($"Varios/EstadoCivil");
                string EstadCivilToString = await httpResponseEstadoCivil.Content.ReadAsStringAsync();
                EstadoCivilList = JsonConvert.DeserializeObject<List<EstadoCivil>>(EstadCivilToString);

                /****ES RE INGRESO*****/
                HttpResponseMessage httpResponseEsReIngreso = await httpClient.GetAsync($"Varios/EsReIngreso");
                string EsReIngresoToString = await httpResponseEsReIngreso.Content.ReadAsStringAsync();
                EsReIngresoList = JsonConvert.DeserializeObject<List<EsReIngreso>>(EsReIngresoToString);

                /****TIPO CUENTA*****/
                HttpResponseMessage httpResponseTipoCuenta = await httpClient.GetAsync($"Varios/TipoCuenta");
                string TipoCuentaToString = await httpResponseTipoCuenta.Content.ReadAsStringAsync();
                TipoCuentaList = JsonConvert.DeserializeObject<List<TipoCuenta>>(TipoCuentaToString);

                /****OCUPACIÓN*****/
                HttpResponseMessage httpResponseOcupacion = await httpClient.GetAsync($"Varios/Ocupaciones");
                string OcupacionToString = await httpResponseOcupacion.Content.ReadAsStringAsync();
                OcupacionList = JsonConvert.DeserializeObject<List<Ocupacion>>(OcupacionToString);

                /****CATEGORIA OCUPACIONAL*****/
                HttpResponseMessage httpResponseCategoriaOcupacional = await httpClient.GetAsync($"Varios/CategoriaOcupacional");
                string CategoriaOcupacionalToString = await httpResponseCategoriaOcupacional.Content.ReadAsStringAsync();
                CategoriaOcupacionalList = JsonConvert.DeserializeObject<List<CategoriaOcupacional>>(CategoriaOcupacionalToString);

                /****NIVEL SALARIAL*****/
                HttpResponseMessage httpResponseNivelSalarial = await httpClient.GetAsync($"Varios/NivelSalarial");
                string NivelSalarialToString = await httpResponseNivelSalarial.Content.ReadAsStringAsync();
                NivelSalarialList = JsonConvert.DeserializeObject<List<NivelSalarial>>(NivelSalarialToString);

                /****PLAN DE CUENTAS*****/
                HttpResponseMessage httpResponsePlanCuentas = await httpClient.GetAsync($"Varios/PlandeCuentas");
                string PlanDeCuentasToString = await httpResponsePlanCuentas.Content.ReadAsStringAsync();
                PlanDeCuentasList = JsonConvert.DeserializeObject<List<PlanDeCuentas>>(PlanDeCuentasToString);

                if (TrabajadorList.Count <= 0) throw new Exception();

                TipoTrabajadorList.Add(new TipoTrabajador("Sin tipo...", " "));
                TipoCeseList.Add(new TipoCese(" ", "Sin especificar..."));

                foreach (var Trabajador in TrabajadorList)
                {
                    Trabajador.Tipo_trabajadorAPI = TipoTrabajadorList.FirstOrDefault(ol => ol.Descripcion.Trim() == Trabajador.Tipo_trabajador.Trim()).Codigo;
                    Trabajador.GeneroAPI = GenerosList.FirstOrDefault(gl => gl.Codigo.Trim() == Trabajador.Genero.Trim()).Descripcion;
                    Trabajador.EstadoTrabajadorAPI = EstadoTrabajadorList.FirstOrDefault(ol => ol.Codigo.Trim() == Trabajador.EstadoTrabajador.Trim()).Descripción;
                    var periodoVac =  PeriodoVacacionesList.FirstOrDefault(ol => ol.Codigo.Trim() == Trabajador.PeriododeVacaciones.ToString());
                    Trabajador.TipodeComisionAPI = TipoComisionList.FirstOrDefault(ol => ol.Descripcion == Trabajador.TipodeComision).Codigo;
                    Trabajador.FormaCalculo13roAPI = DecimoTerceroDecimoCuartoList.FirstOrDefault(ol => ol.Codigo == Trabajador.FormaCalculo13ro.ToString()).Descripcion;
                    Trabajador.FormaCalculo14roAPI = DecimoTerceroDecimoCuartoList.FirstOrDefault(ol => ol.Codigo == Trabajador.FormaCalculo14ro.ToString()).Descripcion;
                    Trabajador.Fondo_ReservaAPI = FondoReservaList.FirstOrDefault(ol => ol.Codigo.Trim() == Trabajador.Fondo_Reserva.Trim()).Descripcion;
                    Trabajador.Tipo_ContratoAPI = TipoContratoList.FirstOrDefault(ol => ol.Codigo.Trim() == Trabajador.Tipo_Contrato.Trim()).Descripcion;
                    Trabajador.Tipo_CeseAPI = TipoCeseList.FirstOrDefault(ol => ol.Codigo.Trim() == Trabajador.Tipo_Cese.Trim()).Descripcion;
                    Trabajador.EstadoCivilAPI = EstadoCivilList.FirstOrDefault(ol => ol.Codigo.Trim() == Trabajador.EstadoCivil.Trim()).Descripcion;
                    Trabajador.EsReingresoAPI = EsReIngresoList.FirstOrDefault(ol => ol.Codigo.Trim() == Trabajador.EsReingreso.Trim()).Descripcion;
                    Trabajador.Tipo_CuentaAPI = TipoCuentaList.FirstOrDefault(ol => ol.Codigo.Trim() == Trabajador.Tipo_Cuenta.Trim()).Descripcion;
                    Trabajador.OcupacionAPI = OcupacionList.FirstOrDefault(ol => ol.Codigo.Trim() == Trabajador.Ocupacion.Trim()).Descripcion;
                    Trabajador.Codigo_Categoria_OcupacionAPI = CategoriaOcupacionalList.FirstOrDefault(ol => ol.Codigo.Trim() == Trabajador.Codigo_Categoria_Ocupacion.Trim()).Descripcion;
                    Trabajador.Nivel_SalarialAPI = NivelSalarialList.FirstOrDefault(ol => ol.Codigo.Trim() == Trabajador.Nivel_Salarial.Trim()).Descripcion;
                    
                    if (periodoVac != null)
                    {
                        Trabajador.PeriododeVacacionesAPI = periodoVac.Descripcion;
                    }
                    else
                    {
                        Trabajador.PeriododeVacacionesAPI = Trabajador.PeriododeVacaciones + " días";
                    }
                }

                return TrabajadorList;
            }
            catch (Exception)
            {
                return new List<Trabajador>();
            }
        }
    }
}
