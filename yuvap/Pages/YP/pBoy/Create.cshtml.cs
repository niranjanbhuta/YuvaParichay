using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using yuvap.Data;
using yuvap.Models;
using Microsoft.EntityFrameworkCore; 

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
          
          // try
         // {         
            _context.Boy.Add(Boy);
            await _context.SaveChangesAsync();
            //return RedirectToPage("./Index");
            //return RedirectToPage("/Index");
            return RedirectToPage("/YP/pProcess/ThankYou");  
       
         /*  try
            {

          }
          catch(DbUpdateException e)  //(System.Exception ex)
          {
             // handleerrorinfo
              //This either returns a error string, or null if it can’t handle that error
          //  var error = CheckHandleError(e);
          //  if (error != null)
          //  {
          //  return error; //return the error string
          //  }
          //  throw; //couldn’t handle that error, so rethrow;

             // throw           
           //  return RedirectToPage("/ErrDuplicateRecord1");
                //return RedirectToPage("/YP/pProcess/ThankYou");                
                //li><a asp-page="/About">About</a></li>       
              
          } 
          */             
       
        } //onPost 
    } //class
}

/*
(2)
Err: Duplicate record
try
{
   _context.SaveChanges();
}
catch (DbUpdateException e)
{
   //This either returns a error string, or null if it can’t handle that error
   var error = CheckHandleError(e);
   if (error != null)
   {
      return error; //return the error string
   }
   throw; //couldn’t handle that error, so rethrow
}
(1)
An unhandled exception occurred while processing the request.
SqliteException: SQLite Error 19: 'UNIQUE constraint failed: Boy.BoyID'.
Microsoft.Data.Sqlite.SqliteException.ThrowExceptionForRC(int rc, sqlite3 db)

DbUpdateException: An error occurred while updating the entries. See the inner exception for details.
Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.
ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken) 

*/