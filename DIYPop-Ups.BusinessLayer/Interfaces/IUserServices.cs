using DIYPop_Ups.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIYPop_Ups.BusinessLayer.Interfaces
{
    public interface IUserServices
    {
        bool Register(User user);
        bool Login(string UserName, string Password);
        bool BlockAd(int BrandId);
        bool PostAdvertiseByUser(List<Brand> brand);
    }
}
