using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

//using Microsoft.AspnetCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

using yuvap.Models;
using yuvap.Data;

namespace yuvap.ViewModels
{
    public class BoyIndexData       
    {
        public IEnumerable<Boy> Boys {get; set;}
        public IEnumerable<BoyLikes> BoyLikes {get; set;}   
        public IEnumerable<Girl> Girls {get; set;}
             
    }



}
    
