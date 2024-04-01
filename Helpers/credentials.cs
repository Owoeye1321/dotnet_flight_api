using FlightApi.Interface;
namespace FlightApi.Helpers
{
  public class EnvironmentVariables : ICredential
  {
      public static string  XRapidAPIKey {get;} = Environment.GetEnvironmentVariable("XRapidAPIKey");
      public static string  XRapidAPIHost {get;} = Environment.GetEnvironmentVariable("XRapidAPIHost");
  }
}