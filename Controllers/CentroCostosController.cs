using MetodologiaDeDesarrolloGrupo3App.Models.CentroCostos;
using MetodologiaDeDesarrolloGrupo3App.Models.Emisor;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data.SqlTypes;
using System.Text;

namespace MetodologiaDeDesarrolloGrupo3App.Controllers
{
    public class CentroCostosController : Controller
    {
        HttpClient httpClient;
        public CentroCostosController()
        {
            //Ignorar errores de SSL al realizar peticiones a HTTP/HTTPS
            httpClient = new HttpClient(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }, }, false);
            httpClient.Timeout = TimeSpan.FromSeconds(7);
            httpClient.BaseAddress = new Uri("http://apiservicios.ecuasolmovsa.com:3009/api/");
        } 

        public async Task<List<CentroCostos>> GetCentrosCostos()
        {
            try
            {
                HttpResponseMessage httpResponse = await httpClient.GetAsync($"Varios/CentroCostosSelect");

                string content = await httpResponse.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<CentroCostos>>(content);
            }
            catch (Exception)
            {
                return new List<CentroCostos>();
            }
        }

        public async Task<List<CentroCostos>> GetCentrosCostosByName(string name)
        {
            try
            {
                HttpResponseMessage httpResponse = await httpClient.GetAsync($"Varios/CentroCostosSearch?descripcioncentrocostos={name}");

                string content = await httpResponse.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<CentroCostos>>(content);
            }
            catch (Exception)
            {
                return new List<CentroCostos>();
            }
        }

        public async Task<bool> CreateCentrosCostos(CentroCostos centroCostosToCreate)
        {
            try
            {
                HttpResponseMessage httpResponse = await httpClient.PostAsync($"Varios/CentroCostosInsert?codigocentrocostos={centroCostosToCreate.Codigo}&descripcioncentrocostos={centroCostosToCreate.NombreCentroCostos}", null);

                if (httpResponse.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateCentrosCostos(CentroCostos centroCostosToUpdate)
        {
            try
            {
                HttpResponseMessage httpResponse = await httpClient.GetAsync($"Varios/CentroCostosUpdate?codigocentrocostos={centroCostosToUpdate.Codigo}&descripcioncentrocostos={centroCostosToUpdate.NombreCentroCostos}");

                if (httpResponse.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteCentrosCostos(CentroCostos CentroCostosToDelete)
        {
            try
            {
                HttpResponseMessage httpResponse = await httpClient.GetAsync($"Varios/CentroCostosDelete?codigocentrocostos={CentroCostosToDelete.Codigo}&descripcioncentrocostos={CentroCostosToDelete.NombreCentroCostos}");

                string content = await httpResponse.Content.ReadAsStringAsync();

                if (httpResponse.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
