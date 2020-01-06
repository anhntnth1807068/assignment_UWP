using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project_san_giao_dich.Models
{
    public class Project_san_giao_dichContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Project_san_giao_dichContext() : base("name=Project_san_giao_dichContext")
        {
        }
        public static Project_san_giao_dichContext Create()
        {
            return new Project_san_giao_dichContext();
        }

        public System.Data.Entity.DbSet<Project_san_giao_dich.Models.Market> Markets { get; set; }

        public System.Data.Entity.DbSet<Project_san_giao_dich.Models.Coin> Coins { get; set; }
    }
}
