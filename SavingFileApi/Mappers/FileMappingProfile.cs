using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SavingFileApi.Models;
using SavingFileDb.Entities;

namespace SavingFileApi.Mappers
{
    public class FileMappingProfile: Profile
    {
        protected FileMappingProfile()
        {
            CreateMap<File, FileModel>();
            CreateMap<FileModel, File>();
        }
    }
}
