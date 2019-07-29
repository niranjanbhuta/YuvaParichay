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
    public class DeleteAllModel : PageModel
    {
        private readonly yuvap.Data.YPContext _context;
        public DeleteAllModel(yuvap.Data.YPContext context)
        {
            _context = context;
        }

       public async Task OnGetAsync()        {
        DelAllBoy(); //must be before Process 
        DelAllGirl(); 

        //return RedirectToPage("./Index");
       

      } 
        public void DelAllBoy() {
          foreach (var raw in _context.Boy) {
            _context.Boy.Remove(raw);
          }
          _context.SaveChangesAsync();
        }   

       public void DelAllGirl() {
          foreach (var raw in _context.Girl) {
            _context.Girl.Remove(raw);
          }
          _context.SaveChangesAsync();
        }   

    }//class

 }//namespace


     /*/

    public static class EntityExtensionsDeleteAll
    {
      public static void Clear<T>(this DbSet<T> dbSet) where T : class
      {
        dbSet.RemoveRange(dbSet);
      }
    }



Warning: The following is only suitable for small tables (think < 1000 rows)
Here is a solution that uses entity framework (not SQL) to delete the rows, so it is not SQL Engine(R/DBM) specific.
This assumes that you're doing this for testing or some similar situation. Either
The amount of data is small or
The performance doesn't matter
Simply call:
VotingContext.Votes.RemoveRange(VotingContext.Votes);
Assuming this context:
public class VotingContext : DbContext
{
    public DbSet<Vote> Votes{get;set;}
    public DbSet<Poll> Polls{get;set;}
    public DbSet<Voter> Voters{get;set;}
    public DbSet<Candidacy> Candidates{get;set;}
}
For tidier code you can declare the following extension method:

public static class EntityExtensions
{
    public static void Clear<T>(this DbSet<T> dbSet) where T : class
    {
        dbSet.RemoveRange(dbSet);
    }
}
Then the above becomes:

VotingContext.Votes.Clear();
VotingContext.Voters.Clear();
VotingContext.Candidacy.Clear();
VotingContext.Polls.Clear();
await VotingTestContext.SaveChangesAsync();
I recently used this approach to clean up my test database for each testcase run (it´s obviously faster than recreating the DB from scratch each time, though I didn´t check the form of the delete commands that were generated).
    */
