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
      throw new NotImplementedException();
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