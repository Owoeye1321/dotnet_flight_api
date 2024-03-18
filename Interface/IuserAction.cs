using FlightApi.model;
namespace FlightApi.Interface
{
  public interface IUserAction{
    Task<User> RegisterUserAsync(User user);
    Task LoginAsync(LoginDto login)
  }
}