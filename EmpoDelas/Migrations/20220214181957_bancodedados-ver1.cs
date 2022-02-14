using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmpoDelas.Migrations
{
    public partial class bancodedadosver1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Afiliada",
                columns: table => new
                {
                    Id_afiliada = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_afiliada = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Sobrenome_afiliada = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Email_afiliada = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    DataNasc_afiliada = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NumTelefone_afiliada = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Endereco_afiliada = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Cep_afiliada = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Descricao_afiliada = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ComprovanteResid_afiliada = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afiliada", x => x.Id_afiliada);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Autonoma",
                columns: table => new
                {
                    Id_autonoma = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_autonoma = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Sobrenome_autonoma = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Email_autonoma = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    DataNasc_autonoma = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NumTelefone_autonoma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Endereco_autonoma = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Cep_autonoma = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    NomeNegocio_autonoma = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContatoNegocio_autonoma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CategoriaNegocio_autonoma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DescricaoNegocio_autonoma = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ComprovanteResid_autonoma = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autonoma", x => x.Id_autonoma);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoServico",
                columns: table => new
                {
                    Id_produtoServico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_produtoServico = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Tipo_produtoServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome_produtoServico = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Descricao_produtoServico = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Preco_produtoServico = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NomeNegocio_autonoma = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FK_id_autonoma = table.Column<int>(type: "int", nullable: false),
                    Id_autonoma1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoServico", x => x.Id_produtoServico);
                    table.ForeignKey(
                        name: "FK_ProdutoServico_Autonoma_Id_autonoma1",
                        column: x => x.Id_autonoma1,
                        principalTable: "Autonoma",
                        principalColumn: "Id_autonoma",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Afiliacao",
                columns: table => new
                {
                    Id_afiliacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_produtoServico = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descricao_afiliacao = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FK_id_afiliada = table.Column<int>(type: "int", nullable: false),
                    AfiliadaId_afiliada = table.Column<int>(type: "int", nullable: true),
                    FK_id_produtoServico = table.Column<int>(type: "int", nullable: false),
                    ProdutoServicoId_produtoServico = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afiliacao", x => x.Id_afiliacao);
                    table.ForeignKey(
                        name: "FK_Afiliacao_Afiliada_AfiliadaId_afiliada",
                        column: x => x.AfiliadaId_afiliada,
                        principalTable: "Afiliada",
                        principalColumn: "Id_afiliada",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Afiliacao_ProdutoServico_ProdutoServicoId_produtoServico",
                        column: x => x.ProdutoServicoId_produtoServico,
                        principalTable: "ProdutoServico",
                        principalColumn: "Id_produtoServico",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Afiliacao_AfiliadaId_afiliada",
                table: "Afiliacao",
                column: "AfiliadaId_afiliada");

            migrationBuilder.CreateIndex(
                name: "IX_Afiliacao_ProdutoServicoId_produtoServico",
                table: "Afiliacao",
                column: "ProdutoServicoId_produtoServico");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoServico_Id_autonoma1",
                table: "ProdutoServico",
                column: "Id_autonoma1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Afiliacao");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Afiliada");

            migrationBuilder.DropTable(
                name: "ProdutoServico");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Autonoma");
        }
    }
}
