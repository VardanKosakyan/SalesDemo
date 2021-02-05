using Microsoft.EntityFrameworkCore.Migrations;

namespace TestSalesDB.Migrations
{
    public partial class PersonDiscriminatorScript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                  begin transaction
                  update Persons set Discriminator = 'Person'
                  commit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                  begin transaction
                  update Persons set Discriminator = NULL
                  commit");
        }
    }
}
