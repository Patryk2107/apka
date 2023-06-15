using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SavingApiMenager.Models;
using SavingFileDb.Entities;

namespace SavingApiMenager.Mappers
{
    public class FileMappingProfile: Profile
    {
        public FileMappingProfile()
        {
            CreateMap<File, FileModel>();
            CreateMap<FileModel, File>();
        }
    }
}
