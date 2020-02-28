using DIYPop_Ups.BusinessLayer.Interfaces;
using DIYPop_Ups.Entities;
using DIYPop_Ups.NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIYPop_Ups.BusinessLayer.Servicess
{
    public class AdvertiseService : IAdvertiseService
    {


        private readonly IMapperSession _session;

        public AdvertiseService(IMapperSession session)
        {
            _session = session;
        }

        public bool AgreePayment(int UserId, int advertiseId,PayementType paymentType)
        {
            PayementType paymenttype = new PayementType();
            return true;
        }

        public bool Login(string UserName, string Password)
        {
            return true;
        }

        public bool PostAdvertise(List<Brand> brand,List<User> user)
        {
            return true;       
        }

        public bool Register(Entities.Advertiser advertise)
        {
            return true;
        }

        public List<Entities.User> SearchUser(Entities.User user)
        {
            List<Entities.User> UserList = new List<Entities.User>();
            return UserList;
        }
    }
}
