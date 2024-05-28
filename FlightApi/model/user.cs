using FlightApi.Interface;
using System.ComponentModel.DataAnnotations;


namespace FlightApi.model
{
  public record User : IUser
  {
    public Guid id {get; set;}

    [Required]
    public string username {get; set;}

    [Required]
    public  string email {get; set;}

    [Required]
    public string password {get; set;}

    public string salt {get; set;}

    public string two_fa_code {get; set;}

  }
}