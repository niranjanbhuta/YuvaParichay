using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using yuvap.Data;
using yuvap.Models;
namespace yuvap.Pages.YP.pProcess
{
    public class ReportGirlModel : PageModel
    {
        private readonly yuvap.Data.YPContext _context;
        public ReportGirlModel(yuvap.Data.YPContext context)
        {
            _context = context;
        }
        //[BindProperty]
        public IList<Girl> Girl { get;set; }
        //public IList<Girl> Girl {get; set;}
       // public Boy Boy {get; set;}
       // public Girl Girl {get; set;}
       // public IList<int> Likes; 
        //IEnumerable< int> boyTotal = _context.boy.count();

    public async Task OnGetAsync()        {
      Girl = await _context.Girl.ToListAsync(); //OK
        //ProcessAndSave();   Only Report          
      } // OnGetAssync () 
    } //Class ends
} // Namespace ends
