using SavingFileApi.Authorization;
using SavingFileApi.Models;

namespace SavingFileApi.Interfaces
{
    public interface ILoginService
    {
        AuthResult TokenGenerator(Credentials dto);
    }
}