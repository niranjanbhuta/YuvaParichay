using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using yuvap.Models;
using yuvap.ViewModels;

namespace yuvap.Pages.YP.PGirl
{
    public class EditWithLikesModel : PageModel
    {
        private readonly yuvap.Models.YPContext _context;
        public int[] Likes;

        public EditWithLikesModel(yuvap.Models.YPContext context)
        {
            _context = context;
        }

  [BindProperty]
  //      public IEnumerable<Boy> Boy { get; set; }
  public Boy Boy { get; set; } //Boy
  //public Boy Boys { get; set; } //nsb 
/*
[BindProperty]  //nsb 17-1-19
  public BoyIndexData AllTableData {get; set;}
*/
        public async Task<IActionResult> OnGetAsync(int? id)
        //public async Task OnGetAsync(int? id) 
        //Since 'EditWithLikesModel.OnGetAsync(int?)' is an async method that returns 'Task'
        //,a return keyword must not be followed by an object expression. 
        //Did you intend to return 'Task<T>'?
        {
          if (id == null)
            {
                return NotFound();
            }
        
           // AllTableData = new BoyIndexData();
            Boy = await _context.Boy
            .Include (bl => bl.BoyLikes ) 
            .FirstOrDefaultAsync(m => m.BoyId == id); //past compatibility
            
          /* 
           // BoyIData.Boys =  await _context.Boy.FirstOrDefaultAsync(m => m.BoyId == id)  
           AllTableData.Boys =  await _context.Boy 
           //.Where(i => i.BoyId == id.Value).Single()        
           .Include(i => i.BoyLikes)
            .AsNoTracking()
            .ToListAsync();
            //.FirstOrDefaultAsync(m => m.BoyId == id); //nsb 
            //error CS0266: Cannot implicitly convert type 'yuvap.Models.Boy' to 'System.Collections.Generic.IEnumerable<yuvap.Models.Boy>'.
           */
        if (id != null)
        {
        //   BoyId = id.Value;
        // AllTableData Boy = AllTableData.Boys.Where(
    /*/// keep 
    Boy  =  AllTableData.Boys.Where(
    i => i.BoyId == id.Value).Single();
    */
    
        // Instructor.Courses = instructor.CourseAssignments.Select(s => s.Course);
       // Boy = _context.Boy ;  //.FirstOrDefaultAsync(b => b.BoyId == id) //await, 'IQueryable<Boy>' does not contain a definition for 'GetAwaiter'
       // .Include (bl => bl.BoyLikes)
       // .AsNoTracking();
        //.single() ;
        
        }


            if (Boy == null)
            {
                return NotFound();
            }
            return Page();

  } //end of get

   //public async Task<IActionResult> OnPostAsync(int? id)
   public async Task<IActionResult> OnPostAsync(int? id,int[] PreferredGirls) //To Edit BoyPrefers data 
  {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var BoyToUpdate = await _context.Boy
            // Boy = await _context.Boy
            .Include (bl => bl.BoyLikes ) 
            .FirstOrDefaultAsync(m => m.BoyId == id); //past compatibility
            

          //  _context.Attach(Boy).State = EntityState.Modified;
            /*
            The instance of entity type 'Boy' cannot be tracked because another instance with the same key value for {'BoyId'} is already being tracked. 
            When attaching existing entities, ensure that only one entity instance with a given key value is attached. 
            
            Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see the conflicting key values.
             */

           // _context.Attach(Boy).State = EntityState.Modified;           
          //  _context.Attach(BoyToUpdate).State = EntityState.Modified;          
           // _context.Attach(Boy.BoyLikes).State = EntityState.Modified; //nsb 24-1-19 
           //err-runtime: The entity type 'HashSet<BoyLikes>' was not found.
           // Though Err-message, data is saved?, No ,       ( Can ignore/bypass err-msg?  )   

            
           
           // BoyToUpdate.BoyId = Boy.BoyId; // Optional, not reqd
      // BoyToUpdate.Name = Boy.Name ; BoyToUpdate.MobileNum = Boy.MobileNum;  //keep ok
            //BoyToUpdate.BoyLikes


            if(await TryUpdateModelAsync<Boy>(
               BoyToUpdate, "Boy"     //not Boy but "Boy" reqd. , All parent data saved/ updated. OK keep.
               //, "Boy" 
               //, i => i.BoyId, i => i.Name, i => i.MobileNum 
             // ,  i => i.Boy.Name, i => i.Boy.MobileNum //OK but can be auto.
               //,BoyToUpdate.Name = Boy.Name, BoyToUpdate.MobileNum = Boy.MobileNum
               ))
            {               
              //Update BoyBoyLikes BoyPrefers data 
              if(PreferredGirls == null) //go back without doing anything.
              {return Page() ;}

              var PreferredGirlsHS = new HashSet<int>(PreferredGirls);
                int cnt = 0; // 1 //PreferredGirlsHS.count
             
             /* 
              foreach (var PGirl in PreferredGirls)
                {
                // BoyLikes.Find(1).BoyPrefers = PGirl;
               // BoyToUpdate.BoyLikes.Find(1).BoyPrefers = PGirl; //Err:  'ICollection<BoyLikes>' does not contain a definition for 'Find'
                //cnt++;
                } 
             */

             foreach( var item in BoyToUpdate.BoyLikes)
                {
                    //if cnt > PreferredGirls.count() 
                    item.BoyPrefers = PreferredGirls[cnt];
                    cnt++;
                }

            }
            else {//return NoContent();
             //return NotFound();
            }

            

            await _context.SaveChangesAsync();  

            /*       
            try        
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BoyExists(Boy.BoyId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            */
 
            return RedirectToPage("./Index");
   }

