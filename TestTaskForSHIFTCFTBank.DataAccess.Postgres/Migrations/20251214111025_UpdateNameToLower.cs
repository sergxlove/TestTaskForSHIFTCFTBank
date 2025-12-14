using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNameToLower : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accounts_clients_Client_ref",
                table: "accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_accounts_products_Product_ref",
                table: "accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_products_clients_Client_ref",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_productype_Products_type_id",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_productype_tarifs_Tarif_ref",
                table: "productype");

            migrationBuilder.DropForeignKey(
                name: "FK_records_accounts_Acc_ref",
                table: "records");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tarifs",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "tarifs",
                newName: "cost");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tarifs",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Sum",
                table: "records",
                newName: "sum");

            migrationBuilder.RenameColumn(
                name: "Oper_date",
                table: "records",
                newName: "oper_date");

            migrationBuilder.RenameColumn(
                name: "Dt",
                table: "records",
                newName: "dt");

            migrationBuilder.RenameColumn(
                name: "Acc_ref",
                table: "records",
                newName: "acc_ref");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "records",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_records_Acc_ref",
                table: "records",
                newName: "IX_records_acc_ref");

            migrationBuilder.RenameColumn(
                name: "Tarif_ref",
                table: "productype",
                newName: "tarif_ref");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "productype",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "End_date",
                table: "productype",
                newName: "end_date");

            migrationBuilder.RenameColumn(
                name: "Begin_date",
                table: "productype",
                newName: "begin_date");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "productype",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_productype_Tarif_ref",
                table: "productype",
                newName: "IX_productype_tarif_ref");

            migrationBuilder.RenameColumn(
                name: "Open_date",
                table: "products",
                newName: "open_date");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "products",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Close_date",
                table: "products",
                newName: "close_date");

            migrationBuilder.RenameColumn(
                name: "Client_ref",
                table: "products",
                newName: "client_ref");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "products",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Products_type_id",
                table: "products",
                newName: "product_type_id");

            migrationBuilder.RenameIndex(
                name: "IX_products_Client_ref",
                table: "products",
                newName: "IX_products_client_ref");

            migrationBuilder.RenameIndex(
                name: "IX_products_Products_type_id",
                table: "products",
                newName: "IX_products_product_type_id");

            migrationBuilder.RenameColumn(
                name: "Place_of_birth",
                table: "clients",
                newName: "place_of_birth");

            migrationBuilder.RenameColumn(
                name: "Passport",
                table: "clients",
                newName: "passport");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "clients",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Date_of_birth",
                table: "clients",
                newName: "date_of_birth");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "clients",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "clients",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Saldo",
                table: "accounts",
                newName: "saldo");

            migrationBuilder.RenameColumn(
                name: "Product_ref",
                table: "accounts",
                newName: "product_ref");

            migrationBuilder.RenameColumn(
                name: "Open_date",
                table: "accounts",
                newName: "open_date");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "accounts",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Close_date",
                table: "accounts",
                newName: "close_date");

            migrationBuilder.RenameColumn(
                name: "Client_ref",
                table: "accounts",
                newName: "client_ref");

            migrationBuilder.RenameColumn(
                name: "Acc_num",
                table: "accounts",
                newName: "acc_num");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "accounts",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_accounts_Product_ref",
                table: "accounts",
                newName: "IX_accounts_product_ref");

            migrationBuilder.RenameIndex(
                name: "IX_accounts_Client_ref",
                table: "accounts",
                newName: "IX_accounts_client_ref");

            migrationBuilder.AddForeignKey(
                name: "FK_accounts_clients_client_ref",
                table: "accounts",
                column: "client_ref",
                principalTable: "clients",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_accounts_products_product_ref",
                table: "accounts",
                column: "product_ref",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_clients_client_ref",
                table: "products",
                column: "client_ref",
                principalTable: "clients",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_productype_product_type_id",
                table: "products",
                column: "product_type_id",
                principalTable: "productype",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productype_tarifs_tarif_ref",
                table: "productype",
                column: "tarif_ref",
                principalTable: "tarifs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_records_accounts_acc_ref",
                table: "records",
                column: "acc_ref",
                principalTable: "accounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accounts_clients_client_ref",
                table: "accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_accounts_products_product_ref",
                table: "accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_products_clients_client_ref",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_productype_product_type_id",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_productype_tarifs_tarif_ref",
                table: "productype");

            migrationBuilder.DropForeignKey(
                name: "FK_records_accounts_acc_ref",
                table: "records");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "tarifs",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "cost",
                table: "tarifs",
                newName: "Cost");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "tarifs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "sum",
                table: "records",
                newName: "Sum");

            migrationBuilder.RenameColumn(
                name: "oper_date",
                table: "records",
                newName: "Oper_date");

            migrationBuilder.RenameColumn(
                name: "dt",
                table: "records",
                newName: "Dt");

            migrationBuilder.RenameColumn(
                name: "acc_ref",
                table: "records",
                newName: "Acc_ref");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "records",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_records_acc_ref",
                table: "records",
                newName: "IX_records_Acc_ref");

            migrationBuilder.RenameColumn(
                name: "tarif_ref",
                table: "productype",
                newName: "Tarif_ref");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "productype",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "end_date",
                table: "productype",
                newName: "End_date");

            migrationBuilder.RenameColumn(
                name: "begin_date",
                table: "productype",
                newName: "Begin_date");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "productype",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_productype_tarif_ref",
                table: "productype",
                newName: "IX_productype_Tarif_ref");

            migrationBuilder.RenameColumn(
                name: "open_date",
                table: "products",
                newName: "Open_date");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "close_date",
                table: "products",
                newName: "Close_date");

            migrationBuilder.RenameColumn(
                name: "client_ref",
                table: "products",
                newName: "Client_ref");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "product_type_id",
                table: "products",
                newName: "Products_type_id");

            migrationBuilder.RenameIndex(
                name: "IX_products_client_ref",
                table: "products",
                newName: "IX_products_Client_ref");

            migrationBuilder.RenameIndex(
                name: "IX_products_product_type_id",
                table: "products",
                newName: "IX_products_Products_type_id");

            migrationBuilder.RenameColumn(
                name: "place_of_birth",
                table: "clients",
                newName: "Place_of_birth");

            migrationBuilder.RenameColumn(
                name: "passport",
                table: "clients",
                newName: "Passport");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "clients",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "date_of_birth",
                table: "clients",
                newName: "Date_of_birth");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "clients",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "clients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "saldo",
                table: "accounts",
                newName: "Saldo");

            migrationBuilder.RenameColumn(
                name: "product_ref",
                table: "accounts",
                newName: "Product_ref");

            migrationBuilder.RenameColumn(
                name: "open_date",
                table: "accounts",
                newName: "Open_date");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "accounts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "close_date",
                table: "accounts",
                newName: "Close_date");

            migrationBuilder.RenameColumn(
                name: "client_ref",
                table: "accounts",
                newName: "Client_ref");

            migrationBuilder.RenameColumn(
                name: "acc_num",
                table: "accounts",
                newName: "Acc_num");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "accounts",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_accounts_product_ref",
                table: "accounts",
                newName: "IX_accounts_Product_ref");

            migrationBuilder.RenameIndex(
                name: "IX_accounts_client_ref",
                table: "accounts",
                newName: "IX_accounts_Client_ref");

            migrationBuilder.AddForeignKey(
                name: "FK_accounts_clients_Client_ref",
                table: "accounts",
                column: "Client_ref",
                principalTable: "clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_accounts_products_Product_ref",
                table: "accounts",
                column: "Product_ref",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_clients_Client_ref",
                table: "products",
                column: "Client_ref",
                principalTable: "clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_productype_Products_type_id",
                table: "products",
                column: "Products_type_id",
                principalTable: "productype",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productype_tarifs_Tarif_ref",
                table: "productype",
                column: "Tarif_ref",
                principalTable: "tarifs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_records_accounts_Acc_ref",
                table: "records",
                column: "Acc_ref",
                principalTable: "accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
