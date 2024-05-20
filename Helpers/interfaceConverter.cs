using FlightApi.Interface;
namespace FlightApi.Helpers{
  public class CheckServerStatus : ICheckServerStatus {
    public bool status { get; set; }
    public string message { get; set; }
  }

  public class getConfig: IGetConfig{
    public bool status { get; set; }
    public string message { get; set; }
    public double timestamp { get; set; }
    public IEnumerable<getConfigDataObject> data { get; set; }
  }
  public class autoCompleteDataObject:IAutoCompleteDataObject {
    public string id { get; set; }

  }

  public class autoComplete : IAutoComplete{
     public bool status { get; set; }
    public string message { get; set; }
   public  IEnumerable<autoCompleteDataObject> data { get; set; }
  }

  public class getConfigDataObject: IGetConfigDataObject{
     public string country { get; set; }
    public string market { get; set; }
    public string locale { get; set; }
    public object currencyTitle { get; set; }
    public string currency { get; set; }
    public string currencySymbol { get; set; }
    public string site { get; set; }
  }
}