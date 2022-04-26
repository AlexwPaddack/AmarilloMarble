using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AmarilloMarble.Models;

namespace AmarilloMarble.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly AmarilloMarble.Models.CustomerDbContext _context;

        public DetailsModel(AmarilloMarble.Models.CustomerDbContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.Include(c => c.Jobs).FirstOrDefaultAsync(m => m.CustomerId == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
