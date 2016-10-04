using System;

namespace ZillowExercise.Models
{
   public class Address
   {
      public string AddressLine1 { get; set; } = string.Empty;
      public string AddressLine2 { get; set; } = string.Empty;
      public string City { get; set; } = string.Empty;
      public string State { get; set; } = string.Empty;
      public string ZipCode { get; set; } = string.Empty;

      public Address(string address1, string address2, string city, string state, string zip)
      {
         this.AddressLine1 = address1;
         this.AddressLine2 = address2;
         this.City = city;
         this.State = state;
         this.ZipCode = zip;
      }

      public Address()
      {
      }

      public string GetAddressForUri()
      {
         return AddressLine1 + (string.IsNullOrWhiteSpace(AddressLine2) ? string.Empty : " " + AddressLine2);
      }

      public string GetCityStateZipForUri()
      {
         return $"{City},{State},{ZipCode}";
      }
   }
}