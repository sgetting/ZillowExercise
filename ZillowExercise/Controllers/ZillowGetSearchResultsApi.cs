using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using System.Web.Mvc;
using ZillowExercise.Models;

namespace ZillowExercise.Controllers
{
   public class ZillowGetSearchResultsApi : Controller
   {
      public static readonly Uri baseUri = new Uri("http://www.zillow.com/webservice/GetSearchResults.htm");

      private static readonly string ZillowApiKey = "X1-ZWz1dyb53fdhjf_6jziz";
      

      /// <summary>
      /// 
      /// </summary>
      /// <param name="address"></param>
      /// <param name="cityStateZip"></param>
      /// <returns></returns>
      public static async Task<SearchResults> GetSearchResults(IHttpClient client, Address address)
      {
         var uriBuilder = new UriBuilder(client.BaseAddress);
         System.Collections.Specialized.NameValueCollection paramValues = HttpUtility.ParseQueryString(uriBuilder.Query);
         paramValues.Add("zws-id", ZillowApiKey);
         paramValues.Add("address", address.GetAddressForUri());
         paramValues.Add("citystatezip", address.GetCityStateZipForUri());
         uriBuilder.Query = paramValues.ToString();

         client.BaseAddress = uriBuilder.Uri;
         client.DefaultRequestHeaders.Accept.Clear();
         client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/xml"));
            
         HttpResponseMessage response = await client.GetAsync(client.BaseAddress);

         // Throws exception if status code is not success.
         response.EnsureSuccessStatusCode();

         XmlSerializer searchResultsSerializer = new XmlSerializer(typeof(SearchResults));
         Stream searchResultsStream = await response.Content.ReadAsStreamAsync();
         return (SearchResults)searchResultsSerializer.Deserialize(searchResultsStream);
      }
   }
}