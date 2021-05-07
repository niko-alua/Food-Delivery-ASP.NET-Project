using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FoodDeliveryProject.Models
{
    public class Place
    {
        public int PlaceID { get; set; }
        public string TypeName { get; set; }
        public string Name { get; set; }
        [StringLength(512)]
        public string Description { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }
        public double MinOrderPrice { get; set; }
        public double DeliveryPriceFrom { get; set; }
        public double DeliveryPriceTo { get; set; }
        public double Rating { get; set; }

        public IdentityUser IdentityUser { get; set; }
        public ICollection<Item> Items { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
