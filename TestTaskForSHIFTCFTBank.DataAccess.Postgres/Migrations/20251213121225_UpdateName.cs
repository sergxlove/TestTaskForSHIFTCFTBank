using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTaskForSHIFTCFTBank.DataAccess.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class UpdateName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accounts_clients_CLIENT_REF",
                table: "accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_accounts_products_PRODUCT_REF",
                table: "accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_products_clients_CLIENT_REF",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_productype_PRODUCTS_TYPE_ID",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_productype_tarifs_TARIF_REF",
                table: "productype");

            migrationBuilder.DropForeignKey(
                name: "FK_records_accounts_ACC_REF",
                table: "records");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "tarifs",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "COST",
                table: "tarifs",
                newName: "Cost");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "tarifs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SUM",
                table: "records",
                newName: "Sum");

            migrationBuilder.RenameColumn(
                name: "OPER_DATE",
                table: "records",
                newName: "Oper_date");

            migrationBuilder.RenameColumn(
                name: "DT",
                table: "records",
                newName: "Dt");

            migrationBuilder.RenameColumn(
                name: "ACC_REF",
                table: "records",
                newName: "Acc_ref");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "records",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_records_ACC_REF",
                table: "records",
                newName: "IX_records_Acc_ref");

            migrationBuilder.RenameColumn(
                name: "TARIF_REF",
                table: "productype",
                newName: "Tarif_ref");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "productype",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "END_DATE",
                table: "productype",
                newName: "End_date");

            migrationBuilder.RenameColumn(
                name: "BEGIN_DATE",
                table: "productype",
                newName: "Begin_date");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "productype",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_productype_TARIF_REF",
                table: "productype",
                newName: "IX_productype_Tarif_ref");

            migrationBuilder.RenameColumn(
                name: "PRODUCTS_TYPE_ID",
                table: "products",
                newName: "Products_type_id");

            migrationBuilder.RenameColumn(
                name: "OPEN_DATE",
                table: "products",
                newName: "Open_date");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CLOSE_DATE",
                table: "products",
                newName: "Close_date");

            migrationBuilder.RenameColumn(
                name: "CLIENT_REF",
                table: "products",
                newName: "Client_ref");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "products",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_products_PRODUCTS_TYPE_ID",
                table: "products",
                newName: "IX_products_Products_type_id");

            migrationBuilder.RenameIndex(
                name: "IX_products_CLIENT_REF",
                table: "products",
                newName: "IX_products_Client_ref");

            migrationBuilder.RenameColumn(
                name: "PLACE_OF_BIRTH",
                table: "clients",
                newName: "Place_of_birth");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "clients",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DATE_OF_BIRTH",
                table: "clients",
                newName: "Date_of_birth");

            migrationBuilder.RenameColumn(
                name: "ADDRESS",
                table: "clients",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "clients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PASSSPORT",
                table: "clients",
                newName: "Passport");

            migrationBuilder.RenameColumn(
                name: "SALDO",
                table: "accounts",
                newName: "Saldo");

            migrationBuilder.RenameColumn(
                name: "PRODUCT_REF",
                table: "accounts",
                newName: "Product_ref");

            migrationBuilder.RenameColumn(
                name: "OPEN_DATE",
                table: "accounts",
                newName: "Open_date");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "accounts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CLOSE_DATE",
                table: "accounts",
                newName: "Close_date");

            migrationBuilder.RenameColumn(
                name: "CLIENT_REF",
                table: "accounts",
                newName: "Client_ref");

            migrationBuilder.RenameColumn(
                name: "ACC_NUM",
                table: "accounts",
                newName: "Acc_num");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "accounts",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_accounts_PRODUCT_REF",
                table: "accounts",
                newName: "IX_accounts_Product_ref");

            migrationBuilder.RenameIndex(
                name: "IX_accounts_CLIENT_REF",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "tarifs",
                newName: "COST");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tarifs",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Sum",
                table: "records",
                newName: "SUM");

            migrationBuilder.RenameColumn(
                name: "Oper_date",
                table: "records",
                newName: "OPER_DATE");

            migrationBuilder.RenameColumn(
                name: "Dt",
                table: "records",
                newName: "DT");

            migrationBuilder.RenameColumn(
                name: "Acc_ref",
                table: "records",
                newName: "ACC_REF");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "records",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_records_Acc_ref",
                table: "records",
                newName: "IX_records_ACC_REF");

            migrationBuilder.RenameColumn(
                name: "Tarif_ref",
                table: "productype",
                newName: "TARIF_REF");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "productype",
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "End_date",
                table: "productype",
                newName: "END_DATE");

            migrationBuilder.RenameColumn(
                name: "Begin_date",
                table: "productype",
                newName: "BEGIN_DATE");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "productype",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_productype_Tarif_ref",
                table: "productype",
                newName: "IX_productype_TARIF_REF");

            migrationBuilder.RenameColumn(
                name: "Products_type_id",
                table: "products",
                newName: "PRODUCTS_TYPE_ID");

            migrationBuilder.RenameColumn(
                name: "Open_date",
                table: "products",
                newName: "OPEN_DATE");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "products",
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "Close_date",
                table: "products",
                newName: "CLOSE_DATE");

            migrationBuilder.RenameColumn(
                name: "Client_ref",
                table: "products",
                newName: "CLIENT_REF");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "products",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_products_Products_type_id",
                table: "products",
                newName: "IX_products_PRODUCTS_TYPE_ID");

            migrationBuilder.RenameIndex(
                name: "IX_products_Client_ref",
                table: "products",
                newName: "IX_products_CLIENT_REF");

            migrationBuilder.RenameColumn(
                name: "Place_of_birth",
                table: "clients",
                newName: "PLACE_OF_BIRTH");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "clients",
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "Date_of_birth",
                table: "clients",
                newName: "DATE_OF_BIRTH");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "clients",
                newName: "ADDRESS");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "clients",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Passport",
                table: "clients",
                newName: "PASSSPORT");

            migrationBuilder.RenameColumn(
                name: "Saldo",
                table: "accounts",
                newName: "SALDO");

            migrationBuilder.RenameColumn(
                name: "Product_ref",
                table: "accounts",
                newName: "PRODUCT_REF");

            migrationBuilder.RenameColumn(
                name: "Open_date",
                table: "accounts",
                newName: "OPEN_DATE");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "accounts",
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "Close_date",
                table: "accounts",
                newName: "CLOSE_DATE");

            migrationBuilder.RenameColumn(
                name: "Client_ref",
                table: "accounts",
                newName: "CLIENT_REF");

            migrationBuilder.RenameColumn(
                name: "Acc_num",
                table: "accounts",
                newName: "ACC_NUM");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "accounts",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_accounts_Product_ref",
                table: "accounts",
                newName: "IX_accounts_PRODUCT_REF");

            migrationBuilder.RenameIndex(
                name: "IX_accounts_Client_ref",
                table: "accounts",
                newName: "IX_accounts_CLIENT_REF");

            migrationBuilder.AddForeignKey(
                name: "FK_accounts_clients_CLIENT_REF",
                table: "accounts",
                column: "CLIENT_REF",
                principalTable: "clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_accounts_products_PRODUCT_REF",
                table: "accounts",
                column: "PRODUCT_REF",
                principalTable: "products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_clients_CLIENT_REF",
                table: "products",
                column: "CLIENT_REF",
                principalTable: "clients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_productype_PRODUCTS_TYPE_ID",
                table: "products",
                column: "PRODUCTS_TYPE_ID",
                principalTable: "productype",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productype_tarifs_TARIF_REF",
                table: "productype",
                column: "TARIF_REF",
                principalTable: "tarifs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_records_accounts_ACC_REF",
                table: "records",
                column: "ACC_REF",
                principalTable: "accounts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
