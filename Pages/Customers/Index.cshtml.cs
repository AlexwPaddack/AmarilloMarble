using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AmarilloMarble.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AmarilloMarble.Pages.Customers
{
    public class IndexModel : PageModel
    {
        public IList<Customer> Customer { get; set; }

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}
        public SelectList SortList {get; set;}
        [BindProperty(SupportsGet = true)]
        public string SearchString {get; set;}
        
        private readonly AmarilloMarble.Models.CustomerDbContext _context;

        public IndexModel(AmarilloMarble.Models.CustomerDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customers { get;set; }

        public async Task OnGetAsync()
        {
            var customers = from m in _context.Customer
                            select m;
            if(!string.IsNullOrEmpty(SearchString))
            {
                customers = customers.Where(c => c.CustomerFirstName.Contains(SearchString));
            }
            var query = _context.Customer.Select(c => c);
            List<SelectListItem> sortItems = new List<SelectListItem> {
                new SelectListItem { Text = "First Name Ascending", Value = "first_asc" },
                new SelectListItem { Text = "First Name Descending", Value = "first_desc"}
            };
            SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);

            switch (CurrentSort)
            {
                case "first_asc": 
                    query = query.OrderBy(c => c.CustomerFirstName);
                    break;

                case "first_desc":
                    query = query.OrderByDescending(c => c.CustomerLastName);
                    break;

            }

            Customers = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
