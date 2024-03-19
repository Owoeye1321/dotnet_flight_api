using System.IdentityModel.Tokens.Jwt;
namespace FlightApi.Interface

{
  public interface IJwtInterface
  {
    string Generatejwt(Guid Id);
    JwtSecurityToken VerifyJwt(string token);
  }
}