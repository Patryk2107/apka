using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavingFileApi.Models
{
    public class FileModel
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
    }
}
