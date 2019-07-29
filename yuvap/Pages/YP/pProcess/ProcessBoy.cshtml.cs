using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using yuvap.Data;
using yuvap.Models;
using Microsoft.AspNetCore.Mvc.Rendering; //nsb

namespace yuvap.Pages.YP.pProcess
{
    public class ProcessBoyModel : PageModel
    {
        private readonly yuvap.Data.YPContext _context;
        public ProcessBoyModel(yuvap.Data.YPContext context)
        {
            _context = context;
        }
        //[BindProperty]
        public IList<Boy> Boy { get;set; }
        public Boy b1 { get; set; } //nsb //Required to remove err: "no method .find()"
        //public IList<Girl> Girl {get; set;}
       // public Boy Boy {get; set;}
       // public Girl Girl {get; set;}
       // public IList<int> Likes; 
        //IEnumerable< int> boyTotal = _context.boy.count();
        //public Boy b1; //nsb
    public async Task OnGetAsync()        {
      Boy = await _context.Boy.ToListAsync(); //OK
        //_context.Boy.Add(b1); OK only if b1 is Boy-Property {get;set;} declared.
        FillNotEnteredButRefCandidates(); //IT MUST BE BEFORE Post()
        Post(); //ProcessBoyData();             
      } // OnGetAssync () 

