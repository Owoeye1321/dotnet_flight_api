
namespace FlightApi.Interface
{
  public interface IUser{
    Guid id {get; set;}
    string username {get; set;}
    string email {get; set;}
    string password {get; set;}
    string salt {get; set;}
  }
}