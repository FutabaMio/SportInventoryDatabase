using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInventoryDatabase.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }

        // Связь с таблицей Goods
        //public int GoodsId { get; set; }
        //public Goods Goods { get; set; }
    }


}
