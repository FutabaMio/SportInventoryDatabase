using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInventoryDatabase.Models
{
    public class Goods
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        // Связь с таблицей Manufacturer
        //public int ManufacturerId { get; set; }
        //public Manufacturer Manufacturer { get; set; }

        public int Count { get; set; }
        public decimal Price { get; set; }

        // Связь с таблицей User
        //public List<User> Users { get; set; }

        // Связь с таблицей Shop
        //public List<Shop> Shops { get; set; }
    }

}
