using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Project_san_giao_dich.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_san_giao_dich.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AccountRolesController : Controller
    {
        private Project_san_giao_dichContext dbContext = new Project_san_giao_dichContext();
        private RoleManager<AccountRole> roleManager;

        public AccountRolesController()
        {
            RoleStore<AccountRole> roleStore = new RoleStore<AccountRole>(dbContext);
            roleManager = new RoleManager<AccountRole>(roleStore);
        }
        // GET: AccountRoles
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Store(string name)
        {
            var role = new AccountRole()
            {
                Name = name,
                CreatedAt = DateTime.Now
            };
            var result = roleManager.Create(role);
            return View("Create");
        }
    }
}