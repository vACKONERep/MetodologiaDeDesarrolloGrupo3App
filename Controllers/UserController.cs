using MetodologiaDeDesarrolloGrupo3App.Authentication;
using MetodologiaDeDesarrolloGrupo3App.Models.Emisor;
using MetodologiaDeDesarrolloGrupo3App.Models.Users;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MetodologiaDeDesarrolloGrupo3App.Controllers
{
    public class UserController : Controller
    {
        HttpClient httpClient;
        public UserController()
        {
            //Ignorar errores de SSL al realizar peticiones a HTTP/HTTPS
            httpClient = new HttpClient(new HttpClientHandler() { ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }, }, false);
            httpClient.Timeout = TimeSpan.FromSeconds(7);
            httpClient.BaseAddress = new Uri("http://apiservicios.ecuasolmovsa.com:3009/api/");
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<Usuario> GetUserByModel(string UserName, string Password, int SelectedProvince)
        {
            try
            {
                Usuario usuario = new Usuario();
                HttpResponseMessage httpResponse = await httpClient.GetAsync($"Usuarios?usuario={UserName}&password={Password}");

                string content = await httpResponse.Content.ReadAsStringAsync();

                if (content.Contains("error"))
                {
                    usuario.Observacion = "ERROR";
                    return usuario;
                }

                List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(content);

                if (usuarios != null)
                {
                    usuario = usuarios.FirstOrDefault();

                    foreach (var property in typeof(Usuario).GetProperties())
                    {
                        if (property.PropertyType == typeof(string))
                        {
                            var currentValue = property.GetValue(usuario) as string;

                            if (currentValue != null)
                            {
                                property.SetValue(usuario, currentValue.Trim());
                            }
                        }
                    }
                    return usuario;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
