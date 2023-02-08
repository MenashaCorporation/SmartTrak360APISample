using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;

namespace ST360_API_Consumer.Repository
{
    public static class IntegrationRepo
    {
        private static readonly string _clientId = ConfigurationManager.AppSettings["ClientId"];
        private static readonly string _clienSecret = ConfigurationManager.AppSettings["ClientSecret"];
        private static readonly string _baseApiURL = ConfigurationManager.AppSettings["BaseUrl"];

        public static void PostToApi(string endPoint, string jsonData)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create($"{_baseApiURL}/{endPoint}");
                var data = Encoding.ASCII.GetBytes(jsonData);

                var authenticationString = $"{_clientId}:{_clienSecret}";
                var base64EncodedAuthenticationString = Convert.ToBase64String(Encoding.UTF8.GetBytes(authenticationString));

                request.Headers.Add("Authorization", "Basic " + base64EncodedAuthenticationString);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = data.Length;
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();
                var responseMessage = new StreamReader(response.GetResponseStream()).ReadToEnd();

                Console.WriteLine(responseMessage);
                Console.WriteLine("Success");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
