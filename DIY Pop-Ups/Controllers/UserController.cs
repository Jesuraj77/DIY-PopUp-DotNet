using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIYPop_Ups.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DIYPop_Ups.Web.Controllers
{
    public class UserController : Controller
    {
        public bool BlockAd(int BrandId)
        {
            // code to block an ad

            return true;
        }
        public bool Login(string UserName, string Password)
        {
            // code for user login

            return true;
        }

        public bool Register(User user)
        {
           //code for user registration

            return true;
        }

        public bool PostAdvertiseByUser(List<Brand> brand)
        {
           // code here to post advertises by user
           
            return false;
        }


    }
}



