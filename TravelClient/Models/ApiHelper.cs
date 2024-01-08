using System.Threading.Tasks;
using RestSharp;

namespace TravelClient.Models
{
  public class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5063/");
      RestRequest request = new RestRequest($"api/reviews", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
  }
}