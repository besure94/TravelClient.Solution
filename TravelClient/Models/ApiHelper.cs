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

    public static async Task<string> FilterReviews(string city, string country, int rating, string random)
    {
      RestClient client = new RestClient("http://localhost:5063/");
      RestRequest request = new RestRequest($"api/reviews", Method.Get).AddParameter("city", city).AddParameter("country", country).AddParameter("rating", rating).AddParameter("random", random);
      RestResponse response = await client.GetAsync(request);

      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5063/");
      RestRequest request = new RestRequest($"api/reviews/{id}", Method.Get);
      RestResponse response = await client.GetAsync(request);

      return response.Content;
    }

    public static async void Post(string newReview)
    {
      RestClient client = new RestClient("http://localhost:5063/");
      RestRequest request = new RestRequest($"api/reviews", Method.Post);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newReview);
      await client.PostAsync(request);
    }

    public static async void Put(int id, string author, string newReview)
    {
      RestClient client = new RestClient("http://localhost:5063/");
      RestRequest request = new RestRequest($"api/reviews/{id}?author={author}", Method.Put);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newReview);
      await client.PutAsync(request);
    }
  }
}