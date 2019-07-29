using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using yuvap.Data;
using yuvap.Models;

namespace yuvap.Pages.YP.pBoy
{
    public class EditModel : PageModel
    {
        private readonly yuvap.Data.YPContext _context;

        public EditModel(yuvap.Data.YPContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Boy Boy { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Boy = await _context.Boy.FirstOrDefaultAsync(m => m.BoyID == id);

            if (Boy == null)
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

            _context.Attach(Boy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BoyExists(Boy.BoyID))
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

        private bool BoyExists(int id)
        {
            return _context.Boy.Any(e => e.BoyID == id);
        }
    }
}
