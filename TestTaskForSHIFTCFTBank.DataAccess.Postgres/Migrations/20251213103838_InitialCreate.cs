using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NAME = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    PLACE_OF_BIRTH = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    DATE_OF_BIRTH = table.Column<DateOnly>(type: "date", nullable: false),
                    ADDRESS = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    PASSSPORT = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tarifs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NAME = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    COST = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tarifs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "productype",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NAME = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    BEGIN_DATE = table.Column<DateOnly>(type: "date", nullable: false),
                    END_DATE = table.Column<DateOnly>(type: "date", nullable: false),
                    TARIF_REF = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productype", x => x.ID);
                    table.ForeignKey(
                        name: "FK_productype_tarifs_TARIF_REF",
                        column: x => x.TARIF_REF,
                        principalTable: "tarifs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PRODUCTS_TYPE_ID = table.Column<int>(type: "integer", nullable: false),
                    NAME = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CLIENT_REF = table.Column<int>(type: "integer", nullable: false),
                    OPEN_DATE = table.Column<DateOnly>(type: "date", nullable: false),
                    CLOSE_DATE = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_products_clients_CLIENT_REF",
                        column: x => x.CLIENT_REF,
                        principalTable: "clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_productype_PRODUCTS_TYPE_ID",
                        column: x => x.PRODUCTS_TYPE_ID,
                        principalTable: "productype",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NAME = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    SALDO = table.Column<decimal>(type: "numeric", nullable: false),
                    CLIENT_REF = table.Column<int>(type: "integer", nullable: false),
                    OPEN_DATE = table.Column<DateOnly>(type: "date", nullable: false),
                    CLOSE_DATE = table.Column<DateOnly>(type: "date", nullable: false),
                    PRODUCT_REF = table.Column<int>(type: "integer", nullable: false),
                    ACC_NUM = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_accounts_clients_CLIENT_REF",
                        column: x => x.CLIENT_REF,
                        principalTable: "clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_accounts_products_PRODUCT_REF",
                        column: x => x.PRODUCT_REF,
                        principalTable: "products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "records",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DT = table.Column<bool>(type: "boolean", nullable: false),
                    SUM = table.Column<decimal>(type: "numeric", nullable: false),
                    ACC_REF = table.Column<int>(type: "integer", nullable: false),
                    OPER_DATE = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_records", x => x.ID);
                    table.ForeignKey(
                        name: "FK_records_accounts_ACC_REF",
                        column: x => x.ACC_REF,
                        principalTable: "accounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_accounts_CLIENT_REF",
                table: "accounts",
                column: "CLIENT_REF");

            migrationBuilder.CreateIndex(
                name: "IX_accounts_PRODUCT_REF",
                table: "accounts",
                column: "PRODUCT_REF");

            migrationBuilder.CreateIndex(
                name: "IX_products_CLIENT_REF",
                table: "products",
                column: "CLIENT_REF");

            migrationBuilder.CreateIndex(
                name: "IX_products_PRODUCTS_TYPE_ID",
                table: "products",
                column: "PRODUCTS_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_productype_TARIF_REF",
                table: "productype",
                column: "TARIF_REF");

            migrationBuilder.CreateIndex(
                name: "IX_records_ACC_REF",
                table: "records",
                column: "ACC_REF");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "records");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "productype");

            migrationBuilder.DropTable(
                name: "tarifs");
        }
    }
}
