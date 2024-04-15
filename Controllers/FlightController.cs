namespace FlightApi.Controller
{
[ApiController]
[Route("flight")]
public class FlightController : ControllerBase
{
  public FlightController(){}
  [HttpGet("/get-config")]
  public async Task<IActionResult> getConfig(){

  }

}
}