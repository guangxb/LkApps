using System.Web.Mvc;

namespace Apps.Web.Areas.WMS_Maintenance
{
    public class WMS_MaintenanceAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "WMS_Maintenance";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "WMS_Maintenance_default",
                "WMS_Maintenance/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}