using FlightApi.Helpers;
namespace FlightApi.Interface
{
  //get config interface start here
  public interface IGetConfigDataObject
  {
    string country { get; set; }
    string market { get; set; }
    string locale { get; set; }
    object currencyTitle { get; set; }
    string currency { get; set; }
    string currencySymbol { get; set; }
    string site { get; set; }
  }
  public interface IGetConfig
  {
    bool status { get; set; }
    string message { get; set; }
    double timestamp { get; set; }
    IEnumerable<getConfigDataObject> data { get; set; }
  }

  //get config interface ends here

  //server status interface start here
  public interface ICheckServerStatus
  {
    bool status { get; set; }
    string message { get; set; }
  }

  //server status interface ends here

  //Auto complete interface start here
  public interface IAutoCompletePresentation
  {
    string title { get; set; }
    string suggestionTitle { get; set; }
    string subtitle { get; set; }
  }
  public interface IAutoCompleteRelevantFlightParams
  {
    string skyId { get; set; }
    string entityId { get; set; }
    string flightPlaceTye { get; set; }
    string localizedName { get; set; }
  }
  public interface IAutoCompleteRelevantHotelParams
  {
    string entityId { get; set; }
    string entityType { get; set; }
    string localizedName { get; set; }
  }
  public interface IAutoCompleteNavigation
  {
    string entityId { get; set; }
    string entityType { get; set; }
    string localizedName { get; set; }
    autoCompleteRelevantFlightParams relevantFlightParams { get; set; }
    autoCompleteRelevantHotelParams relevantHotelParams { get; set; }
  }

  public interface IAutoCompleteDataObject
  {
    string id { get; set; }
    autoCompletePresentation presentation { get; set; }
    autoCompleteNavigation navigation { get; set; }

  }
  public interface IAutoComplete
  {
    bool status { get; set; }
    string message { get; set; }
    IEnumerable<IAutoCompleteDataObject> data { get; set; }
  }
  //Auto completes interface ends here

  //Search one way interface start here
  public interface searchOneWayContext
  {
    string status { get; set; }
    string sessionId { get; set; }
    int totalResults { get; set; }
  }

  public interface itineryLegOrigin
  {
    string id { get; set; }
    string name { get; set; }
    string displayCode { get; set; }
    string city { get; set; }
    string country { get; set; }
    bool isHighlighted { get; set; }
  }
  public interface itineryLegDestination
  {
    string id { get; set; }
    string name { get; set; }
    string displayCode { get; set; }
    string city { get; set; }
    string country { get; set; }
    bool isHighlighted { get; set; }

  }
  public interface cariersMarketingOobject{
    string id {get; set;}
    string logoUrl {get; set;}
    string name {get; set;}
  }
  public interface cariersOperatingObject{
    string id {get; set;}
    string logoUrl {get; set;}
    string name {get; set;}
  }
  public interface itineryLegCarriers
  {
    IEnumerable<cariersMarketingOobject> marketing {get; set;}
    IEnumerable<cariersOperatingObject> operating {get; set;}
    string operationType {get; set;}
  }
  public interface itineryLegs
  {
    string id { get; set; }
    itineryLegOrigin origin { get; set; }
    itineryLegDestination destination { get; set; }
    int durationInMinutes { get; set; }
    string stopCount { get; set; }
    bool isSmallestStops { get; set; }
    DateTimeOffset depature { get; set; }
    DateTimeOffset arrival { get; set; }
    int timeDeltaInDays { get; set; }
    itineryLegCarriers carriers {get; set;}


  }
  public interface itineryPrice
  {
    double raw { get; set; }
    string formatted { get; set; }
    string pricingOptionId { get; set; }
  }
  public interface itenaryObjects
  {
    string id { get; set; }
    itineryPrice price { get; set; }

  }
  public interface searchOneWayitineraries
  {

  }
  public interface searchOneWayData
  {
    string token { get; set; }
    searchOneWayContext context { get; set; }
    IEnumerable<searchOneWayitineraries> itineraries { get; set; }
  }
}