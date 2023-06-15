using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PrywatnaPrzychodniaLekarska.Services;
using SavingFileApi.Interfaces;
using SavingFileApi.Models;
using SavingFileDb;
using SavingFileDb.Entities;

namespace SavingFileApi.Services
{
    public class FileService: ConnectionService, ICrudScheme<FileService>
    {
        public IMapper _mapper;
        public FileService(SavingFileDbContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public bool Create<TV>(TV userModel)
        {
            var result = userModel as FileModel;
            var file = new File
            {
                StatusFile = result.StatusFile,
                AddedDate = result.AddedDate,
                Description = result.Description,
                FileType = result.FileType,
                Title = result.Title,
                UserEmail = result.UserEmail,
                UserName = result.UserName,
                UserSurname = result.UserSurname
            };

            _context.Files.Add(file);
            _context.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            var file = _context.Files?.Where(x => x.Id == id).FirstOrDefault();
            if (file != null)
            {
                _context.Remove(file);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<TV> Get<TV>()
        {
            var files = _context.Files.ToList();
            return _mapper.Map<List<TV>>(files);
        }

        public bool Update<TV>(int id, TV model)
        {
            var result = model as FileModel;

            var file = _context.Files?.Where(x => x.Id == id).FirstOrDefault();
            
            if (file != null)
            {
                var response = _mapper.Map<File>(result);
                
                _context.Files.Update(response);
                _context.SaveChanges();
            }

            return true;
        }

        public TV GetById<TV>(int id)
        {
            var value = _context.Files.FirstOrDefault(x => x.Id == id);
            return _mapper.Map<TV>(value);
        }

        public bool CreateNoLogin<TV>(TV model)
        {
            var result = model as FileModel;
            var file = new File
            {
                StatusFile = result.StatusFile,
                AddedDate = result.AddedDate,
                Description = result.Description,
                FileType = result.FileType,
                Title = result.Title,
                UserEmail = result.UserEmail,
                UserName = result.UserName,
                UserSurname = result.UserSurname
            };

            _context.Files.Add(file);
            _context.SaveChanges();

            return true;
        }
    }
}
