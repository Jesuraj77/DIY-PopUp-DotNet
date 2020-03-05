using DIYPop_Ups.BusinessLayer.Servicess;
using DIYPop_Ups.Entities;
using DIYPop_Ups.NHibernate;
using DIYPop_Ups.Test.Exceptions;
using NSubstitute;
using Xunit;

namespace DIYPop_Ups.Test.TestCases
{
    public class ExeptionTest
    {
        private readonly UserService User_Service;
        private readonly AdvertiserService Advertiser_Service;
        private readonly IMapperSession _Session = Substitute.For<IMapperSession>();

        public ExeptionTest()
        {
            User_Service = new UserService(_Session);
            Advertiser_Service = new AdvertiserService(_Session);
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
                Interest = "",

            };
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => Advertiser_Service.SearchUser(user));
            Assert.Equal("User Not Found", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_ValidUser_InvalidPassword()
        {
            User user = new User { Id = 1, UserName = "Mary", Age = 23, Location = "bangalore", Gender = "male", Password = "123", Interest = "Cosmetics" };
            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsExecptions>(() => User_Service.Login("abc", "987654321"));
            var exc = Assert.Throws<InvalidCredentialsExecptions>(() => Advertiser_Service.Login("ab", "9876547321"));
            Assert.Equal("Please enter valid usename & password", ex.Messages);
            Assert.Equal("Please enter valid usename & password", exc.Messages);
        }

        [Fact]
        public void ExceptionTestFor_InvalidUser_validPassword()
        {
            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsExecptions>(() => User_Service.Login("abc", "987654321"));
            var exc = Assert.Throws<InvalidCredentialsExecptions>(() => Advertiser_Service.Login("ab", "9876543721"));

            Assert.Equal("Please enter valid usename & password", ex.Messages);
            Assert.Equal("Please enter valid usename & password", exc.Messages);
        }

    }
}
