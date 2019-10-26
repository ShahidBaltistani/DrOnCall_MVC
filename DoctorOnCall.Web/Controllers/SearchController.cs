//using DoctorOnCall.Web.Models;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Web.Mvc;
//namespace KitchenCloudFreeLance.Controllers
//{
//    public class SearchController : Controller
//    {
//        // GET: Search
//        static int count = 0;
//        private static int stringLegnth = 10;
//        private static List<SearchTitle> searchResults;
//        // GET: HomeSearch
//        public ActionResult Suggestions(string key)
//        {
//            Stopwatch timeTaken = new Stopwatch();
//            timeTaken.Start();

            
//            List<SuggestionModel> suggestions = new List<SuggestionModel>();

//            if (key != "")
//            {
//                ViewBag.Word = key;
//                if (SearchTitle.RecipeTitles != null && SearchTitle.RecipeTitles.Count > 0)
//                {
//                    //suggestions = new SearchMappers().RecipeTitlesToSuggestionModels(RecipeTitle.PropertiesTitles.Where(x => x.Title.ToLower().Contains(key.ToLower())).ToList());


//                    foreach (string k in key.Split(' '))
//                    {
//                        if (count == 0 || key.Length < stringLegnth)
//                        {
//                            stringLegnth = key.Length;
//                            searchResults = new List<SearchTitle>();
//                            searchResults.AddRange(SearchTitle.RecipeTitles.Where(x =>x.Title.ToLower().Contains(k.ToLower())));
//                            count++;
//                        }
//                        else
//                        {
//                            searchResults = searchResults.Where(x => x.Title.ToLower().Contains(k.ToLower())).ToList();
//                            stringLegnth = key.Length;
//                        }
//                    }
//                    //Comparison<SuggestionModel> comparer = (x, y) => { return x.Id.CompareTo(y.Id); };

//                    suggestions = new SearchMappers().RecipeTitlesToSuggestionModels(searchResults.Distinct().ToList());

//                    if (suggestions == null || suggestions.Count == 0)
//                    {
//                        suggestions = new List<SuggestionModel>()
//                        {
//                            new SuggestionModel()
//                            {
//                                Title = "no results found",

//                            }
//                        };
//                    }


//                    timeTaken.Stop();
//                    ViewBag.TimeTaken = timeTaken.Elapsed.TotalSeconds;
//                    return PartialView("_Suggestions", suggestions);
//                }

//                suggestions = new List<SuggestionModel>()
//                {
//                    new SuggestionModel()
//                    {
//                        Title = "no results found",
//                        SellerImage = ""
//                    }
//                };
//            }
//            count = 0;
//            searchResults = new List<SearchTitle>();





//            timeTaken.Stop();
//            ViewBag.TimeTaken = 0;

//            return PartialView("_Suggestions", suggestions);
//        }
//    }
//}