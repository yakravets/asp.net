using Microsoft.EntityFrameworkCore.Migrations;

namespace Rooms.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinCountGamers = table.Column<int>(type: "int", nullable: false),
                    MinAge = table.Column<int>(type: "int", nullable: false),
                    LevelOfDifficulty = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    LevelOfFear = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Rating = table.Column<double>(type: "float", maxLength: 5, nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Address", "Company", "Description", "Duration", "LevelOfDifficulty", "LevelOfFear", "MinAge", "MinCountGamers", "Name", "PhoneNumber", "PictureUrl", "Rating" },
                values: new object[,]
                {
                    { 1, "New York", "Intercity", "Think you’ve got what it takes to be the world’s greatest thief?", "60m", 3, 1, 12, 1, "DIAMOND HEIST", "0123456789", "https://m.economictimes.com/thumb/msid-60217597,width-1200,height-900,resizemode-4,imgsize-73839/the-untold-story-of-a-100mn-diamond-heist-and-how-it-happened.jpg", 1.0 },
                    { 2, "St. Lois", "King", "Can you save the kingdom from eternal darkness?", "60m", 5, 1, 10, 5, "CURSED CASTLE", "213456789", "https://images-na.ssl-images-amazon.com/images/I/91hTjrrFYIL.jpg", 5.0 },
                    { 3, "New York", "King", "Will you survive the trials of a Secret Society’s initiation?", "120m", 4, 3, 16, 5, "SECRET SOCIETY", "123456789", "https://upload.wikimedia.org/wikipedia/commons/2/24/Secret_Society_Buildings_New_Haven.jpg", 3.0 },
                    { 4, "St. Lois", "King", "Can you save the Mona Lisa from burglars?", "80m", 2, 1, 10, 2, "DAVINCI’S WORKSHOP", "123456789", "https://i.pinimg.com/originals/32/35/b0/3235b03626e8bf3baf3accd7399df06c.jpg", 5.0 },
                    { 5, "Chicago", "King", "Ready to defend your home from the Wet Bandits?", "60m", 5, 4, 10, 4, "HOME ALONE", "987654310", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWCBy0UhjPAQW8vS-Iif6T6g371tYQktlEPQ&usqp=CAU", 5.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
