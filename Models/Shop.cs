using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SIS222.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string MarketName { get; set; }
        public decimal MarketCost { get; set; }
        public string MarketType { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataBuy { get; set; }
    }
}
