using FlightApi.Interface;
namespace FlightApi.Helpers
{
  //check server status start here
  public class CheckServerStatus : ICheckServerStatus
  {
    public bool status { get; set; }
    public string message { get; set; }
  }
//check server status ends here

//get config  start here
  public class getConfigDataObject : IGetConfigDataObject
  {
    public string country { get; set; }
    public string market { get; set; }
    public string locale { get; set; }
    public object currencyTitle { get; set; }
    public string currency { get; set; }
    public string currencySymbol { get; set; }
    public string site { get; set; }
  }
  public class getConfig : IGetConfig
  {
    public bool status { get; set; }
    public string message { get; set; }
    public double timestamp { get; set; }
    public IEnumerable<getConfigDataObject> data { get; set; }
  }
  //get config  ends here

  //auto complete start here
  public class autoCompleteDataObject : IAutoCompleteDataObject
  {
    public string id { get; set; };
    public autoCompletePresentation presentation { get; set; };
    public autoCompleteNavigation navigation { get; set; };
  }

  public class autoCompletePresentation: IAutoCompletePresentation
  {
    public string title { get; set; }
    public string suggestionTitle { get; set; }
    public string subtitle { get; set; }
    
  }
  public class autoCompleteNavigation : IAutoCompleteNavigation
  {
    public string entityId { get; set; }
    public string entityType { get; set; }
    public string localizedName { get; set; }
    public autoCompleteRelevantFlightParams relevantFlightParams { get; set; }
    public autoCompleteRelevantHotelParams relevantHotelParams { get; set; }
  }
  public class autoCompleteRelevantFlightParams : IAutoCompleteRelevantFlightParams
  {
    public string skyId { get; set; }
    public string entityId { get; set; }
    public string flightPlaceTye { get; set; }
    public string localizedName { get; set; }
  }
  public class autoCompleteRelevantHotelParams : IAutoCompleteRelevantHotelParams 
  {
     string entityId { get; set; }
    string entityType { get; set; }
    string localizedName { get; set; }
  }

  public class autoComplete : IAutoComplete
  {
    public bool status { get; set; }
    public string message { get; set; }
    public IEnumerable<autoCompleteDataObject> data { get; set; }
  }
  //auto complete ends here

}