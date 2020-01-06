using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_san_giao_dich.Models
{
    public class Market
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Market Name")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
       
        public DateTime? CreatedAt { get; set; }
     
        public DateTime? UpdatedAt { get; set; }
        public virtual ICollection<Coin> Coins{ get; set; }


        [Required]
        public status Status { get; set; }
        public enum status
        {
            Active = 0, Delete = 1, Deactive = -1
        }
    }
}