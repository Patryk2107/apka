using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SavingFileDb;

namespace PrywatnaPrzychodniaLekarska.Services
{
    public abstract class ConnectionService 
    {
        public SavingFileDbContext _context;
        public ConnectionService(SavingFileDbContext context)
        {
            _context = context;
        }

        public ConnectionService()
        {
        }
    }
}
