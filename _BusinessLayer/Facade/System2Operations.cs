using _BusinessLayer.Business;
using System;
using System.Web.Security;

namespace _BusinessLayer.Facade
{
    public class System2Operations
    {
        UserAuthorizedBusiness rb = new UserAuthorizedBusiness();
        AuthorizedNumberBusiness anb = new AuthorizedNumberBusiness();

        public int InsertUser(string username, string password, string mail, string question, string answer,int? authorize)
        {
            var stats = anb.GetByAuthorizeNumber(authorize);
            if (stats != null)
            {
                MembershipCreateStatus status;
                Membership.CreateUser(username,password,mail,question,answer, true, out status);
                switch (status)
                {
                    case MembershipCreateStatus.Success:
                        var user  = Membership.GetUser(username);
                        var number = anb.GetByAuthorizeNumber(authorize);

                        rb.Add(new _DataLayer.Entities.UserAuthorize
                        {
                            UserId = new Guid (user.ProviderUserKey.ToString()),
                            AuthorizeNumberId = stats.AuthorizeNumberId,
                            
                        });
                        return 0;
                    case MembershipCreateStatus.InvalidUserName:
                        return 1;
                    case MembershipCreateStatus.InvalidPassword:
                        return 2;
                    case MembershipCreateStatus.InvalidQuestion:
                        return 3;
                    case MembershipCreateStatus.InvalidAnswer:
                        return 4; 
                    case MembershipCreateStatus.InvalidEmail:
                        return 5;
                    case MembershipCreateStatus.DuplicateUserName:
                        return 6;
                    case MembershipCreateStatus.DuplicateEmail:
                        return 7;
                    case MembershipCreateStatus.UserRejected:
                        return 8;
                    case MembershipCreateStatus.InvalidProviderUserKey:
                        return 9;
                    case MembershipCreateStatus.DuplicateProviderUserKey:
                        return 10;
                    case MembershipCreateStatus.ProviderError:
                        return 11; 
                    default:
                        return 12;
                }
            }
            return 100;
        }
        public MembershipUser GetUser(string username)
        {
             var deger = Membership.GetUser(username);
            return deger;
        }
        public void DeleteUser(string username)
        {
            var deger = Membership.DeleteUser(username);
        }
        public bool IsValidUser(string username,string password)
        {
            bool deneme =  Membership.ValidateUser(username,password);
            return deneme;
        }
    }
}
