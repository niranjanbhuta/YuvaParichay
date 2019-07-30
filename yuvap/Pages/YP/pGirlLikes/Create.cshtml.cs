using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using yuvap.Models;

namespace yuvap.Pages.YP.pGirlLikes
{
    public class CreateModel : PageModel
    {
        private readonly yuvap.Models.YPContext _context;

        public CreateModel(yuvap.Models.YPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["GirlPrefers"] = new SelectList(_context.Boy, "BoyId", "BoyId");
        ViewData["GirlId"] = new SelectList(_context.Girl, "GirlId", "GirlId");
            return Page();
        }

        [BindProperty]
        public GirlLikes GirlLikes { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.GirlLikes.Add(GirlLikes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}