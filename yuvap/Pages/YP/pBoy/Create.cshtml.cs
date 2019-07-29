using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using yuvap.Data;
using yuvap.Models;

namespace yuvap.Pages.YP.pBoy
{
    public class CreateModel : PageModel
    {
        private readonly yuvap.Data.YPContext _context;

        public CreateModel(yuvap.Data.YPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Boy Boy { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            //nsb Ask for User PW = user4321           


            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Boy.Add(Boy);
            await _context.SaveChangesAsync();
            //return RedirectToPage("./Index");
          //return RedirectToPage("/Index");
            return RedirectToPage("/YP/pProcess/ThankYou");
       
        }
    }
}