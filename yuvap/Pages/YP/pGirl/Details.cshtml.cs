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
    public class DetailsModel : PageModel
    {
        private readonly yuvap.Models.YPContext _context;

        public DetailsModel(yuvap.Models.YPContext context)
        {
            _context = context;
        }

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
    }
}
