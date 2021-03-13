using Microsoft.EntityFrameworkCore.Migrations;

namespace UrnaWeb.Migrations
{
    public partial class adjustedCadidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vote_Candidate_IdCanditadeId",
                table: "Vote");

            migrationBuilder.RenameColumn(
                name: "IdCanditadeId",
                table: "Vote",
                newName: "CandidateIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Vote_IdCanditadeId",
                table: "Vote",
                newName: "IX_Vote_CandidateIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vote_Candidate_CandidateIdId",
                table: "Vote",
                column: "CandidateIdId",
                principalTable: "Candidate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vote_Candidate_CandidateIdId",
                table: "Vote");

            migrationBuilder.RenameColumn(
                name: "CandidateIdId",
                table: "Vote",
                newName: "IdCanditadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Vote_CandidateIdId",
                table: "Vote",
                newName: "IX_Vote_IdCanditadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vote_Candidate_IdCanditadeId",
                table: "Vote",
                column: "IdCanditadeId",
                principalTable: "Candidate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
