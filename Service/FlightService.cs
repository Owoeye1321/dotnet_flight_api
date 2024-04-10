using FlightApi.Interface;

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
        using (var httpClient = new httpClient()){
        var response = httpClient.GetAsync()
      }
      throw new NotImplementedException();
      }
      catch (Exception ex)
      {
        throw new UnprocessableEntity(ex.message)
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