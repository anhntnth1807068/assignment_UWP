using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using Project_san_giao_dich.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Project_san_giao_dich.App_Start.IdentityConfig;

namespace Project_san_giao_dich
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<Project_san_giao_dichContext>(Project_san_giao_dichContext.Create);
            app.CreatePerOwinContext<MyUserManager>(MyUserManager.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });
        }
    }
}