  private bool BoyExists(int id)
  {
            return _context.Boy.Any(e => e.BoyId == id);
  }
 } // end of class
}

/*


(4) AJAX:
(c)  OK:
 function addRow(in_tbl_name){
                        var tbody = document.getElementById(in_tbl_name).getElementsByTagName("TBODY")[0];
                        // create row
                        var row = document.createElement("TR");
                        // create table cell                
                        var td1 =  document.createElement("TD");
                        var strHtml = " <input type=\"text\" name=\"PreferredGirls\" value=\"\" />  ";                        
                        td1.innerHTML = strHtml;
                        
                        row.appendChild(td1);
                        tbody.appendChild(row);      
                        
                       // alert(tbody + row + td1 + '  nsb');      //debug                       
                    }

(b)  @foreach (var item in Model.Boy.BoyLikes)
                    {
                        <tr id="ForeachTR">
                            <td></td>
                            <td>
                              <input type="text" name="PreferredGirls" value="@item.BoyPrefers" >  
                            </td>                                              
                        </tr>                        
                    }


    <td>
                             <!-- @Html.EditorFor(modelItem => item.BoyPrefers, new { htmlAttributes = new { @class = "form-control"} }) -->      
                                <input type="text" name="PreferredGirls" value="@item.BoyPrefers" >  
                                
                               <input type="button" onclick="addRow('foreachTR')" id="btnAddRow" value="Click If Yoy Want to Add Preference-Number"/> 
                              <input type="button" onclick="mymsg('foreachTR')" id="btnAddRow" value="alert"/>   

                              </td>    

 backup: <input type="button" id="btnAdd" value="Click If Yoy Want to Add New Preference-Number"/> 
    <a title="Add More Preference-Number" style="cursor: pointer;" onclick="addRow('allData')"> Click If Yoy Want to Add More Preference-Number</a>
 This works: <input type="button" onclick="alert('The text will be show!!');" id="btnAddRow" value="Click If Yoy Want to Add More Preference-Number"/> 
                              

How to Add TextBox Dynamically Using JavaScript in ASP.Net,  Year:2014
(a)https://www.c-sharpcorner.com/UploadFile/c4cfca/how-to-add-textbox-dynamically-using-javascript-in-Asp-Net/
(b)https://www.pluralsight.com/guides/asp-net-mvc-using-javascript-with-ajax-and-razor-partial-views
(c)http://techiesweb.net/2012/09/17/asp-net-mvc3-dynamically-added-form-fields-model-binding.html

(3)For UI: http://www.dotnetfunda.com/articles/show/2924/how-to-control-the-output-of-htmleditorfor-in-aspnet-mvc

(a) @Html.EditorFor(model => model.FirstName) 
For example
If Model.Property is of string type, it renders a simple TextBox on the page
(b) <input class="text-box single-line" id="LastName" name="LastName" type="text" value="" />

see also our case:
 (c) <div class="form-group">
                <label asp-for="Boy.Name" class="control-label"></label>
                <input asp-for="Boy.Name" class="form-control" />
                <span asp-validation-for="Boy.Name" class="text-danger"></span>
      </div>

(2) ref- https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/update-related-data?view=aspnetcore-2.2#add-asnotracking-to-the-details-and-delete-page-models
 one to one relation
 public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var instructorToUpdate = await _context.Instructors
            .Include(i => i.OfficeAssignment)
            .FirstOrDefaultAsync(s => s.ID == id);

        if (await TryUpdateModelAsync<Instructor>(
            instructorToUpdate,
            "Instructor",
            i => i.FirstMidName, i => i.LastName, 
            i => i.HireDate, i => i.OfficeAssignment))
        {
            if (String.IsNullOrWhiteSpace(
                instructorToUpdate.OfficeAssignment?.Location))
            {
                instructorToUpdate.OfficeAssignment = null;
            }
            await _context.SaveChangesAsync();
        }
        return RedirectToPage("./Index");

    }

(1)public Book AddReviewToBook(ReviewDto dto)
{
    var book = _context.Books
        .Include(r => r.Reviews)
        .Single(k => k.BookId == dto.BookId);
    var newReview = new Review(dto.numStars, dto.comment, dto.voterName);
    book.Reviews.Add(newReview); 
    _context.SaveChanges();
    return book;
} */
