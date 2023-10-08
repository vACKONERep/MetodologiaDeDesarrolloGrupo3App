using MetodologiaDeDesarrolloGrupo3App.Models.Users;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Security.Claims;

namespace MetodologiaDeDesarrolloGrupo3App.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ProtectedSessionStorage _sessionStorage;
        private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());

        public CustomAuthenticationStateProvider(ProtectedSessionStorage sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var userSessionStorageResult = await _sessionStorage.GetAsync <Usuario>("Usuario");
                var usuario = userSessionStorageResult.Success ? userSessionStorageResult.Value : null;

                if (usuario == null)
                    return await Task.FromResult(new AuthenticationState(_anonymous));

                var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usuario.UserName),
                    new Claim(ClaimTypes.PrimarySid, usuario.Compania.ToString()),
                    new Claim(ClaimTypes.GroupSid, usuario.Emisor.ToString()),
                    new Claim(ClaimTypes.Hash, usuario.Password)
                }, "CustomAuth"));
                return await Task.FromResult(new AuthenticationState(claimsPrincipal));
            }
            catch
            {
                return await Task.FromResult(new AuthenticationState(_anonymous));
            }
        }

        public async Task UpdateAuthenticationState(Usuario? usuario)
        {
            ClaimsPrincipal claimsPrincipal;

            if(usuario != null)
            {
                await _sessionStorage.SetAsync("Usuario", usuario);
                claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usuario.UserName),
                    new Claim(ClaimTypes.PrimarySid, usuario.Compania.ToString()),
                    new Claim(ClaimTypes.GroupSid, usuario.Emisor.ToString()),
                    new Claim(ClaimTypes.Hash, usuario.Password)
                }));
            }
            else
            {
                await _sessionStorage.DeleteAsync("Usuario");
                claimsPrincipal = _anonymous;
            }

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }
    }
}
