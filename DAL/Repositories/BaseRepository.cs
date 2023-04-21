using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly ProjectDbContext _projectDbContext;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(ProjectDbContext internshipDbContext)
        {
            _projectDbContext = internshipDbContext;
            _dbSet = _projectDbContext.Set<T>();
        }

        public T Get(int id)
        {
            return _dbSet.SingleOrDefault(x => x.Id == id);
        }

		public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public void Remove(T model)
        {
            _projectDbContext.Remove(model);
        }

        public void Remove(int id)
        {
            var model = Get(id);
            Remove(model);
        }

        public void RemoveAll()
        {
            _dbSet.RemoveRange(_dbSet);
        }

        public void Save(T model)
        {
            if (model.Id > 0)
            {
                _dbSet.Update(model);
            }
            else
            {
                _dbSet.Add(model);
            }
        }
    }
}
