using MetodologiaDeDesarrolloGrupo3App.Models.Emisor;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MetodologiaDeDesarrolloGrupo3App.Controllers
{
    public class EmisorController : Controller
    {
        HttpClient httpClient;
        public EmisorController()
        {
            //Ignorar errores de SSL al realizar peticiones a HTTP/HTTPS
            httpClient = new HttpClient(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }, }, false);
            httpClient.Timeout = TimeSpan.FromSeconds(7);
            httpClient.BaseAddress = new Uri("http://apiservicios.ecuasolmovsa.com:3009/api/");
        }

        public async Task<List<Emisor>> GetEmisorByCode(int code)
        {
            try
            {
                List<Emisor> listEmisor = await GetEmisores();

                return listEmisor.Where(e => e.Codigo == code).ToList();
            }
            catch (Exception)
            {
                return new List<Emisor>();
            }
        }

        public async Task<List<Emisor>> GetEmisores()
        {
            try
            {
                HttpResponseMessage httpResponse = await httpClient.GetAsync($"Varios/GetEmisor");

                string content = await httpResponse.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<Emisor>>(content);
            }
            catch (Exception)
            {
                return new List<Emisor>();
            }
        }
    }
}
