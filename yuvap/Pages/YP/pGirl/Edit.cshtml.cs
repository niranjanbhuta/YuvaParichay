using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using yuvap.Models;

namespace yuvap.Pages.YP.pGirl
{
    public class EditModel : PageModel
    {
        private readonly yuvap.Models.YPContext _context;

        public EditModel(yuvap.Models.YPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Girl Girl { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Girl = await _context.Girl.FirstOrDefaultAsync(m => m.GirlId == id);

            if (Girl == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Girl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GirlExists(Girl.GirlId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GirlExists(int id)
        {
            return _context.Girl.Any(e => e.GirlId == id);
        }
    }
}
