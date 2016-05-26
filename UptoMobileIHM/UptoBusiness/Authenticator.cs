using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Auth;

namespace UptoBusiness
{
    public class Authenticator
    {
        public void FacebookLogin() {
        var auth = new OAuth2Authenticator(
            clientId: "222535738090638",
            scope: "",
            authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
            redirectUrl: new Uri("http://www.facebook.com/connect/login_success.html"));
        }

        public void TwitterLogin()
        {

        }

        public void GoogleLogin()
        {

        }
    }
}
