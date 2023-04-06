using ST360_API_Consumer.Integrations;
using System;

namespace ST360_API_Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            while (1 != 0)
            {
                try
                {
                    var integrationSelection = GetIntegration();
                    DoWork(integrationSelection);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine();
            }
        }

        static int GetIntegration()
        {
            Console.WriteLine("Select an Integration and hit enter");
            Console.WriteLine("1. PFEP");
            Console.WriteLine("2. ASN by Item");
            Console.WriteLine("3. ASN by Production Part");
            Console.WriteLine("4. Demand Forecast by Item");
            Console.WriteLine("5. Demand Forecast by Production Part");
            Console.WriteLine("6. Partner Order by Item");
            Console.WriteLine();

            var integrationSelection = Console.ReadLine();

            return Convert.ToInt32(integrationSelection);
        }

        static void DoWork(int integrationSelection)
        {
            Console.WriteLine("Processing request. please wait....");
            var integaration = IntegrationServiceFactory.GetIntegration(integrationSelection);

            integaration.PostToApi();
        }
    }
}
