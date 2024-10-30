using Secure_API_Template.Data.Entites;

namespace Secure_API_Template.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUsers user);
    }
}
