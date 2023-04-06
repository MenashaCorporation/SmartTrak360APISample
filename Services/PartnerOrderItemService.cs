using ST360_API_Consumer.Integrations;
using ST360_API_Consumer.Repository;
using System;
using System.IO;

namespace ST360_API_Consumer.Services
{
    public class PartnerOrderItemService : IIntegration
    {
        public string Endpoint
        {
            get
            {
                return "v1/partner-order/containers";
            }
        }
        public string GetData()
        {
            string fileName = "PartnerOrder_Container.json";
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

