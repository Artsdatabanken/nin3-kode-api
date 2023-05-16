using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NiN3KodeAPI.Migrations
{
    public partial class variabelgruppe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Domene",
                keyColumn: "Id",
                keyValue: new Guid("8024a183-9cce-4d61-bea2-6fec9c207ec9"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivaa",
                keyColumn: "Id",
                keyValue: new Guid("3b1dab44-8562-41bf-a4b6-22f89c0824a2"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivaa",
                keyColumn: "Id",
                keyValue: new Guid("4fe545c7-17a7-4f10-83e3-244c65307a23"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivaa",
                keyColumn: "Id",
                keyValue: new Guid("503bd8e4-d781-48b9-b227-21e005a29af6"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("41a1bd99-d666-49e2-ac31-1f1bb7207705"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("7c6c6c11-2d99-4b64-a645-67043c2a3628"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("9f11090a-a415-49b7-89ea-4f213661227e"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("a2afc6ca-6d2f-4bcb-8bfc-ba7450ed7b37"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("a302a814-e5e7-4c36-a609-efb83b52ea29"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("e5a04723-6a38-4867-b7ab-6d97701b8dd1"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("07f6cbd4-77c6-43af-a3d7-6ee24b1126ea"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("21dbd023-f1a8-4dba-8de8-1c846779c106"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("5af5138f-4e08-4288-ac6d-9efc76ae7940"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("7a4ebba8-037d-4738-a30a-eb5ac910d1b9"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("8b6bf6f2-3f34-4fb2-b618-ea1e8a560785"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("8e077c5c-a072-47a6-8c1c-66a0f8856cb2"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("97b86afb-73f0-4a9a-b7db-6d97c9e949ca"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("ae93b65b-f246-43f8-b625-889f06adfaaf"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("afc5cbfe-2f87-4f6f-b337-7b75bbeda21b"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("c96ea63a-a34c-4b9c-93e6-9fd4b11adbc8"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("dd2db91f-9bab-41bf-896e-2bc897d56b33"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("e4678e8d-4e8c-4c6f-beae-9251734f648e"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("e724609a-b036-4119-b5ba-3f583316d01b"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("f36d6f31-dc4c-46d8-a366-e0cb80d92f8f"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("f53e33d5-44ad-4415-9555-da15b951af56"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("f5d32d52-8e66-42b5-bf66-2faacfe8c0c4"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("087daf6d-1df2-4d46-bdac-d5269c7880dd"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("6943b4e3-2cfd-4303-bd3c-d5bd938aab01"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("7635a7db-9895-4429-b304-88ed1e1821ec"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("a9dc5d91-98cd-4dc1-b9c9-0dc7d3c6c2ce"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("e6ba9540-d33c-4313-a1f2-2c52ecd384a6"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("2b37ebfc-befa-40e7-91cf-903af973eda6"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("636fafbb-fa09-42d6-9eea-5eb521971323"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("a1389c5d-76a3-4b71-8fd3-d147b6ac961d"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("ae9e496b-b044-4ef5-8cce-d8a8a2b027d0"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("b0c55c5f-2d66-4449-acae-0069d7400d0b"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("d8c3357c-af29-4fc0-b03c-b9daade3857b"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("e33a6d9e-fff1-4d5a-8141-e71451ac2f39"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("eaa20eeb-981f-4abc-9182-47a2ad8b6623"));

            migrationBuilder.DeleteData(
                table: "Typekategori3",
                keyColumn: "Id",
                keyValue: new Guid("b2c048cd-ff92-4b2d-a0f8-e2a8a03146a7"));

            migrationBuilder.DeleteData(
                table: "Typekategori3",
                keyColumn: "Id",
                keyValue: new Guid("d26897b7-6628-4143-943a-387e98b368e8"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori",
                keyColumn: "Id",
                keyValue: new Guid("485f8f84-cefd-4caa-a2dd-51edb30f93ff"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori",
                keyColumn: "Id",
                keyValue: new Guid("56cf49b5-a7a9-4e40-82f6-66a5f7dd3a3d"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("19d2c01c-627e-4166-94dc-9d058b228ca6"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("1b241896-a567-4435-b390-2131e846cf9e"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("260b09b0-fb0f-4974-9c95-9fc73fa0b3c8"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("6bf7bb8a-bb0b-4535-a52a-e44835e0c888"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("7c8ff245-4e96-4962-94fd-afccb6ecaf08"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("8ac3b854-c67f-4d70-8a8e-d02a9d9eae34"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("9370e320-b34b-4d6b-938b-53f8a295eb2b"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("940a9985-e4cb-4686-a783-0fc3c9ea7fe1"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("965fc22e-07a3-4f1a-a7d1-dacd98f7d3d5"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("9d85f563-c5c5-443b-b76a-949a085739cd"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("9f7024b5-c500-4196-8c85-a5a0be8b4908"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("c2f51e8e-0285-4256-a6ff-a451067a3800"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("ce8c5e16-4d81-45c1-a948-4c82061bad4d"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("d55c97bf-8ae0-4947-a0b2-7b6f2ee46c13"));

            migrationBuilder.DeleteData(
                table: "Variabeltype",
                keyColumn: "Id",
                keyValue: new Guid("16fbff5b-5af3-4796-ab13-b9a7faa3c5dd"));

            migrationBuilder.DeleteData(
                table: "Variabeltype",
                keyColumn: "Id",
                keyValue: new Guid("31d28776-c8df-42b0-b55d-a51b79175358"));

            migrationBuilder.DeleteData(
                table: "Variabeltype",
                keyColumn: "Id",
                keyValue: new Guid("bbf1dc54-94e8-4213-8993-f65bd0e7c143"));

            migrationBuilder.DeleteData(
                table: "Variabeltype",
                keyColumn: "Id",
                keyValue: new Guid("e01545d2-20c8-47b9-b88d-e6b42a7a465e"));

            migrationBuilder.CreateTable(
                name: "Variabelgruppe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Kode = table.Column<string>(type: "TEXT", nullable: false),
                    Beskrivelse = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variabelgruppe", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Domene",
                columns: new[] { "Id", "Navn" },
                values: new object[] { new Guid("f5ba9df1-de9a-40de-b36d-81a99653312b"), "3.0" });

            migrationBuilder.InsertData(
                table: "Ecosystnivaa",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("941b5dda-cbbe-4416-9e3b-a2ccbe7fd769"), "abiotisk", "A" });

            migrationBuilder.InsertData(
                table: "Ecosystnivaa",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9b6dcc36-eeaa-4283-bc6d-fbb1863d487f"), "biotisk", "B" });

            migrationBuilder.InsertData(
                table: "Ecosystnivaa",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d3b0dcbe-3689-4bb1-b30d-d1a4c41fdaa2"), "økodiversitet", "C" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("11061cd1-90f7-47ae-b3ba-21c74d0a0153"), "kartleggingsenhet tilpasset 1:5000", "005K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("428ed318-7b13-4768-96ae-a7479cec4168"), "kartleggingsenhet tilpasset 1:20 000", "020K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("68f43148-edf9-4e1d-993c-9b6ade23f775"), "kartleggingsenhet tilpasset 1:50 000", "050K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("ab332908-eefe-4ed2-99ef-49dab60bed11"), "kartleggingsenhet tilpasset 1:10 000", "010K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("ae1fd731-2bf7-4956-8da4-cc0203e0779e"), "grunntype", "G" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("be5677f2-ad34-4459-b064-051f253d7339"), "kartleggingsenhet tilpasset 1:100 000", "100K" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("0b0ec1ca-8f37-4ccc-8280-913ab544a5ff"), "A", "A" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("17f7a898-9114-4a12-995b-912ac9620054"), "N", "N" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("23b34728-1eaf-4358-8023-8127c5f3a9f0"), "J", "J" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("25281fab-d33a-47da-b21f-eba772e762e8"), "O", "O" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("296e5ebd-11fb-4559-a252-d14a57926bac"), "E", "E" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("314f4aed-88db-46bd-82fd-be1409fe30b3"), "I", "I" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("384aeddb-54a4-4236-a4f9-7330fa8666b6"), "C", "C" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("75cd215d-ef92-47fd-9383-518c5d9db002"), "G", "G" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("78a321a6-1667-4f97-b314-6b37ce980758"), "Ikke angitt", "0" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("94b7a9c8-1a7d-483c-9390-c9b346efe469"), "B", "B" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9d16c459-7a8a-4b9a-ac8b-c7b180150ab6"), "M", "M" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9dec75fa-b6eb-4596-ad6d-7995e38b1944"), "D", "D" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("b4d32f82-58c9-49f0-9ea9-020f229b2e8f"), "L", "L" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("c5c7f807-b8f8-4ca2-b6a3-630b72e672fb"), "K", "K" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("eb93d97c-20a2-44ab-8d90-f34260e864f1"), "H", "H" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("f76f3e2b-bbd6-43bd-aed0-6f4bcb40c4ac"), "F", "F" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("0ca5b7b4-224a-44a5-9bc0-d6f2d9ffe257"), "primært økodiversitetsnivå", "PE" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("5432c6b2-7afe-4e40-9812-1d06b2d1699d"), "livsmedium", "LI" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("5bbb768c-ffb9-44a5-9f4d-7d48ebdfe336"), "landformvariasjon", "LV" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("802a52c4-15a4-4d16-a474-624a2de7f693"), "sekundært økodiversitetsnivå", "SE" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("8f87d5eb-ba1d-487d-b037-3d1a316d743d"), "marine vannmasser", "MV" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("0073c05e-ef0e-41ba-9cf1-c2e6a48454b0"), "elveløp", "EL" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("2a84ff69-2c91-4b82-878e-b63ed66fcd0a"), "natursystem", "NA" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("5e340153-1548-4619-8b45-9ebdf5d1394c"), "bremassiv", "BM" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("8d8456e8-9d9e-4eff-ae34-7143ed00eea6"), "landskapstype", "LA" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("8f299742-a6a0-4975-b9ab-36a96f4b6ee3"), "innsjøbasseng", "IB" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("b511bf09-13f5-48fa-b295-44423da97a8f"), "naturkompleks", "NK" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("ba5695fb-e754-44b4-8434-59ef8be76c94"), "torvmarksmassiv", "TM" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("f6276f3f-aa2d-4cfe-893a-997fbd565a01"), "landformer i fast fjell og løsmasser", "FL" });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("f4034d7d-f392-45ba-b3fd-09f0916951b3"), "mark- og bunnsystemer", "MB" });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("fca564d6-005c-4cdd-ade0-0e1322be6261"), "vannmassesystemer", "VM" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("081c0087-ef48-4b8e-bfca-51e796578ee8"), "SB skogbruksrelaterte egeskaper", "SB skogbruksrelaterte egeskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("13620de7-a51d-49a7-ac09-bc2ab0605270"), "SB skogbruksrelaterte egenskaper", "SB skogbruksrelaterte egenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("1ec448ec-256e-404e-9dfd-6fadc492250b"), "DL liggende død ved (læger)", "DL liggende død ved (læger)" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("2d32d816-e800-4feb-a63e-0161ccf1306c"), "GT generelle terrengegenskaper", "GT generelle terrengegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("3058b2a4-b467-4c9c-bc36-22ccf2541930"), "AM artsforekomst/-mengde", "AM artsforekomst/-mengde" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("32af0b61-1f2a-4a22-bf29-d3c77a5d2a8c"), "GE generelle egenskaper", "GE generelle egenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("38c83231-e099-4d2a-bf68-79cc7dcaf73f"), "SU suksesjonsrelaterte egenskaper", "SU suksesjonsrelaterte egenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("4ca7d75b-58e8-47ef-b9ad-9ba682a2e782"), "TG gammelt tre", "TG gammelt tre" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("4dbba74b-d00b-4d03-8fe7-95ab5928ae18"), "TB torvmarksmassiv: myrstruktur", "TB torvmarksmassiv: myrstruktur" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("5168f34c-2260-4ee7-a82d-e0488b521b91"), "BO naturgitte breobjekter", "BO naturgitte breobjekter" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("51a1da49-4c04-4b38-bbe2-c647ab74b3a4"), "TA torvmarksmassiv: myrsegment", "TA torvmarksmassiv: myrsegment" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("55f04db9-eca0-4245-a80d-4eb56737ffaf"), "AG artsgruppesammensetning", "AG artsgruppesammensetning" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("621f89e7-ae64-40a6-9f64-fd626b330eca"), "TE generelle treegenskaper", "TE generelle treegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("6246513c-094b-4c70-bb8b-467924bfb2b2"), "OT menneskeskapt terrestrisk objekt", "OT menneskeskapt terrestrisk objekt" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("655fb8c1-8be1-45d6-a8ed-8e6d357d4eeb"), "SB skogbruksegenskaper", "SB skogbruksegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("69d3075b-39f4-457b-8124-075fc7a84eeb"), "W artsforekomst/-mengde", "W artsforekomst/-mengde" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("7657a33f-89bd-4921-ba09-ed890eb7b1ac"), "TC torvmarksmassiv: mikrostruktur", "TC torvmarksmassiv: mikrostruktur" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("7989f5ea-799f-44e9-aece-6fcb33f5a7af"), "OI menneskeskapt objekt i innsjø eller til havs", "OI menneskeskapt objekt i innsjø eller til havs" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("7c241c3c-b3b9-4b02-b7bc-792f241b0299"), "W W", "W W" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("841cc039-3c64-45da-80ba-1ac94edf15bb"), "FA fremmedartsegenskaper", "FA fremmedartsegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a2869a72-b2e9-4f41-83a4-da6f882243ca"), "TS trær med gitt størrelse", "TS trær med gitt størrelse" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a9cfd4b9-65df-4acf-9cb6-bd4676c5c330"), "EE elveløpsegenskaper", "EE elveløpsegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("b0ce8ee1-a871-4a0f-8d46-6a5a1cfef259"), "JB jordbruksrelaterte egenskaper", "JB jordbruksrelaterte egenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("bc086a2c-c14b-4da1-b3e9-02a5e55ecc71"), "TL tre med spesielt livsmedium", "TL tre med spesielt livsmedium" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("c6e52333-0f9c-4f81-bbd3-705110166df3"), "SE skogegenskaper", "SE skogegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("cbe8a960-443d-4ce9-affd-b997b1d8019d"), "OE menneskeskapt objekt i elv", "OE menneskeskapt objekt i elv" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("ce1df305-5517-4471-b4c7-89ba16a33683"), "AR relativ del-artsgruppesammensetning", "AR relativ del-artsgruppesammensetning" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("cf9bc9e2-40bd-4a94-8fde-d1a2c8639026"), "DR relativ sammensetning av død ved", "DR relativ sammensetning av død ved" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d0f9f516-ef15-43a4-add6-19e02a1e9df7"), "DG stående død ved (gadder)", "DG stående død ved (gadder)" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d4920d25-db38-4886-bd5f-19c32996924a"), "HE havegenskaper", "HE havegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d746bcf0-1e55-48ad-92b5-45c472f40caa"), "BE bremassivegenskaper", "BE bremassivegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d8f460ee-4a4e-4f27-be2f-51eeb99901a9"), "TM trær med gitt minstestørrelse", "TM trær med gitt minstestørrelse" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e3e553f4-f52f-4885-bcd8-e134fc1e75f8"), "EO andre naturgitte elveløpsobjekter", "EO andre naturgitte elveløpsobjekter" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("f02e1909-7b92-4aaf-8166-03d1a61b55b5"), "IE innsjøbassengegenskaper", "IE innsjøbassengegenskaper" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("f26b8a7b-0ec5-47e9-82db-3925e4a42dd9"), "EB elvebanker", "EB elvebanker" });

            migrationBuilder.InsertData(
                table: "Variabelgruppe",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("f3ed0009-2dea-4617-a226-aae42f810804"), "IO naturgitte innsjøobjekter", "IO naturgitte innsjøobjekter" });

            migrationBuilder.InsertData(
                table: "Variabelkategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("4ea06d5e-542b-48f2-9fda-843d6331b38b"), "naturgitt", "N" });

            migrationBuilder.InsertData(
                table: "Variabelkategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d62830da-ffd4-44f3-97af-e5c6f9649ef8"), "mennekebetinget", "M" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("08a998da-1963-40b8-bd48-8922f9e680bb"), "landform-objekter", "LO" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("1213fd0f-10a2-431a-9de2-33872e774fc8"), "naturgitt objekt", "NO" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("29e08dee-7c4a-4269-b3f9-5b6b9d76e0c2"), "bergarter", "BE" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("2ad45eb2-722d-46fa-a863-c640f94c1756"), "vertikal struktur", "VS" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("5cb204ee-5feb-4050-9d7a-548b9fcad080"), "artssammensetningsdynamikk", "AD" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("74d61a6f-c714-4c96-8701-dfacc0b1aaee"), "lokal miljøvariabel", "LM" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("7b459aeb-1023-4810-be3f-4094191756af"), "romlig strukturvariasjon", "RS" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9be0bbf9-7478-49e5-a498-9f65eb71ce90"), "regional miljøvariabel", "RM" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9ea3a365-f4fd-4f3e-940f-384e8b9c218f"), "strukturerende og funksjonelle artsgrupper", "SA" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a8a63710-0477-432f-af80-ee6f8d045523"), "miljødynamikk", "MD" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("afb433e8-44a1-45ad-a5d2-2a6c00f79bff"), "korttidsmiljøvariabel", "KM" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("c267dcd0-16f9-48e0-925a-d4c3a5988571"), "menneskeskapt objekt", "MO" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d39933e6-4aff-4a5f-a818-23fc716ca06f"), "terrengformvariasjon", "TF" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("df2a28e2-3f54-4391-9d56-73e5ca54dd9c"), "romlig artsfordelingsmønster", "RA" });

            migrationBuilder.InsertData(
                table: "Variabeltype",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9b0dba26-b5ee-4bce-a4ad-5716ec274620"), "enkel gradient", "GE" });

            migrationBuilder.InsertData(
                table: "Variabeltype",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("b6fa1f07-03b7-4210-a8ae-de960edf0e41"), "kompleks, ikke-ordnet faktorvariabel", "FK" });

            migrationBuilder.InsertData(
                table: "Variabeltype",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("c1fb504d-c22c-42d5-b20b-6e1dbcff7ce7"), "kompleks gradient", "GK" });

            migrationBuilder.InsertData(
                table: "Variabeltype",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d6757587-d072-4aeb-bccc-8a6ab6f0ceba"), "enkel, ikke-ordnet faktorvariabel", "FE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Variabelgruppe");

            migrationBuilder.DeleteData(
                table: "Domene",
                keyColumn: "Id",
                keyValue: new Guid("f5ba9df1-de9a-40de-b36d-81a99653312b"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivaa",
                keyColumn: "Id",
                keyValue: new Guid("941b5dda-cbbe-4416-9e3b-a2ccbe7fd769"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivaa",
                keyColumn: "Id",
                keyValue: new Guid("9b6dcc36-eeaa-4283-bc6d-fbb1863d487f"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivaa",
                keyColumn: "Id",
                keyValue: new Guid("d3b0dcbe-3689-4bb1-b30d-d1a4c41fdaa2"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("11061cd1-90f7-47ae-b3ba-21c74d0a0153"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("428ed318-7b13-4768-96ae-a7479cec4168"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("68f43148-edf9-4e1d-993c-9b6ade23f775"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("ab332908-eefe-4ed2-99ef-49dab60bed11"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("ae1fd731-2bf7-4956-8da4-cc0203e0779e"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("be5677f2-ad34-4459-b064-051f253d7339"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("0b0ec1ca-8f37-4ccc-8280-913ab544a5ff"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("17f7a898-9114-4a12-995b-912ac9620054"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("23b34728-1eaf-4358-8023-8127c5f3a9f0"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("25281fab-d33a-47da-b21f-eba772e762e8"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("296e5ebd-11fb-4559-a252-d14a57926bac"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("314f4aed-88db-46bd-82fd-be1409fe30b3"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("384aeddb-54a4-4236-a4f9-7330fa8666b6"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("75cd215d-ef92-47fd-9383-518c5d9db002"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("78a321a6-1667-4f97-b314-6b37ce980758"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("94b7a9c8-1a7d-483c-9390-c9b346efe469"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("9d16c459-7a8a-4b9a-ac8b-c7b180150ab6"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("9dec75fa-b6eb-4596-ad6d-7995e38b1944"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("b4d32f82-58c9-49f0-9ea9-020f229b2e8f"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("c5c7f807-b8f8-4ca2-b6a3-630b72e672fb"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("eb93d97c-20a2-44ab-8d90-f34260e864f1"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("f76f3e2b-bbd6-43bd-aed0-6f4bcb40c4ac"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("0ca5b7b4-224a-44a5-9bc0-d6f2d9ffe257"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("5432c6b2-7afe-4e40-9812-1d06b2d1699d"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("5bbb768c-ffb9-44a5-9f4d-7d48ebdfe336"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("802a52c4-15a4-4d16-a474-624a2de7f693"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("8f87d5eb-ba1d-487d-b037-3d1a316d743d"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("0073c05e-ef0e-41ba-9cf1-c2e6a48454b0"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("2a84ff69-2c91-4b82-878e-b63ed66fcd0a"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("5e340153-1548-4619-8b45-9ebdf5d1394c"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("8d8456e8-9d9e-4eff-ae34-7143ed00eea6"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("8f299742-a6a0-4975-b9ab-36a96f4b6ee3"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("b511bf09-13f5-48fa-b295-44423da97a8f"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("ba5695fb-e754-44b4-8434-59ef8be76c94"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("f6276f3f-aa2d-4cfe-893a-997fbd565a01"));

            migrationBuilder.DeleteData(
                table: "Typekategori3",
                keyColumn: "Id",
                keyValue: new Guid("f4034d7d-f392-45ba-b3fd-09f0916951b3"));

            migrationBuilder.DeleteData(
                table: "Typekategori3",
                keyColumn: "Id",
                keyValue: new Guid("fca564d6-005c-4cdd-ade0-0e1322be6261"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori",
                keyColumn: "Id",
                keyValue: new Guid("4ea06d5e-542b-48f2-9fda-843d6331b38b"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori",
                keyColumn: "Id",
                keyValue: new Guid("d62830da-ffd4-44f3-97af-e5c6f9649ef8"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("08a998da-1963-40b8-bd48-8922f9e680bb"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("1213fd0f-10a2-431a-9de2-33872e774fc8"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("29e08dee-7c4a-4269-b3f9-5b6b9d76e0c2"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("2ad45eb2-722d-46fa-a863-c640f94c1756"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("5cb204ee-5feb-4050-9d7a-548b9fcad080"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("74d61a6f-c714-4c96-8701-dfacc0b1aaee"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("7b459aeb-1023-4810-be3f-4094191756af"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("9be0bbf9-7478-49e5-a498-9f65eb71ce90"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("9ea3a365-f4fd-4f3e-940f-384e8b9c218f"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("a8a63710-0477-432f-af80-ee6f8d045523"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("afb433e8-44a1-45ad-a5d2-2a6c00f79bff"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("c267dcd0-16f9-48e0-925a-d4c3a5988571"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("d39933e6-4aff-4a5f-a818-23fc716ca06f"));

            migrationBuilder.DeleteData(
                table: "Variabelkategori2",
                keyColumn: "Id",
                keyValue: new Guid("df2a28e2-3f54-4391-9d56-73e5ca54dd9c"));

            migrationBuilder.DeleteData(
                table: "Variabeltype",
                keyColumn: "Id",
                keyValue: new Guid("9b0dba26-b5ee-4bce-a4ad-5716ec274620"));

            migrationBuilder.DeleteData(
                table: "Variabeltype",
                keyColumn: "Id",
                keyValue: new Guid("b6fa1f07-03b7-4210-a8ae-de960edf0e41"));

            migrationBuilder.DeleteData(
                table: "Variabeltype",
                keyColumn: "Id",
                keyValue: new Guid("c1fb504d-c22c-42d5-b20b-6e1dbcff7ce7"));

            migrationBuilder.DeleteData(
                table: "Variabeltype",
                keyColumn: "Id",
                keyValue: new Guid("d6757587-d072-4aeb-bccc-8a6ab6f0ceba"));

            migrationBuilder.InsertData(
                table: "Domene",
                columns: new[] { "Id", "Navn" },
                values: new object[] { new Guid("8024a183-9cce-4d61-bea2-6fec9c207ec9"), "3.0" });

            migrationBuilder.InsertData(
                table: "Ecosystnivaa",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("3b1dab44-8562-41bf-a4b6-22f89c0824a2"), "økodiversitet", "C" });

            migrationBuilder.InsertData(
                table: "Ecosystnivaa",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("4fe545c7-17a7-4f10-83e3-244c65307a23"), "abiotisk", "A" });

            migrationBuilder.InsertData(
                table: "Ecosystnivaa",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("503bd8e4-d781-48b9-b227-21e005a29af6"), "biotisk", "B" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("41a1bd99-d666-49e2-ac31-1f1bb7207705"), "kartleggingsenhet tilpasset 1:50 000", "050K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("7c6c6c11-2d99-4b64-a645-67043c2a3628"), "kartleggingsenhet tilpasset 1:10 000", "010K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9f11090a-a415-49b7-89ea-4f213661227e"), "kartleggingsenhet tilpasset 1:20 000", "020K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a2afc6ca-6d2f-4bcb-8bfc-ba7450ed7b37"), "kartleggingsenhet tilpasset 1:100 000", "100K" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a302a814-e5e7-4c36-a609-efb83b52ea29"), "grunntype", "G" });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e5a04723-6a38-4867-b7ab-6d97701b8dd1"), "kartleggingsenhet tilpasset 1:5000", "005K" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("07f6cbd4-77c6-43af-a3d7-6ee24b1126ea"), "C", "C" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("21dbd023-f1a8-4dba-8de8-1c846779c106"), "B", "B" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("5af5138f-4e08-4288-ac6d-9efc76ae7940"), "N", "N" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("7a4ebba8-037d-4738-a30a-eb5ac910d1b9"), "G", "G" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("8b6bf6f2-3f34-4fb2-b618-ea1e8a560785"), "A", "A" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("8e077c5c-a072-47a6-8c1c-66a0f8856cb2"), "L", "L" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("97b86afb-73f0-4a9a-b7db-6d97c9e949ca"), "Ikke angitt", "0" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("ae93b65b-f246-43f8-b625-889f06adfaaf"), "K", "K" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("afc5cbfe-2f87-4f6f-b337-7b75bbeda21b"), "F", "F" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("c96ea63a-a34c-4b9c-93e6-9fd4b11adbc8"), "D", "D" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("dd2db91f-9bab-41bf-896e-2bc897d56b33"), "J", "J" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e4678e8d-4e8c-4c6f-beae-9251734f648e"), "M", "M" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e724609a-b036-4119-b5ba-3f583316d01b"), "H", "H" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("f36d6f31-dc4c-46d8-a366-e0cb80d92f8f"), "I", "I" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("f53e33d5-44ad-4415-9555-da15b951af56"), "E", "E" });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("f5d32d52-8e66-42b5-bf66-2faacfe8c0c4"), "O", "O" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("087daf6d-1df2-4d46-bdac-d5269c7880dd"), "landformvariasjon", "LV" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("6943b4e3-2cfd-4303-bd3c-d5bd938aab01"), "sekundært økodiversitetsnivå", "SE" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("7635a7db-9895-4429-b304-88ed1e1821ec"), "primært økodiversitetsnivå", "PE" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a9dc5d91-98cd-4dc1-b9c9-0dc7d3c6c2ce"), "marine vannmasser", "MV" });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e6ba9540-d33c-4313-a1f2-2c52ecd384a6"), "livsmedium", "LI" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("2b37ebfc-befa-40e7-91cf-903af973eda6"), "innsjøbasseng", "IB" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("636fafbb-fa09-42d6-9eea-5eb521971323"), "bremassiv", "BM" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("a1389c5d-76a3-4b71-8fd3-d147b6ac961d"), "torvmarksmassiv", "TM" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("ae9e496b-b044-4ef5-8cce-d8a8a2b027d0"), "landformer i fast fjell og løsmasser", "FL" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("b0c55c5f-2d66-4449-acae-0069d7400d0b"), "naturkompleks", "NK" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d8c3357c-af29-4fc0-b03c-b9daade3857b"), "elveløp", "EL" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e33a6d9e-fff1-4d5a-8141-e71451ac2f39"), "natursystem", "NA" });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("eaa20eeb-981f-4abc-9182-47a2ad8b6623"), "landskapstype", "LA" });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("b2c048cd-ff92-4b2d-a0f8-e2a8a03146a7"), "vannmassesystemer", "VM" });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d26897b7-6628-4143-943a-387e98b368e8"), "mark- og bunnsystemer", "MB" });

            migrationBuilder.InsertData(
                table: "Variabelkategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("485f8f84-cefd-4caa-a2dd-51edb30f93ff"), "mennekebetinget", "M" });

            migrationBuilder.InsertData(
                table: "Variabelkategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("56cf49b5-a7a9-4e40-82f6-66a5f7dd3a3d"), "naturgitt", "N" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("19d2c01c-627e-4166-94dc-9d058b228ca6"), "strukturerende og funksjonelle artsgrupper", "SA" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("1b241896-a567-4435-b390-2131e846cf9e"), "artssammensetningsdynamikk", "AD" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("260b09b0-fb0f-4974-9c95-9fc73fa0b3c8"), "romlig strukturvariasjon", "RS" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("6bf7bb8a-bb0b-4535-a52a-e44835e0c888"), "romlig artsfordelingsmønster", "RA" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("7c8ff245-4e96-4962-94fd-afccb6ecaf08"), "korttidsmiljøvariabel", "KM" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("8ac3b854-c67f-4d70-8a8e-d02a9d9eae34"), "terrengformvariasjon", "TF" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9370e320-b34b-4d6b-938b-53f8a295eb2b"), "miljødynamikk", "MD" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("940a9985-e4cb-4686-a783-0fc3c9ea7fe1"), "naturgitt objekt", "NO" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("965fc22e-07a3-4f1a-a7d1-dacd98f7d3d5"), "regional miljøvariabel", "RM" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9d85f563-c5c5-443b-b76a-949a085739cd"), "landform-objekter", "LO" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("9f7024b5-c500-4196-8c85-a5a0be8b4908"), "bergarter", "BE" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("c2f51e8e-0285-4256-a6ff-a451067a3800"), "vertikal struktur", "VS" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("ce8c5e16-4d81-45c1-a948-4c82061bad4d"), "lokal miljøvariabel", "LM" });

            migrationBuilder.InsertData(
                table: "Variabelkategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("d55c97bf-8ae0-4947-a0b2-7b6f2ee46c13"), "menneskeskapt objekt", "MO" });

            migrationBuilder.InsertData(
                table: "Variabeltype",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("16fbff5b-5af3-4796-ab13-b9a7faa3c5dd"), "enkel, ikke-ordnet faktorvariabel", "FE" });

            migrationBuilder.InsertData(
                table: "Variabeltype",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("31d28776-c8df-42b0-b55d-a51b79175358"), "kompleks gradient", "GK" });

            migrationBuilder.InsertData(
                table: "Variabeltype",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("bbf1dc54-94e8-4213-8993-f65bd0e7c143"), "kompleks, ikke-ordnet faktorvariabel", "FK" });

            migrationBuilder.InsertData(
                table: "Variabeltype",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[] { new Guid("e01545d2-20c8-47b9-b88d-e6b42a7a465e"), "enkel gradient", "GE" });
        }
    }
}
