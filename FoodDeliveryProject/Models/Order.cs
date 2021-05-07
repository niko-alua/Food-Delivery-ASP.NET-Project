using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryProject.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserAddressID { get; set; }
        public int PlaceID { get; set; }
        public DateTime OrderDate { get; set; }

        public UserAddress UserAddress { get; set; }
        public Place Place { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
