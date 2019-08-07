using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using yuvap.Models;

namespace yuvap.Pages.YP.pGirlLikes
{
    public class EditModel : PageModel
    {
        private readonly yuvap.Models.YPContext _context;

        public EditModel(yuvap.Models.YPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GirlLikes GirlLikes { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GirlLikes = await _context.GirlLikes
                .Include(g => g.GirlPrefersNavigation)
                .Include(g => g.Girls).FirstOrDefaultAsync(m => m.GirlId == id);

            if (GirlLikes == null)
            {
                return NotFound();
            }
           ViewData["GirlPrefers"] = new SelectList(_context.Boy, "BoyId", "BoyId");
           ViewData["GirlId"] = new SelectList(_context.Girl, "GirlId", "GirlId");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(GirlLikes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GirlLikesExists(GirlLikes.GirlId))
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

        private bool GirlLikesExists(int id)
        {
            return _context.GirlLikes.Any(e => e.GirlId == id);
        }
    }
}
