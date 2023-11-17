using MetodologiaDeDesarrolloGrupo3App.Models.CentroCostos;
using MetodologiaDeDesarrolloGrupo3App.Models.Nomina;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace MetodologiaDeDesarrolloGrupo3App.Controllers
{
    public class NominaController : Controller
    {
        HttpClient httpClient;
        public NominaController()
        {
            //Ignorar errores de SSL al realizar peticiones a HTTP/HTTPS
            httpClient = new HttpClient(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }, }, false);
            httpClient.Timeout = TimeSpan.FromSeconds(7);
            httpClient.BaseAddress = new Uri("http://apiservicios.ecuasolmovsa.com:3009/api/");
        }

        public async Task<List<GestionCuentaContableNomina>> GetNomina(int sucursal)
        {
            try
            {
                HttpResponseMessage httpResponse = await httpClient.GetAsync($"Varios/Gestion_Cuenta_Contable_Nomina_Select?Sucursal={sucursal}");

                string content = await httpResponse.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<GestionCuentaContableNomina>>(content);
            }
            catch (Exception)
            {
                return new List<GestionCuentaContableNomina>();
            }
        }

        public async Task<List<GestionCuentaContableNomina>> GetNominaByName(string nominaToSearch)
        {
            try
            {
                HttpResponseMessage httpResponse = await httpClient.GetAsync($"Varios/");

                string content = await httpResponse.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<GestionCuentaContableNomina>>(content);
            }
            catch (Exception)
            {
                return new List<GestionCuentaContableNomina>();
            }
        }

        public async Task<bool> CreateNomina(GestionCuentaContableNomina nominaToCreate)
        {
            try
            {
                HttpResponseMessage httpResponse = await httpClient.PostAsync($"Varios/GestionContableNominaInsert?Sucursal={nominaToCreate.Sucursal}&CodigoConceptoNomina={nominaToCreate.CodigoConceptoNomina}&CodigoCategoOcupacional={nominaToCreate.CodigoCategoriaocupacional}&CodigoOperacion={nominaToCreate.CodigoOperacion}&CodigoCuenta={nominaToCreate.CodigoCuentaContable}&CodigoTipocuenta={nominaToCreate.CodigoTipoCuenta}", null);

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

        public async Task<bool> UpdateNomina(GestionCuentaContableNomina nominaToUpdate)
        {
            try
            {
                HttpResponseMessage httpResponse = await httpClient.GetAsync($"Varios/");

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

        public async Task<bool> DeleteNomina(GestionCuentaContableNomina nominaToDelete)
        {
            try
            {
                HttpResponseMessage httpResponse = await httpClient.PostAsync($"Varios/GestionContableNominaDelete?Sucursal={nominaToDelete.Sucursal}&CodigoConceptoNomina={nominaToDelete.CodigoConceptoNomina}&CodigoCategoOcupacional={nominaToDelete.CodigoCategoriaocupacional}&CodigoOperacion={nominaToDelete.CodigoOperacion}&CodigoCuenta={nominaToDelete.CodigoCuentaContable}&CodigoTipocuenta={nominaToDelete.CodigoTipoCuenta}", null);

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
