using System.IdentityModel.Tokens.Jwt;
namespace Notepad.Interface

{
  public interface IJwtInterface
  {
    string Generatejwt(Guid Id);
    JwtSecurityToken VerifyJwt(string token);
  }
}