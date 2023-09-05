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
            GoogleOAuth2Client clientGoog = new GoogleOAuth2Client("303346449770-nd40jvhmhk2ssgvvr8gecmj238ebh25j.apps.googleusercontent.com", "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");
            IDictionary<string, string> extraData = new Dictionary<string, string>();            
            OpenAuth.AuthenticationClients.Add("google", () => clientGoog, extraData);
        }
    }
}
