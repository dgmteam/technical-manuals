using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;

namespace OpenIdProvider.Data
{
    public class IdServerConfig
    {
        public static List<IdentityResource> IdentityResources = new List<IdentityResource>()
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email(),
        };
        
        public static IList<Client> Clients = new List<Client>()
        {
            new Client()
            {
                // Provide client_id and client_secret to everlearn
                ClientId = "everlearn",
                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                },
                AllowedScopes =
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    IdentityServerConstants.StandardScopes.OfflineAccess,
                    IdentityServerConstants.StandardScopes.Email,
                },
                AllowedGrantTypes = GrantTypes.Code,
                RedirectUris =
                {
                    "https://id.everlearn.vn/signin-oauth/tenant",
                    "http://localhost:5015/signin-oauth/tenant"
                },
                RequirePkce = false
            }
        };

        public static IEnumerable<ApiResource> ApiResources = new List<ApiResource>()
        {
            new ApiResource("ap1")
            {
                Scopes = {"api.1"}
            }
        };
    }
}