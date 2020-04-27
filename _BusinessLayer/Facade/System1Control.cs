using _BusinessLayer.Business;

namespace _BusinessLayer.Facade
{
    public class System1Control
    {
        AuthorizedNumberBusiness anb = new AuthorizedNumberBusiness(); 
        public bool AuthorizeControl(int? authnumberr)
        {
            if (authnumberr!=null)
            {
               return anb.IsVailAuthNumber(authnumberr);
            }
            else
            {
                return false;
            }
        }
    }
}
