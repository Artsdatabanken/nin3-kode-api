using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NiN3KodeAPI.Migrations
{
    public partial class hovedtypegruppe_modified2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hovedtypegruppe_Typekategori2_Typekategori2Id",
                table: "Hovedtypegruppe");

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("630ba1e7-4d91-4ffb-a7f5-a0a62f6c7cd2"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("6e4b2194-3db2-4410-9423-cae094b641e8"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("94c1e42e-8d6c-4397-adcb-13fce8dbd522"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("11de2b8c-74d5-4f91-b78a-4fbc9c05e75e"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("3fb50ffa-30ff-41c6-9622-cd622d98e541"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("5a1499e5-1a01-4237-8cfc-f20868b9d50a"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("67464a17-69dc-4d2c-bda0-0cd56124e8c9"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("793515e2-29d3-4784-a1fe-9614ee5c53ba"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("c4a9dd99-45fb-4fa4-ad7f-f1cdb96667c7"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("0f2aaf60-c92d-412a-99fe-662c6a05f20e"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("12bf500d-02e8-4b13-ab2b-235006f17b51"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("170443a4-6fa8-4088-b32a-52bb546470b3"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("21d627ea-c90d-453e-be13-2e24200c132c"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("36ff9165-a4a4-403b-94ce-5358269ce7ff"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("48c79850-c45e-45fc-ab67-8dbb8b507381"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("6cbf61e8-2cdf-4955-9b82-8f625b634b31"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("7dc094d4-6e3a-4eaa-9fe6-fe470e435a93"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("888cdbb0-0a4f-463c-9e82-15dd848dde13"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("8d0c0a02-e38d-4d8f-b248-d4cc1012457a"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("981ccb8f-7f66-4fa1-9c99-1345638e3435"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("b1ebdfc1-7356-4878-b8fb-26886f26f53b"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("cb19c297-72ca-43ca-8f2a-c3e1de433856"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("d3d6fde4-591e-408a-845e-c605e975ccf3"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("f026b15e-7545-4bfe-822e-9d300b0f3161"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("0436ff8f-a31f-462a-9138-83ab51a9a4a3"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("267c8729-02f5-4e39-adc8-2152956d170a"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("4ff17bd0-b4ab-40f8-9690-4a759068db81"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("a77cb14c-8b81-4efd-b013-8ce9fec8c356"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("ac012d20-3d4f-4618-973e-348b59fc326d"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("0376d3f2-721d-42e3-957e-3185ed821ca4"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("13051329-cd59-4516-8386-e155aab522e7"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("1bd12aa1-11e1-4128-8fe0-90d94457ea7e"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("4c437ff9-3145-4932-8e8c-473c061e10b9"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("69cf6147-43fe-4a59-abb8-9cf673978279"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("7d38d1a4-6163-4750-b8e8-ae173c4fa7e7"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("b0c25309-c6b5-4301-835d-dc4197dd896b"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("cd814bf5-5345-41ea-a063-44c8cdd95825"));

            migrationBuilder.DeleteData(
                table: "Typekategori3",
                keyColumn: "Id",
                keyValue: new Guid("1b43fad6-a3a0-4ff2-9163-f38b8aade99f"));

            migrationBuilder.DeleteData(
                table: "Typekategori3",
                keyColumn: "Id",
                keyValue: new Guid("88c9be1b-c64f-4893-bc1b-b60c5afd5dec"));

            migrationBuilder.DeleteData(
                table: "domene",
                keyColumn: "Id",
                keyValue: new Guid("3b682481-d0f8-4edc-9b8e-2ba35bf30fc3"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Typekategori2Id",
                table: "Hovedtypegruppe",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "Typekategori2Id",
                table: "Hovedtypegruppe",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Ecosystnivå",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("630ba1e7-4d91-4ffb-a7f5-a0a62f6c7cd2"), "abiotisk", "A" },
                    { new Guid("6e4b2194-3db2-4410-9423-cae094b641e8"), "biotisk", "B" },
                    { new Guid("94c1e42e-8d6c-4397-adcb-13fce8dbd522"), "økodiversitet", "C" }
                });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("11de2b8c-74d5-4f91-b78a-4fbc9c05e75e"), "kartleggingsenhet tilpasset 1:100 000", "100K" },
                    { new Guid("3fb50ffa-30ff-41c6-9622-cd622d98e541"), "kartleggingsenhet tilpasset 1:10 000", "010K" },
                    { new Guid("5a1499e5-1a01-4237-8cfc-f20868b9d50a"), "grunntype", "G" },
                    { new Guid("67464a17-69dc-4d2c-bda0-0cd56124e8c9"), "kartleggingsenhet tilpasset 1:20 000", "020K" },
                    { new Guid("793515e2-29d3-4784-a1fe-9614ee5c53ba"), "kartleggingsenhet tilpasset 1:50 000", "050K" },
                    { new Guid("c4a9dd99-45fb-4fa4-ad7f-f1cdb96667c7"), "kartleggingsenhet tilpasset 1:5000", "005K" }
                });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("0f2aaf60-c92d-412a-99fe-662c6a05f20e"), "K", "K" },
                    { new Guid("12bf500d-02e8-4b13-ab2b-235006f17b51"), "F", "F" },
                    { new Guid("170443a4-6fa8-4088-b32a-52bb546470b3"), "L", "L" },
                    { new Guid("21d627ea-c90d-453e-be13-2e24200c132c"), "J", "J" },
                    { new Guid("36ff9165-a4a4-403b-94ce-5358269ce7ff"), "O", "O" },
                    { new Guid("48c79850-c45e-45fc-ab67-8dbb8b507381"), "H", "H" },
                    { new Guid("6cbf61e8-2cdf-4955-9b82-8f625b634b31"), "N", "N" },
                    { new Guid("7dc094d4-6e3a-4eaa-9fe6-fe470e435a93"), "B", "B" },
                    { new Guid("888cdbb0-0a4f-463c-9e82-15dd848dde13"), "I", "I" },
                    { new Guid("8d0c0a02-e38d-4d8f-b248-d4cc1012457a"), "A", "A" },
                    { new Guid("981ccb8f-7f66-4fa1-9c99-1345638e3435"), "D", "D" },
                    { new Guid("b1ebdfc1-7356-4878-b8fb-26886f26f53b"), "C", "C" },
                    { new Guid("cb19c297-72ca-43ca-8f2a-c3e1de433856"), "M", "M" },
                    { new Guid("d3d6fde4-591e-408a-845e-c605e975ccf3"), "E", "E" },
                    { new Guid("f026b15e-7545-4bfe-822e-9d300b0f3161"), "G", "G" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("0436ff8f-a31f-462a-9138-83ab51a9a4a3"), "sekundært økodiversitetsnivå", "SE" },
                    { new Guid("267c8729-02f5-4e39-adc8-2152956d170a"), "livsmedium", "LI" },
                    { new Guid("4ff17bd0-b4ab-40f8-9690-4a759068db81"), "landformvariasjon", "LV" },
                    { new Guid("a77cb14c-8b81-4efd-b013-8ce9fec8c356"), "primært økodiversitetsnivå", "PE" },
                    { new Guid("ac012d20-3d4f-4618-973e-348b59fc326d"), "marine vannmasser", "MV" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("0376d3f2-721d-42e3-957e-3185ed821ca4"), "elveløp", "EL" },
                    { new Guid("13051329-cd59-4516-8386-e155aab522e7"), "naturkompleks", "NK" },
                    { new Guid("1bd12aa1-11e1-4128-8fe0-90d94457ea7e"), "landformer i fast fjell og løsmasser", "FL" },
                    { new Guid("4c437ff9-3145-4932-8e8c-473c061e10b9"), "torvmarksmassiv", "TM" },
                    { new Guid("69cf6147-43fe-4a59-abb8-9cf673978279"), "natursystem", "NA" },
                    { new Guid("7d38d1a4-6163-4750-b8e8-ae173c4fa7e7"), "innsjøbasseng", "IB" },
                    { new Guid("b0c25309-c6b5-4301-835d-dc4197dd896b"), "bremassiv", "BM" },
                    { new Guid("cd814bf5-5345-41ea-a063-44c8cdd95825"), "landskapstype", "LA" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("1b43fad6-a3a0-4ff2-9163-f38b8aade99f"), "vannmassesystemer", "VM" },
                    { new Guid("88c9be1b-c64f-4893-bc1b-b60c5afd5dec"), "mark- og bunnsystemer", "MB" }
                });

            migrationBuilder.InsertData(
                table: "domene",
                columns: new[] { "Id", "Navn" },
                values: new object[] { new Guid("3b682481-d0f8-4edc-9b8e-2ba35bf30fc3"), "3.0" });

            migrationBuilder.AddForeignKey(
                name: "FK_Hovedtypegruppe_Typekategori2_Typekategori2Id",
                table: "Hovedtypegruppe",
                column: "Typekategori2Id",
                principalTable: "Typekategori2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
