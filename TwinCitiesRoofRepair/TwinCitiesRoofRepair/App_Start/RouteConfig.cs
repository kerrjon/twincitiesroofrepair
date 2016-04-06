using System.Web.Mvc;
using System.Web.Routing;

namespace TwinCitiesRoofRepair
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("ChoosingRoofingContractor", "choosing-a-minnesota-roofing-contractor", new {controller = "Home", action = "ChoosingRoofingContractors"});
            routes.MapRoute("ContactUs", "contact-us", new { controller = "Home", action = "ContactUs" });
            routes.MapRoute("InsuranceClaims", "roofing-insurance-claims-assistance", new { controller = "Home", action = "InsuranceClaims" });
            routes.MapRoute("RoofRepairExperts", "twincities-roofing-repair-experts", new { controller = "Home", action = "RoofRepairExperts" });
            routes.MapRoute("ServiceAreas", "roofing-service-areas", new { controller = "Home", action = "ServiceAreas" });
            routes.MapRoute("StormDamageSpecialists", "choosing-a-top-minnesota-storm-damage-contractor", new { controller = "Home", action = "StormDamageSpecialists" });
            routes.MapRoute("WhatToExpect", "what-to-expect-with-a-roofing-project", new { controller = "Home", action = "WhatToExpect" });
            routes.MapRoute("Default" , "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
