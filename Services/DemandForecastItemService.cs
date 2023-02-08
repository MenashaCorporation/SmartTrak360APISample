using ST360_API_Consumer.Repository;
using System;
using System.IO;

namespace ST360_API_Consumer.Integrations
{
    public class DemandForecastItemService : IIntegration
    {
        public string Endpoint
        {
            get
            {
                return "v1/forecast-demands/containers";
            }
        }
        public string GetData()
        {
            string fileName = "DemandForecast_Item.json";
            string path = Path.Combine(Environment.CurrentDirectory, @"PostJson\", fileName);

            string postJson = File.ReadAllText(path);
            return postJson;
        }

        public void PostToApi()
        {
            IntegrationRepo.PostToApi(Endpoint, GetData());
        }
    }
}
