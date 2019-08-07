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
    public class BoySingleRelData       
    {
        public IEnumerable<Boy> BoyEnumerable {get; set;}
        public IEnumerable<BoyLikes> BoyLikesEnumerable {get; set;}   
        public IEnumerable<Girl> GirlEnumerable {get; set;}
             
    }



}
    
