using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInventoryDatabase.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Dealer { get; set; }

        // Связь с таблицей Goods
        //public int GoodsId { get; set; }
        //public Goods Goods { get; set; }
    }

}
