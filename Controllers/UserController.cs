using System.Net;
using Microsoft.AspNetCore.Mvc;
using FlightApi.Interface;
using FlightApi.Dtos;
using FlightApi.model;
using FlightApi.Helpers;

namespace FlightApi.Controllers
{
  [ApiController]

  [Route("auth")]
  public class UserController : ControllerBase
  {
    private IUserAction userService;


    public UserController(IUserAction userService)
    {
      this.userService = userService;
    }

    [HttpPost("/login")]
    public async Task<ActionResult> loginAsync(loginDto data)
    {
      try
      {
        return Ok(new { });
      }
      catch (UnprocessableEntityException Ex)
      {
        return UnprocessableEntity(new { code = HttpStatusCode.UnprocessableEntity, message = Ex.Message });
      }
    }

    [HttpPost("/register")]
    public async Task<ActionResult> registerUserAsync(userDto user)
    {
      try
      {

         User userDetail = new User()
         {
         id = new Guid(),
         email = user.email,
         username = user.username,
         password = user.password
         };
          await userService.registerUserAsync(userDetail);
        return Ok( new {code = HttpStatusCode.OK, message = "success", data = userDetail});
      }
      catch (UnprocessableEntityException Ex)
      {
       return UnprocessableEntity(new { code = HttpStatusCode.UnprocessableEntity, message = Ex.Message });
      }
    }
  }
}