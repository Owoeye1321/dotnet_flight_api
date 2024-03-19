using System.ComponentModel.DataAnnotations;
namespace FlightApi.Dtos 
{
  public record LoginDto([Required] string email, [Required] string password);
  public record UserDto([Required] string username, [Required] string email, [Required] string password);
}