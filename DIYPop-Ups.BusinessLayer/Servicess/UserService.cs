using DIYPop_Ups.BusinessLayer.Interfaces;
using DIYPop_Ups.Entities;
using DIYPop_Ups.NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIYPop_Ups.BusinessLayer.Servicess
{
    public class UserService : IUserServices
    {

        private readonly IMapperSession _session;

        public UserService(IMapperSession session)
        {
            _session = session;
        }

        public bool Register(User user)
        {
            return false;
        }

        public bool Login(string UserName, string Password)
        {
            return false;
        }

        public bool PostAdvertiseByUser(List<Brand> brand)
        {
            return false;
        }

        public bool BlockAd(int BrandId)
        {
            return false;
        }
    }
}
