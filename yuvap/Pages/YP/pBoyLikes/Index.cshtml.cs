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
    public class IndexModel : PageModel
    {
        private readonly yuvap.Models.YPContext _context;

        public IndexModel(yuvap.Models.YPContext context)
        {
            _context = context;
        }

        public IList<BoyLikes> BoyLikes { get;set; }

        public async Task OnGetAsync()
        {
            BoyLikes = await _context.BoyLikes
                .Include(b => b.BoyPrefersNavigation)
                .Include(b => b.Boys).ToListAsync();
        }
    }
}
