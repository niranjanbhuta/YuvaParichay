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

namespace yuvap.Pages.YP.pBoy
{
    public class EditWithLikesModel : PageModel
    {
        private readonly yuvap.Models.YPContext _context;
        public int[] Likes; // It is never used. 8-8-19

        public EditWithLikesModel(yuvap.Models.YPContext context)
        {
            _context = context;
        }

  [BindProperty]
  //      public IEnumerable<Boy> Boy { get; set; }
  public Boy Boy { get; set; } //Boy  
  //public Boy Boys { get; set; } //nsb 

  public Boy BoyToUpdate {get;set;} //nsb 5-2-19

  public IList<Girl> Girls {get;set;} // nsb 1-2-19. To validate that boy prefers existing girl
  //public IList<int> gIdList {get;set;} /err in populating.

  //public IList<BoyLikes> bLikesList {get;set;} // dt 5-2-19
  // public IEnumerable<BoyLikes> bLikesList {get;set;} // dt 5-2-19

/*
[BindProperty]  //nsb 17-1-19
  public BoyIndexData AllTableData {get; set;}  
*/
// public BoySingleRelData boySingleRelData {get;set;}  // dt 5-2-19

    public async Task<IActionResult> OnGetAsync(int? id) {
       // ViewData["BoyPrefers"] = new SelectList(_context.Girl, "GirlId", "GirlId"); // Get listbox . dt 3-2-19. For 'edit' only. Not useful for 'create'
        ViewData["BoyId"] = new SelectList(_context.Boy, "BoyId", "BoyId"); //though data pre-entered, but no listbox.
      
        //public async Task OnGetAsync(int? id) 
        //Since 'EditWithLikesModel.OnGetAsync(int?)' is an async method that returns 'Task'
        //,a return keyword must not be followed by an object expression. 
        //Did you intend to return 'Task<T>'?
        
          if (id == null)
            {
                return NotFound();
            }
        
           // AllTableData = new BoyIndexData();
            Boy = await _context.Boy
           .Include (bl => bl.BoyLikes ) // Can ommit this line without err.
            .FirstOrDefaultAsync(m => m.BoyId == id); //past compatibility      

            Girls = await _context.Girl // await nsb 1-2-19
            //.Include(g => g.GirlId) 
            //err: 'GirlId' is not a navigation property of entity type 'Girl'. 
            //The 'Include(string)' method can only be used with a '.' separated list of navigation property names. 
            .ToListAsync();

    //var g1 = Girls[1];  //ok tested.
          // foreach (var g in  Girls){
               // gIdList.Add(1);   //(g.GirlId);
             //   gIdList=new int[] {1,2,3,4};      // err
          // }
            

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

      //  if (id != null)
      //  {
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
      //  } //if (id != null)


            if (Boy == null) //It is not important as we already have populated data? Still user may enter wrong id, unless list box is provided.
            {
                //return NotFound();
                return NotFound("Error: Your Reg. num " + id + " does not exists! Pl. Go back and correct.");
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

            //var 
            BoyToUpdate = await _context.Boy
            // Boy = await _context.Boy
            .Include (bl => bl.BoyLikes ) 
                
            .FirstOrDefaultAsync(m => m.BoyId == id); //past compatibility
            
         // Ilist<BoyLikes> bLikesList = new  IList<BoyLikes>() ;
       //  var bLikesListv =  BoyToUpdate.BoyLikes; // OK // .ToListAsync();
        // boySingleRelData.BoyLikesEnumerable = BoyToUpdate.BoyLikes; // dt 5-2-19 Err Runtime: NullReferenceException: Object reference not set to an instance of an object.
  //  _context.Attach(Boy).State = EntityState.Modified; // Is reqd for data validation / integrity?
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

            // remove old boylikes data
               /*  for (int i = 0; i < bLikesListv.Count; i++)
                {
                    //bLikesListv.Remove(i);
                 //  var blTmp = bLikesListv[i].BoyId;// err: Cannot apply indexing with [] to an expression of type 'ICollection<BoyLikes>
                //    BoyLikes blTmp = _context.BoyLikes.Find(BoyToUpdate.BoyLikes.BoyId,BoyToUpdate.BoyLikes.BoyPrefers); //err: 'ICollection<BoyLikes>' does not contain a definition for 'BoyId'
                //    BoyToUpdate.BoyLikes.Remove(blTmp);
                } */
            foreach( var item in BoyToUpdate.BoyLikes) // 5-2-19 Err- Runtime: Collection was modified; enumeration operation may not execute.             
                {     
                  // BoyToUpdate.BoyLikes.Remove(item);  //.remove();   Runtime err              
                    _context.BoyLikes.Remove(item);
                 }
            //if (BoyToUpdate.BoyLikes.Count>0) _context.SaveChangesAsync; // save only if old rec exists.     
            
             // var PreferredGirlsHS = new HashSet<int>(PreferredGirls); // not usefull
             //   int cnt = 0; // 1 //PreferredGirlsHS.count
             
    // var bl = new BoyLikes(); OK
             // PreferredGirls[0] = 1; //Just test then remove
              //  PreferredGirls[1] = 2;
               // PreferredGirls[2] = 3;
               // PreferredGirls[3] = 4;
//return NotFound("Test: PreferredGirls =  " + PreferredGirls[2] );  //test
            //Dt 7-2-19. Find duplicate and return back if found.



            // Add for new entries, as we have already deleted old rec and, removed duplicates from new entries.
              foreach (var PGirl in PreferredGirls)
                {
                // BoyLikes.Find(1).BoyPrefers = PGirl;
               // BoyToUpdate.BoyLikes.Find(1).BoyPrefers = PGirl; //Err:  'ICollection<BoyLikes>' does not contain a definition for 'Find'
               //var author = new Author{ FirstName = "William", LastName = "Shakespeare" };
               var bl = new BoyLikes(); 
            
               bl.BoyId=Boy.BoyId;  //id;
               bl.BoyPrefers = PGirl;

               //bl.BoyLikes.ID = 
               // BoyToUpdate.BoyLikes.add(new BoyLikes{BoyToUpdate.BoyId, PGirl}); //Err:  'ICollection<BoyLikes>' does not contain a definition for 'Find'
               //BoyToUpdate.BoyLikes.add(bl); //err: 'ICollection<BoyLikes>' does not contain a definition for 'add'
              //  bLikesListv.Add(bl); // OK. WARNING .add instead of .Add wasted lot of time ! // Var never used !
              
               _context.BoyLikes.Add(bl); //OK
               // boySingleRelData.BoyLikesEnumerable.Add(bl); //err: 'IEnumerable<BoyLikes>' does not contain a definition for 'Add'
                //cnt++;
//return NotFound("Test: PreferredGirls 1st val =  " + bl.BoyPrefers );  //test

            // await _context.SaveChangesAsync(); // Dt 7-2-19 Err: Duplicate entry '20' for key 'PRIMARY'
                } 
            
        /* .cshtml
         @foreach (var item in Model.Boy.BoyLikes)
                    {
                        <tr id="ForeachTR">
                            <td></td>
                            <td>
                              <input type="text" name="PreferredGirls" value="@item.BoyPrefers" >  
                            </td>                                              
                        </tr>                        
                    } */


         /*    Likes = PreferredGirls;          
            int TotalPreferredGirls = Likes.count();
            // var item[] = BoyToUpdate.BoyBoyLikes.ToListAsync;
           var item = BoyToUpdate.BoyBoyLikes;
             for(cnt = 0; cnt > TotalPreferredGirls; cnt++) {
                item[cnt] = PreferredGirls[cnt]; 
             }
        */                 

           /*  OK, but
             foreach( var item in BoyToUpdate.BoyLikes) // 5-2-19 err: here we can not add more than the existing num of boylikes, e.g. 2 for boy(3)
                // even worse: if num of (newly) entry is less e.g. 1 then err of index outseide the bound
                // Soln: For Loop: w.r.t. if cnt > PreferredGirls.count() ? No
                // -- Use this loop to remove old data. We are not able to edit data with select-box, as can be done for new entry.
                {
                    //if cnt > PreferredGirls.count() 
                    // validate if girl-code exists 1-2-19 nsb, can be done in javascript

                    //Dt 5-2-19Err: IndexOutOfRangeException: Index was outside the bounds of the array.
                    // OnPostAsync(Nullable<int> id, int[] PreferredGirls) in EditWithLikes.cshtml..cs,
                   if (GirlExists(PreferredGirls[cnt])) {
                    item.BoyPrefers = PreferredGirls[cnt];
                    cnt++;
                   }
                   else{
                       return NotFound("Error! Your Preferred Reg. num " + PreferredGirls[cnt] + " does not exists! Pl Go back and correct." );
                   }
                }
            */
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
   } //end of post

  private bool BoyExists(int id)
  {
            return _context.Boy.Any(e => e.BoyId == id);
  }

  private bool GirlExists(int id) // nsb dt 1-2-19
  {
            return _context.Girl.Any(e => e.GirlId == id);
  }

 } // end of class
}

/*
(11)Dt 8-2-19  Duplicate rec
(a)
How to check duplicates in string array c# - CodeProject
https://www.codeproject.com/.../Howplustopluscheckplusduplicatesplusinplusstringpl
6 answers
Apr 14, 2013 - One method is: First sort the array. Then, foreach item: if it is equal to the next one then you have a duplicate 
(and you may show the message).

Soln-1
string[] myStrings = // ...
if (myStrings.Distinct().Count() != myStrings.Count())
{
    // Show message
}

Soln-2
string[] array = { "First", "Second", "Third", "First", "Third" }; 
var i= CheckforDuplicates(array);

public bool CheckforDuplicates(string[] array)
      {
          var duplicates = array
           .GroupBy(p => p)
           .Where(g => g.Count() > 1)
           .Select(g => g.Key);
          return (duplicates.Count() > 0);
      }

Soln-4
private static int CountDuplicates(string[] array)
{
  HashSet<string> stringSet = new HashSet<string>();
  int numDups = 0;
  foreach (var item in array)
  {
    if (stringSet.Contains(item))
    {
      ++numDups;
    }
    else
    {
      stringSet.Add(item);
    }
  }
  return numDups;
}

// this returns an IEnumerable with both the strings and the repeat counts (might be useful for reporting...)
private static IEnumerable<KeyValuePair<string, int>> FindDuplicates(string[] array)
{
  Dictionary<string, int> stringSet = new Dictionary<string, int>();
  foreach (var item in array)
  {
    int count;
    if (stringSet.TryGetValue(item, out count))
    {
      stringSet[item] = count + 1;
    }
    else
    {
      stringSet[item] = 1;
    }
  }
  return stringSet.Where(p => p.Value > 1);
}


(10)dt 7-2-19 https://www.learnentityframeworkcore.com/dbcontext/adding-data
// with type parameter
var author = new Author{ FirstName = "William", LastName = "Shakespeare" };
context.Add<Author>(author);
context.SaveChanges();
// without type parameter
var author = new Author{ FirstName = "William", LastName = "Shakespeare" };
context.Add(author);
context.SaveChanges();

(9) 5-2-19 10 PM: Delete obj from list by composite key: esp for BoyLikes: 
(b) 
https://stackoverflow.com/questions/48157531/save-multiple-rows-simultaneously-from-the-same-form-dotnet-core
    https://stackoverflow.com/questions/23429888/best-way-to-insert-data-to-multiple-table-mvc-asp

(a)
https://stackoverflow.com/questions/34337072/delete-record-with-composite-primary-key-in-mvc
 TicketSubscription ticketSubscription = db.TicketSubscriptions.Find(ticketId,userId);
     ticketSubscriptions.Delete(ticketSubscription);

(8) Syntax:
(a) List<string> AuthorList = new List<string>(); AuthorList.Add("Mahesh Chand");  AuthorList.Remove("Mahesh Chand");  
(b) var bLikesListv =  BoyToUpdate.BoyLikes; 
(c)  public IList<Girl> Girls {get;set;}     Girls = await _context.Girl.ToListAsync();
(d)  public IEnumerable<Person> People { get; set; }


(7)
(d) Alternate soln. but not better than modified (c) as it can not show header in text-box? Can show trick of '(c)', 
but seems to be a combo-box which is high objectionable here.
 <td> 
                              <input id ="selectTopRow" type="text" list="PreferredGirls" value="" name="PreferredGirls" style="width: 90px;" aria-invalid="true" > 
                              <datalist id ="PreferredGirls">
                               @foreach (var  gid in   Model.Girls )  
                                 {
                                    <option value="@gid.GirlId">@gid.GirlId</option>
                                 }   
                              </datalist>
                        </td>
     
(c)  <td> 
                              <select id ="selectTopRow" value="" name="PreferredGirls" style="width: 90px;" aria-invalid="true" type="text" >
 <option value="" selected disabled hidden>Choose here</option> // modified dt 5-2-19, Now OK OK.                             
                               @foreach (var  gid in   Model.Girls )  
                                 {
                                    <option value="@gid.GirlId">@gid.GirlId</option>
                                 }   
                            </select>
                        </td>
  It is OK but selection box should not be having default val "1"  ?    OK with modi fication                
(b) Default val can be 'blank' https://www.w3docs.com/learn-html/html-select-tag.html 
 <form action="action_form.php" method="get">
      <input type = "text" list = "airports" name="airports"> 
      <datalist id = "airports">    //nsb note this line
        <option value = "Berlin">
        <option value = "Los Angeles">
        <option value = "Moscow">
        <option value = "Paris">
      </datalist>
      <input type = "submit" value = "confirm">
    </form>
(a)  <input asp-for="Girls[0].GirlId " class="form-control" />               OK 
      <input value="@Model.gIdList[1]" type="text" />           OK    
                    
(6)Dt 2-2-19.  CSS
(a)
<style>
thead {color:green;}
tbody {color:blue;}
tfoot {color:red;}

table, th, td {
  border: 1px solid black;
}
</style>
see also <tfoot> under <table>

(b) Also as class = " "
  .TemplateTable tr td div a
        {
            color: Blue;
        }
 (c) <table> ->
  <caption>Monthly savings</caption>
     
(5)
(d) Good HTML Example: https://www.w3schools.com/howto/tryit.asp?filename=tryhow_css_checkout_form
(c) USE <select> element :Ref-w3schools.com: https://www.w3schools.com/tags/default.asp
      /*(Create Model):     
 (i)      <select asp-for="BoyLikes.BoyPrefers" class ="form-control" asp-items="ViewBag.BoyPrefers"></select>
                        As seen in 'Inspect Element' of Chrome Browser, It Renders To:->
<select class="form-control valid" data-val="true" data-val-required="The BoyPrefers field is required." 
   id="BoyLikes_BoyPrefers" name="BoyLikes.BoyPrefers" aria-describedby="BoyLikes_BoyPrefers-error" aria-invalid="false">
<option value="1">1</option>
<option value="2">2</option>
<option selected="selected" value="3">3</option>
<option value="4">4</option>
<option value="5">5</option>
</select> 
It is well modified to run.  <select name="id" asp-items="ViewBag.BoyId"></select> . Note that name property is changed to "id". OK. It renders to only:
<select value="1" name="PreferredGirls"><option value="1">1</option>
<option value="2">2</option>
<option value="3">3</option>
<option value="4">4</option>
<option value="5">5</option>
</select>        
 
<span class="text-danger field-validation-valid" data-valmsg-for="BoyLikes.BoyPrefers" data-valmsg-replace="true"></span>

(ii)  <label asp-for="BoyLikes.BoyId" class="control-label"></label> Renders to :
        <label class="control-label" for="BoyLikes_BoyPrefers">BoyPrefers</label>
(iii)
<input asp-for="Boy.Name" class="form-control" /> Renders to:
    <input class="form-control valid" type="text" id="Boy_Name" name="Boy.Name" value="boy3" aria-invalid="false">          
<span asp-validation-for="Boy.Name" class="text-danger"></span> Renders to:
    <span class="text-danger field-validation-valid" data-valmsg-for="Boy.Name" data-valmsg-replace="true"></span>        
(iv)
@Html.EditorFor(modelItem => item.BoyPrefers, new { htmlAttributes = new { @class = "form-control"} }) .    Renders to:       
   <input class="form-control text-box single-line valid" data-val="true" data-val-required="The BoyPrefers field is required." 
   id="item_BoyPrefers" name="item.BoyPrefers" type="number" value="1" aria-describedby="item_BoyPrefers-error" aria-invalid="false">                   

(b)https://www.pluralsight.com/guides/asp-net-mvc-populating-dropdown-lists-in-razor-views-using-the-mvvm-design-pattern-entity-framework-and-ajax
   @Html.DropDownListFor(x => Model.SelectedCountryIso3, new SelectList(Model.Countries, "Value", "Text"), htmlAttributes: new { @class = "form-control", id = "Country"})
    
 <!-- @Html.EditorFor(modelItem => item.BoyPrefers, new { htmlAttributes = new { @class = "form-control"} })  -->     OK?
 <!-- @Html.DropDownListFor(x => Model.SelectedCountryIso3, new SelectList(Model.Countries, "Value", "Text"), htmlAttributes: new { @class = "form-control", id = "Country"}) -->


@Html.DropDownListFor(modelItem => item.BoyPrefers, new SelectList( Model.Girls, "Value", "Text"), htmlAttributes: new { @class = "form-control", id = "Country"})
                       
                            <td><img src="~/Images/del-x.png" onclick="delRow()" style="width: 22px; cursor: pointer;" /></td>                                                    
                       </tr>                        
                    }                
                  </Tbody>
            </Table>
     
  <form action="./EditWithLikes">
  Type Your Reg. Number Without Prefix Like M/F etc:<br>
  <input type="text" name="id" ><br>  
  <input type="submit" value="Submit">
</form>
         


(a)https://www.ryadel.com/en/asp-net-mvc-viewmodel-boolean-property-dropdownlistfor-checkboxfor-dropdownlist-checkbox-bool/
DropDownListFor with Nullable Boolean:
@Html.DropDownListFor(m => m.NullableBooleanProperty, new SelectList(
        new[] { 
            new { Value = "", Text = "-- Choose YES or NO --" },
            new { Value = "true", Text = "YES" },
            new { Value = "false", Text = "NO" },
        },
        "Value",
        "Text"
    ))


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
          <!-- @Html.EditorFor(modelItem => item.BoyPrefers, new { htmlAttributes = new { @class = "form-control"} }) -->  OK for edit only     
 Dt 1-2-19: <input type="text" name="PreferredGirls" value="@item.BoyPrefers" >  //OK  to replace @htmlEditorFor() with a view to mix both 'edit' and 'create'.  
         <select  value="@item.BoyPrefers" name="PreferredGirls" asp-items="ViewBag.BoyPrefers"></select> </td> //OK Better, selects val for girlId, only for 'edit'. 
                                          
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


WARNINGS :
 (i) --  WARNING .add instead of .Add wasted lot of time !
        .Remove (not .remove)
 (ii) When adding multiple records, we must fill data thru new var each time, e.g. var bl = new BoyLikes(); must be in loop, not at pre-loop !!!
             
} */
