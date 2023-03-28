using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class WorkspaceDeskConfigurations : IEntityTypeConfiguration<WorkspaceDesk>
    {
        public void Configure(EntityTypeBuilder<WorkspaceDesk> builder)
        {
            builder.HasOne(x => x.Desk)
                .WithMany(x => x.WorkspaceDesks)
                .HasForeignKey(x => x.DeskID);

            builder.HasOne(x => x.Workspace)
                .WithMany(x => x.WorkspaceDesks)
                .HasForeignKey(x => x.WorkspaceID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasKey(x => new { x.WorkspaceID, x.DeskID });
        }
    }
}
