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
    public class IndexModel : PageModel
    {
        private readonly AmarilloMarble.Models.CustomerDbContext _context;

        public IndexModel(AmarilloMarble.Models.CustomerDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
