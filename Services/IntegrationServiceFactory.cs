using ST360_API_Consumer.Services;
using System;

namespace ST360_API_Consumer.Integrations
{
    public static class IntegrationServiceFactory
    {
        public static IIntegration GetIntegration(int selection)
        {
            return selection switch
            {
                1 => new PFEPService(),
                2 => new ASNItemService(),
                3 => new ASNPartService(),
                4 => new DemandForecastItemService(),
                5 => new DemandForecastPartService(),
                6 => new PartnerOrderItemService(),
                _ => throw new Exception("Invalid User Input"),
            };
        }
    }
}
