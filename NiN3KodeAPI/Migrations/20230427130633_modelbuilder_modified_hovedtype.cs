using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NiN3KodeAPI.Migrations
{
    public partial class modelbuilder_modified_hovedtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hovedtypegruppe_Typekategori2_Typekategori2Id",
                table: "Hovedtypegruppe");

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("37fcfdee-84da-4620-98d9-1b4a783507df"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("46356f5c-f428-4287-8834-51744e649f2d"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("f3de68b9-3f99-4d40-a90a-ec42af3b2e64"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("29d0e8f0-cccc-4b6d-84a1-6b7fd16cc1df"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("4268a201-8c7d-4f72-91e0-ae422b691a61"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("74dee18a-6d42-4e21-b1b3-96343794da58"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("adbdcf5a-e863-4b82-a333-5f02ce28c7c1"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("d1848ab0-7571-4367-a7b1-b0adc19f2bfa"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("fc79d338-9c25-4a1e-8474-6ae688848b90"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("0fd26cb3-80fa-4703-b9b5-1f690853c028"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("1ef65842-d8dc-4506-a268-daaf853c3893"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("613678b3-c54e-4eb7-b474-21cab077b95e"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("69cefd53-9dd1-4021-b578-c913a88c8c49"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("6b360ce2-9b97-4174-bb7c-a3ea3aa4806c"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("719e837b-681d-4578-9886-1d345ee515f4"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("72035fed-78a9-4d06-8d6d-2c57c7e86f2b"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("79596b08-b917-4f7f-a641-647ee5cc798c"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("8000923b-fb47-4b4a-9616-b5557cf33b90"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("965f2c88-120e-48ec-b35d-4618b30d222f"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("9bce5744-8161-4956-939d-c4ba913793a2"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("9f3b8fb2-1e9a-4593-bd6f-e3a9f99a2a44"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("a62ac50d-fe2d-4bb6-bfe8-7f26314ca647"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("d6501941-e1dc-4a8e-9f74-508b417455f0"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("e2fd0ed1-d390-4ac2-a2bd-1af5e40e7e3a"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("19b45be9-ecd3-4f20-b2e2-36b29bb031c6"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("1d4fdc7f-4862-4349-85ab-4093dd8437a8"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("4329ff26-02d7-44c5-97ed-1456330eada8"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("66cd532b-48ab-4d54-a9b1-c12791e2657a"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("7c71fd75-b093-45e7-87c7-879e3033dc07"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("04c57e4b-3896-4550-95ad-03380ccc1a6e"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("088f295c-8e37-40a9-af38-bc6092f160f4"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("30bf370f-2182-4444-94c1-833e94c25bd1"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("332cb709-1579-47fa-a1a5-e7b8b4d9582e"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("6daa35a9-f104-4316-916b-b4c452313eb2"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("924dc517-e45e-411d-8d8a-45a7c6e94c40"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("a5e56142-5109-487c-8f65-b4f1a025783a"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("d695e7b9-9f65-489a-a42e-4a04a2976312"));

            migrationBuilder.DeleteData(
                table: "Typekategori3",
                keyColumn: "Id",
                keyValue: new Guid("7eafd8de-5782-4c01-8b5b-5624f34d9a7b"));

            migrationBuilder.DeleteData(
                table: "Typekategori3",
                keyColumn: "Id",
                keyValue: new Guid("cd2f1400-56ed-47b4-b26d-aa8cf390758f"));

            migrationBuilder.DeleteData(
                table: "domene",
                keyColumn: "Id",
                keyValue: new Guid("37f5bb46-c3f2-4b9a-9f05-21739d7a0024"));

            migrationBuilder.AddColumn<string>(
                name: "Delkode",
                table: "Hovedtype",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "HovedtypegruppeId",
                table: "Hovedtype",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProsedyrekategoriId",
                table: "Hovedtype",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Ecosystnivå",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("5d0f5872-e973-436a-b73f-882e39488009"), "abiotisk", "A" },
                    { new Guid("afe84582-1f43-47d8-aef3-3719df2d20c3"), "biotisk", "B" },
                    { new Guid("b27464da-1d44-4df3-bfe3-6eb3e819fbb8"), "økodiversitet", "C" }
                });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("50743dd8-ef0a-4fd2-8e76-a63f3333517f"), "kartleggingsenhet tilpasset 1:100 000", "100K" },
                    { new Guid("9b908310-4506-4444-87a7-019d5b60870e"), "kartleggingsenhet tilpasset 1:20 000", "020K" },
                    { new Guid("cad5bebb-bca5-4445-b990-7ae1cda6aafb"), "kartleggingsenhet tilpasset 1:50 000", "050K" },
                    { new Guid("de3563eb-7cc9-4a12-9bcc-5aa2d54fdf20"), "kartleggingsenhet tilpasset 1:5000", "005K" },
                    { new Guid("e36255f4-5fc2-4de9-a89b-2066e44b05e5"), "grunntype", "G" },
                    { new Guid("f0724a84-9669-4a62-aabd-5281a4e1d25d"), "kartleggingsenhet tilpasset 1:10 000", "010K" }
                });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("025f8d81-4856-4660-9e0e-8aff44b00dd0"), "I", "I" },
                    { new Guid("0ab3775d-2123-4551-b2b0-64494fae8b29"), "H", "H" },
                    { new Guid("0e959966-532a-488d-b5e4-07e63b4f2957"), "M", "M" },
                    { new Guid("10d33671-bb08-4583-955f-c4e04d04e20e"), "G", "G" },
                    { new Guid("138e0a01-3076-49ce-bb29-0178b65d4886"), "L", "L" },
                    { new Guid("2b71daa7-6ef9-4ab6-8c97-44405629d7a8"), "C", "C" },
                    { new Guid("412122e0-3fe9-419d-be89-db2f31fcfbbb"), "E", "E" },
                    { new Guid("67de15f0-8c1c-4526-9917-590639cc952b"), "K", "K" },
                    { new Guid("6f094b22-554b-4fd3-b47e-d98b17f13f1c"), "F", "F" },
                    { new Guid("7ec3663c-6db0-4f22-8ca0-898b80c4167d"), "A", "A" },
                    { new Guid("802ad24b-a9f0-49e2-80a9-45a7b47e4cb2"), "B", "B" },
                    { new Guid("a1aa2ab7-9f4f-46a6-9720-ed60d8304ba0"), "N", "N" },
                    { new Guid("a2f75e87-3da2-4fbc-a4ef-bf880a46cdaf"), "D", "D" },
                    { new Guid("ab6aec50-55a9-493b-9a91-f23509312662"), "O", "O" },
                    { new Guid("ba1299bd-c2b6-4f8a-8859-46359f07893b"), "J", "J" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("00d70522-60fe-4e9b-962d-1232f2476851"), "landformvariasjon", "LV" },
                    { new Guid("3d95b5e0-7bb1-4df5-945a-fc2f4339c17b"), "livsmedium", "LI" },
                    { new Guid("844f9c1f-72a3-47f3-9bc7-06d35047550f"), "sekundært økodiversitetsnivå", "SE" },
                    { new Guid("de4ec007-bf98-4eb9-bbd4-ee3b3868f3fd"), "marine vannmasser", "MV" },
                    { new Guid("f7eac1eb-c66d-4119-af7f-845c78d59ae9"), "primært økodiversitetsnivå", "PE" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("0a4f978d-5a72-4b52-a64c-1321735522c1"), "innsjøbasseng", "IB" },
                    { new Guid("2b0220f5-483b-435b-a729-5bd7eb51df3e"), "landskapstype", "LA" },
                    { new Guid("3ca7d579-e4ce-4fa6-b30a-1e6f72b64d6f"), "landformer i fast fjell og løsmasser", "FL" },
                    { new Guid("4935ce21-dcdb-40b3-b3c5-11643594b1aa"), "naturkompleks", "NK" },
                    { new Guid("4f62b339-ff99-4fbf-8fff-4e9d0be545e7"), "bremassiv", "BM" },
                    { new Guid("5fa41c4c-9654-468e-8e6e-d9eceb61b21a"), "torvmarksmassiv", "TM" },
                    { new Guid("9503a817-d1cc-4978-a7f0-e98a986fd595"), "natursystem", "NA" },
                    { new Guid("fbddf779-53ed-4f52-90ce-c723bfff9e4a"), "elveløp", "EL" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("8f025a5c-1b7d-4051-8cda-11c065388031"), "vannmassesystemer", "VM" },
                    { new Guid("9b856646-0dd2-4698-b9f3-e4b70182b7df"), "mark- og bunnsystemer", "MB" }
                });

            migrationBuilder.InsertData(
                table: "domene",
                columns: new[] { "Id", "Navn" },
                values: new object[] { new Guid("970268f4-7c56-42c6-a52a-90d0017d0e48"), "3.0" });

            migrationBuilder.CreateIndex(
                name: "IX_Hovedtype_HovedtypegruppeId",
                table: "Hovedtype",
                column: "HovedtypegruppeId");

            migrationBuilder.CreateIndex(
                name: "IX_Hovedtype_ProsedyrekategoriId",
                table: "Hovedtype",
                column: "ProsedyrekategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hovedtype_Hovedtypegruppe_HovedtypegruppeId",
                table: "Hovedtype",
                column: "HovedtypegruppeId",
                principalTable: "Hovedtypegruppe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hovedtype_Prosedyrekategori_ProsedyrekategoriId",
                table: "Hovedtype",
                column: "ProsedyrekategoriId",
                principalTable: "Prosedyrekategori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hovedtypegruppe_Typekategori2_Typekategori2Id",
                table: "Hovedtypegruppe",
                column: "Typekategori2Id",
                principalTable: "Typekategori2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hovedtype_Hovedtypegruppe_HovedtypegruppeId",
                table: "Hovedtype");

            migrationBuilder.DropForeignKey(
                name: "FK_Hovedtype_Prosedyrekategori_ProsedyrekategoriId",
                table: "Hovedtype");

            migrationBuilder.DropForeignKey(
                name: "FK_Hovedtypegruppe_Typekategori2_Typekategori2Id",
                table: "Hovedtypegruppe");

            migrationBuilder.DropIndex(
                name: "IX_Hovedtype_HovedtypegruppeId",
                table: "Hovedtype");

            migrationBuilder.DropIndex(
                name: "IX_Hovedtype_ProsedyrekategoriId",
                table: "Hovedtype");

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("5d0f5872-e973-436a-b73f-882e39488009"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("afe84582-1f43-47d8-aef3-3719df2d20c3"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("b27464da-1d44-4df3-bfe3-6eb3e819fbb8"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("50743dd8-ef0a-4fd2-8e76-a63f3333517f"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("9b908310-4506-4444-87a7-019d5b60870e"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("cad5bebb-bca5-4445-b990-7ae1cda6aafb"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("de3563eb-7cc9-4a12-9bcc-5aa2d54fdf20"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("e36255f4-5fc2-4de9-a89b-2066e44b05e5"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("f0724a84-9669-4a62-aabd-5281a4e1d25d"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("025f8d81-4856-4660-9e0e-8aff44b00dd0"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("0ab3775d-2123-4551-b2b0-64494fae8b29"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("0e959966-532a-488d-b5e4-07e63b4f2957"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("10d33671-bb08-4583-955f-c4e04d04e20e"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("138e0a01-3076-49ce-bb29-0178b65d4886"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("2b71daa7-6ef9-4ab6-8c97-44405629d7a8"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("412122e0-3fe9-419d-be89-db2f31fcfbbb"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("67de15f0-8c1c-4526-9917-590639cc952b"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("6f094b22-554b-4fd3-b47e-d98b17f13f1c"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("7ec3663c-6db0-4f22-8ca0-898b80c4167d"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("802ad24b-a9f0-49e2-80a9-45a7b47e4cb2"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("a1aa2ab7-9f4f-46a6-9720-ed60d8304ba0"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("a2f75e87-3da2-4fbc-a4ef-bf880a46cdaf"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("ab6aec50-55a9-493b-9a91-f23509312662"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("ba1299bd-c2b6-4f8a-8859-46359f07893b"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("00d70522-60fe-4e9b-962d-1232f2476851"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("3d95b5e0-7bb1-4df5-945a-fc2f4339c17b"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("844f9c1f-72a3-47f3-9bc7-06d35047550f"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("de4ec007-bf98-4eb9-bbd4-ee3b3868f3fd"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("f7eac1eb-c66d-4119-af7f-845c78d59ae9"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("0a4f978d-5a72-4b52-a64c-1321735522c1"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("2b0220f5-483b-435b-a729-5bd7eb51df3e"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("3ca7d579-e4ce-4fa6-b30a-1e6f72b64d6f"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("4935ce21-dcdb-40b3-b3c5-11643594b1aa"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("4f62b339-ff99-4fbf-8fff-4e9d0be545e7"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("5fa41c4c-9654-468e-8e6e-d9eceb61b21a"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("9503a817-d1cc-4978-a7f0-e98a986fd595"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("fbddf779-53ed-4f52-90ce-c723bfff9e4a"));

            migrationBuilder.DeleteData(
                table: "Typekategori3",
                keyColumn: "Id",
                keyValue: new Guid("8f025a5c-1b7d-4051-8cda-11c065388031"));

            migrationBuilder.DeleteData(
                table: "Typekategori3",
                keyColumn: "Id",
                keyValue: new Guid("9b856646-0dd2-4698-b9f3-e4b70182b7df"));

            migrationBuilder.DeleteData(
                table: "domene",
                keyColumn: "Id",
                keyValue: new Guid("970268f4-7c56-42c6-a52a-90d0017d0e48"));

            migrationBuilder.DropColumn(
                name: "Delkode",
                table: "Hovedtype");

            migrationBuilder.DropColumn(
                name: "HovedtypegruppeId",
                table: "Hovedtype");

            migrationBuilder.DropColumn(
                name: "ProsedyrekategoriId",
                table: "Hovedtype");

            migrationBuilder.InsertData(
                table: "Ecosystnivå",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("37fcfdee-84da-4620-98d9-1b4a783507df"), "abiotisk", "A" },
                    { new Guid("46356f5c-f428-4287-8834-51744e649f2d"), "biotisk", "B" },
                    { new Guid("f3de68b9-3f99-4d40-a90a-ec42af3b2e64"), "økodiversitet", "C" }
                });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("29d0e8f0-cccc-4b6d-84a1-6b7fd16cc1df"), "kartleggingsenhet tilpasset 1:20 000", "020K" },
                    { new Guid("4268a201-8c7d-4f72-91e0-ae422b691a61"), "kartleggingsenhet tilpasset 1:100 000", "100K" },
                    { new Guid("74dee18a-6d42-4e21-b1b3-96343794da58"), "grunntype", "G" },
                    { new Guid("adbdcf5a-e863-4b82-a333-5f02ce28c7c1"), "kartleggingsenhet tilpasset 1:5000", "005K" },
                    { new Guid("d1848ab0-7571-4367-a7b1-b0adc19f2bfa"), "kartleggingsenhet tilpasset 1:50 000", "050K" },
                    { new Guid("fc79d338-9c25-4a1e-8474-6ae688848b90"), "kartleggingsenhet tilpasset 1:10 000", "010K" }
                });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("0fd26cb3-80fa-4703-b9b5-1f690853c028"), "I", "I" },
                    { new Guid("1ef65842-d8dc-4506-a268-daaf853c3893"), "D", "D" },
                    { new Guid("613678b3-c54e-4eb7-b474-21cab077b95e"), "M", "M" },
                    { new Guid("69cefd53-9dd1-4021-b578-c913a88c8c49"), "A", "A" },
                    { new Guid("6b360ce2-9b97-4174-bb7c-a3ea3aa4806c"), "O", "O" },
                    { new Guid("719e837b-681d-4578-9886-1d345ee515f4"), "K", "K" },
                    { new Guid("72035fed-78a9-4d06-8d6d-2c57c7e86f2b"), "B", "B" },
                    { new Guid("79596b08-b917-4f7f-a641-647ee5cc798c"), "J", "J" },
                    { new Guid("8000923b-fb47-4b4a-9616-b5557cf33b90"), "N", "N" },
                    { new Guid("965f2c88-120e-48ec-b35d-4618b30d222f"), "C", "C" },
                    { new Guid("9bce5744-8161-4956-939d-c4ba913793a2"), "F", "F" },
                    { new Guid("9f3b8fb2-1e9a-4593-bd6f-e3a9f99a2a44"), "H", "H" },
                    { new Guid("a62ac50d-fe2d-4bb6-bfe8-7f26314ca647"), "L", "L" },
                    { new Guid("d6501941-e1dc-4a8e-9f74-508b417455f0"), "G", "G" },
                    { new Guid("e2fd0ed1-d390-4ac2-a2bd-1af5e40e7e3a"), "E", "E" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("19b45be9-ecd3-4f20-b2e2-36b29bb031c6"), "sekundært økodiversitetsnivå", "SE" },
                    { new Guid("1d4fdc7f-4862-4349-85ab-4093dd8437a8"), "landformvariasjon", "LV" },
                    { new Guid("4329ff26-02d7-44c5-97ed-1456330eada8"), "primært økodiversitetsnivå", "PE" },
                    { new Guid("66cd532b-48ab-4d54-a9b1-c12791e2657a"), "livsmedium", "LI" },
                    { new Guid("7c71fd75-b093-45e7-87c7-879e3033dc07"), "marine vannmasser", "MV" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("04c57e4b-3896-4550-95ad-03380ccc1a6e"), "landskapstype", "LA" },
                    { new Guid("088f295c-8e37-40a9-af38-bc6092f160f4"), "bremassiv", "BM" },
                    { new Guid("30bf370f-2182-4444-94c1-833e94c25bd1"), "torvmarksmassiv", "TM" },
                    { new Guid("332cb709-1579-47fa-a1a5-e7b8b4d9582e"), "naturkompleks", "NK" },
                    { new Guid("6daa35a9-f104-4316-916b-b4c452313eb2"), "elveløp", "EL" },
                    { new Guid("924dc517-e45e-411d-8d8a-45a7c6e94c40"), "natursystem", "NA" },
                    { new Guid("a5e56142-5109-487c-8f65-b4f1a025783a"), "landformer i fast fjell og løsmasser", "FL" },
                    { new Guid("d695e7b9-9f65-489a-a42e-4a04a2976312"), "innsjøbasseng", "IB" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("7eafd8de-5782-4c01-8b5b-5624f34d9a7b"), "mark- og bunnsystemer", "MB" },
                    { new Guid("cd2f1400-56ed-47b4-b26d-aa8cf390758f"), "vannmassesystemer", "VM" }
                });

            migrationBuilder.InsertData(
                table: "domene",
                columns: new[] { "Id", "Navn" },
                values: new object[] { new Guid("37f5bb46-c3f2-4b9a-9f05-21739d7a0024"), "3.0" });

            migrationBuilder.AddForeignKey(
                name: "FK_Hovedtypegruppe_Typekategori2_Typekategori2Id",
                table: "Hovedtypegruppe",
                column: "Typekategori2Id",
                principalTable: "Typekategori2",
                principalColumn: "Id");
        }
    }
}
