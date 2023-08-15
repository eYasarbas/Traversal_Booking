using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
	/// <inheritdoc />
	public partial class mig1 : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Abouts",
				columns: table => new
				{
					AboutID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Image1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Title2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Status = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Abouts", x => x.AboutID);
				});

			migrationBuilder.CreateTable(
				name: "Abouts2",
				columns: table => new
				{
					About2ID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Title1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Title2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Abouts2", x => x.About2ID);
				});

			migrationBuilder.CreateTable(
				name: "Contacts",
				columns: table => new
				{
					ContactID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
					MapLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Status = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Contacts", x => x.ContactID);
				});

			migrationBuilder.CreateTable(
				name: "Destinations",
				columns: table => new
				{
					DestinationID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Ctiy = table.Column<string>(type: "nvarchar(max)", nullable: false),
					DayNight = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Price = table.Column<double>(type: "float", nullable: false),
					Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Status = table.Column<bool>(type: "bit", nullable: false),
					Capacity = table.Column<int>(type: "int", nullable: false),
					CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Details1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Details2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Image2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Destinations", x => x.DestinationID);
				});

			migrationBuilder.CreateTable(
				name: "Features",
				columns: table => new
				{
					FeatureID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Post1Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Post1Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Post1Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Post1Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Features", x => x.FeatureID);
				});

			migrationBuilder.CreateTable(
				name: "Features2",
				columns: table => new
				{
					Feature2ID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Status = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Features2", x => x.Feature2ID);
				});

			migrationBuilder.CreateTable(
				name: "Guides",
				columns: table => new
				{
					GuideID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
					TwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
					InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Status = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Guides", x => x.GuideID);
				});

			migrationBuilder.CreateTable(
				name: "NewsLetter",
				columns: table => new
				{
					NewsLetterID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Mail = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_NewsLetter", x => x.NewsLetterID);
				});

			migrationBuilder.CreateTable(
				name: "SubAbout",
				columns: table => new
				{
					SubAboutID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_SubAbout", x => x.SubAboutID);
				});

			migrationBuilder.CreateTable(
				name: "Tests",
				columns: table => new
				{
					TestimonalID = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Client = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
					ClientImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Status = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Tests", x => x.TestimonalID);
				});
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Abouts");

			migrationBuilder.DropTable(
				name: "Abouts2");

			migrationBuilder.DropTable(
				name: "Contacts");

			migrationBuilder.DropTable(
				name: "Destinations");

			migrationBuilder.DropTable(
				name: "Features");

			migrationBuilder.DropTable(
				name: "Features2");

			migrationBuilder.DropTable(
				name: "Guides");

			migrationBuilder.DropTable(
				name: "NewsLetter");

			migrationBuilder.DropTable(
				name: "SubAbout");

			migrationBuilder.DropTable(
				name: "Tests");
		}
	}
}
