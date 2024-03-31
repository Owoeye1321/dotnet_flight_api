namespace FlightApi.Interface
{
  public interface getConfigDataObject
  {
   string  country {get; set;}
   string  market {get; set;}
   string locale {get; set;}
   string currencyTitle {get; set;}
   string currency {get; set;}
   string currencySymbol {get; set;}
   string site {get; set;}
  }
  public interface getConfig 
  {
    string status {get; set;}
    string message {get; set;}
    string timestamp {get; set;}
    IEnumerable<getConfigDataObject> data {get; set;}
  }
  public interface checkServerStatus 
  {
    string status {get; set;}
    string message {get; set;}
  }
  public interface autoCompletePresentationDataObject 
  {
    string title {get; set;}
    string suggestionTitle {get; set;}
    string subtitle {get; set;}
  }
   public interface autoCompleteNavigationDataObject 
  {
    string entityId {get; set;}
    string entityType {get; set;}
    string localizedName {get; set;}
  }
    public interface autoCompleteRelevantFlightParams 
  {
    string skyId {get; set;}
    string entityId {get; set;}
    string flightPlaceTye {get; set;}
    string localizedName {get; set;}
  }
   public interface autoCompleteRelevantHotelParamsDataObject 
  {
    string entityId {get; set;}
    string entityType {get; set;}
    string localizedName {get; set;}
  }
  public interface autoComplete 
  {
    string status {get; set;}
    string message {get; set;}
    IEnumerable<autoCompletePresentationDataObject> data { get; set;}
  }
}