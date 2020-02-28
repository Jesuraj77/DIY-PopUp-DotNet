using DIYPop_Ups.BusinessLayer.Servicess;
using DIYPop_Ups.Entities;
using DIYPop_Ups.NHibernate;
using DIYPop_Ups.Test.Exceptions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DIYPop_Ups.Test.TestCases
{
    public class ExeptionTest
    {
        private readonly UserService user_service;
        private readonly AdvertiseService advertiser_service;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();

        public ExeptionTest()
        {
            user_service = new UserService(_session);
            advertiser_service = new AdvertiseService(_session);
        }


        

        [Fact]
        public void ExceptionTestFor_SearchingAnUser()
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
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => advertiser_service.SearchUser(user));
            Assert.Equal("User Not Found", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_ValidUser_InvalidPassword()
        {
            User user = new User { Id = 1, UserName = "Mary", Age = 23, Location = "bangalore", Gender = "male", Password = "123", Intrest = "Cosmetics" };
            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsExecptions>(() => user_service.Login("abc", "987654321"));
            var exc = Assert.Throws<InvalidCredentialsExecptions>(() => advertiser_service.Login("ab", "9876547321"));
            Assert.Equal("Please enter valid usename & password", ex.Messages);
            Assert.Equal("Please enter valid usename & password", exc.Messages);
        }

        [Fact]
        public void ExceptionTestFor_InvalidUser_validPassword()
        {
            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsExecptions>(() => user_service.Login("abc", "987654321"));
            var exc = Assert.Throws<InvalidCredentialsExecptions>(() => advertiser_service.Login("ab", "9876543721"));


            Assert.Equal("Please enter valid usename & password", ex.Messages);
            Assert.Equal("Please enter valid usename & password", exc.Messages);
        }

    }
}
