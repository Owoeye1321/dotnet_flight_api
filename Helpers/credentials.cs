using FlightApi.Interface;
namespace FlightApi.Helpers
{
  public class EnvironmentVariables : ICredential
  {
      public  string  XRapidAPIKey {get;} = Environment.GetEnvironmentVariable("XRapidAPIKey");
      public  string  XRapidAPIHost {get;} = Environment.GetEnvironmentVariable("XRapidAPIHost");
      public  string  MongoUrl {get;} = Environment.GetEnvironmentVariable("MongoUrl");
      public  string  RapidUrl {get;} = Environment.GetEnvironmentVariable("RapidUrl");


  }
}
