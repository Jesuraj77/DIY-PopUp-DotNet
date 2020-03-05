using DIYPop_Ups.BusinessLayer.Servicess;
using DIYPop_Ups.Entities;
using DIYPop_Ups.NHibernate;
using NSubstitute;
using Xunit;

namespace DIYPop_Ups.Test.TestCases
{
    public class BoundaryTest
    {
        private readonly UserService User_Service;
        private readonly AdvertiserService Advertiser_Service;
        private readonly IMapperSession _Session = Substitute.For<IMapperSession>();

        public BoundaryTest()
        {
            User_Service = new UserService(_Session);
            Advertiser_Service = new AdvertiserService(_Session);
        }

        User user = new User()
        {
            Id=100,
            UserName="John", 
            Email="john@gmail.com",
            Age =25,
            Location="Paris", 
            FamilyStatus="Rich",
            Gender ="Male",
            Password ="john1234",
            Interest="Car"
        };

        [Fact]
        public void BoundaryTestFor_Password_Length()
        {
            //Arrange
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = user.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTestFor_UserName_Length()
        {
            //Arrange
            var MinLength = 3;
            var MaxLength = 50;

            //Action
            var actualLength = user.UserName.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTestFor_ValidEmailFormat()
        {
            var emailRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Assert.DoesNotMatch(emailRegex, user.Email);
        }



    }
}
