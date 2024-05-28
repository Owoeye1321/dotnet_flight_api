using System.IdentityModel.Tokens.Jwt;
namespace FlightApi.Interface

{
  public interface IJwtAction
  {
    string Generatejwt(Guid Id);
    JwtSecurityToken VerifyJwt(string token);
  }
}