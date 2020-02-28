using DIYPop_Ups.BusinessLayer.Interfaces;
using DIYPop_Ups.BusinessLayer.Servicess;
using DIYPop_Ups.Entities;
using DIYPop_Ups.NHibernate;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DIYPop_Ups.Test.TestCases
{
    public class FuctionalTest
    {
        private readonly UserService user_service;
        private readonly AdvertiseService advertiser_service;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();

        public FuctionalTest()
        {
            user_service = new UserService(_session);
            advertiser_service = new AdvertiseService(_session);
        }

        //User Testcases
        [Fact]
        public void Test_For_Valid_Registration()
        {
            //Arrange
            User user = new User
            {
                Id = 100,
                UserName = "Mary",
                Age = 25,
                Location = "Delhi",
                FamilyStatus = "",
                Gender = "Female",
                Password = "123456789",
                Intrest="",
                
            };

            Advertiser advertiser = new Advertiser
            {
                Id = 1,
                UserName = "Suresh",
                Password = "123",
            };

            //Action
            var IsRegisteredFromUser = user_service.Register(user);
            var IsRegisteredFromAdvertiser = advertiser_service.Register(advertiser);

            //Assert
            Assert.True(IsRegisteredFromUser);
            Assert.True(IsRegisteredFromAdvertiser);
        }


        [Fact]
        public void Test_For_Valid_SignIn()
        {
            //Arrange
            User user = new User
            {
                Id = 100,
                UserName = "Mary",
                Age = 25,
                Location = "Delhi",
                FamilyStatus = "",
                Gender = "Female",
                Password = "123456789",
                Intrest = "",
            };

            Advertiser advertiser = new Advertiser
            {
                UserName = "suresh",
                Password = "123"
            };

            //Action
            var IsLoggedFromUser = user_service.Login(user.UserName, user.Password);
            var IsLoggedFromAdvertiser = advertiser_service.Login(advertiser.UserName, advertiser.Password);
            //Assert
            
            Assert.True(IsLoggedFromUser);
            Assert.True(IsLoggedFromAdvertiser);
        }



        [Fact]
        public void Test_For_Valid_AdvertisePost()
        {
            User user = new User
            {
                Id = 100,
                UserName = "Mary",
                Age = 25,
                Location = "Delhi",
                FamilyStatus = "",
                Gender = "Female",
                Password = "123456789",
                Intrest = "",
            };

            List<User> UserList = new List<User>();
            UserList.Add(user);

            Brand brand = new Brand
            {
                Id = 1,
                BrandName = "cake",
                BrandDescription = "xxx..",
                AdvertiserId = 1,
                Video = "",
            };

            List<Brand> BrandList = new List<Brand>();
            BrandList.Add(brand);

            //Action
            var isPosted = advertiser_service.PostAdvertise(BrandList,UserList);

            //Assert
            Assert.Equal(true, isPosted);
           
        }



        [Fact]
        public void Test_for_BlockAd()
        {
            Brand brand = new Brand
            {
                Id = 1
            };

            var block = user_service.BlockAd(brand.Id);

            Assert.Equal(true, block);

        }



        [Fact]
        public void Test_For_Valid_SearchUser()
        {
            //Arrange

            User user = new User
            {
                Id = 100,
                UserName = "Mary",
                Age = 25,
                Location = "Delhi",
                FamilyStatus = "",
                Gender = "Female",
                Password = "123456789",
                Intrest = "",
            };

            List<User> userlist = new List<User>();
            userlist.Add(user);

            // Action
            var gotUserlist = advertiser_service.SearchUser(user);

            //Assert
            Assert.Equal(userlist, gotUserlist);


        }
        [Fact]
        public void Test_For_Valid_AgreePayment()
        {
            //Arrange
            User user = new User
            {
                Id = 100,
                UserName = "Mary",
                Age = 25,
                Location = "Delhi",
                FamilyStatus = "",
                Gender = "Female",
                Password = "123456789",
                Intrest = "",
            };
            Advertiser advertiser = new Advertiser();

            PayementType payment = new PayementType();

            //Action
            var IsAgreed = advertiser_service.AgreePayment(user.Id, advertiser.Id, payment);

            //Action
            Assert.Equal(true, IsAgreed);
            Assert.True(IsAgreed);
        }

    }

}

