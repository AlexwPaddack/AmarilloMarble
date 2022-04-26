using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using AmarilloMarble.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AmarilloMarble.Pages
{
    public class AddJobModel : PageModel
    {
        private readonly ILogger<AddJobModel> _logger;
        private readonly CustomerDbContext _context; // Customer Database context
        [BindProperty]
        public Job Job {get; set;}
        public SelectList CustomersDropDown {get; set;}

        public AddJobModel(CustomerDbContext context, ILogger<AddJobModel> logger)
        {
            // Bring in Database context and logger using dependency injection
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            CustomersDropDown = new SelectList(_context.Customer.ToList(), "CustomerId", "CustomerFirstName CustomerLastName");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Job.Add(Job);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}