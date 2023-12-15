using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MetodologiaDeDesarrolloGrupo3App.Models.MovimientoPlanilla;
using MetodologiaDeDesarrolloGrupo3App.Models.MovimientoPlanilla.MovimientoPlanillaFields;

namespace MetodologiaDeDesarrolloGrupo3App.Controllers
{
    public class MovimientoPlanillaController : Controller
    {
        public List<MovimientoPlanilla> MovimientoPlanillaList = new List<MovimientoPlanilla>();
        public List<TipoOperacion> TipoOperacionList = new List<TipoOperacion>();
        public List<MovimientosExcepcion1y2> MovimientosExcepcion1y2List = new List<MovimientosExcepcion1y2>();
        public List<MovimientosExcepcion3> MovimientosExcepcion3List = new List<MovimientosExcepcion3>();
        public List<TrabaAfectaIESS> TrabaAfectaIESSList = new List<TrabaAfectaIESS>();
        public List<TrabAfecImpuestoRenta> TrabAfecImpuestoRentaList = new List<TrabAfecImpuestoRenta>();

        HttpClient httpClient;
        public MovimientoPlanillaController()
        {
            //Ignorar errores de SSL al realizar peticiones a HTTP/HTTPS
            httpClient = new HttpClient(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }, }, false);
            httpClient.Timeout = TimeSpan.FromSeconds(7);
            httpClient.BaseAddress = new Uri("http://apiservicios.ecuasolmovsa.com:3009/api/");
        }

        public async Task<List<MovimientosExcepcion1y2>> GetExcepcion1y2()
        {
            try
            {
                /****MOV EXCEP 1 Y 2*****/
                HttpResponseMessage httpResponseMovimientosExcepcion1y2 = await httpClient.GetAsync($"Varios/MovimientosExcepcion1y2");
                string MovimientosExcepcion1y2ToString = await httpResponseMovimientosExcepcion1y2.Content.ReadAsStringAsync();
                MovimientosExcepcion1y2List = JsonConvert.DeserializeObject<List<MovimientosExcepcion1y2>>(MovimientosExcepcion1y2ToString);

                return MovimientosExcepcion1y2List;
            }
            catch (Exception ex)
            {
                return new List<MovimientosExcepcion1y2>();
            }
        }

        public async Task<List<MovimientosExcepcion3>> GetExcepcion3()
        {
            try
            {
                /****MOV EXCEP 3*****/
                HttpResponseMessage httpResponseMovimientosExcepcion3 = await httpClient.GetAsync($"Varios/MovimientosExcepcion3");
                string MovimientosExcepcion3ToString = await httpResponseMovimientosExcepcion3.Content.ReadAsStringAsync();
                MovimientosExcepcion3List = JsonConvert.DeserializeObject<List<MovimientosExcepcion3>>(MovimientosExcepcion3ToString);

                return MovimientosExcepcion3List;
            }
            catch (Exception ex)
            {
                return new List<MovimientosExcepcion3>();
            }
        }

        public async Task<List<TrabaAfectaIESS>> GetTrabaAfectaIess()
        {
            try
            {
                /****TRAB AFECTA IESS*****/
                HttpResponseMessage httpResponseTrabaAfectaIESS = await httpClient.GetAsync($"Varios/TrabaAfectaIESS");
                string TrabaAfectaIESSToString = await httpResponseTrabaAfectaIESS.Content.ReadAsStringAsync();
                TrabaAfectaIESSList = JsonConvert.DeserializeObject<List<TrabaAfectaIESS>>(TrabaAfectaIESSToString);

                return TrabaAfectaIESSList;
            }
            catch (Exception ex)
            {
                return new List<TrabaAfectaIESS>();
            }
        }

        public async Task<List<TipoOperacion>> GetTipoOperacion()
        {
            try
            {
                /****TIPO OPERACION*****/
                HttpResponseMessage httpResponseTipoOperacion = await httpClient.GetAsync($"Varios/TipoOperacion");
                string TipoOperacionToString = await httpResponseTipoOperacion.Content.ReadAsStringAsync();
                TipoOperacionList = JsonConvert.DeserializeObject<List<TipoOperacion>>(TipoOperacionToString);

                return TipoOperacionList;
            }
            catch (Exception ex)
            {
                return new List<TipoOperacion>();
            }
        }

        public async Task<List<TrabAfecImpuestoRenta>> GetTrabaAfecImpuestoRenta()
        {
            try
            {
                /****TRAB AFECTA IMP RENTA*****/
                HttpResponseMessage httpResponseTrabAfecImpuestoRenta = await httpClient.GetAsync($"Varios/TrabAfecImpuestoRenta");
                string TrabAfecImpuestoRentaToString = await httpResponseTrabAfecImpuestoRenta.Content.ReadAsStringAsync();
                TrabAfecImpuestoRentaList = JsonConvert.DeserializeObject<List<TrabAfecImpuestoRenta>>(TrabAfecImpuestoRentaToString);

                return TrabAfecImpuestoRentaList;
            }
            catch (Exception ex)
            {
                return new List<TrabAfecImpuestoRenta>();
            }
        }

        public async Task<List<MovimientoPlanilla>> GetMovimientosPlantilla()
        {
            try
            {
                /****MOVIMIENTO PLANTILLA*****/
                HttpResponseMessage httpResponseMovimientoPlanilla = await httpClient.GetAsync($"Varios/MovimientoPlanillaSelect");
                string MovPlantToString = await httpResponseMovimientoPlanilla.Content.ReadAsStringAsync();
                MovimientoPlanillaList = JsonConvert.DeserializeObject<List<MovimientoPlanilla>>(MovPlantToString);

                /****TIPO OPERACION*****/
                HttpResponseMessage httpResponseTipoOperacion = await httpClient.GetAsync($"Varios/TipoOperacion");
                string TipoOperacionToString = await httpResponseTipoOperacion.Content.ReadAsStringAsync();
                TipoOperacionList = JsonConvert.DeserializeObject<List<TipoOperacion>>(TipoOperacionToString);

                /****MOV EXCEP 1 Y 2*****/
                HttpResponseMessage httpResponseMovimientosExcepcion1y2 = await httpClient.GetAsync($"Varios/MovimientosExcepcion1y2");
                string MovimientosExcepcion1y2ToString = await httpResponseMovimientosExcepcion1y2.Content.ReadAsStringAsync();
                MovimientosExcepcion1y2List = JsonConvert.DeserializeObject<List<MovimientosExcepcion1y2>>(MovimientosExcepcion1y2ToString);

                /****MOV EXCEP 3*****/
                HttpResponseMessage httpResponseMovimientosExcepcion3 = await httpClient.GetAsync($"Varios/MovimientosExcepcion3");
                string MovimientosExcepcion3ToString = await httpResponseMovimientosExcepcion3.Content.ReadAsStringAsync();
                MovimientosExcepcion3List = JsonConvert.DeserializeObject<List<MovimientosExcepcion3>>(MovimientosExcepcion3ToString);

                /****TRAB AFECTA IESS*****/
                HttpResponseMessage httpResponseTrabaAfectaIESS = await httpClient.GetAsync($"Varios/TrabaAfectaIESS");
                string TrabaAfectaIESSToString = await httpResponseTrabaAfectaIESS.Content.ReadAsStringAsync();
                TrabaAfectaIESSList = JsonConvert.DeserializeObject<List<TrabaAfectaIESS>>(TrabaAfectaIESSToString);

                /****TRAB AFECTA IMP RENTA*****/
                HttpResponseMessage httpResponseTrabAfecImpuestoRenta = await httpClient.GetAsync($"Varios/TrabAfecImpuestoRenta");
                string TrabAfecImpuestoRentaToString = await httpResponseTrabAfecImpuestoRenta.Content.ReadAsStringAsync();
                TrabAfecImpuestoRentaList = JsonConvert.DeserializeObject<List<TrabAfecImpuestoRenta>>(TrabAfecImpuestoRentaToString);

                MovimientoPlanillaList[0].TipoOperacionList = TipoOperacionList.OrderBy(to => to.CodigoTipooperacion).ToList();
                MovimientoPlanillaList[0].MovimientosExcepcion1y2List = MovimientosExcepcion1y2List;
                MovimientoPlanillaList[0].MovimientosExcepcion3List = MovimientosExcepcion3List;
                MovimientoPlanillaList[0].TrabajoAfectaIessList = TrabaAfectaIESSList.OrderBy(to => to.DesripMovimientoExce).ToList(); ;
                MovimientoPlanillaList[0].TrabAfecImpuestoRentaList = TrabAfecImpuestoRentaList.OrderBy(to => to.DesripMovimientoExce).ToList(); ;

                foreach (var movimiento in MovimientoPlanillaList)
                {
                    /************** M O V I M I E N T O S ***************/

                    if (movimiento.MovimientoExcepcion1 == " ")
                        movimiento.MovimientoExcepcion1API = "Sin Excep.";
                    else
                        movimiento.MovimientoExcepcion1API = movimiento.MovimientoExcepcion1;

                    if (movimiento.MovimientoExcepcion2 == " ")
                        movimiento.MovimientoExcepcion2API = "Sin Excep.";
                    else
                        movimiento.MovimientoExcepcion2API = movimiento.MovimientoExcepcion2;

                    if (movimiento.MovimientoExcepcion3 == " ")
                        movimiento.MovimientoExcepcion3API = "Sin Excep.";
                    else
                        movimiento.MovimientoExcepcion3API = movimiento.MovimientoExcepcion3;

                    /************ A F E C T A     Y    A P L I C A**************/

                    if (movimiento.Aplica_iess == " ")
                        movimiento.Aplica_iessAPI = "No Especif.";
                    else
                        movimiento.Aplica_iessAPI = movimiento.Aplica_iess;

                    if (movimiento.Aplica_imp_renta == " ")
                        movimiento.Aplica_imp_rentaAPI = "No Especif.";
                    else
                        movimiento.Aplica_imp_rentaAPI = movimiento.Aplica_imp_renta;

                    if (movimiento.Empresa_Afecta_Iess == " ")
                        movimiento.Empresa_Afecta_IessAPI = "No Especif.";
                    else
                        movimiento.Empresa_Afecta_IessAPI = movimiento.Empresa_Afecta_Iess;

                }

                return MovimientoPlanillaList;
            }
            catch (Exception ex)
            {
                return new List<MovimientoPlanilla>();
            }
        }

        public async Task<List<MovimientoPlanilla>> GetMovimientosPlantillaByName(string name)
        {
            try
            {
                HttpResponseMessage httpResponse = await httpClient.GetAsync($"Varios/MovimientoPlanillaSearch?Concepto={name}");
                string content = await httpResponse.Content.ReadAsStringAsync();
                MovimientoPlanillaList = JsonConvert.DeserializeObject<List<MovimientoPlanilla>>(content);

                HttpResponseMessage httpResponseTipoOperacion = await httpClient.GetAsync($"Varios/TipoOperacion");
                string TipoOperacionToString = await httpResponseTipoOperacion.Content.ReadAsStringAsync();
                TipoOperacionList = JsonConvert.DeserializeObject<List<TipoOperacion>>(TipoOperacionToString);

                /****MOV EXCEP 1 Y 2*****/
                HttpResponseMessage httpResponseMovimientosExcepcion1y2 = await httpClient.GetAsync($"Varios/MovimientosExcepcion1y2");
                string MovimientosExcepcion1y2ToString = await httpResponseMovimientosExcepcion1y2.Content.ReadAsStringAsync();
                MovimientosExcepcion1y2List = JsonConvert.DeserializeObject<List<MovimientosExcepcion1y2>>(MovimientosExcepcion1y2ToString);

                /****MOV EXCEP 3*****/
                HttpResponseMessage httpResponseMovimientosExcepcion3 = await httpClient.GetAsync($"Varios/MovimientosExcepcion3");
                string MovimientosExcepcion3ToString = await httpResponseMovimientosExcepcion3.Content.ReadAsStringAsync();
                MovimientosExcepcion3List = JsonConvert.DeserializeObject<List<MovimientosExcepcion3>>(MovimientosExcepcion3ToString);

                /****TRAB AFECTA IESS*****/
                HttpResponseMessage httpResponseTrabaAfectaIESS = await httpClient.GetAsync($"Varios/TrabaAfectaIESS");
                string TrabaAfectaIESSToString = await httpResponseTrabaAfectaIESS.Content.ReadAsStringAsync();
                TrabaAfectaIESSList = JsonConvert.DeserializeObject<List<TrabaAfectaIESS>>(TrabaAfectaIESSToString);

                /****TRAB AFECTA IMP RENTA*****/
                HttpResponseMessage httpResponseTrabAfecImpuestoRenta = await httpClient.GetAsync($"Varios/TrabAfecImpuestoRenta");
                string TrabAfecImpuestoRentaToString = await httpResponseTrabAfecImpuestoRenta.Content.ReadAsStringAsync();
                TrabAfecImpuestoRentaList = JsonConvert.DeserializeObject<List<TrabAfecImpuestoRenta>>(TrabAfecImpuestoRentaToString);

                MovimientoPlanillaList[0].TipoOperacionList = TipoOperacionList.OrderBy(to => to.CodigoTipooperacion).ToList();
                MovimientoPlanillaList[0].MovimientosExcepcion1y2List = MovimientosExcepcion1y2List;
                MovimientoPlanillaList[0].MovimientosExcepcion3List = MovimientosExcepcion3List;
                MovimientoPlanillaList[0].TrabajoAfectaIessList = TrabaAfectaIESSList.OrderBy(to => to.DesripMovimientoExce).ToList(); ;
                MovimientoPlanillaList[0].TrabAfecImpuestoRentaList = TrabAfecImpuestoRentaList.OrderBy(to => to.DesripMovimientoExce).ToList(); ;

                return MovimientoPlanillaList;
            }
            catch (Exception)
            {
                return new List<MovimientoPlanilla>();
            }
        }

        public async Task<bool> CreateMovimientoPlanilla(MovimientoPlanilla movimiento)
        {
            try
            {
                string requestUrl = $"Varios/MovimientoPlanillaInsert?conceptos={movimiento.Concepto}&prioridad={movimiento.Prioridad}&tipooperacion={movimiento.TipoOperacion}&cuenta1={movimiento.Cuenta1}&cuenta2={movimiento.Cuenta2}&cuenta3={movimiento.Cuenta3}&cuenta4={movimiento.Cuenta4}&MovimientoExcepcion1={movimiento.MovimientoExcepcion1}&MovimientoExcepcion2={movimiento.MovimientoExcepcion2}&MovimientoExcepcion3={movimiento.MovimientoExcepcion3}&Traba_Aplica_iess={movimiento.Aplica_iess}&Traba_Proyecto_imp_renta={movimiento.Aplica_imp_renta}&Aplica_Proy_Renta={movimiento.Aplica_imp_renta}&Empresa_Afecta_Iess={movimiento.Empresa_Afecta_Iess}";
                HttpResponseMessage httpResponse = await httpClient.PostAsync(requestUrl, null);

                if (httpResponse.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateMovimientoPlanilla(MovimientoPlanilla movimiento)
        {
            try
            {
                string requestUrl = $"Varios/MovimientoPlanillaUpdate?codigoplanilla={movimiento.CodigoConcepto}&conceptos={movimiento.Concepto}&prioridad={movimiento.Prioridad}&tipooperacion={movimiento.TipoOperacion}&cuenta1={movimiento.Cuenta1}&cuenta2={movimiento.Cuenta2}&cuenta3={movimiento.Cuenta3}&cuenta4={movimiento.Cuenta4}&MovimientoExcepcion1={movimiento.MovimientoExcepcion1}&MovimientoExcepcion2={movimiento.MovimientoExcepcion2}&MovimientoExcepcion3={movimiento.MovimientoExcepcion3}&Traba_Aplica_iess={movimiento.Aplica_iess}&Traba_Proyecto_imp_renta={movimiento.Aplica_imp_renta}&Aplica_Proy_Renta={movimiento.Aplica_imp_renta}&Empresa_Afecta_Iess={movimiento.Empresa_Afecta_Iess}";
                HttpResponseMessage httpResponse = await httpClient.GetAsync(requestUrl);

                if (httpResponse.IsSuccessStatusCode)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<string> DeleteMovimientoPlanilla(MovimientoPlanilla movimiento)
        {
            try
            {
                HttpResponseMessage httpResponseMovimientoPlanilla = await httpClient.GetAsync($"Varios/MovimeintoPlanillaDelete?codigomovimiento={movimiento.CodigoConcepto}&descripcionomovimiento={movimiento.Concepto}");
                if (httpResponseMovimientoPlanilla.IsSuccessStatusCode)
                {
                    string MovPlantToString = await httpResponseMovimientoPlanilla.Content.ReadAsStringAsync();
                    MovimientoPlanillaList  = JsonConvert.DeserializeObject<List<MovimientoPlanilla>>(MovPlantToString);

                    
                    return MovimientoPlanillaList[0].Concepto;
                }
                else
                {
                    return "Ha ocurrido un error en el servidor";
                }
            }
            catch (Exception ex)
            {
                return "Ha ocurrido un error inesperado";
            }
        }


        public async Task GetGeneros()
        {

        }
    }
}
