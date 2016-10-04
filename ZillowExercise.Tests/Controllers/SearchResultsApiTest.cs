using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;
using ZillowExercise.Models;
using ZillowExercise.Controllers;
using System.Linq;

namespace ZillowExercise.Tests.Controllers
{
   [TestClass]
   public class SearchResultsApiTest
   {
      Uri completeUri = new Uri("http://www.zillow.com/webservice/GetSearchResults.htm?zws-id=X1-ZWz1dyb53fdhjf_6jziz&address=15%20Willowgrove&citystatezip=Irvine,CA");

      Task<HttpResponseMessage> successResponseTask;
      Mock<IHttpClient> mockClient;

      [TestInitialize]
      public void SetupHttpResponses()
      {
         HttpResponseMessage successResponse = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
         successResponse.Content = new StringContent(File.ReadAllText("Data/SearchResultsSuccess1.xml"));
         successResponseTask = Task.Factory.StartNew(() => successResponse);
         mockClient = new Mock<IHttpClient>();

         mockClient.SetupGet(client => client.BaseAddress).Returns(completeUri);
         mockClient.Setup(client => client.GetAsync(completeUri)).Returns(successResponseTask);
         mockClient.SetupGet(client => client.DefaultRequestHeaders).Returns((new HttpClient()).DefaultRequestHeaders);
      }

      [TestMethod]
      public async Task SuccessResponseCreatesObjectStructure()
      {
         SearchResults searchResults = await ZillowGetSearchResultsApi.GetSearchResults(mockClient.Object, new Address("136 Acamar", "", "Irvine", "CA", "92618"));

         Assert.IsNotNull(searchResults);
         Assert.IsNotNull(searchResults.request);
         Assert.IsNotNull(searchResults.message);
         Assert.IsNotNull(searchResults.response);
         Assert.IsNotNull(searchResults.response.results);
         Assert.IsTrue(searchResults.response.results.Count > 0);
         Assert.IsNotNull(searchResults.response.results[0].address);
         Assert.IsNotNull(searchResults.response.results[0].links);
         Assert.IsNotNull(searchResults.response.results[0].zestimate);
         Assert.IsNotNull(searchResults.response.results[0].localRealEstate);
      }

      [TestMethod]
      public async Task SuccessResponseParsesCorrectly()
      {
         SearchResults searchResults = await ZillowGetSearchResultsApi.GetSearchResults(mockClient.Object, new Address("136 Acamar", "", "Irvine", "CA", "92618"));

         Assert.AreEqual("120 Acamar", searchResults.response.results[0].address.street);
         Assert.AreEqual("USD", searchResults.response.results[0].zestimate.valuationRange.low.currency);
         Assert.AreEqual((uint)540968, searchResults.response.results[0].zestimate.valuationRange.low.Value);
         Assert.AreEqual((decimal)-117.75134, searchResults.response.results[0].address.longitude);
         Assert.AreEqual((uint)2097382861, searchResults.response.results[0].zpid);

         Assert.AreEqual("144 Acamar", searchResults.response.results[1].address.street);

      }
   }
}
