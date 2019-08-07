using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using yuvap.Models;

namespace yuvap.Pages.YP.pBoy
{
    public class DeleteModel : PageModel
    {
        private readonly yuvap.Models.YPContext _context;

        public DeleteModel(yuvap.Models.YPContext context)
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

            Boy = await _context.Boy.FirstOrDefaultAsync(m => m.BoyId == id);

            if (Boy == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Boy = await _context.Boy.FindAsync(id);

            if (Boy != null)
            {
                _context.Boy.Remove(Boy);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
