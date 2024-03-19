using FlightApi.model;
using FlightApi.Dtos;
namespace FlightApi.Interface
{
  public interface IUserAction{
    Task<User> RegisterUserAsync(User user);
    Task LoginAsync(LoginDto login);
  }
}