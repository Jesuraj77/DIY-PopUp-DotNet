using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIYPop_Ups.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DIYPop_Ups.Web.Controllers
{
    public class AdvertiserController : Controller
    {
        public bool AgreePayment(int UserId, int advertiseId, PaymentType paymentType)
        {

            //code for payment from user to advertiser
            return true;
        }
        public bool Login(string UserName, string Password)
        {

            // Login for advertiser
            return true;
        }
        public bool PostAdvertise(List<Brand> brand, List<User> user)
        {
            // code to post an ad(advertise)

            return true;
        }
        public bool Register(Advertiser advertise)
        {
            //code for rrgistration

            return true;
        }

        public List<User> SearchUser(User user)
        {
            //write query to get user from db

            // code to search user

            List<User> UserList = new List<User>();
            return UserList;
        }
        public bool SendMessages(User user)
        {
            //Code here to Send Messages to User About Advertise
            return true;
        }



    }
}





