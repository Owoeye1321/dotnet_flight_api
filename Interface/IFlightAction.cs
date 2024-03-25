namespace FlightApi.Interface
{
  public interface IFlightAction 
  {
    public object create(object payload);
    public object pollSearch();
    public object autoSuggestFlight();
    public object autoSuggestHotels();
    public object searchHotels();
    public object getLocals();
    public object getCarrier();
    public object getLocations();
  }
}