    //public void async Task ProcessAndSave() {
    public void   Post() {    
        // Boy Boy ; //{get; set;}
        // Girl Girl; // {get; set;}
         //var Boys= await _context.Boy.ToListAsync(); 
         //var Girls = await _context.Girl.ToListAsync(); 
      //   _context.Boy Boy ;
      //  var Boys = new List<_context.Boy>();
    //var Boys =  _context.Boy.ToListAsync(); 
         
         var Girls =  _context.Girl.ToListAsync(); 
         var LikedBy = "";
//for (int n = 1 ; n < 5; n++) { //Outer loop
    foreach (var b in _context.Boy) { //Outer loop, For loop not cares of break in BoyID 
//var b = _context.Boy.Find(n); //OK  Boy
     //Test    
        //var Boy = _context.Boy.Find(3); //    
        //var Boy = Boys.Find(3); //  
      //  IEnumerable<Boy> b;
      //  b = Boy.Find(3);  //_context.Boy.Find(3); // ok
//Boy.BoyLikedByConcat  =  LikedBy; 

      //Boy = Boys.Find(n);     
        //if (Boy == null) break; OK // Must to avoid err of NULL Ref Exception !!!
//if (b == null) break; // Care for end of file, not cares of break in BoyID no
      LikedBy = "" ; //init  in outer loop not in inner-1 loop not inner-2
//LikedBy = "bID=" + Convert.ToString(b.BoyID)+":-" ; //Temp
             //Boy = await _context.Boy.ToListAsync();
           //int boyTot = Boy.Count;
      //foreach (var item in collection)      
//for (int i1 = 1 ; i1 < 5 ; i1++){ //Inner-1 loop
      foreach (var girl in _context.Girl) {
//var Girl = _context.Girl.Find(i1); //OK       
            //Girls = _context.Girl.Find(i1);        
            //Girl = Girls.Find(i1);
//if (Girl == null) break; //Care for end of file
//LikedBy = LikedBy + ",gID = " + Convert.ToString(girl.GirlID)+":" ; //Temp 
            //Girl = await _context.Girl.FirstAsync(r => r.GirlID==1);            
           //var strID = Convert.ToChar(Girl.GirlID); 
           //var strID = Convert.ToChar(2);         
           
       // for (int i2 =1 ; i2 < 9 ; i2++) { //Inner-2 loop ,Not reqd!!
           //init  
            //int LikeSNo = 0;
            //LikedBy = "" ; //boyLikes = "";
            //var strID = Girl.GirlID  ;
            var intPref  = 1;;
           var strID = Convert.ToString(girl.GirlID); // ToChar
           //var strID = Convert.ToString(2); // OK //ToChar  

            //for (LikeSNo = 0 ; LikeSNo < 8; LikeSNo ++ ){}
            intPref = Convert.ToInt32(girl.Pref1);   //OK   .ToInt      
           //var str1 = Convert.ToChar(Girl.GirlID);         
            //intPref = int32.Parse(Girl.Pref1);  
            //LikedBy = LikedBy + "Pref="+ Convert.ToString(intPref+","); //Temp
            if (intPref >0 ) { // Some candidate don't enter Pref data
                //Test
                //var strID = Convert.ToString(Girl.GirlID); //ToChar
                //LikedBy = strID ;
                //strID = Convert.ToString(2);  
                //LikedBy = strID ;//Convert.ToString(2);  //strId ;   
           // Likes[LikeSNo] = (int) Girl.Pref1; 
              if ( intPref == b.BoyID  ) {  //Problem NULL Ref Err, // Some candidate don't enter Pref data, Care for only those pref for which continuous data entered.
               LikedBy = LikedBy + "," + strID ;
               //LikeSNo ++ ;            
              } 
             /*  else{ //new entry to be added with BoyID=intPref and all other fields empty.     
                //_context.Boy.addrange(Boy); .add
               //var b1 = new Boy(); // BoyID=intPref}  
               b1.BoyID = intPref;
               b1.BoyLikedByConcat = "";
               b1.MobileNum = "";       
               b1.Name = "";
               b1.Pref1=null ; b1.Pref2=null ; b1.Pref3=null ; b1.Pref4=null ; 
               b1.Pref5=null ; b1.Pref6=null ; b1.Pref7=null ; b1.Pref8=null ;     
            _context.Boy.Add(b1); //OK only if b1 is Boy-Property {get;set;} declared.
             } */
            }
            /* else
            {                
             break ; // Pref after blank are ignored!!!
            }*/

            intPref = Convert.ToInt32(girl.Pref2); 
            //LikedBy = LikedBy + "Pf="+ Convert.ToString(intPref+","); //Temp
            if ( intPref  > 0 ) {
               if ( intPref == b.BoyID ) {
                LikedBy = LikedBy + "," + strID ;           
               } 
            }
           /* else
            {                
             break ; // Pref after blank are ignored!!!
            }*/

             intPref = Convert.ToInt32(girl.Pref3);        
            //LikedBy = LikedBy + "Pf="+ Convert.ToString(intPref+","); //Temp
           if ( intPref  > 0 ) {
               if ( intPref == b.BoyID ) {
                LikedBy = LikedBy + "," + strID ;           
               } 
            }
            
            intPref = Convert.ToInt32(girl.Pref4);        
            //LikedBy = LikedBy + "Pf="+ Convert.ToString(intPref+","); //Temp
           if ( intPref  > 0 ) {
               if ( intPref == b.BoyID ) {
                LikedBy = LikedBy + "," + strID ;           
               } 
            }
            
            intPref = Convert.ToInt32(girl.Pref5);        
            //LikedBy = LikedBy + "Pf="+ Convert.ToString(intPref+","); //Temp
           if ( intPref  > 0 ) {
               if ( intPref == b.BoyID ) {
                LikedBy = LikedBy + "," + strID ;           
               } 
            }
           
            intPref = Convert.ToInt32(girl.Pref6);        
            //LikedBy = LikedBy + "Pf=" +Convert.ToString(intPref+","); //Temp
           if ( intPref  > 0 ) {
               if ( intPref == b.BoyID ) {
                LikedBy = LikedBy + "," + strID ;           
               } 
            }
            
            intPref = Convert.ToInt32(girl.Pref7);        
            if ( intPref  > 0 ) {
               if ( intPref == b.BoyID ) {
                LikedBy = LikedBy + "," + strID ;           
               } 
            }
            
            intPref = Convert.ToInt32(girl.Pref8);        
            if ( intPref  > 0 ) {
               if ( intPref == b.BoyID ) {
                LikedBy = LikedBy + "," + strID ;           
               } 
            }           
           
        //Boy.BoyLikedByConcat  = boyLikes;
         
       // } //Inner-2 loop Not reqd
       } // Inner-1 loop
       //Boy.BoyLikedByConcat  =  LikedBy;   //boyLikes;
       b.BoyLikedByConcat  =  LikedBy; 
       //_context.SaveChanges();
       //await _context.SaveChangesAsync();
      _context.SaveChangesAsync(); //OK
              
    } //Outer loop ends
      // _context.SaveChangesAsync();
    } // Process  //AndSave() ends


