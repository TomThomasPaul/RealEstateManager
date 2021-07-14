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
    public class DetailsModel : PageModel
    {
        private readonly RealEstateManager.Data.RealEstateManagerContext _context;

        public DetailsModel(RealEstateManager.Data.RealEstateManagerContext context)
        {
            _context = context;
        }

        public Listing Listing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Listing = await _context.Listing.FirstOrDefaultAsync(m => m.Id == id);

            if (Listing == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
