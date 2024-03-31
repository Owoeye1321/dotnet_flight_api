namespace FlightApi.Interface
{
  public interface IFlightAction 
  {
    Task<getConfig> getConfig();
    Task<checkServerStatus> checkServerStatus();
    Task<autoComplete> autoComplete();
  }
}