namespace FlightApi.Settings{
  public class RapidSettings {

     public string XRapidAPIKey {get; set;}
   public string XRapidAPIHost {get; set;}
   public string RapidUrl {get; set;}
     public string getXRapidAPIKey {get {return XRapidAPIKey}};
   public string getXRapidAPIHost {get {return XRapidAPIHost}}
   public string getRapidUrl {get {return RapidUrl}}
   
  }
}