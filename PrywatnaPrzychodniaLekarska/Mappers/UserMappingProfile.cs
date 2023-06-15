using AutoMapper;
using SavingApiMenager.Models;
using SavingFileDb.Entities;

namespace SavingApiMenager.Mappers
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<UserModel, User>();
        }
    }
}
