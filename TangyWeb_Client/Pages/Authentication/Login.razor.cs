using Microsoft.AspNetCore.Components;
using System.Web;
using Tangy_Models;
using TangyWeb_Client.Serivce.IService;

namespace TangyWeb_Client.Pages.Authentication
{
    public partial class Login
    {
        private SignInRequestDTO SignInRequest = new();
        public bool IsProcessing { get; set; } = false;
        public bool ShowSignInErrors { get; set; }
        public string Errors { get; set; }

        [Inject]
        public IAuthenticationService _authSerivce { get; set; }
        [Inject]
        public NavigationManager _navigationManager { get; set; }
        public string ReturnUrl { get; set; }
        private async Task LoginUser()
        {
            ShowSignInErrors=false;
            IsProcessing=true;
            var result = await _authSerivce.Login(SignInRequest);
            if (result.IsAuthSuccessful)
            {
                //regiration is successful
                var absoluteUri = new Uri(_navigationManager.Uri);
                var queryParam = HttpUtility.ParseQueryString(absoluteUri.Query);
                ReturnUrl = queryParam["returnUrl"];
                if (string.IsNullOrEmpty(ReturnUrl))
                {
                    _navigationManager.NavigateTo("/");
                }
                else
                {
                    _navigationManager.NavigateTo("/" + ReturnUrl);
                }
            }
            else
            {
                //failure
                Errors=result.ErrorMessage;
                ShowSignInErrors=true;

            }
            IsProcessing=false;
        }
    }
}
