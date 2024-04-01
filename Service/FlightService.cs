using FlightApi.Interface;

namespace FlightApi.Service
{
  public class FlightService
  {

    private ICredential environmentVariables;
    public FlightService(ICredential environmentVariables){
      this.environmentVariables = environmentVariables;
    }
    // public async Task<object> create(object payload)
    // {
    // }
    //   public async Task<object> pollSearch(string sessionToken)
    // {
      
    // }
    //   public async Task<object> autoSuggestFlight(object payload)
    // {
      
    // }
    //   public async Task<object> autoSuggestHotels(object payload)
    // {
      
    // }
    //   public async Task<object> searchHotels(object payload)
    // {
      
    // }
    //   public async Task<object> getLocals()
    // {
      
    // }
    //   public async Task<object> getCarrier()
    // {
      
    // }
    //   public async Task<object> getLocations(object payload)
    // {
      
    // }
  }
}