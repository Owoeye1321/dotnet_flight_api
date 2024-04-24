using System.Net;
using Microsoft.AspNetCore.Mvc;
using FlightApi.Interface;

namespace FlightApi.Controller
{
[ApiController]
[Route("flight")]
public class FlightController : ControllerBase
{
  private IFlightAction flightService;
  public FlightController(IFlightAction flightService){
    this.flightService = flightService;
  }
  [HttpGet("/get-config")]
  public async Task<IActionResult> getConfig(){
    try
    {
      getConfig configResponse = await flightService.getConfig();
      return Ok(new { code = HttpStatusCode.OK, message = "success", data = configResponse});
    }
    catch (UnprocessableEntityException Ex)
    {
      return BadRequest(code = HttpStatusCode.BadRequest, message = Ex.Message);
    }
  }

 [HttpGet("/check-server-status")]
  public async Task<IActionResult> checkServerStatus(){
       try
    {
      checkServerStatus runCheck = await flightService.checkServerStatus();
      return Ok(new {code = HttpStatusCode.OK, message = "success", data = runCheck});
    }
    catch (UnprocessableEntityException Ex)
    {
      return BadRequest(code = HttpStatusCode.BadRequest, message = Ex.Message);
    }
  }
   [HttpGet("/auto-complete")]
  public async Task<IActionResult> autoComplete(){
       try
    {
      autoComplete autoComplete = await flightService.autoComplete();
      return Ok(new {code = HttpStatusCode.OK, message = "success", data = autoComplete});
    }
    catch (UnprocessableEntityException Ex)
    {
      return BadRequest(code = HttpStatusCode.BadRequest, message = Ex.Message);
    }
  }
}
}