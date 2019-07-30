using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using yuvap.Models;

namespace yuvap.Pages.YP.pBoyLikes
{
    public class EditModel : PageModel
    {
        private readonly yuvap.Models.YPContext _context;

        public EditModel(yuvap.Models.YPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BoyLikes BoyLikes { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BoyLikes = await _context.BoyLikes
                .Include(b => b.BoyPrefersNavigation)
                .Include(b => b.Boys).FirstOrDefaultAsync(m => m.BoyId == id);

            if (BoyLikes == null)
            {
                return NotFound();
            }
           ViewData["BoyPrefers"] = new SelectList(_context.Girl, "GirlId", "GirlId");
           ViewData["BoyId"] = new SelectList(_context.Boy, "BoyId", "BoyId");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BoyLikes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BoyLikesExists(BoyLikes.BoyId))
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

        private bool BoyLikesExists(int id)
        {
            return _context.BoyLikes.Any(e => e.BoyId == id);
        }
    }
}
