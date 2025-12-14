using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class BagFixWithType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                ALTER TABLE records 
                ALTER COLUMN dt TYPE integer 
                USING CASE WHEN dt THEN 1 ELSE 0 END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                ALTER TABLE records 
                ALTER COLUMN dt TYPE boolean 
                USING (dt != 0)");
        }
    }
}
