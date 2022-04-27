using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AmarilloMarble.Models;

namespace AmarilloMarble.Pages.Customers
{
    public class EditJobModel : PageModel
    {
        private readonly AmarilloMarble.Models.CustomerDbContext _context;

        public EditJobModel(AmarilloMarble.Models.CustomerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Job Job { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Job = await _context.Job.FirstOrDefaultAsync(m => m.JobId == id);

            if (Job == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Job = await _context.Job.FindAsync(id);

            if(Job != null)
            {
                _context.Attach(Job).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            //_context.Attach(Job).State = EntityState.Modified;

            /*try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobExists(Job.JobId))
                {
                    return NotFound();
                }
                else
                {
                    if (!JobExists(Job.JobId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }*/

            return RedirectToPage("./Index");
        }

        private bool JobExists(int id)
        {
            return _context.Job.Any(e => e.JobId == id);
        }
    }
}