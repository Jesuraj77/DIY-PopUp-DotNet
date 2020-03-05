using DIYPop_Ups.Entities;
using FluentNHibernate.Mapping;


namespace DIYPop_Ups.Mapping
{
   public class UserMap:ClassMap<User>
    {
        public UserMap()
        {

            Id(x => x.Id);
            Map(x => x.UserName);
            Map(x => x.Email);
            Map(x => x.Age);
            Map(x => x.Location);
            Map(x => x.FamilyStatus);
            Map(x => x.Gender);
            Map(x => x.Password);
            Map(x => x.Interest);

            Table("User");

        }
    }
}
