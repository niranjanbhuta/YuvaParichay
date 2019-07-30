using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using yuvap.Models;
using yuvap.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace yuvap.Pages.YP.pBoy
{
    public class GetRegNumForEditBoyModel : PageModel
    {
      
         private readonly yuvap.Models.YPContext _context;

        public GetRegNumForEditBoyModel(yuvap.Models.YPContext context)
        {
            _context = context;
        }

   //[BindProperty]
        public Boy Boy { get; set; }

          public IActionResult OnGet()
        {
       // ViewData["BoyPrefers"] = new SelectList(_context.Girl, "GirlId", "GirlId");
        ViewData["BoyId"] = new SelectList(_context.Boy, "BoyId", "BoyId");
            return Page();
        }

 /*   public IList<Boy> Boy { get;set; }

        public async Task OnGetAsync()
        {
            ViewData["BoyId"] = new SelectList(_context.Boy, "BoyId", "BoyId"); //though data pre-entered, but no listbox.
      
            Boy = await _context.Boy.ToListAsync();
        }
  */      
    }
}