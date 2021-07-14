using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstateManager.Data;
using RealEstateManager.Models;

namespace RealEstateManager.Pages.Listings
{
    public class IndexModel : PageModel
    {
        private readonly RealEstateManager.Data.RealEstateManagerContext _context;

        public IndexModel(RealEstateManager.Data.RealEstateManagerContext context)
        {
            _context = context;
        }

        public IList<Listing> Listing { get;set; }

        public async Task OnGetAsync()
        {
            Listing = await _context.Listing.ToListAsync();
        }
    }
}