    public void FillNotEnteredButRefCandidates(){
      var intPref  = 1; //init
      //var b2 = new Boy(); // must be created each time ,else same data repeated. // _context.Boy();
       
      //var Track = "";      
      foreach (var girl in _context.Girl) {
           //var Girls =  _context.Girl.ToListAsync(); 
            //var intPref  = 1;;
            //var strID = Convert.ToString(girl.GirlID);
            var Track = "";  
        //    Track = "G-" + Convert.ToString(girl.GirlID) + ": ";

            intPref = Convert.ToInt32(girl.Pref1);  
        //Track = Track + "Pf1=" +Convert.ToString(intPref) + ", "; // temp
            if (intPref >0 ) {     // Some candidate don't enter Pref data  
                //var b = _context.Boy.Find(n); //OK  Boy
    //intPref = 27; // test temp 
    //Track = Track + "Before if-null-7 " ;
    //intPref = 27; // test temp 
             //var v = _context.Boy.Find(intPref)
             if (_context.Boy.Find(intPref) == null){ // Create if not found BoyID  
            //if (_context.Boy.Find(intPref).GirlID == 0){ // Create if not found BoyID  
       
       //intPref = 27; // test temp  
       //Track = Track + "Inside-27, intPref=" + Convert.ToString(intPref) + ", ";
//girl.GirlLikedByConcat = Track ; //temp
//_context.SaveChangesAsync();  //public Boy b1 {get;set;}
      // var b2 = new Boy(); // _context.Boy();
            var b2 = new Boy(); // must be created each time ,else same data repeated. // _context.Boy();             
               b2.BoyID = intPref;        
      //Track = Track + "Inside-27 " ;
               b2.BoyLikedByConcat = "";
               b2.MobileNum = "";       
               b2.Name = "";
               b2.Pref1=null ; b2.Pref2=null ; b2.Pref3=null ; b2.Pref4=null ; 
               b2.Pref5=null ; b2.Pref6=null ; b2.Pref7=null ; b2.Pref8=null ;     
               _context.Boy.Add(b2); //OK only if b1 is Boy-Property {get;set;} declared.? No, var b2 = new Boy();  worked
             
          /*    b1.BoyID = intPref;        
               b1.BoyLikedByConcat = "";
               b1.MobileNum = "";       
               b1.Name = "";
               b1.Pref1=null ; b1.Pref2=null ; b1.Pref3=null ; b1.Pref4=null ; 
               b1.Pref5=null ; b1.Pref6=null ; b1.Pref7=null ; b1.Pref8=null ;     
               _context.Boy.Add(b1); //OK only if b1 is Boy-Property {get;set;} declared.
            */
             }    
            }  

            intPref = Convert.ToInt32(girl.Pref2);   
        // Track = Track + "Pf2=" + Convert.ToString(intPref) + ", "; // temp
           if (intPref >0 ) {     // Some candidate don't enter Pref data  
                //var b = _context.Boy.Find(n); //OK  Boy
             if (_context.Boy.Find(intPref)== null){ // Create if not found BoyID
             var b2 = new Boy();
               b2.BoyID = intPref;
               b2.BoyLikedByConcat = "";
               b2.MobileNum = "";       
               b2.Name = "";
               b2.Pref1=null ; b2.Pref2=null ; b2.Pref3=null ; b2.Pref4=null ; 
               b2.Pref5=null ; b2.Pref6=null ; b2.Pref7=null ; b2.Pref8=null ;     
               _context.Boy.Add(b2); //OK only if b1 is Boy-Property {get;set;} declared.
             }    
            }   
            
            intPref = Convert.ToInt32(girl.Pref3);   
        //Track = Track + "Pf3=" + Convert.ToString(intPref) + ", "; // temp
            //girl.GirlLikedByConcat = Track ; //temp
            //_context.SaveChangesAsync();  
             if (intPref >0 ) {
             if (_context.Boy.Find(intPref)== null){ 
            //if (_context.Boy.Find(intPref) == 0){ // Create if not found BoyID  
            //Track = Track + "Inside-if-null Pf3=" + Convert.ToString(intPref) + ", "; // temp
            //girl.GirlLikedByConcat = Track ; //temp
            //_context.SaveChangesAsync();  
            var b2 = new Boy(); 
               b2.BoyID = intPref;
               b2.BoyLikedByConcat = "";
               b2.MobileNum = "";       
               b2.Name = "";
               b2.Pref1=null ; b2.Pref2=null ; b2.Pref3=null ; b2.Pref4=null ; 
               b2.Pref5=null ; b2.Pref6=null ; b2.Pref7=null ; b2.Pref8=null ;     
               _context.Boy.Add(b2); 
             }    
            }    

            intPref = Convert.ToInt32(girl.Pref4);   
         //Track = Track + "Pf4=" + Convert.ToString(intPref) + ", "; // temp
            if (intPref >0 ) {     
             if (_context.Boy.Find(intPref)== null){ 
            var b2 = new Boy();
               b2.BoyID = intPref;
               b2.BoyLikedByConcat = "";
               b2.MobileNum = "";       
               b2.Name = "";
               b2.Pref1=null ; b2.Pref2=null ; b2.Pref3=null ; b2.Pref4=null ; 
               b2.Pref5=null ; b2.Pref6=null ; b2.Pref7=null ; b2.Pref8=null ;     
               _context.Boy.Add(b2); 
             }    
            }    

            intPref = Convert.ToInt32(girl.Pref5);   
        //Track = Track + "Pf5=" + Convert.ToString(intPref) + ", "; // temp
             if (intPref >0 ) { 
             if (_context.Boy.Find(intPref)== null){ 
            var b2 = new Boy();
               b2.BoyID = intPref;
               b2.BoyLikedByConcat = "";
               b2.MobileNum = "";       
               b2.Name = "";
               b2.Pref1=null ; b2.Pref2=null ; b2.Pref3=null ; b2.Pref4=null ; 
               b2.Pref5=null ; b2.Pref6=null ; b2.Pref7=null ; b2.Pref8=null ;     
               _context.Boy.Add(b2); 
             }    
            }    

            intPref = Convert.ToInt32(girl.Pref6);   
         //Track = Track + "Pf6=" + Convert.ToString(intPref) + ", "; // temp
            if (intPref >0 ) {  
             if (_context.Boy.Find(intPref)== null){ 
               var b2 = new Boy();
               b2.BoyID = intPref;
               b2.BoyLikedByConcat = "";
               b2.MobileNum = "";       
               b2.Name = "";
               b2.Pref1=null ; b2.Pref2=null ; b2.Pref3=null ; b2.Pref4=null ; 
               b2.Pref5=null ; b2.Pref6=null ; b2.Pref7=null ; b2.Pref8=null ;     
               _context.Boy.Add(b2); 
             }    
            }    

            intPref = Convert.ToInt32(girl.Pref7);   
        //Track = Track + "Pf7=" + Convert.ToString(intPref) + ", "; // temp
             if (intPref >0 ) {   
             if (_context.Boy.Find(intPref)== null){
               var b2 = new Boy();   
               b2.BoyID = intPref;
               b2.BoyLikedByConcat = "";
               b2.MobileNum = "";       
               b2.Name = "";
               b2.Pref1=null ; b2.Pref2=null ; b2.Pref3=null ; b2.Pref4=null ; 
               b2.Pref5=null ; b2.Pref6=null ; b2.Pref7=null ; b2.Pref8=null ;     
               _context.Boy.Add(b2); 
             }    
            }     

            intPref = Convert.ToInt32(girl.Pref8);   
         //Track = Track + "Pf8=" + Convert.ToString(intPref) + ", "; // temp
            if (intPref >0 ) {   
             if (_context.Boy.Find(intPref)== null){ 
               var b2 = new Boy();
               b2.BoyID = intPref;
               b2.BoyLikedByConcat = "";
               b2.MobileNum = "";       
               b2.Name = "";
               b2.Pref1=null ; b2.Pref2=null ; b2.Pref3=null ; b2.Pref4=null ; 
               b2.Pref5=null ; b2.Pref6=null ; b2.Pref7=null ; b2.Pref8=null ;     
               _context.Boy.Add(b2);
             }    
            }   
             girl.GirlLikedByConcat = Track ;
             _context.SaveChangesAsync();   

      } //Loop    
    } //FillNotEnteredButRefCandidates ends 

    } //Class ends
} // Namespace ends

