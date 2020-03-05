using DIYPop_Ups.BusinessLayer.Servicess;
using DIYPop_Ups.Entities;
using DIYPop_Ups.NHibernate;
using NSubstitute;
using System.Collections.Generic;
using Xunit;

namespace DIYPop_Ups.Test.TestCases
{
    public class FuctionalTest
    {
        private readonly UserService User_Service;
        private readonly AdvertiserService Advertiser_Service;
        private readonly IMapperSession _Session = Substitute.For<IMapperSession>();

        public FuctionalTest()
        {
            User_Service = new UserService(_Session);
            Advertiser_Service = new AdvertiserService(_Session);
        }


        User user = new User
        {
            Id = 100,
            UserName = "Mary",
            Age = 25,
            Location = "Delhi",
            FamilyStatus = "",
            Gender = "Female",
            Password = "123456789",
            Interest = "",
        };
        Advertiser advertiser = new Advertiser
        {
            Id = 1,
            UserName = "Suresh",
            Password = "123",
        };

        Brand brand = new Brand
        {
            Id = 1,
            BrandName = "cake",
            BrandDescription = "xxx..",
            AdvertiserId = 1,
            Video = "",
        };

        //User Testcases
        [Fact]
        public void Test_For_Valid_RegistrationForUser()
        {
            //Arrange
            //Action
            var IsRegisteredFromUser = User_Service.Register(user);

            //Assert
            Assert.True(IsRegisteredFromUser);
        }


        [Fact]
        public void TestFor_Valid_RegistrationForAdvertiser()
        {
            //Action
            var IsRegisteredFromAdvertiser = Advertiser_Service.Register(advertiser);
            //Assert
            Assert.True(IsRegisteredFromAdvertiser);
        }


        [Fact]
        public void TestFor_Valid_SignInForUser()
        {
            //Action
            var IsLoggedFromUser = User_Service.Login(user.UserName, user.Password);
            //Assert
            Assert.True(IsLoggedFromUser);
        }

        [Fact]
        public void TestFor_Valid_AdvertisePostByUser()
        {
            List<Brand> BrandList = new List<Brand>();
            BrandList.Add(brand);

            //Action
            var isPosted = User_Service.PostAdvertiseByUser(BrandList);

            //Assert
            Assert.True(isPosted);
        }

        [Fact]
        public void TestFor_Valid_SignInForAdvertiser()
        {
            //Action
            var IsLoggedFromAdvertiser = Advertiser_Service.Login(advertiser.UserName, advertiser.Password);
            //Assert
            Assert.True(IsLoggedFromAdvertiser);
        }


        [Fact]
        public void TestFor_Valid_AdvertisePost()
        {
            //Arrange
            List<User> UserList = new List<User>();
            UserList.Add(user);

            List<Brand> BrandList = new List<Brand>();
            BrandList.Add(brand);

            //Action
            var isPosted = Advertiser_Service.PostAdvertise(BrandList,UserList);

            //Assert
            Assert.True(isPosted);
        }

        [Fact]
        public void TestFor_BlockAd()
        {
            var block = User_Service.BlockAd(brand.Id);
            Assert.True( block);
        }

        [Fact]
        public void TestFor_Valid_SearchUser()
        {
            //Arrange
            List<User> userlist = new List<User>();
            userlist.Add(user);

            // Action
            var gotUserlist = Advertiser_Service.SearchUser(user);

            //Assert
            Assert.Equal(userlist, gotUserlist);
        }

        [Fact]
        public void TestFor_Valid_AgreePayment()
        {
            //Arrange
            PaymentType payment = new PaymentType()
            {    PayPerLike=true,
                 PayPerView=true,
                 PayPerClick=true
            };

            //Action
            var IsAgreed = Advertiser_Service.AgreePayment(user.Id, advertiser.Id, payment);

            //Action
            Assert.True(IsAgreed);
        }

        [Fact]
        public void TestFor_Valid_SendingMessages()
        {
         //Action
         var isSent= Advertiser_Service.SendMessages(user);

         //Assert
         Assert.True(isSent);
        }

    }
}

