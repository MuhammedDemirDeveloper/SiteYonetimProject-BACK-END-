using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteYonetimData_Access.Migrations
{
    public partial class EkleTumTablolarSiteYonetim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Cinsiyetler",
                columns: table => new
                {
                    CinsiyetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Cinsiyetler", x => x.CinsiyetID);
                });

            migrationBuilder.CreateTable(
                name: "tb_IsinmaTurleri",
                columns: table => new
                {
                    IsinmaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsinmaTuru = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_IsinmaTurleri", x => x.IsinmaID);
                });

            migrationBuilder.CreateTable(
                name: "tb_iletisimDilleri",
                columns: table => new
                {
                    IletisimDiliID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dil = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_iletisimDilleri", x => x.IletisimDiliID);
                });

            migrationBuilder.CreateTable(
                name: "tb_Meslekler",
                columns: table => new
                {
                    MeslekID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Meslek = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Meslekler", x => x.MeslekID);
                });

            migrationBuilder.CreateTable(
                name: "tb_OgrenimDurumu",
                columns: table => new
                {
                    OgrenimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ogrenim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_OgrenimDurumu", x => x.OgrenimID);
                });

            migrationBuilder.CreateTable(
                name: "tb_SozlesmeTarihleri",
                columns: table => new
                {
                    SozlesmeTarihiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_SozlesmeTarihleri", x => x.SozlesmeTarihiID);
                });

            migrationBuilder.CreateTable(
                name: "tb_Ulkeler",
                columns: table => new
                {
                    UlkeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlkeAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Ulkeler", x => x.UlkeID);
                });

            migrationBuilder.CreateTable(
                name: "tb_Uyruklar",
                columns: table => new
                {
                    UyrukID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uyruk = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Uyruklar", x => x.UyrukID);
                });

            migrationBuilder.CreateTable(
                name: "tb_iller",
                columns: table => new
                {
                    ilID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ilAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UlkeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_iller", x => x.ilID);
                    table.ForeignKey(
                        name: "FK_tb_iller_tb_Ulkeler_UlkeID",
                        column: x => x.UlkeID,
                        principalTable: "tb_Ulkeler",
                        principalColumn: "UlkeID");
                });

            migrationBuilder.CreateTable(
                name: "tb_ilceler",
                columns: table => new
                {
                    ilceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ilceAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ilID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ilceler", x => x.ilceID);
                    table.ForeignKey(
                        name: "FK_tb_ilceler_tb_iller_ilID",
                        column: x => x.ilID,
                        principalTable: "tb_iller",
                        principalColumn: "ilID");
                });

            migrationBuilder.CreateTable(
                name: "tb_Firmalar",
                columns: table => new
                {
                    ilID = table.Column<int>(type: "int", nullable: true),
                    ilceID = table.Column<int>(type: "int", nullable: true),
                    UlkeID = table.Column<int>(type: "int", nullable: true),
                    SozlesmeTarihiID = table.Column<int>(type: "int", nullable: true),
                    FirmaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaTelNo = table.Column<long>(type: "bigint", maxLength: 10, nullable: false),
                    FirmaEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaKayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Firmalar", x => x.FirmaID);
                    table.ForeignKey(
                        name: "FK_tb_Firmalar_tb_ilceler_ilceID",
                        column: x => x.ilceID,
                        principalTable: "tb_ilceler",
                        principalColumn: "ilceID");
                    table.ForeignKey(
                        name: "FK_tb_Firmalar_tb_iller_ilID",
                        column: x => x.ilID,
                        principalTable: "tb_iller",
                        principalColumn: "ilID");
                    table.ForeignKey(
                        name: "FK_tb_Firmalar_tb_SozlesmeTarihleri_SozlesmeTarihiID",
                        column: x => x.SozlesmeTarihiID,
                        principalTable: "tb_SozlesmeTarihleri",
                        principalColumn: "SozlesmeTarihiID");
                    table.ForeignKey(
                        name: "FK_tb_Firmalar_tb_Ulkeler_UlkeID",
                        column: x => x.UlkeID,
                        principalTable: "tb_Ulkeler",
                        principalColumn: "UlkeID");
                });

            migrationBuilder.CreateTable(
                name: "tb_Siteler",
                columns: table => new
                {
                    FirmaID = table.Column<int>(type: "int", nullable: false),
                    ilID = table.Column<int>(type: "int", nullable: true),
                    ilceID = table.Column<int>(type: "int", nullable: true),
                    UlkeID = table.Column<int>(type: "int", nullable: true),
                    IsinmaID = table.Column<int>(type: "int", nullable: true),
                    SiteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteAdres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Siteler", x => x.SiteID);
                    table.ForeignKey(
                        name: "FK_tb_Siteler_tb_Firmalar_FirmaID",
                        column: x => x.FirmaID,
                        principalTable: "tb_Firmalar",
                        principalColumn: "FirmaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_Siteler_tb_IsinmaTurleri_IsinmaID",
                        column: x => x.IsinmaID,
                        principalTable: "tb_IsinmaTurleri",
                        principalColumn: "IsinmaID");
                    table.ForeignKey(
                        name: "FK_tb_Siteler_tb_ilceler_ilceID",
                        column: x => x.ilceID,
                        principalTable: "tb_ilceler",
                        principalColumn: "ilceID");
                    table.ForeignKey(
                        name: "FK_tb_Siteler_tb_iller_ilID",
                        column: x => x.ilID,
                        principalTable: "tb_iller",
                        principalColumn: "ilID");
                    table.ForeignKey(
                        name: "FK_tb_Siteler_tb_Ulkeler_UlkeID",
                        column: x => x.UlkeID,
                        principalTable: "tb_Ulkeler",
                        principalColumn: "UlkeID");
                });

            migrationBuilder.CreateTable(
                name: "tb_Bloklar",
                columns: table => new
                {
                    FirmaID = table.Column<int>(type: "int", nullable: true),
                    SiteID = table.Column<int>(type: "int", nullable: true),
                    BlokID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlokTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlokDaireSayisi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Bloklar", x => x.BlokID);
                    table.ForeignKey(
                        name: "FK_tb_Bloklar_tb_Firmalar_FirmaID",
                        column: x => x.FirmaID,
                        principalTable: "tb_Firmalar",
                        principalColumn: "FirmaID");
                    table.ForeignKey(
                        name: "FK_tb_Bloklar_tb_Siteler_SiteID",
                        column: x => x.SiteID,
                        principalTable: "tb_Siteler",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "tb_Personeller",
                columns: table => new
                {
                    FirmaID = table.Column<int>(type: "int", nullable: true),
                    SiteID = table.Column<int>(type: "int", nullable: true),
                    PersonelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelDurum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelTc = table.Column<long>(type: "bigint", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Personeller", x => x.PersonelID);
                    table.ForeignKey(
                        name: "FK_tb_Personeller_tb_Firmalar_FirmaID",
                        column: x => x.FirmaID,
                        principalTable: "tb_Firmalar",
                        principalColumn: "FirmaID");
                    table.ForeignKey(
                        name: "FK_tb_Personeller_tb_Siteler_SiteID",
                        column: x => x.SiteID,
                        principalTable: "tb_Siteler",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "tb_Daireler",
                columns: table => new
                {
                    DaireID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaireTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaireOdaSayisi = table.Column<int>(type: "int", nullable: false),
                    BlokID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Daireler", x => x.DaireID);
                    table.ForeignKey(
                        name: "FK_tb_Daireler_tb_Bloklar_BlokID",
                        column: x => x.BlokID,
                        principalTable: "tb_Bloklar",
                        principalColumn: "BlokID");
                });

            migrationBuilder.CreateTable(
                name: "tb_Kisiler",
                columns: table => new
                {
                    CinsiyetID = table.Column<int>(type: "int", nullable: true),
                    MeslekID = table.Column<int>(type: "int", nullable: true),
                    UyrukID = table.Column<int>(type: "int", nullable: true),
                    DaireID = table.Column<int>(type: "int", nullable: true),
                    IletisimDiliID = table.Column<int>(type: "int", nullable: true),
                    OgrenimID = table.Column<int>(type: "int", nullable: true),
                    KisiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TcKimlikNo = table.Column<long>(type: "bigint", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNo1 = table.Column<long>(type: "bigint", maxLength: 10, nullable: false),
                    TelNo2 = table.Column<long>(type: "bigint", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Kisiler", x => x.KisiID);
                    table.ForeignKey(
                        name: "FK_tb_Kisiler_tb_Cinsiyetler_CinsiyetID",
                        column: x => x.CinsiyetID,
                        principalTable: "tb_Cinsiyetler",
                        principalColumn: "CinsiyetID");
                    table.ForeignKey(
                        name: "FK_tb_Kisiler_tb_Daireler_DaireID",
                        column: x => x.DaireID,
                        principalTable: "tb_Daireler",
                        principalColumn: "DaireID");
                    table.ForeignKey(
                        name: "FK_tb_Kisiler_tb_iletisimDilleri_IletisimDiliID",
                        column: x => x.IletisimDiliID,
                        principalTable: "tb_iletisimDilleri",
                        principalColumn: "IletisimDiliID");
                    table.ForeignKey(
                        name: "FK_tb_Kisiler_tb_Meslekler_MeslekID",
                        column: x => x.MeslekID,
                        principalTable: "tb_Meslekler",
                        principalColumn: "MeslekID");
                    table.ForeignKey(
                        name: "FK_tb_Kisiler_tb_OgrenimDurumu_OgrenimID",
                        column: x => x.OgrenimID,
                        principalTable: "tb_OgrenimDurumu",
                        principalColumn: "OgrenimID");
                    table.ForeignKey(
                        name: "FK_tb_Kisiler_tb_Uyruklar_UyrukID",
                        column: x => x.UyrukID,
                        principalTable: "tb_Uyruklar",
                        principalColumn: "UyrukID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Bloklar_FirmaID",
                table: "tb_Bloklar",
                column: "FirmaID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Bloklar_SiteID",
                table: "tb_Bloklar",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Daireler_BlokID",
                table: "tb_Daireler",
                column: "BlokID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Firmalar_ilceID",
                table: "tb_Firmalar",
                column: "ilceID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Firmalar_ilID",
                table: "tb_Firmalar",
                column: "ilID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Firmalar_SozlesmeTarihiID",
                table: "tb_Firmalar",
                column: "SozlesmeTarihiID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Firmalar_UlkeID",
                table: "tb_Firmalar",
                column: "UlkeID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_ilceler_ilID",
                table: "tb_ilceler",
                column: "ilID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_iller_UlkeID",
                table: "tb_iller",
                column: "UlkeID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Kisiler_CinsiyetID",
                table: "tb_Kisiler",
                column: "CinsiyetID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Kisiler_DaireID",
                table: "tb_Kisiler",
                column: "DaireID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Kisiler_IletisimDiliID",
                table: "tb_Kisiler",
                column: "IletisimDiliID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Kisiler_MeslekID",
                table: "tb_Kisiler",
                column: "MeslekID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Kisiler_OgrenimID",
                table: "tb_Kisiler",
                column: "OgrenimID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Kisiler_UyrukID",
                table: "tb_Kisiler",
                column: "UyrukID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Personeller_FirmaID",
                table: "tb_Personeller",
                column: "FirmaID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Personeller_SiteID",
                table: "tb_Personeller",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Siteler_FirmaID",
                table: "tb_Siteler",
                column: "FirmaID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Siteler_IsinmaID",
                table: "tb_Siteler",
                column: "IsinmaID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Siteler_ilceID",
                table: "tb_Siteler",
                column: "ilceID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Siteler_ilID",
                table: "tb_Siteler",
                column: "ilID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Siteler_UlkeID",
                table: "tb_Siteler",
                column: "UlkeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Kisiler");

            migrationBuilder.DropTable(
                name: "tb_Personeller");

            migrationBuilder.DropTable(
                name: "tb_Cinsiyetler");

            migrationBuilder.DropTable(
                name: "tb_Daireler");

            migrationBuilder.DropTable(
                name: "tb_iletisimDilleri");

            migrationBuilder.DropTable(
                name: "tb_Meslekler");

            migrationBuilder.DropTable(
                name: "tb_OgrenimDurumu");

            migrationBuilder.DropTable(
                name: "tb_Uyruklar");

            migrationBuilder.DropTable(
                name: "tb_Bloklar");

            migrationBuilder.DropTable(
                name: "tb_Siteler");

            migrationBuilder.DropTable(
                name: "tb_Firmalar");

            migrationBuilder.DropTable(
                name: "tb_IsinmaTurleri");

            migrationBuilder.DropTable(
                name: "tb_ilceler");

            migrationBuilder.DropTable(
                name: "tb_SozlesmeTarihleri");

            migrationBuilder.DropTable(
                name: "tb_iller");

            migrationBuilder.DropTable(
                name: "tb_Ulkeler");
        }
    }
}
