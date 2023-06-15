using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using SavingApiMenager.Services;
using SavingFileDb;
using SavingFileDb.Entities;

namespace SavingApiMenager
{
    public class SavingDbSeeder : ConnectionService
    {
        private IPasswordHasher<User> _passwordHasher;

        public SavingDbSeeder(SavingFileDbContext context, IPasswordHasher<User> passwordHasher) : base(context)
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

                    var user2 = SeedUserSecond();
                    _context.Users.Add(user2);
                    _context.SaveChanges();

                    var admin = SeedAdmin();
                    _context.Users.Add(admin);
                    _context.SaveChanges();
                }

                if (!_context.StatusFiles.Any())
                {
                    var status = new List<StatusFile>
                    {
                        new StatusFile{Status = "Private"},
                        new StatusFile{Status = "Public"},
                        new StatusFile{Status = "Secret"}
                    };
                    _context.StatusFiles.AddRange(status);
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

        public User SeedUserSecond()
        {
            var createUser = new User
            {
                Email = "user2@gmail.com",
                FirstName = "Tomek",
                LastName = "Milinska",
                Role = "user",
                Password = "user2"
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
