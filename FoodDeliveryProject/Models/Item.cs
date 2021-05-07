using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryProject.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public int PlaceID { get; set; }
        public string Name { get; set; }
        [StringLength(512)]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }

        public Place Place { get; set; }
    }
}
