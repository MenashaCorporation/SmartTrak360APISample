
namespace ST360_API_Consumer.Integrations
{
    public interface IIntegration
    {
        public string GetData();
        public string Endpoint { get; }
        public void PostToApi();
    }   
}
