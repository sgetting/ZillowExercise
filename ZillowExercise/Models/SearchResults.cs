// Schema generated automatically with Visual Studio "Paste XML as Classes"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ZillowExercise.Models
{

   /// <remarks/>
   [XmlType(AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/SearchResults.xsd")]
   [XmlRoot(Namespace = "http://www.zillow.com/static/xsd/SearchResults.xsd", IsNullable = false, ElementName = "searchresults")]
   public partial class SearchResults
   {

      private Request requestField;

      private message messageField;

      private response responseField;

      /// <remarks/>
      [XmlElement(Namespace = "", ElementName = "request")]
      public Request request
      {
         get
         {
            return this.requestField;
         }
         set
         {
            this.requestField = value;
         }
      }

      /// <remarks/>
      [XmlElement(Namespace = "")]
      public message message
      {
         get
         {
            return this.messageField;
         }
         set
         {
            this.messageField = value;
         }
      }

      /// <remarks/>
      [XmlElement(Namespace = "")]
      public response response
      {
         get
         {
            return this.responseField;
         }
         set
         {
            this.responseField = value;
         }
      }
   }

   /// <remarks/>
   [XmlType(AnonymousType = true)]
   [XmlRoot(Namespace = "", IsNullable = false)]
   public partial class Request
   {

      private string addressField;

      private string citystatezipField;

      /// <remarks/>
      public string address
      {
         get
         {
            return this.addressField;
         }
         set
         {
            this.addressField = value;
         }
      }

      /// <remarks/>
      public string citystatezip
      {
         get
         {
            return this.citystatezipField;
         }
         set
         {
            this.citystatezipField = value;
         }
      }
   }

   /// <remarks/>
   [XmlType(AnonymousType = true)]
   [XmlRoot(Namespace = "", IsNullable = false)]
   public partial class message
   {

      private string textField;

      private int codeField;

      /// <remarks/>
      public string text
      {
         get
         {
            return this.textField;
         }
         set
         {
            this.textField = value;
         }
      }

      /// <remarks/>
      public int code
      {
         get
         {
            return this.codeField;
         }
         set
         {
            this.codeField = value;
         }
      }
   }

   /// <remarks/>
   [XmlType(AnonymousType = true)]
   [XmlRoot(Namespace = "", IsNullable = false)]
   public partial class response
   {
      /// <remarks/>
      [XmlArray(ElementName = "results")]
      [XmlArrayItem(ElementName = "result")]
      public List<responseResultsResult> results { get; set; }
   }

   /// <remarks/>
   [XmlType(AnonymousType = true)]
   public partial class responseResultsResult
   {

      private uint zpidField;

      private responseResultsResultLinks linksField;

      private responseResultsResultAddress addressField;

      private responseResultsResultZestimate zestimateField;

      private responseResultsResultLocalRealEstate localRealEstateField;

      /// <remarks/>
      public uint zpid
      {
         get
         {
            return this.zpidField;
         }
         set
         {
            this.zpidField = value;
         }
      }

      /// <remarks/>
      public responseResultsResultLinks links
      {
         get
         {
            return this.linksField;
         }
         set
         {
            this.linksField = value;
         }
      }

      /// <remarks/>
      public responseResultsResultAddress address
      {
         get
         {
            return this.addressField;
         }
         set
         {
            this.addressField = value;
         }
      }

      /// <remarks/>
      public responseResultsResultZestimate zestimate
      {
         get
         {
            return this.zestimateField;
         }
         set
         {
            this.zestimateField = value;
         }
      }

      /// <remarks/>
      public responseResultsResultLocalRealEstate localRealEstate
      {
         get
         {
            return this.localRealEstateField;
         }
         set
         {
            this.localRealEstateField = value;
         }
      }
   }

   /// <remarks/>
   [XmlType(AnonymousType = true)]
   public partial class responseResultsResultLinks
   {

      private string homedetailsField;

      private string graphsanddataField;

      private string mapthishomeField;

      private string comparablesField;

      /// <remarks/>
      public string homedetails
      {
         get
         {
            return this.homedetailsField;
         }
         set
         {
            this.homedetailsField = value;
         }
      }

      /// <remarks/>
      public string graphsanddata
      {
         get
         {
            return this.graphsanddataField;
         }
         set
         {
            this.graphsanddataField = value;
         }
      }

      /// <remarks/>
      public string mapthishome
      {
         get
         {
            return this.mapthishomeField;
         }
         set
         {
            this.mapthishomeField = value;
         }
      }

      /// <remarks/>
      public string comparables
      {
         get
         {
            return this.comparablesField;
         }
         set
         {
            this.comparablesField = value;
         }
      }
   }

   /// <remarks/>
   [XmlType(AnonymousType = true)]
   public partial class responseResultsResultAddress
   {

      private string streetField;

      private string zipcodeField;

      private string cityField;

      private string stateField;

      private decimal latitudeField;

      private decimal longitudeField;

      /// <remarks/>
      public string street
      {
         get
         {
            return this.streetField;
         }
         set
         {
            this.streetField = value;
         }
      }

      /// <remarks/>
      public string zipcode
      {
         get
         {
            return this.zipcodeField;
         }
         set
         {
            this.zipcodeField = value;
         }
      }

      /// <remarks/>
      public string city
      {
         get
         {
            return this.cityField;
         }
         set
         {
            this.cityField = value;
         }
      }

      /// <remarks/>
      public string state
      {
         get
         {
            return this.stateField;
         }
         set
         {
            this.stateField = value;
         }
      }

      /// <remarks/>
      public decimal latitude
      {
         get
         {
            return this.latitudeField;
         }
         set
         {
            this.latitudeField = value;
         }
      }

      /// <remarks/>
      public decimal longitude
      {
         get
         {
            return this.longitudeField;
         }
         set
         {
            this.longitudeField = value;
         }
      }
   }

   /// <remarks/>
   [XmlType(AnonymousType = true)]
   public partial class responseResultsResultZestimate
   {

      private responseResultsResultZestimateAmount amountField;

      private string lastupdatedField;

      private responseResultsResultZestimateOneWeekChange oneWeekChangeField;

      private responseResultsResultZestimateValueChange valueChangeField;

      private responseResultsResultZestimateValuationRange valuationRangeField;

      private int percentileField;

      /// <remarks/>
      public responseResultsResultZestimateAmount amount
      {
         get
         {
            return this.amountField;
         }
         set
         {
            this.amountField = value;
         }
      }

      /// <remarks/>
      [XmlElement("last-updated")]
      public string lastupdated
      {
         get
         {
            return this.lastupdatedField;
         }
         set
         {
            this.lastupdatedField = value;
         }
      }

      /// <remarks/>
      public responseResultsResultZestimateOneWeekChange oneWeekChange
      {
         get
         {
            return this.oneWeekChangeField;
         }
         set
         {
            this.oneWeekChangeField = value;
         }
      }

      /// <remarks/>
      public responseResultsResultZestimateValueChange valueChange
      {
         get
         {
            return this.valueChangeField;
         }
         set
         {
            this.valueChangeField = value;
         }
      }

      /// <remarks/>
      public responseResultsResultZestimateValuationRange valuationRange
      {
         get
         {
            return this.valuationRangeField;
         }
         set
         {
            this.valuationRangeField = value;
         }
      }

      /// <remarks/>
      public int percentile
      {
         get
         {
            return this.percentileField;
         }
         set
         {
            this.percentileField = value;
         }
      }
   }

   /// <remarks/>
   [XmlType(AnonymousType = true)]
   public partial class responseResultsResultZestimateAmount
   {

      private string currencyField;

      private uint valueField;

      /// <remarks/>
      [XmlAttribute()]
      public string currency
      {
         get
         {
            return this.currencyField;
         }
         set
         {
            this.currencyField = value;
         }
      }

      /// <remarks/>
      [XmlText()]
      public uint Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }

   /// <remarks/>
   [XmlType(AnonymousType = true)]
   public partial class responseResultsResultZestimateOneWeekChange
   {

      private bool deprecatedField;

      /// <remarks/>
      [XmlAttribute()]
      public bool deprecated
      {
         get
         {
            return this.deprecatedField;
         }
         set
         {
            this.deprecatedField = value;
         }
      }
   }

   /// <remarks/>
   [XmlType(AnonymousType = true)]
   public partial class responseResultsResultZestimateValueChange
   {

      private uint durationField;

      private string currencyField;

      private int valueField;

      /// <remarks/>
      [XmlAttribute()]
      public uint duration
      {
         get
         {
            return this.durationField;
         }
         set
         {
            this.durationField = value;
         }
      }

      /// <remarks/>
      [XmlAttribute()]
      public string currency
      {
         get
         {
            return this.currencyField;
         }
         set
         {
            this.currencyField = value;
         }
      }

      /// <remarks/>
      [XmlText()]
      public int Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }

   /// <remarks/>
   [XmlType(AnonymousType = true)]
   public partial class responseResultsResultZestimateValuationRange
   {

      private responseResultsResultZestimateValuationRangeLow lowField;

      private responseResultsResultZestimateValuationRangeHigh highField;

      /// <remarks/>
      public responseResultsResultZestimateValuationRangeLow low
      {
         get
         {
            return this.lowField;
         }
         set
         {
            this.lowField = value;
         }
      }

      /// <remarks/>
      public responseResultsResultZestimateValuationRangeHigh high
      {
         get
         {
            return this.highField;
         }
         set
         {
            this.highField = value;
         }
      }
   }

   /// <remarks/>
   [XmlType(AnonymousType = true)]
   public partial class responseResultsResultZestimateValuationRangeLow
   {

      private string currencyField;

      private uint valueField;

      /// <remarks/>
      [XmlAttribute()]
      public string currency
      {
         get
         {
            return this.currencyField;
         }
         set
         {
            this.currencyField = value;
         }
      }

      /// <remarks/>
      [XmlText()]
      public uint Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }

   /// <remarks/>
   [XmlType(AnonymousType = true)]
   public partial class responseResultsResultZestimateValuationRangeHigh
   {

      private string currencyField;

      private uint valueField;

      /// <remarks/>
      [XmlAttribute()]
      public string currency
      {
         get
         {
            return this.currencyField;
         }
         set
         {
            this.currencyField = value;
         }
      }

      /// <remarks/>
      [XmlText()]
      public uint Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }

   /// <remarks/>
   [XmlType(AnonymousType = true)]
   public partial class responseResultsResultLocalRealEstate
   {

      private responseResultsResultLocalRealEstateRegion regionField;

      /// <remarks/>
      public responseResultsResultLocalRealEstateRegion region
      {
         get
         {
            return this.regionField;
         }
         set
         {
            this.regionField = value;
         }
      }
   }

   /// <remarks/>
   [XmlType(AnonymousType = true)]
   public partial class responseResultsResultLocalRealEstateRegion
   {

      private string zindexValueField;

      private responseResultsResultLocalRealEstateRegionLinks linksField;

      private string nameField;

      private uint idField;

      private string typeField;

      /// <remarks/>
      public string zindexValue
      {
         get
         {
            return this.zindexValueField;
         }
         set
         {
            this.zindexValueField = value;
         }
      }

      /// <remarks/>
      public responseResultsResultLocalRealEstateRegionLinks links
      {
         get
         {
            return this.linksField;
         }
         set
         {
            this.linksField = value;
         }
      }

      /// <remarks/>
      [XmlAttribute()]
      public string name
      {
         get
         {
            return this.nameField;
         }
         set
         {
            this.nameField = value;
         }
      }

      /// <remarks/>
      [XmlAttribute()]
      public uint id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }

      /// <remarks/>
      [XmlAttribute()]
      public string type
      {
         get
         {
            return this.typeField;
         }
         set
         {
            this.typeField = value;
         }
      }
   }

   /// <remarks/>
   [XmlType(AnonymousType = true)]
   public partial class responseResultsResultLocalRealEstateRegionLinks
   {

      private string overviewField;

      private string forSaleByOwnerField;

      private string forSaleField;

      /// <remarks/>
      public string overview
      {
         get
         {
            return this.overviewField;
         }
         set
         {
            this.overviewField = value;
         }
      }

      /// <remarks/>
      public string forSaleByOwner
      {
         get
         {
            return this.forSaleByOwnerField;
         }
         set
         {
            this.forSaleByOwnerField = value;
         }
      }

      /// <remarks/>
      public string forSale
      {
         get
         {
            return this.forSaleField;
         }
         set
         {
            this.forSaleField = value;
         }
      }
   }


}