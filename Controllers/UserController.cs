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
        if(user == null || !BCrypt.Net.BCrypt.Verify(data.password, user.password)) return BadRequest(new { code = HttpStatusCode.BadRequest, message = "Invalid details"});
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
        // Generate a salt and hash the password
        string salt = BCrypt.Net.BCrypt.GenerateSalt();

         User userDetail = new User()
         {
         id = new Guid(),
         email = user.email,
         username = user.username,
         salt = salt,
         password = BCrypt.Net.BCrypt.HashPassword(user.password, salt)
         };
        await userService.registerUserAsync(userDetail);
        string token = jwtService.Generatejwt(userDetail.id);
        return Ok( new {code = HttpStatusCode.OK, message = "success", data = userDetail, token = token});
      }
      catch (UnprocessableEntityException Ex)
      {
       return BadRequest(new { code = HttpStatusCode.UnprocessableEntity, message = Ex.Message });
      }
    }

    [HttpPost("/forget-password")]
    public async Task<ActionResult> forgetPassword (forgetPasswordDto data){
      try
      {
        bool emailExist = aweait userService.forgetPassword(data);
        if(!emailExist) return BadRequest(new {code: HttpStatusCode.BadRequest, message = "Email does not exist"})
      }
      catch (UnprocessableEntityException Ex)
      {
        return BadRequest(new { code = HttpStatusCode.UnprocessableEntity, message = Ex.Message });
      }
    }
  }
}