﻿using System;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

//[assembly: OwinStartup(typeof(XJFWebApi.Franework.Startup))]

namespace XJFWebApi.Franework
{
    //public class Startup
    //{
    //    public void Configuration(IAppBuilder app)
    //    {
    //        HttpConfiguration config = new HttpConfiguration();
    //        ConfigureOAuth(app);

    //        WebApiConfig.Register(config);
    //        app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
    //        app.UseWebApi(config);
    //    }

    //    public void ConfigureOAuth(IAppBuilder app)
    //    {
    //        OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
    //        {
    //            AllowInsecureHttp = true,
    //            TokenEndpointPath = new PathString("/token"),
    //            AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
    //            Provider = new SimpleAuthorizationServerProvider()
    //        };
    //        app.UseOAuthAuthorizationServer(OAuthServerOptions);
    //        app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
    //    }
    //}

    ///// <summary>
    ///// Token验证
    ///// </summary>
    //public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    //{
    //    public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
    //    {
    //        await Task.Factory.StartNew(() => context.Validated());
    //    }

    //    public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
    //    {
    //        await Task.Factory.StartNew(() => context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" }));
    //        /*
    //         * 对用户名、密码进行数据校验
    //        using (AuthRepository _repo = new AuthRepository())
    //        {
    //            IdentityUser user = await _repo.FindUser(context.UserName, context.Password);

    //            if (user == null)
    //            {
    //                context.SetError("invalid_grant", "The user name or password is incorrect.");
    //                return;
    //            }
    //        }*/

    //        var identity = new ClaimsIdentity(context.Options.AuthenticationType);
    //        identity.AddClaim(new Claim("sub", context.UserName));
    //        identity.AddClaim(new Claim("role", "user"));

    //        context.Validated(identity);

    //    }
    //}
}