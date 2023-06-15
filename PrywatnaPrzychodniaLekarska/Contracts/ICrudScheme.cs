using System.Collections.Generic;
using SavingApiMenager.Models;

namespace SavingApiMenager.Contracts
{
    public interface ICrudScheme<T>
    {
        bool Create<TV>(TV userModel);
        bool Delete(int id);
        public List<TV> Get<TV>();
        bool Update<TV>(int id, TV model);
        public TV GetById<TV>(int id);
        bool CreateNoLogin<TV>(TV model);
        List<TV> GetGetExtended<TV>(FileModelQuery query);
        public TV GetByFileName<TV>(FileSearchModel model);
        public FileModel GetByFileName (FileSearchModel model);
    }
}
