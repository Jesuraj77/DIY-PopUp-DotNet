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
    public class BoundaryTest
    {
        private readonly UserService user_service;
        private readonly AdvertiseService advertiser_service;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();

        public BoundaryTest()
        {
            user_service = new UserService(_session);
            advertiser_service = new AdvertiseService(_session);
        }

        [Fact]
        public void BoundaryTest_ForPassword_Length()
        {
            User user = new User();
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = user.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForUserName_Length()
        {
            User user = new User();
            //Arrange
            var MinLength = 0;
            var MaxLength = 50;

            //Action
            var actualLength = user.UserName.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        

    
    }
}
