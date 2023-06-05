using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrantFoods.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public string UserName { get; set; }
        public decimal TotalCost { get; set; }

    }
}
