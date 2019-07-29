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
        public async Task OnGetAsync()        {
        Girl = await _context.Girl.ToListAsync(); //OK
        FillNotEnteredButRefCandidates(); //must be before Process 
        Post(); 

      } // OnGetAssync () 

    public void   Post() {           
         var Boys =  _context.Boy.ToListAsync(); 
         var LikedBy = "";
    //for (int n = 1 ; n < 5; n++) { //Outer loop
    foreach (var b in _context.Girl) { //Outer loop, For loop not cares of break in BoyID no
    //var b = _context.Girl.Find(n); //OK  Boy     
      //if (b == null) break; // Care for end of file
      LikedBy = "" ; //init  in outer loop not in inner-1 loop not inner-2
//LikedBy = "gID = " + Convert.ToString(b.GirlID) ; //Temp test      
      
       //for (int i1 = 1 ; i1 < 5 ; i1++){ //Inner-1 loop
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
      _context.SaveChangesAsync(); //OK              
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
