using DIYPop_Ups.BusinessLayer.Interfaces;
using DIYPop_Ups.Entities;
using DIYPop_Ups.NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIYPop_Ups.BusinessLayer.Servicess
{
    public class AdvertiserService : IAdvertiserService
    {
        private readonly IMapperSession _session;

        public AdvertiserService(IMapperSession session)
        {
            _session = session;
        }
                                                                                                                                                                                                                                                                                                                                                                                            

        public bool AgreePayment(int UserId, int advertiserId,PaymentType paymentType)
        {
            return false;
        }


        public bool Login(string UserName, string Password)
        {
            return false;
        }


        public bool PostAdvertise(List<Brand> brand, List<User> user)
        {
            return false;
        }

        public bool PostAdvertiseByUser(List<Brand> brand,List<User> user)
        {
            return false;       
        }

        public bool Register(Advertiser advertiser)
        {
            return false;
        }

        public List<User> SearchUser(User user)
        {
            List<User> UserList = new List<User>();
            return UserList;
        }

        public bool SendMessages(User user)
        {
            return false;
        }
    }
}
