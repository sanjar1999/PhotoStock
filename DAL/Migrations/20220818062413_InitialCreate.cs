using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up( MigrationBuilder migrationBuilder )
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>( type: "int", nullable: false )
                        .Annotation( "SqlServer:Identity", "1, 1" ),
                    Name = table.Column<string>( type: "nvarchar(max)", nullable: false ),
                    LastName = table.Column<string>( type: "nvarchar(max)", nullable: false ),
                    NickName = table.Column<string>( type: "nvarchar(max)", nullable: false ),
                    DateOfBirth = table.Column<DateTime>( type: "datetime2", nullable: false ),
                    DateOfRegistration = table.Column<DateTime>( type: "datetime2", nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_Authors", x => x.Id );
                } );

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>( type: "int", nullable: false )
                        .Annotation( "SqlServer:Identity", "1, 1" ),
                    Name = table.Column<string>( type: "nvarchar(max)", nullable: false ),
                    Link = table.Column<string>( type: "nvarchar(max)", nullable: false ),
                    OriginalSize = table.Column<int>( type: "int", nullable: false ),
                    DateOfCreation = table.Column<DateTime>( type: "datetime2", nullable: false ),
                    AuthorId = table.Column<int>( type: "int", nullable: false ),
                    Cost = table.Column<int>( type: "int", nullable: false ),
                    NumberOfSales = table.Column<int>( type: "int", nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_Photos", x => x.Id );
                    table.ForeignKey(
                        name: "FK_Photos_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateTable(
                name: "Texts",
                columns: table => new
                {
                    Id = table.Column<int>( type: "int", nullable: false )
                        .Annotation( "SqlServer:Identity", "1, 1" ),
                    Name = table.Column<string>( type: "nvarchar(max)", nullable: false ),
                    TextOfText = table.Column<string>( type: "nvarchar(max)", nullable: false ),
                    DateOfCreation = table.Column<DateTime>( type: "datetime2", nullable: false ),
                    Cost = table.Column<int>( type: "int", nullable: false ),
                    AuthorId = table.Column<int>( type: "int", nullable: false ),
                    NumberOfSales = table.Column<int>( type: "int", nullable: false )
                },
                constraints: table =>
                {
                    table.PrimaryKey( "PK_Texts", x => x.Id );
                    table.ForeignKey(
                        name: "FK_Texts_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade );
                } );

            migrationBuilder.CreateIndex(
                name: "IX_Photos_AuthorId",
                table: "Photos",
                column: "AuthorId" );

            migrationBuilder.CreateIndex(
                name: "IX_Texts_AuthorId",
                table: "Texts",
                column: "AuthorId" );
        }

        protected override void Down( MigrationBuilder migrationBuilder )
        {
            migrationBuilder.DropTable(
                name: "Photos" );

            migrationBuilder.DropTable(
                name: "Texts" );

            migrationBuilder.DropTable(
                name: "Authors" );
        }
    }
}
