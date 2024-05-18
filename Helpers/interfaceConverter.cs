using FlightApi.Interface;
namespace FlightApi.Helpers{
  public class CheckServerStatus : ICheckServerStatus {
    public bool status { get; set; }
    public string message { get; set; }
  }


  public class getConfig: IGetConfig{
    public string status { get; set; }
    public string message { get; set; }
    public string timestamp { get; set; }
    public IEnumerable<getConfigDataObject> data { get; set; }
  }

  public class autoComplete : IAutoComplete{
     public string status { get; set; }
    public string message { get; set; }
   public  IEnumerable<autoCompleteDataObject> data { get; set; }
  }
}