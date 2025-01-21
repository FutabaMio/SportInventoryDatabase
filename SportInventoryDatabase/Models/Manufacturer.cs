using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInventoryDatabase.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        // Связь с таблицей Goods
        //public List<Goods> Goods { get; set; }
    }

}
