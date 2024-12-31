using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _37EntityFramework.Migrations
{
    public partial class AddEmployeeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                                CREATE PROCEDURE getEmpById
                                @Id INT
                                AS
                                BEGIN
                                SELECT * FROM EMPLOYEES
                                WHERE EId = @Id
                                END
                                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
