using FlightApi.Interface;
namespace FlightApi.Helpers
{
  public class EnvironmentVariables : ICredential
  {
      public static string  XRapidAPIKey {get;} = Environment.GetEnvironmentVariable("XRapidAPIKey");
      public static string  XRapidAPIHost {get;} = Environment.GetEnvironmentVariable("XRapidAPIHost");
      public static string  MongoUrl {get;} = Environment.GetEnvironmentVariable("MongoUrl");
      public static string  RapidUrl {get;} = Environment.GetEnvironmentVariable("RapidUrl");


  }
}
