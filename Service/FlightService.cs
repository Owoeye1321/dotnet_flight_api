using FlightApi.Interface;
using System.Net;
using FlightApi.Helpers;
using System.Text.Json;

namespace FlightApi.Service
{
  public class FlightService : IFlightAction
  {
    private string configUrl = EnvironmentVariables.RapidUrl;
        private string rapidApiKey = EnvironmentVariables.XRapidAPIKey;
        private string rapidHost = EnvironmentVariables.XRapidAPIHost;
    public FlightService()
    {
    }

    public async Task<autoComplete> autoComplete()
    {
      try
      {
        using (HttpClient httpClient = new HttpClient())
        {
          httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", rapidApiKey);
          httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", rapidHost);
          var response = await httpClient.GetAsync($"{configUrl}/flight/auto-complete");
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

    public async Task<checkServerStatus> checkServerStatus()
    {
       try
      {
      using (HttpClient httpClient = new HttpClient()){
          httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", rapidApiKey);
          httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", rapidHost);
          var response = await httpClient.GetAsync($"{configUrl}/checkServer");
          if(!response.IsSuccessStatusCode){
            throw new UnprocessableEntityException("API Error");
          }
        var responseString = await response.Content.ReadAsStringAsync();
        var checkServer = JsonSerializer.Deserialize<checkServerStatus>(responseString, new JsonSerializerOptions(){PropertyNameCaseInsensitive = true});
        return checkServer;
      }
       }
      catch (Exception ex)
      {
        throw new UnprocessableEntityException(ex.Message);
      }
      throw new NotImplementedException();
    }

    public async Task<getConfig> getConfig()
    {
       try
      {
        using (HttpClient httpClient = new HttpClient())
        {
          httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", rapidApiKey);
          httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", rapidHost);
          Console.WriteLine(configUrl);
          var response = await httpClient.GetAsync($"{configUrl}/get-config");
          if(response.StatusCode != HttpStatusCode.OK){
            throw new UnprocessableEntityException("API Error");
          }
          var responseString = await response.Content.ReadAsStringAsync();

          var getConfig = JsonSerializer.Deserialize<getConfig>(responseString, new JsonSerializerOptions(){PropertyNameCaseInsensitive = true});
          return getConfig;
        } 
      }
      catch (Exception ex)
      {
        throw new UnprocessableEntityException(ex.Message);
      }
    }
  }
}