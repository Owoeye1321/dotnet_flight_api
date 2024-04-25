using System.ComponentModel.DataAnnotations;
namespace FlightApi.Dtos 
{
  public record loginDto([Required] string email, [Required] string password);
  public record userDto([Required] string username, [Required] string email, [Required] string password);
  public record forgetPasswordDto([Required] string email);
}