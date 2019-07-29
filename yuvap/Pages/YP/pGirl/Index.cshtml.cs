using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using yuvap.Data;
using yuvap.Models;

namespace yuvap.Pages.YP.pGirl
{
    public class IndexModel : PageModel
    {
        private readonly yuvap.Data.YPContext _context;

        public IndexModel(yuvap.Data.YPContext context)
        {
            _context = context;
        }

        public IList<Girl> Girl { get;set; }

        public async Task OnGetAsync()
        {
            Girl = await _context.Girl.ToListAsync();
        }
    }
}
