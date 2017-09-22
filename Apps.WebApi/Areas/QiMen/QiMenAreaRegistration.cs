using System.Web.Mvc;

namespace Apps.WebApi.Areas.QiMen
{
    public class QiMenAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "QiMen";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "QiMen_default",
                "QiMen/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}