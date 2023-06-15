using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using PrywatnaPrzychodniaLekarska.Services;
using SavingFileDb;
using SavingFileDb.Entities;

namespace SavingFileApi
{
    public class SavingApiSeeder: ConnectionService
    {
        private IPasswordHasher<User> _passwordHasher;

        public SavingApiSeeder(SavingFileDbContext context, IPasswordHasher<User> passwordHasher) : base(context)
        {
            _passwordHasher = passwordHasher;
        }

        public void Seed()
        {
            if (_context.Database.CanConnect())
            {
                if (!_context.Users.Any())
                {
                    var user = SeedUser();
                    _context.Users.Add(user);
                    _context.SaveChanges();

                    var admin = SeedAdmin();
                    _context.Users.Add(admin);
                    _context.SaveChanges();
                }

                if (!_context.StatusFiles.Any())
                {
                    var status = new List<StatusFile>
                    {
                        new StatusFile
                        {
                            Status = "Private"
                        },
                        new StatusFile
                        {
                            Status = "Public"
                        },
                        new StatusFile
                        {
                            Status = "Secret"
                        }
                    };
                    _context.StatusFiles.AddRange(status);
                    _context.SaveChanges();
                }
            }
        }

        public User SeedUser()
        {
            var createUser = new User
            {
                Email = "user@gmail.com",
                FirstName = "Beata",
                LastName = "Milinska",
                Role = "user",
                Password = "user"
            };

            var hashedPassword = _passwordHasher.HashPassword(createUser, createUser.Password);
            createUser.Password = hashedPassword;

            return createUser;
        }

        public User SeedAdmin()
        {
            var createUser = new User
            {
                Email = "admin@gmail.com",
                FirstName = "Beata",
                LastName = "Milinska",
                Role = "admin",
                Password = "admin"
            };

            var hashedPassword = _passwordHasher.HashPassword(createUser, createUser.Password);
            createUser.Password = hashedPassword;

            return createUser;
        }
    }
}
