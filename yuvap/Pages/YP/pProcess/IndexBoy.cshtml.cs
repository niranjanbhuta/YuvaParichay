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
    public class IndexBoyModel : PageModel
    {
        private readonly yuvap.Data.YPContext _context;
        public IndexBoyModel(yuvap.Data.YPContext context)
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
        //ProcessAndSave();             
      } // OnGetAssync () 

    //public void async Task ProcessAndSave() {
    public void   ProcessAndSave() {    
        // Boy Boy ; //{get; set;}
        // Girl Girl; // {get; set;}
         //var Boys= await _context.Boy.ToListAsync(); 
         //var Girls = await _context.Girl.ToListAsync(); 
      //   _context.Boy Boy ;
      //  var Boys = new List<_context.Boy>();
    //var Boys =  _context.Boy.ToListAsync(); 
         
         var Girls =  _context.Girl.ToListAsync(); 
         var LikedBy = "";
    for (int n = 1 ; n < 5; n++) { //Outer loop
    var b = _context.Boy.Find(n); //OK  Boy
     //Test    
        //var Boy = _context.Boy.Find(3); //    
        //var Boy = Boys.Find(3); //  
      //  IEnumerable<Boy> b;
      //  b = Boy.Find(3);  //_context.Boy.Find(3); // ok
//Boy.BoyLikedByConcat  =  LikedBy; 

      //Boy = Boys.Find(n);     
        //if (Boy == null) break; OK // Must to avoid err of NULL Ref Exception !!!
 if (b == null) break; 
      LikedBy = "" ; //init  in outer loop not in inner-1 loop not inner-2
      //LikedBy = "bID = " + Convert.ToString(b.BoyID) ; //Temp
             //Boy = await _context.Boy.ToListAsync();
           //int boyTot = Boy.Count;
      //foreach (var item in collection)      
      for (int i1 = 1 ; i1 < 5 ; i1++){ //Inner-1 loop
           var Girl = _context.Girl.Find(i1); //OK       
            //Girls = _context.Girl.Find(i1);        
            //Girl = Girls.Find(i1);
            if (Girl == null) break;
         //LikedBy = LikedBy + ",gID = " + Convert.ToString(Girl.GirlID) ; //Temp 
            //Girl = await _context.Girl.FirstAsync(r => r.GirlID==1);            
           //var strID = Convert.ToChar(Girl.GirlID); 
           //var strID = Convert.ToChar(2);         
           
       // for (int i2 =1 ; i2 < 9 ; i2++) { //Inner-2 loop ,Not reqd!!
           //init  
            //int LikeSNo = 0;
            //LikedBy = "" ; //boyLikes = "";
            //var strID = Girl.GirlID  ;
            var intPref  = 1;;
           var strID = Convert.ToString(Girl.GirlID); // ToChar
           //var strID = Convert.ToString(2); // OK //ToChar  

            //for (LikeSNo = 0 ; LikeSNo < 8; LikeSNo ++ ){}
            intPref = Convert.ToInt32(Girl.Pref1);   //OK   .ToInt      
           //var str1 = Convert.ToChar(Girl.GirlID);         
            //intPref = int32.Parse(Girl.Pref1);  

            //LikedBy = LikedBy + "Pref="+ Convert.ToString(intPref+","); //Temp
            if (intPref >0 ) {
                //Test
                //var strID = Convert.ToString(Girl.GirlID); //ToChar
                //LikedBy = strID ;
                //strID = Convert.ToString(2);  
                //LikedBy = strID ;//Convert.ToString(2);  //strId ;   

           // Likes[LikeSNo] = (int) Girl.Pref1; 
              if ( intPref == b.BoyID  ) {  //Problem NULL Ref Err
               LikedBy = LikedBy + "," + strID ;
               //LikeSNo ++ ;            
              } 
            }
            /* else
            {                
             break ; // Pref after blank are ignored!!!
            }*/

            intPref = Convert.ToInt32(Girl.Pref2); 
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

             intPref = Convert.ToInt32(Girl.Pref3);        
            //LikedBy = LikedBy + "Pf="+ Convert.ToString(intPref+","); //Temp
           if ( intPref  > 0 ) {
               if ( intPref == b.BoyID ) {
                LikedBy = LikedBy + "," + strID ;           
               } 
            }
            
            intPref = Convert.ToInt32(Girl.Pref4);        
            //LikedBy = LikedBy + "Pf="+ Convert.ToString(intPref+","); //Temp
           if ( intPref  > 0 ) {
               if ( intPref == b.BoyID ) {
                LikedBy = LikedBy + "," + strID ;           
               } 
            }
            
            intPref = Convert.ToInt32(Girl.Pref5);        
            //LikedBy = LikedBy + "Pf="+ Convert.ToString(intPref+","); //Temp
           if ( intPref  > 0 ) {
               if ( intPref == b.BoyID ) {
                LikedBy = LikedBy + "," + strID ;           
               } 
            }
           
            intPref = Convert.ToInt32(Girl.Pref6);        
            //LikedBy = LikedBy + "Pf=" +Convert.ToString(intPref+","); //Temp
           if ( intPref  > 0 ) {
               if ( intPref == b.BoyID ) {
                LikedBy = LikedBy + "," + strID ;           
               } 
            }
            
            intPref = Convert.ToInt32(Girl.Pref7);        
            if ( intPref  > 0 ) {
               if ( intPref == b.BoyID ) {
                LikedBy = LikedBy + "," + strID ;           
               } 
            }
            
            intPref = Convert.ToInt32(Girl.Pref8);        
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


    } // ProcessAndSave() ends


    } //Class ends
} // Namespace ends
