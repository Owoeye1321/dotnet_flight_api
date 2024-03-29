namespace FlightApi.Interface
{
  public interface dataObject
  {

  }
  public interface create 
  {
    string code {get; set;}
    string message {get; set;}
    IEnumerable<dataObject> data {get; set;}
  }
}