﻿// <auto-generated />
using System;
using Assignment.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment.Migrations.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.Interview", b =>
                {
                    b.Property<Guid>("InterviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CandidateId")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ManagerParticipation")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("PanelMemberId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SlotId")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("TAAdminUserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("TARecruiterId")
                        .HasColumnType("TEXT");

                    b.HasKey("InterviewId");

                    b.HasIndex("CandidateId");

                    b.HasIndex("PanelMemberId");

                    b.HasIndex("SlotId");

                    b.HasIndex("TAAdminUserId");

                    b.HasIndex("TARecruiterId");

                    b.ToTable("Interviews");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.Slot", b =>
                {
                    b.Property<Guid>("SlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsBooked")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("PanelMemberId")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("SlotId");

                    b.HasIndex("PanelMemberId");

                    b.ToTable("AvailabilitySlots");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("SuperAdminUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SuperAdminUserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.Users", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Users");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.Candidate", b =>
                {
                    b.HasBaseType("Assignment.Contracts.Data.Entities.Users");

                    b.Property<Guid>("ReportingManagerId")
                        .HasColumnType("TEXT");

                    b.HasIndex("ReportingManagerId");

                    b.HasDiscriminator().HasValue("Candidate");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.PanelCoordinator", b =>
                {
                    b.HasBaseType("Assignment.Contracts.Data.Entities.Users");

                    b.HasDiscriminator().HasValue("PanelCoordinator");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.PanelMember", b =>
                {
                    b.HasBaseType("Assignment.Contracts.Data.Entities.Users");

                    b.Property<DateTime>("AllocatedEndDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AllocatedStartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Experience")
                        .HasColumnType("INTEGER");

                    b.Property<string>("InterviewLevel")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PanelCoordinatorUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Skill")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasIndex("PanelCoordinatorUserId");

                    b.HasDiscriminator().HasValue("PanelMember");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.ReportingManager", b =>
                {
                    b.HasBaseType("Assignment.Contracts.Data.Entities.Users");

                    b.HasDiscriminator().HasValue("ReportingManager");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.SuperAdmin", b =>
                {
                    b.HasBaseType("Assignment.Contracts.Data.Entities.Users");

                    b.HasDiscriminator().HasValue("SuperAdmin");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.TAAdmin", b =>
                {
                    b.HasBaseType("Assignment.Contracts.Data.Entities.Users");

                    b.HasDiscriminator().HasValue("TAAdmin");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.TARecruiter", b =>
                {
                    b.HasBaseType("Assignment.Contracts.Data.Entities.Users");

                    b.HasDiscriminator().HasValue("TARecruiter");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.Interview", b =>
                {
                    b.HasOne("Assignment.Contracts.Data.Entities.Candidate", "Candidate")
                        .WithMany("Interviews")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment.Contracts.Data.Entities.PanelMember", "PanelMember")
                        .WithMany()
                        .HasForeignKey("PanelMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment.Contracts.Data.Entities.Slot", "Slot")
                        .WithMany()
                        .HasForeignKey("SlotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment.Contracts.Data.Entities.TAAdmin", null)
                        .WithMany("ManagedInterviews")
                        .HasForeignKey("TAAdminUserId");

                    b.HasOne("Assignment.Contracts.Data.Entities.TARecruiter", "TARecruiter")
                        .WithMany("ScheduledInterviews")
                        .HasForeignKey("TARecruiterId");

                    b.Navigation("Candidate");

                    b.Navigation("PanelMember");

                    b.Navigation("Slot");

                    b.Navigation("TARecruiter");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.Slot", b =>
                {
                    b.HasOne("Assignment.Contracts.Data.Entities.PanelMember", "PanelMember")
                        .WithMany("Slots")
                        .HasForeignKey("PanelMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PanelMember");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.User", b =>
                {
                    b.HasOne("Assignment.Contracts.Data.Entities.SuperAdmin", null)
                        .WithMany("ManagedUsers")
                        .HasForeignKey("SuperAdminUserId");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.Users", b =>
                {
                    b.HasOne("Assignment.Contracts.Data.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.Candidate", b =>
                {
                    b.HasOne("Assignment.Contracts.Data.Entities.ReportingManager", "ReportingManager")
                        .WithMany("Candidates")
                        .HasForeignKey("ReportingManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReportingManager");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.PanelMember", b =>
                {
                    b.HasOne("Assignment.Contracts.Data.Entities.PanelCoordinator", null)
                        .WithMany("PanelMembers")
                        .HasForeignKey("PanelCoordinatorUserId");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.Candidate", b =>
                {
                    b.Navigation("Interviews");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.PanelCoordinator", b =>
                {
                    b.Navigation("PanelMembers");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.PanelMember", b =>
                {
                    b.Navigation("Slots");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.ReportingManager", b =>
                {
                    b.Navigation("Candidates");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.SuperAdmin", b =>
                {
                    b.Navigation("ManagedUsers");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.TAAdmin", b =>
                {
                    b.Navigation("ManagedInterviews");
                });

            modelBuilder.Entity("Assignment.Contracts.Data.Entities.TARecruiter", b =>
                {
                    b.Navigation("ScheduledInterviews");
                });
#pragma warning restore 612, 618
        }
    }
}
