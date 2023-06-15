using SavingApiMenager.Authorization;
using SavingApiMenager.Models;

namespace SavingApiMenager.Contracts
{
    public interface ILoginService
    {
        AuthResult TokenGenerator(Credentials dto);
    }
}