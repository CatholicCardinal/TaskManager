﻿// <auto-generated />
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    partial class ProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Models.Desk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Desks");
                });

            modelBuilder.Entity("DAL.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "vlad.fiodorov11@gmail.com",
                            FirstName = "Vlad",
                            LastName = "Fedorov",
                            Password = "123"
                        },
                        new
                        {
                            Id = 2,
                            Email = "pasha@gmail.com",
                            FirstName = "Pasha",
                            LastName = "Shlyaga",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 3,
                            Email = "nikita@gmail.com",
                            FirstName = "Nikita",
                            LastName = "Ponomarev",
                            Password = "12345"
                        });
                });

            modelBuilder.Entity("DAL.Models.UserRole", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("UserID", "RoleID");

                    b.HasIndex("RoleID");

                    b.ToTable("UsersRoles");
                });

            modelBuilder.Entity("DAL.Models.UserWorkspace", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("WorkspaceID")
                        .HasColumnType("int");

                    b.HasKey("UserID", "WorkspaceID");

                    b.HasIndex("WorkspaceID");

                    b.ToTable("UsersWorkspaces");
                });

            modelBuilder.Entity("DAL.Models.Workspace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workspaces");
                });

            modelBuilder.Entity("DAL.Models.WorkspaceDesk", b =>
                {
                    b.Property<int>("WorkspaceID")
                        .HasColumnType("int");

                    b.Property<int>("DeskID")
                        .HasColumnType("int");

                    b.HasKey("WorkspaceID", "DeskID");

                    b.HasIndex("DeskID");

                    b.ToTable("WorkspacesDesks");
                });

            modelBuilder.Entity("DAL.Models.UserRole", b =>
                {
                    b.HasOne("DAL.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Models.UserWorkspace", b =>
                {
                    b.HasOne("DAL.Models.User", "User")
                        .WithMany("UserWorkspaces")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.Workspace", "Workspace")
                        .WithMany("UserWorkspaces")
                        .HasForeignKey("WorkspaceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Workspace");
                });

            modelBuilder.Entity("DAL.Models.WorkspaceDesk", b =>
                {
                    b.HasOne("DAL.Models.Desk", "Desk")
                        .WithMany("WorkspaceDesks")
                        .HasForeignKey("DeskID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.Workspace", "Workspace")
                        .WithMany("WorkspaceDesks")
                        .HasForeignKey("WorkspaceID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Desk");

                    b.Navigation("Workspace");
                });

            modelBuilder.Entity("DAL.Models.Desk", b =>
                {
                    b.Navigation("WorkspaceDesks");
                });

            modelBuilder.Entity("DAL.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Navigation("UserRoles");

                    b.Navigation("UserWorkspaces");
                });

            modelBuilder.Entity("DAL.Models.Workspace", b =>
                {
                    b.Navigation("UserWorkspaces");

                    b.Navigation("WorkspaceDesks");
                });
#pragma warning restore 612, 618
        }
    }
}
