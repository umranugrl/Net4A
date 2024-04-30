using Core.Entities;

namespace Core.Utilities.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(BaseUser user);
    }
}