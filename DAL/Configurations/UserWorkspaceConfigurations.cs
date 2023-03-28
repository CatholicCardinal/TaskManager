using DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class UserWorkspaceConfigurations : IEntityTypeConfiguration<UserWorkspace>
    {
        public void Configure(EntityTypeBuilder<UserWorkspace> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(x => x.UserWorkspaces)
                .HasForeignKey(x => x.UserID);

            builder.HasOne(x => x.Workspace)
                .WithMany(x => x.UserWorkspaces)
                .HasForeignKey(x => x.WorkspaceID);

            builder.HasKey(x => new { x.UserID, x.WorkspaceID });
        }
        
    }
}
