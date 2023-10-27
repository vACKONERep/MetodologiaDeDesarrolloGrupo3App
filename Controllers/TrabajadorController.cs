using MetodologiaDeDesarrolloGrupo3App.Models.Emisor;
using MetodologiaDeDesarrolloGrupo3App.Models.Trabajador;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MetodologiaDeDesarrolloGrupo3App.Controllers
{
    public class TrabajadorController : Controller
    {
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
                HttpResponseMessage httpResponse = await httpClient.GetAsync($"Varios/TrabajadorSelect?sucursal="+ CODIGO_EMISOR);

                string content = await httpResponse.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<Trabajador>>(content);
            }
            catch (Exception)
            {
                return new List<Trabajador>();
            }
        }
    }
}
