﻿using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Project_san_giao_dich.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using static Project_san_giao_dich.App_Start.IdentityConfig;

namespace Project_san_giao_dich.Controllers
{
    public class AccountsController : Controller
    {
        private Project_san_giao_dichContext _dbContext;
        private MyUserManager _userManager;

        public AccountsController(Project_san_giao_dichContext dbContext, MyUserManager myUserManager)
        {
            _dbContext = dbContext;
            _userManager = myUserManager;
        }

        public ActionResult Index(string[] ids, string[] roleNames)
        {
            return View("Register");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            Account account = _userManager.Find(username, password);
            if (account == null)
            {
                return HttpNotFound();
            }
            // success
            var ident = _userManager.CreateIdentity(account, DefaultAuthenticationTypes.ApplicationCookie);
            //use the instance that has been created. 
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignIn(
                new AuthenticationProperties { IsPersistent = false }, ident);
            return Redirect("/Home");
        }


        // GET: Accounts
        public ActionResult Register()
        {
            Debug.WriteLine("Count product: " + _dbContext.Coins.ToList().Count);
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Store(string username, string password)
        {
            var account = new Account()
            {
                UserName = username,
                Email = username,
                FirstName = "Xuan Hung",
                LastName = "Dao",
                Avatar = "avatar",
                Birthday = DateTime.Now,
                CreatedAt = DateTime.Now
            };
            IdentityResult result = await _userManager.CreateAsync(account, password);
            if (result.Succeeded)
            {
                _userManager.AddToRole(account.Id, "User");

                // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                // Send an email with this link
                string code = await _userManager.GenerateEmailConfirmationTokenAsync(account.Id);
                await _userManager.SendEmailAsync(account.Id, "Hello world! Please confirm your account", "<b>Please confirm your account</b> by clicking <a href=\"http://google.com.vn\">here</a>");
                return RedirectToAction("Index", "Home");
            }

            return View("Register");
        }

        [Authorize]
        [HttpPost]
        public ActionResult Logout()
        {
            HttpContext.GetOwinContext().Authentication.SignOut();
            return Redirect("/Home");
        }
    }
}