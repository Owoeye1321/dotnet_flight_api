using Microsoft.AspNetCore.Mvc;
using FlightApi.Interface;

namespace FlightApi.Controllers
{
  [ApiController]

  [Route("user")]
  public class UserController : ControllerBase
  {
      private IUserAction userService;

      public UserController(IUserAction userService){
        this.userService = userService;
      }
  }
}