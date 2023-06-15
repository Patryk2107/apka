﻿using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SavingApiMenager.Contracts;
using SavingApiMenager.Exeptions;
using SavingApiMenager.Models;
using SavingFileDb;
using SavingFileDb.Entities;

namespace SavingApiMenager.Services
{
    public class UserService : ConnectionService, ICrudScheme<UserService>
    {
        private IPasswordHasher<User> _passwordHasher;
        private IMapper _mapper;

        public UserService(SavingFileDbContext context, IPasswordHasher<User> passwordHasher, IMapper mapper) : base(context)
        {
            _mapper = mapper;
            _passwordHasher = passwordHasher;
        }

        public bool Create<TV>(TV userModel)
        {
            var userDto = userModel as UserModel;
            var user = _context.Users.Any(x => x.Email == userDto.Email);
            if (!user)
            {
                var createUser = new User
                {
                    Email = userDto.Email,
                    FirstName = userDto.FirstName,
                    LastName = userDto.LastName,
                    Role = userDto.Role
                };

                var hashedPassword = _passwordHasher.HashPassword(createUser, userDto.Password);
                createUser.Password = hashedPassword;

                _context.Users.Add(createUser);
                _context.SaveChanges();

                return true;
            }

            return false;

        }

        public bool Delete(int id)
        {
            var user = _context.Users.Where(x => x.Id == id)?.FirstOrDefault();

            if (user == null)
            {
                throw new NotFoundException($"Brak użytkownika o podanym id:{id}");
            }
            _context.Remove(user);
            _context.SaveChanges();
            return true;
        }

        public List<TV> Get<TV>()
        {
            var user = _context.Users.ToList();
            return _mapper.Map<List<TV>>(user);
        }

        public bool Update<TV>(int id, TV model)
        {
            var userDto = model as UserModel;
            var user = _context.Users.Where(x => x.Id == id)?.FirstOrDefault();
            if (user == null)
            {
                throw new NotFoundException($"Brak użytkownika o podanym id:{id}");
            }

            user.Email = userDto.Email;
            user.FirstName = userDto.FirstName;
            user.LastName = userDto.LastName;
            user.Password = userDto.Password;
            user.Role = userDto.Role;

            var hashedPassword = _passwordHasher.HashPassword(user, userDto.Password);
            user.Password = hashedPassword;

            _context.Update(user);
            _context.SaveChanges();

            return true;
        }

        public TV GetById<TV>(int id)
        {
            var value = _context.Users.FirstOrDefault(x => x.Id == id);
            return _mapper.Map<TV>(value);
        }

        public bool CreateNoLogin<TV>(TV model)
        {
            return true;
        }

        public List<TV> GetGetExtended<TV>(FileModelQuery query)
        {
            throw new System.NotImplementedException();
        }

        public TV GetByFileName<TV>(FileSearchModel model)
        {
            throw new System.NotImplementedException();
        }

        public FileModel GetByFileName(FileSearchModel model)
        {
            throw new System.NotImplementedException();
        }

        //public List<TV> GetGetExtended<TV>(FileModelQuery query)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
