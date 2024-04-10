using FlightApi.Interface;
using System.Net;
using FlightApi.Helpers;
using System.Text.Json;

namespace FlightApi.Service
{
  public class FlightService : IFlightAction
  {
    public FlightService()
    {
    }

    public async Task<autoComplete> autoComplete()
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
          var response = await httpClient.GetAsync($"{configUrl}/get-config");
          if(response.StatusCode != HttpStatusCode.OK){
            throw new UnprocessableEntityException("API Error");
          }
          var responseString = await response.Content.ReadAsStringAsync();

          var autoComplete = JsonSerializer.Deserialize<autoComplete>(responseString, new JsonSerializerOptions(){PropertyNameCaseInsensitive = true});
          return autoComplete;
        }
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