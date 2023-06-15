using System;

namespace SavingApiMenager.Models
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
        public byte[] Photo { get; set; }
        public string UpdatedByLogin { get; set; }
        public DateTime UpdatedIn { get; set; }
    }
}
