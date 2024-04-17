namespace FlightApi.Controller
{
[ApiController]
[Route("flight")]
public class FlightController : ControllerBase
{
  private IFlightAction flightService;
  public FlightController(IFlightAction flightService){
    this.flightService = flightService
  }
  [HttpGet("/get-config")]
  public async Task<IActionResult> getConfig(){
    try
    {
      
    }
    catch (UnprocessableEntityException Ex)
    {
      return BadRequest(code = HttpStatusCode.BadRequest, message = Ex.Message)
    }
  }

 [HttpGet("/check-server-status")]
  public async Task<IActionResult> checkServerStatus(){
       try
    {
      
    }
    catch (UnprocessableEntityException Ex)
    {
      return BadRequest(code = HttpStatusCode.BadRequest, message = Ex.Message)
    }
  }
   [HttpGet("/auto-complete")]
  public async Task<IActionResult> autoComplete(){
       try
    {
      
    }
    catch (UnprocessableEntityException Ex)
    {
      return BadRequest(code = HttpStatusCode.BadRequest, message = Ex.Message)
    }
  }
}
}