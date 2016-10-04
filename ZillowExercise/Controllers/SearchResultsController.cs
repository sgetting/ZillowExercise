using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ZillowExercise.Models;

namespace ZillowExercise.Controllers
{
   public class SearchResultsController : Controller
   {
      // GET: SearchResults
      public async Task<ActionResult> SubmitAddress(Address address)
      {
         var client = new HttpClientWrapper();
         client.BaseAddress = ZillowGetSearchResultsApi.baseUri;
         SearchResults results = await ZillowGetSearchResultsApi.GetSearchResults(client, address);
         return View(results);
      }
   }
}