using FlightApi.Interface;
namespace FlightApi.Helpers{
  public class CheckServerStatus : ICheckServerStatus {
    public bool status { get; set; }
    public string message { get; set; }
  }

  public class getConfig: IGetConfig{
    public bool status { get; set; }
    public string message { get; set; }
    public int timestamp { get; set; }
    public IEnumerable<getConfigDataObject> data { get; set; }
  }

  public class autoComplete : IAutoComplete{
     public bool status { get; set; }
    public string message { get; set; }
   public  IEnumerable<autoCompleteDataObject> data { get; set; }
  }
}