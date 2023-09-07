using BuberDinner.Application.Common.Interfaces.Authentication;

namespace BuberDinner.Infrastructure.Authentication;
public class JwtGenerator : IJwtGenerator
{

    
    public string GenerateToken(Guid userId, string firstName, string lastName)
    {
        throw new NotImplementedException();
    }
}