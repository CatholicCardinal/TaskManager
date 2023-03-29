using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Desk> Desks { get; }
        IBaseRepository<Role> Roles { get; }
        IBaseRepository<User> Users { get;}
        IBaseRepository<Workspace> Workspaces { get; }

        void Save();
    }
}
