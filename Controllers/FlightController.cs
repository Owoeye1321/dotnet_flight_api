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

 [HttpGet("/check-server-status")]
  public async Task<IActionResult> checkServerStatus(){
  }
   [HttpGet("/auto-complete")]
  public async Task<IActionResult> autoComplete(){
  }
}
}