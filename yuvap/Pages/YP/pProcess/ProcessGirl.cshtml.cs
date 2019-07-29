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
    public class ProcessGirlModel : PageModel
    {
        private readonly yuvap.Data.YPContext _context;
        public ProcessGirlModel(yuvap.Data.YPContext context)
        {
            _context = context;
        }
        //[BindProperty]
        public IList<Girl> Girl { get;set; }
        //public IList<Girl> Girl {get; set;}

       // public async Task OnGetAsync()        {
       // Girl = await _context.Girl.ToListAsync(); //OK
        public  void OnGet()        {  //try sync Dt 1-1-19
        Girl =  _context.Girl.ToList(); //OK
        FillNotEnteredButRefCandidates(); //must be before Process 
        Post(); 
       //Test err: InvalidOperationException: A second operation started on this context before a previous operation completed. 
       //This is usually caused by different threads using the same instance of DbContext, however instance members are not guaranteed to be thread safe. 
       //This could also be caused by a nested query being evaluated on the client, if this is the case rewrite the query avoiding nested invocations.

      } // OnGetAssync () 

    public void   Post() {           
    //public   async Task Post() {           
         var Boys =  _context.Boy.ToListAsync(); 
         var LikedBy = "";
    //for (int n = 1 ; n < 5; n++) { //Outer loop
    foreach (var b in _context.Girl) { //Outer loop, For loop not cares of break in BoyID no
    //foreach (var b1 in _context.Girl) { //Outer loop, For loop not cares of break in BoyID no //1-1-19
    
    //var b = _context.Girl.Find(n); //OK  Boy     
      //if (b == null) break; // Care for end of file
      LikedBy = "" ; //init  in outer loop not in inner-1 loop not inner-2
//LikedBy = "gID = " + Convert.ToString(b.GirlID) ; //Temp test      
      
       //for (int i1 = 1 ; i1 < 5 ; i1++){ //Inner-1 loop
   // using( b  ) {  // nsb 1-1-19 to solve err: multiple thresds for an instance.
     //  b = b1;
       foreach (var boy in _context.Boy) {
           //var Boy = _context.Boy.Find(i1); //OK       
           // if (Boy == null) break; // Care for end of file
            var intPref  = 1;;
           var strID = Convert.ToString(boy.BoyID); // ToChar

            intPref = Convert.ToInt32(boy.Pref1);   //OK   .ToInt      
            if (intPref >0 ) { //Avoid NULL ref, Some candidate don't enter Pref data, Care for only those pref for which continuous data entered
              if ( intPref == b.GirlID  ) {  //Problem NULL Ref Err
               LikedBy = LikedBy + "," + strID ;
              } 
            }

            intPref = Convert.ToInt32(boy.Pref2);   //OK   .ToInt      
            if (intPref >0 ) {
              if ( intPref == b.GirlID  ) {  //Problem NULL Ref Err
               LikedBy = LikedBy + "," + strID ;
              } 
            }

            intPref = Convert.ToInt32(boy.Pref3);   //OK   .ToInt      
            if (intPref >0 ) {
              if ( intPref == b.GirlID  ) {  //Problem NULL Ref Err
               LikedBy = LikedBy + "," + strID ;
              } 
            }
            
            intPref = Convert.ToInt32(boy.Pref4);   //OK   .ToInt      
            if (intPref >0 ) {
              if ( intPref == b.GirlID  ) {  //Problem NULL Ref Err
               LikedBy = LikedBy + "," + strID ;
              } 
            }
            
            intPref = Convert.ToInt32(boy.Pref5);   //OK   .ToInt      
            if (intPref >0 ) {
              if ( intPref == b.GirlID  ) {  //Problem NULL Ref Err
               LikedBy = LikedBy + "," + strID ;
              } 
            }
           
            intPref = Convert.ToInt32(boy.Pref6);   //OK   .ToInt      
            if (intPref >0 ) {
              if ( intPref == b.GirlID  ) {  //Problem NULL Ref Err
               LikedBy = LikedBy + "," + strID ;
              } 
            }
            
            intPref = Convert.ToInt32(boy.Pref7);   //OK   .ToInt      
            if (intPref >0 ) {
              if ( intPref == b.GirlID  ) {  //Problem NULL Ref Err
               LikedBy = LikedBy + "," + strID ;
              } 
            }
            
            intPref = Convert.ToInt32(boy.Pref8);   //OK   .ToInt      
            if (intPref >0 ) {
              if ( intPref == b.GirlID  ) {  //Problem NULL Ref Err
               LikedBy = LikedBy + "," + strID ;
              } 
            }  

       } // Inner-1 loop
      
       b.GirlLikedByConcat  =  LikedBy; 
      //_context.SaveChangesAsync(); //OK  
      _context.SaveChanges();

        // await _context.SaveChangesAsync(); //err: can only be used within an async method
            Task.Delay(2000).Wait(); // Wait 2 seconds with blocking
           // await Task.Delay(2000); // Wait 2 seconds without blocking
            
    // } // end of using 

    } //Outer loop ends
 // _context.SaveChangesAsync();
    } // ProcessAndSave() ends

    public void FillNotEnteredButRefCandidates(){
      var intPref  = 1; //init
      //var b2 = new Boy(); // must be created each time ,else same data repeated. // _context.Boy();
      foreach (var boy in _context.Boy) {
         var Track = "";  

         intPref = Convert.ToInt32(boy.Pref1);  
            if (intPref >0 ) {     // Some candidate don't enter Pref data  
             if (_context.Girl.Find(intPref) == null){ // Create if not found GirlID  
               var b2 = new Girl(); // must be created each time ,else same data repeated. // _context.Girl();             
               b2.GirlID = intPref;        
               b2.GirlLikedByConcat = "";
               b2.MobileNum = "";       
               b2.Name = "";
               b2.Pref1=null ; b2.Pref2=null ; b2.Pref3=null ; b2.Pref4=null ; 
               b2.Pref5=null ; b2.Pref6=null ; b2.Pref7=null ; b2.Pref8=null ;     
               _context.Girl.Add(b2); 
             }    
            }  

            intPref = Convert.ToInt32(boy.Pref2);  
            if (intPref >0 ) {    
             if (_context.Girl.Find(intPref) == null){  
               var b2 = new Girl(); 
               b2.GirlID = intPref;        
               b2.GirlLikedByConcat = "";
               b2.MobileNum = "";       
               b2.Name = "";
               b2.Pref1=null ; b2.Pref2=null ; b2.Pref3=null ; b2.Pref4=null ; 
               b2.Pref5=null ; b2.Pref6=null ; b2.Pref7=null ; b2.Pref8=null ;     
               _context.Girl.Add(b2); 
             }    
            }  

            intPref = Convert.ToInt32(boy.Pref3);  
            if (intPref >0 ) {    
             if (_context.Girl.Find(intPref) == null){  
               var b2 = new Girl(); 
               b2.GirlID = intPref;        
               b2.GirlLikedByConcat = "";
               b2.MobileNum = "";       
               b2.Name = "";
               b2.Pref1=null ; b2.Pref2=null ; b2.Pref3=null ; b2.Pref4=null ; 
               b2.Pref5=null ; b2.Pref6=null ; b2.Pref7=null ; b2.Pref8=null ;     
               _context.Girl.Add(b2); 
             }    
            }  

            intPref = Convert.ToInt32(boy.Pref4);  
            if (intPref >0 ) {    
             if (_context.Girl.Find(intPref) == null){  
               var b2 = new Girl(); 
               b2.GirlID = intPref;        
               b2.GirlLikedByConcat = "";
               b2.MobileNum = "";       
               b2.Name = "";
               b2.Pref1=null ; b2.Pref2=null ; b2.Pref3=null ; b2.Pref4=null ; 
               b2.Pref5=null ; b2.Pref6=null ; b2.Pref7=null ; b2.Pref8=null ;     
               _context.Girl.Add(b2); 
             }    
            }  

            intPref = Convert.ToInt32(boy.Pref5);  
            if (intPref >0 ) {    
             if (_context.Girl.Find(intPref) == null){  
               var b2 = new Girl(); 
               b2.GirlID = intPref;        
               b2.GirlLikedByConcat = "";
               b2.MobileNum = "";       
               b2.Name = "";
               b2.Pref1=null ; b2.Pref2=null ; b2.Pref3=null ; b2.Pref4=null ; 
               b2.Pref5=null ; b2.Pref6=null ; b2.Pref7=null ; b2.Pref8=null ;     
               _context.Girl.Add(b2); 
             }    
            }  

            intPref = Convert.ToInt32(boy.Pref6);  
            if (intPref >0 ) {    
             if (_context.Girl.Find(intPref) == null){  
               var b2 = new Girl(); 
               b2.GirlID = intPref;        
               b2.GirlLikedByConcat = "";
               b2.MobileNum = "";       
               b2.Name = "";
               b2.Pref1=null ; b2.Pref2=null ; b2.Pref3=null ; b2.Pref4=null ; 
               b2.Pref5=null ; b2.Pref6=null ; b2.Pref7=null ; b2.Pref8=null ;     
               _context.Girl.Add(b2); 
             }    
            }  

            intPref = Convert.ToInt32(boy.Pref7);  
            if (intPref >0 ) {    
             if (_context.Girl.Find(intPref) == null){  
               var b2 = new Girl(); 
               b2.GirlID = intPref;        
               b2.GirlLikedByConcat = "";
               b2.MobileNum = "";       
               b2.Name = "";
               b2.Pref1=null ; b2.Pref2=null ; b2.Pref3=null ; b2.Pref4=null ; 
               b2.Pref5=null ; b2.Pref6=null ; b2.Pref7=null ; b2.Pref8=null ;     
               _context.Girl.Add(b2); 
             }    
            }  

            intPref = Convert.ToInt32(boy.Pref8);  
            if (intPref >0 ) {    
             if (_context.Girl.Find(intPref) == null){  
               var b2 = new Girl(); 
               b2.GirlID = intPref;        
               b2.GirlLikedByConcat = "";
               b2.MobileNum = "";       
               b2.Name = "";
               b2.Pref1=null ; b2.Pref2=null ; b2.Pref3=null ; b2.Pref4=null ; 
               b2.Pref5=null ; b2.Pref6=null ; b2.Pref7=null ; b2.Pref8=null ;     
               _context.Girl.Add(b2); 
             }    
            }  
               
             boy.BoyLikedByConcat = Track ;
             _context.SaveChangesAsync(); 
           
            
      } //Loop    
    } //FillNotEnteredButRefCandidates ends 

    } //Class ends
} // Namespace ends


