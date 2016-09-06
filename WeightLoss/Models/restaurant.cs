using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeightLoss.Models
{
    public class restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City{ get; set; }
        public string Country { get; set; }
        public ICollection<RestaurantReview> Reviews { get; set; }

    }
}