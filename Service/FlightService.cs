using FlightApi.Interface;
using System.Net.Http;
using FlightApi.Helpers;

namespace FlightApi.Service
{
  public class FlightService : IFlightAction
  {
    public FlightService()
    {
    }

    public Task<autoComplete> autoComplete()
    {
      try
      {
        string configUrl = EnvironmentVariables.RapidUrl;
        string rapidApiKey = EnvironmentVariables.XRapidAPIKey;
        string rapidHost = EnvironmentVariables.XRapidAPIHost;
        using (HttpClient httpClient = new HttpClient())
        {
          httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", rapidApiKey);
          httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", rapidHost);
        var response = httpClient.GetAsync($"{configUrl}/get-config");
        }
      throw new NotImplementedException();
      }
      catch (Exception ex)
      {
        throw new UnprocessableEntityException(ex.Message);
      }
      
    }

    public Task<checkServerStatus> checkServerStatus()
    {
      throw new NotImplementedException();
    }

    public Task<getConfig> getConfig()
    {
      throw new NotImplementedException();
    }
  }
}