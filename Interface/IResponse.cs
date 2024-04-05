namespace FlightApi.Interface 
{
  public interface authResponse {
    string code {get; set;}
    string message {get; set;}
    string token {get; set;}
  }
}