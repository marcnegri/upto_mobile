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

            auth.Completed += (sender, eventArgs) => {
                // We presented the UI, so it's up to us to dimiss it on iOS.
                //DismissViewController(true, null);

                if (eventArgs.IsAuthenticated)
                {
                    // Use eventArgs.Account to do wonderful things
                }
                else
                {
                    // The user cancelled
                }
            };
        }

        public void TwitterLogin()
        {

        }

        public void GoogleLogin()
        {

        }
    }
}
