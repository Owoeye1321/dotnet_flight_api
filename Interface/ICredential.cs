namespace FlightApi.Interface
{
  public interface ICredential
  {
    static string XRapidAPIKey{get;}
    static string XRapidAPIHost{get;}
    static string MongoUrl{get;}
    static string RapidUrl{get;}
  }
}