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
    public class IndexModel : PageModel
    {
        private readonly yuvap.Models.YPContext _context;

        public IndexModel(yuvap.Models.YPContext context)
        {
            _context = context;
        }

        public IList<Boy> Boy { get;set; }

        public async Task OnGetAsync()
        {
            Boy = await _context.Boy.ToListAsync();
        }
    }
}
