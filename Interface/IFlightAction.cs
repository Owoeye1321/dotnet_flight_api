namespace FlightApi.Interface
{
  public interface IFlightAction 
  {
    public object create(object payload);
    public object pollSearch(string sessionToken);
    public object autoSuggestFlight(object payload);
    public object autoSuggestHotels(object payload);
    public object searchHotels(object payload);
    public object getLocals();
    public object getCarrier();
    public object getLocations(object payload);
  }
}