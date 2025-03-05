using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Weapon",
                table: "App",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Moniker",
                table: "App",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Clan",
                table: "App",
                newName: "Developer");

            migrationBuilder.RenameColumn(
                name: "Bio",
                table: "App",
                newName: "Description");

            migrationBuilder.AddColumn<Guid>(
                name: "SuperAdminUserId",
                table: "User",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RoleName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    RoleId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    ReportingManagerId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Skill = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Experience = table.Column<int>(type: "INTEGER", nullable: true),
                    InterviewLevel = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    AllocatedStartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    AllocatedEndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    PanelCoordinatorUserId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Users_PanelCoordinatorUserId",
                        column: x => x.PanelCoordinatorUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Users_Users_ReportingManagerId",
                        column: x => x.ReportingManagerId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AvailabilitySlots",
                columns: table => new
                {
                    SlotId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PanelMemberId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    IsBooked = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailabilitySlots", x => x.SlotId);
                    table.ForeignKey(
                        name: "FK_AvailabilitySlots_Users_PanelMemberId",
                        column: x => x.PanelMemberId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interviews",
                columns: table => new
                {
                    InterviewId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CandidateId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PanelMemberId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TARecruiterId = table.Column<Guid>(type: "TEXT", nullable: true),
                    SlotId = table.Column<Guid>(type: "TEXT", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    ManagerParticipation = table.Column<bool>(type: "INTEGER", nullable: false),
                    TAAdminUserId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviews", x => x.InterviewId);
                    table.ForeignKey(
                        name: "FK_Interviews_AvailabilitySlots_SlotId",
                        column: x => x.SlotId,
                        principalTable: "AvailabilitySlots",
                        principalColumn: "SlotId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interviews_Users_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interviews_Users_PanelMemberId",
                        column: x => x.PanelMemberId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interviews_Users_TAAdminUserId",
                        column: x => x.TAAdminUserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_Interviews_Users_TARecruiterId",
                        column: x => x.TARecruiterId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_SuperAdminUserId",
                table: "User",
                column: "SuperAdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailabilitySlots_PanelMemberId",
                table: "AvailabilitySlots",
                column: "PanelMemberId");

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
                name: "IX_Interviews_TAAdminUserId",
                table: "Interviews",
                column: "TAAdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_TARecruiterId",
                table: "Interviews",
                column: "TARecruiterId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PanelCoordinatorUserId",
                table: "Users",
                column: "PanelCoordinatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ReportingManagerId",
                table: "Users",
                column: "ReportingManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Users_SuperAdminUserId",
                table: "User",
                column: "SuperAdminUserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Users_SuperAdminUserId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Interviews");

            migrationBuilder.DropTable(
                name: "AvailabilitySlots");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropIndex(
                name: "IX_User_SuperAdminUserId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "SuperAdminUserId",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "App",
                newName: "Weapon");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "App",
                newName: "Moniker");

            migrationBuilder.RenameColumn(
                name: "Developer",
                table: "App",
                newName: "Clan");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "App",
                newName: "Bio");
        }
    }
}
