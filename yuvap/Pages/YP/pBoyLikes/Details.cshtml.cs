using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using yuvap.Models;

namespace yuvap.Pages.YP.pBoyLikes
{
    public class DetailsModel : PageModel
    {
        private readonly yuvap.Models.YPContext _context;

        public DetailsModel(yuvap.Models.YPContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
