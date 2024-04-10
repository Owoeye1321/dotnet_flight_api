namespace FlightApi.Interface
{
  public interface ICredential
  {
     string XRapidAPIKey{get;}
     string XRapidAPIHost{get;}
     string MongoUrl{get;}
     string RapidUrl{get;}
  }
}