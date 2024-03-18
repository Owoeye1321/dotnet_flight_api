using FlightApi.Interface;


namespace FlightApi.model
{
  public record User : IUser
  {
    Guid id {get; set;}

    [Required]
    string username {get; set;}

    [Required]
    string email {get; set;}

    [Required]
    string password {get; set;}

  }
}