using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotNetOpenAuth.GoogleOAuth2;
using Microsoft.AspNet.Membership.OpenAuth;

namespace GoogleOAuthDemo
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            GoogleOAuth2Client clientGoog = new GoogleOAuth2Client("303346449770-56juh8bkbe3pbghj8mu21ek9c82jajh4.apps.googleusercontent.com", "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");
            IDictionary<string, string> extraData = new Dictionary<string, string>();            
            OpenAuth.AuthenticationClients.Add("google", () => clientGoog, extraData);
        }
    }
}
