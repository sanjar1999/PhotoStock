using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class FillWithTestData : Migration
    {
        protected override void Up( MigrationBuilder migrationBuilder )
        {
            migrationBuilder.Sql( @"
INSERT INTO Authors(Name, LastName, NickName, DateOfBirth, DateOfRegistration) VALUES
('Sanjar', 'Shavkatkhujaev', 'Sam', '1999-07-05', '2022-08-11'),
('Umar', 'Anorboyev', 'Umaars', '1998-12-05', '2022-08-10'),
('Otabek', 'Nosirov', 'Otash', '1999-10-28', '2022-07-11'),
('Akbar', 'Anvarov', 'Akosh', '1999-09-20', '2022-03-11'),
('Azamat', 'Supiev', 'Azam', '2000-05-26', '2022-11-11');

INSERT INTO Photos(Name, NumberOfSales, Cost, DateOfCreation, Link, OriginalSize, AuthorId) VALUES
('De Sanjar', 123, 3412, '2022-08-11', 'qweq', 431, 1),
('De Umar', 11, 3442, '2022-08-11', 'qwe3q', 443, 2),
('De Otabek', 1223, 2342, '2022-08-11', 'qw3eq', 463, 3),
('De Akbar', 2123, 424, '2022-08-11', 'qweqw', 843, 4),
('De Azamat', 12423, 3642, '2022-08-11', 'qw1eq', 413, 5),
('De Azizjon', 12423, 3642, '2022-09-11', 'qw9eq', 473, 5);;

INSERT INTO Texts(Name, NumberOfSales, Cost, DateOfCreation, TextOfText, AuthorId) VALUES
('La Sanjar', 123, 3412, '2022-08-11', 'qweq', 1),
('La Umar', 11, 3442, '2022-08-11', 'qwe3q', 2),
('La Otabek', 1223, 2342, '2022-08-11', 'qw3eq', 3),
('La Akbar', 2123, 424, '2022-08-11', 'qweqw', 4),
('La Azamat', 12423, 3642, '2022-08-11', 'qw1eq', 5);" );
        }

        protected override void Down( MigrationBuilder migrationBuilder )
        {

        }
    }
}
