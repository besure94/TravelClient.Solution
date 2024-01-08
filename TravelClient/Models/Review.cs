using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;


namespace TravelClient.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Message { get; set; }

    [Required]
    [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10.")]
    public int Rating { get; set; }
    public string Author { get; set; }

    public static List<Review> GetReviews()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Review> reviewList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse.ToString());

      return reviewList;
    }
  }
}