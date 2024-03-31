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
}