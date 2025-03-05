using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations.Migrations
{
    public partial class InitialCreate11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailabilitySlots_Users_PanelMemberId",
                table: "AvailabilitySlots");

            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_Users_CandidateId",
                table: "Interviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_Users_PanelMemberId",
                table: "Interviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_Users_TAAdminUserId",
                table: "Interviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_Users_TARecruiterId",
                table: "Interviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_PanelCoordinatorUserId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_ReportingManagerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PanelCoordinatorUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ReportingManagerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_AvailabilitySlots_PanelMemberId",
                table: "AvailabilitySlots");

            migrationBuilder.DropColumn(
                name: "AllocatedEndDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AllocatedStartDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "InterviewLevel",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PanelCoordinatorUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ReportingManagerId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Skill",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AddedOn",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "TAAdminUserId",
                table: "Interviews",
                newName: "TAAdminId");

            migrationBuilder.RenameColumn(
                name: "InterviewId",
                table: "Interviews",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Interviews_TAAdminUserId",
                table: "Interviews",
                newName: "IX_Interviews_TAAdminId");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                type: "TEXT",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "PanelMemberId",
                table: "AvailabilitySlots",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddColumn<Guid>(
                name: "PanelMemberId1",
                table: "AvailabilitySlots",
                type: "TEXT",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_AvailabilitySlots_PanelMembers_PanelMemberId1",
                table: "AvailabilitySlots",
                column: "PanelMemberId1",
                principalTable: "PanelMembers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_Candidates_CandidateId",
                table: "Interviews",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_PanelMembers_PanelMemberId",
                table: "Interviews",
                column: "PanelMemberId",
                principalTable: "PanelMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_TAAdmins_TAAdminId",
                table: "Interviews",
                column: "TAAdminId",
                principalTable: "TAAdmins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_TARecruiters_TARecruiterId",
                table: "Interviews",
                column: "TARecruiterId",
                principalTable: "TARecruiters",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvailabilitySlots_PanelMembers_PanelMemberId1",
                table: "AvailabilitySlots");

            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_Candidates_CandidateId",
                table: "Interviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_PanelMembers_PanelMemberId",
                table: "Interviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_TAAdmins_TAAdminId",
                table: "Interviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_TARecruiters_TARecruiterId",
                table: "Interviews");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "PanelMembers");

            migrationBuilder.DropTable(
                name: "TAAdmins");

            migrationBuilder.DropTable(
                name: "TARecruiters");

            migrationBuilder.DropTable(
                name: "ReportingManagers");

            migrationBuilder.DropTable(
                name: "PanelCoordinators");

            migrationBuilder.DropIndex(
                name: "IX_AvailabilitySlots_PanelMemberId1",
                table: "AvailabilitySlots");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PanelMemberId1",
                table: "AvailabilitySlots");

            migrationBuilder.RenameColumn(
                name: "TAAdminId",
                table: "Interviews",
                newName: "TAAdminUserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Interviews",
                newName: "InterviewId");

            migrationBuilder.RenameIndex(
                name: "IX_Interviews_TAAdminId",
                table: "Interviews",
                newName: "IX_Interviews_TAAdminUserId");

            migrationBuilder.AddColumn<DateTime>(
                name: "AllocatedEndDate",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AllocatedStartDate",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Experience",
                table: "Users",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InterviewLevel",
                table: "Users",
                type: "TEXT",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PanelCoordinatorUserId",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ReportingManagerId",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Skill",
                table: "Users",
                type: "TEXT",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedOn",
                table: "User",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<Guid>(
                name: "PanelMemberId",
                table: "AvailabilitySlots",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PanelCoordinatorUserId",
                table: "Users",
                column: "PanelCoordinatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ReportingManagerId",
                table: "Users",
                column: "ReportingManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailabilitySlots_PanelMemberId",
                table: "AvailabilitySlots",
                column: "PanelMemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_AvailabilitySlots_Users_PanelMemberId",
                table: "AvailabilitySlots",
                column: "PanelMemberId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_Users_CandidateId",
                table: "Interviews",
                column: "CandidateId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_Users_PanelMemberId",
                table: "Interviews",
                column: "PanelMemberId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_Users_TAAdminUserId",
                table: "Interviews",
                column: "TAAdminUserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_Users_TARecruiterId",
                table: "Interviews",
                column: "TARecruiterId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_PanelCoordinatorUserId",
                table: "Users",
                column: "PanelCoordinatorUserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_ReportingManagerId",
                table: "Users",
                column: "ReportingManagerId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
