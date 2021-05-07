using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FoodDeliveryProject.Models
{
    public class UserAddress
    {
        public int UserAddressID { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public IdentityUser IdentityUser { get; set; }
    }
}
