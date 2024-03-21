using System.Net;
using Microsoft.AspNetCore.Mvc;
using FlightApi.Interface;
using FlightApi.Dtos;
using FlightApi.Helpers;

namespace FlightApi.Controllers
{
  [ApiController]

  [Route("user")]
  public class UserController : ControllerBase
  {
    private IUserAction userService;

    public UserController(IUserAction userService)
    {
      this.userService = userService;
    }

    public async Task<ActionResult> loginAsync(loginDto data)
    {
      try
      {
        return Ok(new { });
      }
      catch (UnprocessableEntityException e)
      {
        return UnprocessableEntity(new { code = HttpStatusCode.UnprocessableEntity, message = e.Message });
      }


    }
  }
}