using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using yuvap.Models;

namespace yuvap.Pages.YP.pGirl
{
    public class DeleteModel : PageModel
    {
        private readonly yuvap.Models.YPContext _context;

        public DeleteModel(yuvap.Models.YPContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Girl = await _context.Girl.FindAsync(id);

            if (Girl != null)
            {
                _context.Girl.Remove(Girl);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
