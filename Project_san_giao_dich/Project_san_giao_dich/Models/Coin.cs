using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_san_giao_dich.Models
{
    public class Coin
    {
        public int id { get; set; }
        [Required]
        [DisplayName("Name Coin")]
        public string NameCoin { get; set; }
        [Required]
        public string BaseAsset { get; set; }
        [Required]
        public string QuoteAsset { get; set; }
        [Required]
        public double LastPrice { get; set; }
        [Required]
        public double Volumn24h { get; set; }

        [Required]
        public int MarketId { get; set; }
        public virtual Market Market { get; set; }

        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }


    }
}