/*  Help:
(3)
  // await _context.SaveChangesAsync(); //err: can only be used within an async method
            //Task.Delay(2000).Wait(); // Wait 2 seconds with blocking
           // await Task.Delay(2000); // Wait 2 seconds without blocking
            
(2) 1-1-19 Try Using: 
(b)
Search Results
Web results
Combining foreach and using - Stack Overflow
https://stackoverflow.com/questions/3005264/combining-foreach-and-using
6 answers
Nov 17, 2011 - 6 Answers. It's not normally good practice to assign the variable outside the using block because the resource would be disposed but could stay in scope. It would, however, result in clearer code here because you can nested the using statement against the foreach .
C# 'using' block inside a loop	26 May 2017
Foreach and SqlConnection Using Statement	24 May 2017
Can't get .Dispose() to work in a foreach loop	8 Dec 2016
Is there a way to have a using statement with dynamically-created ...	29 Jun 2016
More results from stackoverflow.com

(a)
ref. https://stackoverflow.com/questions/30042791/entity-framework-savechanges-vs-savechangesasync-and-find-vs-findasync

using(var context = new MyEDM())
{
    Console.WriteLine("Save Starting");
    context.MyTable.AddRange(myList);
    await context.SaveChangesAsync();
    Console.WriteLine("Save Complete");
}
It is a very small change, but there are profound effects on the efficiency and performance of your code. So what happens? The begining of the code is the same, you create an instance of MyEDM and add your myList to MyTable. But when you call await context.SaveChangesAsync(), the execution of code returns to the calling function! So while you are waiting for all those records to commit, your code can continue to execute. Say the function that contained the above code had the signature of public async Task SaveRecords(List<MyTable> saveList), the calling function could look like this:

public async Task MyCallingFunction()
{
    Console.WriteLine("Function Starting");
    Task saveTask = SaveRecords(GenerateNewRecords());

    for(int i = 0; i < 1000; i++){
        Console.WriteLine("Continuing to execute!");
    }

    await saveTask;
    Console.Log("Function Complete");
}
Why you would have a function like this, I don't know, but what it outputs shows how async await works. First let's go over what happens.

Execution enters MyCallingFunction, Function Starting then Save Starting gets written to the console, then the function SaveChangesAsync() gets called. At this point, execution returns to MyCallingFunction and enters the for loop writing 'Continuing to Execute' up to 1000 times. When SaveChangesAsync() finishes, execution returns to the SaveRecordsfunction, writing Save Complete to the console. Once everything in SaveRecords completes, execution will continue in MyCallingFunction right were it was when SaveChangesAsync() finished. Confused? Here is an example output:

Function Starting
Save Starting
Continuing to execute!
Continuing to execute!
Continuing to execute!
Continuing to execute!
Continuing to execute!
....
Continuing to execute!
Save Complete!
Continuing to execute!
Continuing to execute!
Continuing to execute!
....
Continuing to execute!
Function Complete!



(1) 1-1-19
Prob: Multiple Treads for sngle instance
Try: without ..Async(), we dont have parallel task


*/