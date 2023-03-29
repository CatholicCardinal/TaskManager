using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        IQueryable<T> GetAll();
        T Get(int id);
        void Save(T model);
        void RemoveAll();
        void Remove(T model);
        void Remove(int id);
    }
}
