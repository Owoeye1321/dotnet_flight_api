using FlightApi.Interface;
using System.Net.Http;
using FlightApi.Helpers;

namespace FlightApi.Service
{
  public class FlightService : IFlightAction
  {

    private ICredential environmentVariables;
    public FlightService(ICredential environmentVariables)
    {
      this.environmentVariables = environmentVariables;
    }

    public Task<autoComplete> autoComplete()
    {
      try
      {
        var configUrl = environmentVariables.RapidUrl;
        using (HttpClient httpClient = new HttpClient())
        {
        var response = httpClient.GetAsync(configUrl);
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