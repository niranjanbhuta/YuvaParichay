using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using yuvap.Models;

namespace yuvap.Pages.YP.pGirlLikes
{
    public class DetailsModel : PageModel
    {
        private readonly yuvap.Models.YPContext _context;

        public DetailsModel(yuvap.Models.YPContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
