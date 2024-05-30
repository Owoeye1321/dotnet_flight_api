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

    public async Task<IAutoComplete> autoComplete()
    {
      try
      {
        using (HttpClient httpClient = new HttpClient())
        {
          httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key","37f4bc3034msha49c34d8cab9a70p1a537fjsnc2dbc343db77");
          httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host","skyscanner80.p.rapidapi.com");
          var response = await httpClient.GetAsync("https://skyscanner80.p.rapidapi.com/api/v1/flight/auto-complete");
          if(response.StatusCode != HttpStatusCode.OK){
            throw new UnprocessableEntityException("API Error");
          }
          var responseString = await response.Content.ReadAsStringAsync();

          IAutoComplete autoComplete = JsonSerializer.Deserialize<autoComplete>(responseString, new JsonSerializerOptions(){PropertyNameCaseInsensitive = true});
          return autoComplete;
        } 
      }
      catch (Exception ex)
      {
        throw new UnprocessableEntityException(ex.Message);
      }
      
    }

    public async Task<ICheckServerStatus> checkServerStatus()
    {
       try
      {
      using (HttpClient httpClient = new HttpClient()){
        httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key","37f4bc3034msha49c34d8cab9a70p1a537fjsnc2dbc343db77");
          httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host","skyscanner80.p.rapidapi.com");
          var response = await httpClient.GetAsync("https://skyscanner80.p.rapidapi.com/api/v1/checkServer");
          if(!response.IsSuccessStatusCode){
            throw new UnprocessableEntityException($"{response.StatusCode} API Error");
          }
        var responseString = await response.Content.ReadAsStringAsync();
        ICheckServerStatus checkServer = JsonSerializer.Deserialize<CheckServerStatus>(responseString, new JsonSerializerOptions(){PropertyNameCaseInsensitive = true});
        return checkServer;
      }
       }
      catch (Exception ex)
      {
        throw new UnprocessableEntityException(ex.Message);
      }
    }

    public async Task<IGetConfig> getConfig()
    {
       try
      {
        using (HttpClient httpClient = new HttpClient())
        {
           httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key","37f4bc3034msha49c34d8cab9a70p1a537fjsnc2dbc343db77");
          httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host","skyscanner80.p.rapidapi.com");
          var response = await httpClient.GetAsync("https://skyscanner80.p.rapidapi.com/api/v1/get-config");
          if(response.StatusCode != HttpStatusCode.OK){
            throw new UnprocessableEntityException($"{response.StatusCode} API Error");
          }
          var responseString = await response.Content.ReadAsStringAsync();
          Console.WriteLine(responseString);
          IGetConfig getConfig = JsonSerializer.Deserialize<getConfig>(responseString, new JsonSerializerOptions(){PropertyNameCaseInsensitive = true});
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