using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;

namespace TravelClient.Controllers;

public class ReviewsController : Controller
{
  public IActionResult Index()
  {
    List<Review> reviews = Review.GetReviews();
    return View(reviews);
  }

  public ActionResult Search()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Search(string city, string country, int rating, string random)
  {
    return RedirectToAction("SearchResults", new { searchedCity = city, searchedCountry = country, searchedRating = rating, randomSearch = random });
  }

  public ActionResult SearchResults(string searchedCity, string searchedCountry, int searchedRating, string randomSearch)
  {
    List<Review> searchResults = Review.SearchReviews(searchedCity, searchedCountry, searchedRating, randomSearch);
    return View(searchResults);
  }

  public IActionResult Details(int id)
  {
    Review review = Review.GetDetails(id);
    return View(review);
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Review review)
  {
    if (ModelState.IsValid)
    {
      Review.Post(review);
      return RedirectToAction("Index");
    }
    else
    {
      return RedirectToAction("Create");
    }
  }

  // public ActionResult Edit(int id)
  // {
  //   Review review = Review.GetDetails(id);
  //   return View(review);
  // }

  [HttpPost]
  public ActionResult Edit(Review review)
  {
    if (ModelState.IsValid)
    {
      Review.Put(review);
      return RedirectToAction("Details", new { id = review.ReviewId });
    }
    else
    {
      return RedirectToAction("Edit");
    }

  }

  public ActionResult Delete(int id)
  {
    Review review = Review.GetDetails(id);
    return View(review);
  }

  [HttpPost, ActionName("Delete")]
  public ActionResult DeleteConfirmed(int id)
  {
    Review.Delete(id);
    return RedirectToAction("Index");
  }
}