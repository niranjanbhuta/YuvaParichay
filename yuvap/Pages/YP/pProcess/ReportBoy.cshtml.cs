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
    public class ReportBoyModel : PageModel
    {
        private readonly yuvap.Models.YPContext _context;
        public ReportBoyModel(yuvap.Models.YPContext context)
        {
            _context = context;
        }
        //[BindProperty]
        public IList<Boy> Boy { get;set; }
        //public IList<Girl> Girl {get; set;}
       // public Boy Boy {get; set;}
       // public Girl Girl {get; set;}
       // public IList<int> Likes; 
        //IEnumerable< int> boyTotal = _context.boy.count();

    public async Task OnGetAsync()        {
      Boy = await _context.Boy.ToListAsync(); //OK
        //ProcessAndSave();   Only Report          
      } // OnGetAssync () 
    } //Class ends
} // Namespace ends
