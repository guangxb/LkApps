using System.Web.Mvc;

namespace Apps.Web.Areas.LogisticsSys
{
    public class LogisticsSysAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "LogisticsSys";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "LogisticsSys_default",
                "LogisticsSys/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}