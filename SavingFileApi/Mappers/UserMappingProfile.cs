using AutoMapper;
using SavingFileApi.Models;
using SavingFileDb.Entities;

namespace SavingFileApi.Mappers
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
