using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Desk> Desks { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UsersRoles { get; set; }
        public DbSet<UserWorkspace> UsersWorkspaces { get; set; }
        public DbSet<Workspace> Workspaces{ get; set; }
        public DbSet<WorkspaceDesk> WorkspacesDesks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProjectDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<User>().HasData(
				new User { Id = 1, FirstName = "Vlad", LastName = "Fedorov", Email ="vlad.fiodorov11@gmail.com", Password="123"},
				new User { Id = 2, FirstName = "Pasha", LastName = "Shlyaga", Email ="pasha@gmail.com", Password= "1234" },
				new User { Id = 3, FirstName = "Nikita", LastName = "Ponomarev", Email ="nikita@gmail.com", Password = "12345" }
		);
		}
    }
}