using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeightLoss.Models
{
    public class RestaurantReview
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int rating { get; set; }
    }
}