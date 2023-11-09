using MetodologiaDeDesarrolloGrupo3App.Models.Trabajador.TrabajadorFields;
using MetodologiaDeDesarrolloGrupo3App.Models.Trabajador.TrabajadorFileds;
using MetodologiaDeDesarrolloGrupo3App.Models.Trabajador;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MetodologiaDeDesarrolloGrupo3App.Models.MovimientoPlanilla;
using MetodologiaDeDesarrolloGrupo3App.Models.MovimientoPlanilla.MovimientoPlanillaFields;
using MetodologiaDeDesarrolloGrupo3App.Models.CentroCostos;

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

                MovimientoPlanillaList[0].TipoOperacionList = TipoOperacionList;
                MovimientoPlanillaList[0].MovimientosExcepcion1y2List = MovimientosExcepcion1y2List;
                MovimientoPlanillaList[0].MovimientosExcepcion3List = MovimientosExcepcion3List;

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

                return JsonConvert.DeserializeObject<List<MovimientoPlanilla>>(content);
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
                return true;
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
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteMovimientoPlanilla(MovimientoPlanilla movimiento)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }




    }
}
