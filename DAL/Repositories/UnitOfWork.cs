using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjectDbContext projectDbContext;

        public IBaseRepository<Desk> DeskRep;
        public IBaseRepository<Role> RoleRep;
        public IBaseRepository<User> UserRep;
        public IBaseRepository<Workspace> WorkspaceRep;

        public UnitOfWork(DbContextOptions options)
        {
            projectDbContext = new ProjectDbContext(options);
        }

        public IBaseRepository<Desk> Desks
        {
            get
            {

                if (this.DeskRep == null)
                {
                    this.DeskRep = new BaseRepository<Desk>(projectDbContext);
                }
                return DeskRep;
            }
        }

        public IBaseRepository<Role> Roles
        {
            get
            {
                if (this.RoleRep == null)
                {
                    this.RoleRep = new BaseRepository<Role>(projectDbContext);
                }
                return RoleRep;
            }
        }

        public IBaseRepository<User> Users
        {
            get
            {
                if (this.UserRep == null)
                {
                    this.UserRep = new BaseRepository<User>(projectDbContext);
                }
                return UserRep;
            }
        }

        public IBaseRepository<Workspace> Workspaces
        {
            get
            {
                if (this.WorkspaceRep == null)
                {
                    this.WorkspaceRep = new BaseRepository<Workspace>(projectDbContext);
                }
                return WorkspaceRep;
            }
        }

        private bool disposed = false;

        public void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    projectDbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public void Save()
        {
            projectDbContext.SaveChanges();
        }
    }
}
