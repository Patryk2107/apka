using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SavingApiMenager.Contracts;
using SavingApiMenager.Exeptions;
using SavingApiMenager.Models;
using SavingFileDb;
using SavingFileDb.Entities;

namespace SavingApiMenager.Services
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
                UserSurname = result.UserSurname,
                Photo = result.Photo
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
            var files = _context.Files.Where(x => x.StatusFile == "public").ToList();
            return _mapper.Map<List<TV>>(files);
        }

        public bool Update<TV>(int id, TV model)
        {
            var result = model as FileModel;
            result.UpdatedIn = DateTime.Now;

            var file = _context.Files.AsNoTracking()?.Where(x => x.Id == id).FirstOrDefault();
            
            if (file != null)
            {
                var response = _mapper.Map<File>(result);
                response.StatusFile = file.StatusFile;
                response.AddedDate = file.AddedDate;
                response.FileType = file.FileType;
                response.Photo = file.Photo;
                response.UserEmail = file.UserEmail;
                response.UserName = file.UserName;
                response.UserSurname = file.UserSurname;
                response.Id = file.Id;
                
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
                UserSurname = result.UserSurname,
                Photo = result.Photo
            };

            _context.Files.Add(file);
            _context.SaveChanges();

            return true;
        }

        public List<TV> GetGetExtended<TV>(FileModelQuery query)
        {
            var files = _context.Files.Where(x => x.UserName == query.UserName && x.UserSurname == query.UserSurname &&
                                                  x.UserEmail == query.UserEmail || x.UserEmail == query.UserEmail).ToList();
            return _mapper.Map<List<TV>>(files);
        }

        public TV GetByFileName<TV>(FileSearchModel model)
        {
            var value = _context.Files.FirstOrDefault(x => x.Title == model.FileName);
            var user = _context.Users.FirstOrDefault(x => x.Email == model.Email);
            if (value != null)
            {
                if (user != null && user.Role == "admin")
                {
                    return _mapper.Map<TV>(value);
                }
                if (value.StatusFile == "Secret")
                {
                    if (user != null && user.Email == model.Email)
                    {
                        return _mapper.Map<TV>(value);
                    }
                }

                if (value.StatusFile == "Private")
                {
                    if (user != null || value.UserEmail == model.Email)
                    {
                        return _mapper.Map<TV>(value);
                    }
                }

                if (value.StatusFile == "Public")
                {
                    return _mapper.Map<TV>(value);
                }
            }
            throw new NotFoundException("not found");
        }

        public FileModel GetByFileName(FileSearchModel model)
        {
            var value = _context.Files.FirstOrDefault(x => x.Title == model.FileName);
            var user = _context.Users.FirstOrDefault(x => x.Email == model.Email);
            if (value != null)
            {
                if (user != null && user.Role == "admin")
                {
                    return _mapper.Map<FileModel>(value);
                }
                if (value.StatusFile == "Secret")
                {
                    if (user != null && user.Email == value.UserEmail)
                    {
                        return _mapper.Map<FileModel>(value);
                    }
                }

                if (value.StatusFile == "Private")
                {
                    if (user != null || value.UserEmail == model.Email)
                    {
                        return _mapper.Map<FileModel>(value);
                    }
                }

                if (value.StatusFile == "Public")
                {
                    return _mapper.Map<FileModel>(value);
                }
            }

            return new FileModel{Title = "NoAuth"};
        }
    }
}
