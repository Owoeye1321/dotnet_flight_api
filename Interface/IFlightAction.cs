namespace FlightApi.Interface
{
  public interface IFlightAction 
  {
    Task<getConfig> getConfig();
    Task<ICheckServerStatus> checkServerStatus();
    Task<autoComplete> autoComplete();
  }
}