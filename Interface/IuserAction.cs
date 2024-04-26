using FlightApi.model;
using FlightApi.Dtos;
namespace FlightApi.Interface
{
  public interface IUserAction{
    Task<User> registerUserAsync(User user);
    Task<User> loginAsync(loginDto login);
    Task<boolean> forgetPassword(forgetPasswordDto forgetPasswordDto)
  }
}