/*
Histry / Help
(4)
Identity Role : https://code.msdn.microsoft.com/Getting-Started-With-e98e08b9

(3)
     //var b2 = new Boy(); // must be created each time ,else same data repeated. // _context.Boy();
     
       _context.Boy.Add(b2); //OK only if b1 is Boy-Property {get;set;} declared.? No, var b2 = new Boy();  worked
       
               b1.BoyID = intPref;
               b1.BoyLikedByConcat = "";
               b1.MobileNum = "";       
               b1.Name = "";
               b1.Pref1=null ; b1.Pref2=null ; b1.Pref3=null ; b1.Pref4=null ; 
               b1.Pref5=null ; b1.Pref6=null ; b1.Pref7=null ; b1.Pref8=null ;     
            _context.Boy.Add(b1); //OK only if b1 is Boy-Property {get;set;} declared.

(2) Dt 13-12-18
Scenerio -1 : A boy has not entered data but some girls have entered Pref for him!!
Soln: The boy's entry to be Auto-added with only Reg-no and shown in report.
    This auto-added entry, if its boyID < current boyID, then what? No problem! ? 
    Will Foreach() include it? if Yes, all such entries will be added while 1st boy is processed.?

    We have to write/run a method FillNotEnteredButRefCandidates() before Process()

 (1) http://www.entityframeworktutorial.net/entityframework6/addrange-removerange.aspx
 IList<Student> newStudents = new List<Student>() {
                                    new Student() { StudentName = "Steve" };
                                    new Student() { StudentName = "Bill" };
                                    new Student() { StudentName = "James" };
                                };               

using (var context = new SchoolDBEntities())
{
    context.Students.AddRange(newStudents);
    context.SaveChanges();
}
The following example demonstrates removing multiple entities.

IList<Student> studentsToRemove = new List<Student>() {
                                    new Student() { StudentId = 1, StudentName = "Steve" };
                                    new Student() { StudentId = 2, StudentName = "Bill" };
                                    new Student() { StudentId = 3, StudentName = "James" };
                                };
    
using (var context = new SchoolDBEntities())
{
    context.Students.RemoveRange(studentsToRemove);
    context.SaveChanges();
}
 
 
 */