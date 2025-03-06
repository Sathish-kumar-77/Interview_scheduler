using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations.Migrations
{
    public partial class InitialCreate11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    RoleName = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "PanelCoordinators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    usersUserId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PanelCoordinators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PanelCoordinators_Users_usersUserId",
                        column: x => x.usersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReportingManagers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportingManagers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportingManagers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TAAdmins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAAdmins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TAAdmins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TARecruiters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TARecruiters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TARecruiters_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    SuperAdminUserId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Users_SuperAdminUserId",
                        column: x => x.SuperAdminUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "PanelMembers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Skill = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Experience = table.Column<int>(type: "INTEGER", nullable: false),
                    InterviewLevel = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    AllocatedStartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AllocatedEndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PanelCoordinatorId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PanelMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PanelMembers_PanelCoordinators_PanelCoordinatorId",
                        column: x => x.PanelCoordinatorId,
                        principalTable: "PanelCoordinators",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PanelMembers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ReportingManagerId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidates_ReportingManagers_ReportingManagerId",
                        column: x => x.ReportingManagerId,
                        principalTable: "ReportingManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Candidates_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AvailabilitySlots",
                columns: table => new
                {
                    SlotId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PanelMemberId = table.Column<int>(type: "INTEGER", nullable: false),
                    PanelMemberId1 = table.Column<Guid>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    IsBooked = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailabilitySlots", x => x.SlotId);
                    table.ForeignKey(
                        name: "FK_AvailabilitySlots_PanelMembers_PanelMemberId1",
                        column: x => x.PanelMemberId1,
                        principalTable: "PanelMembers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Interviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CandidateId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PanelMemberId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TARecruiterId = table.Column<Guid>(type: "TEXT", nullable: true),
                    SlotId = table.Column<Guid>(type: "TEXT", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    ManagerParticipation = table.Column<bool>(type: "INTEGER", nullable: false),
                    TAAdminId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interviews_AvailabilitySlots_SlotId",
                        column: x => x.SlotId,
                        principalTable: "AvailabilitySlots",
                        principalColumn: "SlotId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interviews_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interviews_PanelMembers_PanelMemberId",
                        column: x => x.PanelMemberId,
                        principalTable: "PanelMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interviews_TAAdmins_TAAdminId",
                        column: x => x.TAAdminId,
                        principalTable: "TAAdmins",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Interviews_TARecruiters_TARecruiterId",
                        column: x => x.TARecruiterId,
                        principalTable: "TARecruiters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailabilitySlots_PanelMemberId1",
                table: "AvailabilitySlots",
                column: "PanelMemberId1");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_ReportingManagerId",
                table: "Candidates",
                column: "ReportingManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_UserId",
                table: "Candidates",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_CandidateId",
                table: "Interviews",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_PanelMemberId",
                table: "Interviews",
                column: "PanelMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_SlotId",
                table: "Interviews",
                column: "SlotId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_TAAdminId",
                table: "Interviews",
                column: "TAAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_TARecruiterId",
                table: "Interviews",
                column: "TARecruiterId");

            migrationBuilder.CreateIndex(
                name: "IX_PanelCoordinators_usersUserId",
                table: "PanelCoordinators",
                column: "usersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PanelMembers_PanelCoordinatorId",
                table: "PanelMembers",
                column: "PanelCoordinatorId");

            migrationBuilder.CreateIndex(
                name: "IX_PanelMembers_UserId",
                table: "PanelMembers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportingManagers_UserId",
                table: "ReportingManagers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TAAdmins_UserId",
                table: "TAAdmins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TARecruiters_UserId",
                table: "TARecruiters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_SuperAdminUserId",
                table: "User",
                column: "SuperAdminUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interviews");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "AvailabilitySlots");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "TAAdmins");

            migrationBuilder.DropTable(
                name: "TARecruiters");

            migrationBuilder.DropTable(
                name: "PanelMembers");

            migrationBuilder.DropTable(
                name: "ReportingManagers");

            migrationBuilder.DropTable(
                name: "PanelCoordinators");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
