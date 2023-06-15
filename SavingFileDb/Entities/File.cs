using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SavingFileDb.Entities
{
    public class File
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FileType { get; set; }
        public DateTime AddedDate { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserEmail { get; set; }
        public string StatusFile { get; set; }
        public byte[] Photo { get; set; }
        public string UpdatedByLogin { get; set; }
        public DateTime UpdatedIn { get; set; }
    }
}
