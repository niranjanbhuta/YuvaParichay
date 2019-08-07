using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using yuvap.Models;

namespace yuvap.Pages.YP.pGirl
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
            return Page();
        }

        [BindProperty]
        public Girl Girl { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Girl.Add(Girl);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}