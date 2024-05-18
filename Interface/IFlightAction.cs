namespace FlightApi.Interface
{
  public interface IFlightAction 
  {
    Task<IGetConfig> getConfig();
    Task<ICheckServerStatus> checkServerStatus();
    Task<IAutoComplete> autoComplete();
  }
}