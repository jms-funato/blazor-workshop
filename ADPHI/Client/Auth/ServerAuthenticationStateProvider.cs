using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using ADPHI.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace ADPHI.Client.Auth
{
    //public class ServerAuthenticationStateProvider : AuthenticationStateProvider
    //{
    //    private readonly HttpClient _httpClient;

    //    public ServerAuthenticationStateProvider(HttpClient httpClient)
    //    {
    //        _httpClient = httpClient;
    //    }

    //    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    //    {
    //        var userInfo = await _httpClient.GetJsonAsync<UserInfo>("user");

    //        var identity = userInfo.IsAuthenticated
    //            ? new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, userInfo.Name) }, "serverauth")
    //            : new ClaimsIdentity();

    //        return new AuthenticationState(new ClaimsPrincipal(identity));
    //    }
    //}
}
