using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
	/// <inheritdoc />
	public partial class mig_add_comment : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{


			migrationBuilder.CreateTable(
				name: "Comments",
				columns: table => new
				{
					CommentId = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					CommentUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
					CommentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
					CommentContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
					CommentState = table.Column<string>(type: "nvarchar(max)", nullable: false),
					DestinationID = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Comments", x => x.CommentId);
					table.ForeignKey(
						name: "FK_Comments_Destinations_DestinationID",
						column: x => x.DestinationID,
						principalTable: "Destinations",
						principalColumn: "DestinationID",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateIndex(
				name: "IX_Comments_DestinationID",
				table: "Comments",
				column: "DestinationID");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Comments");


		}
	}
}
