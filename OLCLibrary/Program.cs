using Microsoft.Extensions.DependencyInjection;
using System.Net;

namespace OLCLibrary
{
    public class Library
    {
        public static async Task MakeHttpCall()
        {
            var services = new ServiceCollection();
            services.AddHttpClient();
            var serviceProvider = services.BuildServiceProvider();
            var clientFactory = (IHttpClientFactory)serviceProvider.GetService(typeof(IHttpClientFactory));
            using (var client = clientFactory.CreateClient())
            {
                Console.WriteLine(System.Net.ServicePointManager.SecurityProtocol);
                // var responseMessage = await client.SendAsync(new HttpRequestMessage(HttpMethod.Get, "http://localhost:5263/WeatherForecast"));
                var responseMessage = await client.SendAsync(new HttpRequestMessage(HttpMethod.Get, "https://localhost:7185/WeatherForecast"));
            }
        }
    }
}