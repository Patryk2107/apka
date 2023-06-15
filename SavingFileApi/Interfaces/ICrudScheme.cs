using System.Collections.Generic;

namespace SavingFileApi.Interfaces
{
    public interface ICrudScheme<T>
    {
        bool Create<TV>(TV userModel);
        bool Delete(int id);
        public List<TV> Get<TV>();
        bool Update<TV>(int id, TV model);
        public TV GetById<TV>(int id);
        //bool CreateNoLogin<TV>(TV model);
    }
}
