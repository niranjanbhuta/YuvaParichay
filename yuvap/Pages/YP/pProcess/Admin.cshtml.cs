using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using yuvap.Data;
using yuvap.Models;
using Microsoft.AspNetCore.Authorization;
//using System.ComponentModel.DataAnnotations;

namespace yuvap.Pages.YP.pProcess
{
    public class AdminModel : PageModel
    {
      //[Authorize(Roles = "Admin")] 
     public AdminModel() {}    
              [Authorize(Roles = "Admin")]    
          IActionResult  OnGet() //public
        {
                return Page() ;
                //return Page("/Admin") ;
                //return RedirectToPage("/Admin");

        }
      
    }
}
