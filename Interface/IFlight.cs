namespace FlightApi.Interface
{
  //get config interface start here
  public interface getConfigDataObject
  {
    string country { get; set; }
    string market { get; set; }
    string locale { get; set; }
    string currencyTitle { get; set; }
    string currency { get; set; }
    string currencySymbol { get; set; }
    string site { get; set; }
  }
  public interface getConfig
  {
    string status { get; set; }
    string message { get; set; }
    string timestamp { get; set; }
    IEnumerable<getConfigDataObject> data { get; set; }
  }

  //get config interface ends here

  //server status interface start here
  public interface checkServerStatus
  {
    string status { get; set; }
    string message { get; set; }
  }

  //server status interface ends here

  //Auto complete interface start here
  public interface autoCompletePresentation
  {
    string title { get; set; }
    string suggestionTitle { get; set; }
    string subtitle { get; set; }
  }
  public interface autoCompleteRelevantFlightParams
  {
    string skyId { get; set; }
    string entityId { get; set; }
    string flightPlaceTye { get; set; }
    string localizedName { get; set; }
  }
  public interface autoCompleteRelevantHotelParams
  {
    string entityId { get; set; }
    string entityType { get; set; }
    string localizedName { get; set; }
  }
  public interface autoCompleteNavigation
  {
    string entityId { get; set; }
    string entityType { get; set; }
    string localizedName { get; set; }
    autoCompleteRelevantFlightParams relevantFlightParams { get; set; }
    autoCompleteRelevantHotelParams relevantHotelParams { get; set; }
  }

  public interface autoCompleteDataObject
  {
    string id { get; set; }
    autoCompletePresentation presentation { get; set; }
    autoCompleteNavigation navigation { get; set; }

  }
  public interface autoComplete
  {
    string status { get; set; }
    string message { get; set; }
    IEnumerable<autoCompleteDataObject> data { get; set; }
  }
  //Auto completes interface ends here

  //Search one way interface start here
  public interface searchOneWayContext
  {
    string status { get; set; }
    string sessionId { get; set; }
    int totalResults { get; set; }
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