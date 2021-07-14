using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateManager.Models
{
    public class Listing
    {
        public int Id { get; set; }

        public string ListingName { get; set; }

        public decimal ListingPrice { get; set; }

        public bool IsAvailable { get; set; }

        public DateTime PostedDate { get; set; }

        public decimal AreaSqFt { get; set; }

    }
}
