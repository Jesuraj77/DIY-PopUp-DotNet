using DIYPop_Ups.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIYPop_Ups.BusinessLayer.Interfaces
{
    public interface IAdvertiserService
    {
        bool Register(Advertiser advertiser);
        bool Login(string UserName, string Password);
        bool PostAdvertise(List<Brand> brand,List<User> user);
        List<User> SearchUser(User user);
        bool AgreePayment(int UserId, int advertiserId, PaymentType payementType);
        bool SendMessages(User user);
    }
}
