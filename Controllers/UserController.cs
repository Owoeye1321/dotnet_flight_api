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
    private IJwtAction jwtService;


    public UserController(IUserAction userService, IJwtAction jwtService)
    {
      this.userService = userService;
      this.jwtService = jwtService;
    }

    [HttpPost("/login")]
    public async Task<ActionResult> loginAsync(loginDto data)
    {
      try
      {
        var user =  await userService.loginAsync(data);
        if(user == null || !BCrypt.Net.BCrypt.Verify(user.password, data.password)) return BadRequest(new { code = HttpStatusCode.BadRequest, message = "Invalid details"});
        var token = jwtService.Generatejwt(user.id);
        return Ok(new {code = HttpStatusCode.OK, message = "success", data = user, token = token});
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
         password = BCrypt.Net.BCrypt.HashPassword(user.password)
         };
          await userService.registerUserAsync(userDetail);
          string token = jwtService.Generatejwt(userDetail.id);
          Console.WriteLine(token);
        return Ok( new {code = HttpStatusCode.OK, message = "success", data = userDetail, token = token});
      }
      catch (UnprocessableEntityException Ex)
      {
       return BadRequest(new { code = HttpStatusCode.UnprocessableEntity, message = Ex.Message });
      }
    }
  }
}