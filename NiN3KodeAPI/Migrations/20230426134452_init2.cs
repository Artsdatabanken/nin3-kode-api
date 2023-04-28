using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NiN3KodeAPI.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Type_Typekategori2_Typekategori2Id",
                table: "Type");

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("11c7ada4-87df-41e2-97f7-98201c93a1ac"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("8f4f79e4-4bc8-49ea-a491-176b4aa0b565"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("aa29179e-5055-4f62-b7ac-73dad8fa6330"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("106a357d-6ea6-4c36-aaff-66b6b397ccd0"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("4d978e1f-5922-48ad-92a5-1f00d38c452f"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("4f462294-d679-40b5-9d4b-390f4ec5c9eb"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("547c5e0b-186b-4f1b-bc3a-d842073be832"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("810c297f-3173-45fb-812e-25fc31bbf285"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("a8b5a81f-7ed6-43c9-8d2d-e25c957e5ae0"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("0905bb19-6d75-4c77-8fd1-3acef420dba9"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("26838b8c-da4a-43b0-958e-bae954e33ae7"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("6cd02757-f959-4347-98f6-c7cb78ba41b2"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("762b2b1e-f204-42dc-bdd3-06b462cc52d8"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("7c061b16-048e-4af9-9be9-8e1111bfe019"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("8ac0b7b9-95f0-4fd4-bd3b-1deaaa9d22f6"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("8ae20e55-181c-4cf2-8402-60b10c6dd54c"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("8b8d6124-3281-401c-932b-087edd5cce4c"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("ae5b4f06-c378-4470-8db8-e86534a31cf1"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("b554a112-db5d-40e6-bf23-bf392afecc61"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("c25a75c7-aa35-47be-90b4-e3faf3d69e07"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("cdbf7ece-3dd9-4b49-bfd7-777327e3135e"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("e72f3e05-20aa-4fb4-ae35-1537c74830e4"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("f2db4103-5bc1-45e5-84b6-6c95eee7cb95"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("f657ad4d-a0d5-4211-a1d2-f120b2aa4b9d"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("09cb2cb3-42c5-4aca-8a0b-7b916ee749d6"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("7b972e3c-f2c9-4ee6-a60e-d9ab9ca597f5"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("bc067a1b-756f-4141-8007-ef09e5942ef3"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("cb1383be-2090-40b4-984a-7bc8ad8dada7"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("f6f4d140-7c8a-4720-8ae2-5a80e347ccf1"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("0de07b92-5d22-45a5-a607-b7ee3087ecdb"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("0e4388f7-00ea-4118-aa74-49dd87940914"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("4e8416d0-8dca-45ee-88d0-6d5b6738686c"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("902b89c5-4b5a-4f6d-8a6f-ca077315e862"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("f24b611d-8cb9-4586-ab58-46aec19190ea"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("f938f305-7b43-44db-876d-d0ef171cd00c"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("faaaae2d-a94e-4612-ac6c-3d8f8a9ec3cb"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("faab5b3c-eb86-418a-9ec8-95415ba2ca15"));

            migrationBuilder.DeleteData(
                table: "Typekategori3",
                keyColumn: "Id",
                keyValue: new Guid("19713000-5712-4a91-8f87-0cb906e83004"));

            migrationBuilder.DeleteData(
                table: "Typekategori3",
                keyColumn: "Id",
                keyValue: new Guid("20c9b7ea-d683-4a3e-8fa9-87b40af1f724"));

            migrationBuilder.DeleteData(
                table: "domene",
                keyColumn: "Id",
                keyValue: new Guid("3ce9268b-ea16-4185-a24c-44adf835e99d"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Typekategori2Id",
                table: "Type",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Ecosystnivå",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("03547635-15e4-4937-9f3d-94f62718821c"), "abiotisk", "A" },
                    { new Guid("66bd8a43-2922-423c-a5b1-a960e6212caf"), "biotisk", "B" },
                    { new Guid("f8185130-66fd-41fe-87c8-297cce508b24"), "økodiversitet", "C" }
                });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("14f913f1-d43d-4a17-9519-de5891be97e7"), "kartleggingsenhet tilpasset 1:5000", "005K" },
                    { new Guid("71f9518d-c6cd-44e6-84d2-3e082b68942c"), "grunntype", "G" },
                    { new Guid("88e6000a-5c10-452c-97b7-db418be9038d"), "kartleggingsenhet tilpasset 1:10 000", "010K" },
                    { new Guid("a3ec6065-710c-4dda-8fc8-59afdd1f75d5"), "kartleggingsenhet tilpasset 1:50 000", "050K" },
                    { new Guid("c10ab970-99b3-40c8-9808-e4faf13440f6"), "kartleggingsenhet tilpasset 1:100 000", "100K" },
                    { new Guid("e61d6697-af8e-4c3d-90d4-75becf8060cf"), "kartleggingsenhet tilpasset 1:20 000", "020K" }
                });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("2c14bf0e-b2de-445d-9066-5c726ae6f1ff"), "K", "K" },
                    { new Guid("37841b3a-a7cc-47f5-8f4f-bd8b51e1e5ad"), "G", "G" },
                    { new Guid("454fac4f-1db6-496a-ab45-55fe2b45e898"), "M", "M" },
                    { new Guid("492679a5-e628-4003-8f66-7a29f4e22714"), "D", "D" },
                    { new Guid("6b6dc872-fea6-4639-9546-5b7c3504d533"), "H", "H" },
                    { new Guid("77f7c734-3b71-4199-9ca2-e662c0720087"), "O", "O" },
                    { new Guid("9460e79b-9047-459c-8b8c-eac5bf138d05"), "C", "C" },
                    { new Guid("97756e1b-0ec0-4c40-8671-3d2d80514570"), "B", "B" },
                    { new Guid("aafcd636-24f0-4e95-a84a-0a8a118af410"), "J", "J" },
                    { new Guid("b5b895fb-9ef6-4562-a538-249fbd8925e5"), "N", "N" },
                    { new Guid("bc74ce7c-23f0-4e19-8f14-828f450e9f2a"), "L", "L" },
                    { new Guid("cd247bd1-e6af-4944-b4be-aebfc21c1331"), "F", "F" },
                    { new Guid("d1904299-7c48-40ce-8af0-2087b627b027"), "E", "E" },
                    { new Guid("e54a9153-2064-4eaa-96dc-761496b5ea93"), "A", "A" },
                    { new Guid("ea992126-7180-43f9-bf12-6a0c9c116fa7"), "I", "I" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("4e86a0f6-d687-4d70-8332-4222d627aee3"), "primært økodiversitetsnivå", "PE" },
                    { new Guid("647f50cc-7569-4383-9f4d-18df50f959a0"), "sekundært økodiversitetsnivå", "SE" },
                    { new Guid("6deb7afe-3e93-4544-8de1-d9de69436b1c"), "livsmedium", "LI" },
                    { new Guid("d5ce3251-06b8-4c62-abb4-4efbc1fd51a0"), "landformvariasjon", "LV" },
                    { new Guid("de3b01b4-f4ed-4ca8-bbe6-c4504304e160"), "marine vannmasser", "MV" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("05056a56-a023-42a4-988c-e5475377e562"), "landskapstype", "LA" },
                    { new Guid("0d0ffcdd-485e-4b17-9fc4-2d582026a9a9"), "natursystem", "NA" },
                    { new Guid("273e7b8f-e1da-4249-936d-0dfeaebe4851"), "bremassiv", "BM" },
                    { new Guid("2d9d31db-65d6-494a-ba4b-6f7539e406c6"), "elveløp", "EL" },
                    { new Guid("2e0e35fd-e862-4cc8-977f-b64cfa80634e"), "innsjøbasseng", "IB" },
                    { new Guid("98d8b37b-7567-4802-a02c-f4b54076fe58"), "landformer i fast fjell og løsmasser", "FL" },
                    { new Guid("a89a0d5b-a1c8-4755-b77f-776df46397fb"), "torvmarksmassiv", "TM" },
                    { new Guid("ae344ade-f294-4b88-bbee-5222930a2c6a"), "naturkompleks", "NK" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("6b0626d2-792e-4a42-b107-ec164e21ac46"), "vannmassesystemer", "VM" },
                    { new Guid("cb68c8b7-c721-4576-ba30-a9d96fb18b3f"), "mark- og bunnsystemer", "MB" }
                });

            migrationBuilder.InsertData(
                table: "domene",
                columns: new[] { "Id", "Navn" },
                values: new object[] { new Guid("01613e0f-41a2-4855-90dd-72ee35d79db9"), "3.0" });

            migrationBuilder.AddForeignKey(
                name: "FK_Type_Typekategori2_Typekategori2Id",
                table: "Type",
                column: "Typekategori2Id",
                principalTable: "Typekategori2",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Type_Typekategori2_Typekategori2Id",
                table: "Type");

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("03547635-15e4-4937-9f3d-94f62718821c"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("66bd8a43-2922-423c-a5b1-a960e6212caf"));

            migrationBuilder.DeleteData(
                table: "Ecosystnivå",
                keyColumn: "Id",
                keyValue: new Guid("f8185130-66fd-41fe-87c8-297cce508b24"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("14f913f1-d43d-4a17-9519-de5891be97e7"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("71f9518d-c6cd-44e6-84d2-3e082b68942c"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("88e6000a-5c10-452c-97b7-db418be9038d"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("a3ec6065-710c-4dda-8fc8-59afdd1f75d5"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("c10ab970-99b3-40c8-9808-e4faf13440f6"));

            migrationBuilder.DeleteData(
                table: "Maalestokk",
                keyColumn: "Id",
                keyValue: new Guid("e61d6697-af8e-4c3d-90d4-75becf8060cf"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("2c14bf0e-b2de-445d-9066-5c726ae6f1ff"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("37841b3a-a7cc-47f5-8f4f-bd8b51e1e5ad"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("454fac4f-1db6-496a-ab45-55fe2b45e898"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("492679a5-e628-4003-8f66-7a29f4e22714"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("6b6dc872-fea6-4639-9546-5b7c3504d533"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("77f7c734-3b71-4199-9ca2-e662c0720087"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("9460e79b-9047-459c-8b8c-eac5bf138d05"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("97756e1b-0ec0-4c40-8671-3d2d80514570"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("aafcd636-24f0-4e95-a84a-0a8a118af410"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("b5b895fb-9ef6-4562-a538-249fbd8925e5"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("bc74ce7c-23f0-4e19-8f14-828f450e9f2a"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("cd247bd1-e6af-4944-b4be-aebfc21c1331"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("d1904299-7c48-40ce-8af0-2087b627b027"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("e54a9153-2064-4eaa-96dc-761496b5ea93"));

            migrationBuilder.DeleteData(
                table: "Prosedyrekategori",
                keyColumn: "Id",
                keyValue: new Guid("ea992126-7180-43f9-bf12-6a0c9c116fa7"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("4e86a0f6-d687-4d70-8332-4222d627aee3"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("647f50cc-7569-4383-9f4d-18df50f959a0"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("6deb7afe-3e93-4544-8de1-d9de69436b1c"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("d5ce3251-06b8-4c62-abb4-4efbc1fd51a0"));

            migrationBuilder.DeleteData(
                table: "Typekategori",
                keyColumn: "Id",
                keyValue: new Guid("de3b01b4-f4ed-4ca8-bbe6-c4504304e160"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("05056a56-a023-42a4-988c-e5475377e562"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("0d0ffcdd-485e-4b17-9fc4-2d582026a9a9"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("273e7b8f-e1da-4249-936d-0dfeaebe4851"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("2d9d31db-65d6-494a-ba4b-6f7539e406c6"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("2e0e35fd-e862-4cc8-977f-b64cfa80634e"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("98d8b37b-7567-4802-a02c-f4b54076fe58"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("a89a0d5b-a1c8-4755-b77f-776df46397fb"));

            migrationBuilder.DeleteData(
                table: "Typekategori2",
                keyColumn: "Id",
                keyValue: new Guid("ae344ade-f294-4b88-bbee-5222930a2c6a"));

            migrationBuilder.DeleteData(
                table: "Typekategori3",
                keyColumn: "Id",
                keyValue: new Guid("6b0626d2-792e-4a42-b107-ec164e21ac46"));

            migrationBuilder.DeleteData(
                table: "Typekategori3",
                keyColumn: "Id",
                keyValue: new Guid("cb68c8b7-c721-4576-ba30-a9d96fb18b3f"));

            migrationBuilder.DeleteData(
                table: "domene",
                keyColumn: "Id",
                keyValue: new Guid("01613e0f-41a2-4855-90dd-72ee35d79db9"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Typekategori2Id",
                table: "Type",
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
                    { new Guid("11c7ada4-87df-41e2-97f7-98201c93a1ac"), "abiotisk", "A" },
                    { new Guid("8f4f79e4-4bc8-49ea-a491-176b4aa0b565"), "økodiversitet", "C" },
                    { new Guid("aa29179e-5055-4f62-b7ac-73dad8fa6330"), "biotisk", "B" }
                });

            migrationBuilder.InsertData(
                table: "Maalestokk",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("106a357d-6ea6-4c36-aaff-66b6b397ccd0"), "grunntype", "G" },
                    { new Guid("4d978e1f-5922-48ad-92a5-1f00d38c452f"), "kartleggingsenhet tilpasset 1:100 000", "100K" },
                    { new Guid("4f462294-d679-40b5-9d4b-390f4ec5c9eb"), "kartleggingsenhet tilpasset 1:10 000", "010K" },
                    { new Guid("547c5e0b-186b-4f1b-bc3a-d842073be832"), "kartleggingsenhet tilpasset 1:20 000", "020K" },
                    { new Guid("810c297f-3173-45fb-812e-25fc31bbf285"), "kartleggingsenhet tilpasset 1:50 000", "050K" },
                    { new Guid("a8b5a81f-7ed6-43c9-8d2d-e25c957e5ae0"), "kartleggingsenhet tilpasset 1:5000", "005K" }
                });

            migrationBuilder.InsertData(
                table: "Prosedyrekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("0905bb19-6d75-4c77-8fd1-3acef420dba9"), "O", "O" },
                    { new Guid("26838b8c-da4a-43b0-958e-bae954e33ae7"), "B", "B" },
                    { new Guid("6cd02757-f959-4347-98f6-c7cb78ba41b2"), "M", "M" },
                    { new Guid("762b2b1e-f204-42dc-bdd3-06b462cc52d8"), "G", "G" },
                    { new Guid("7c061b16-048e-4af9-9be9-8e1111bfe019"), "A", "A" },
                    { new Guid("8ac0b7b9-95f0-4fd4-bd3b-1deaaa9d22f6"), "I", "I" },
                    { new Guid("8ae20e55-181c-4cf2-8402-60b10c6dd54c"), "L", "L" },
                    { new Guid("8b8d6124-3281-401c-932b-087edd5cce4c"), "K", "K" },
                    { new Guid("ae5b4f06-c378-4470-8db8-e86534a31cf1"), "N", "N" },
                    { new Guid("b554a112-db5d-40e6-bf23-bf392afecc61"), "E", "E" },
                    { new Guid("c25a75c7-aa35-47be-90b4-e3faf3d69e07"), "C", "C" },
                    { new Guid("cdbf7ece-3dd9-4b49-bfd7-777327e3135e"), "F", "F" },
                    { new Guid("e72f3e05-20aa-4fb4-ae35-1537c74830e4"), "H", "H" },
                    { new Guid("f2db4103-5bc1-45e5-84b6-6c95eee7cb95"), "D", "D" },
                    { new Guid("f657ad4d-a0d5-4211-a1d2-f120b2aa4b9d"), "J", "J" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("09cb2cb3-42c5-4aca-8a0b-7b916ee749d6"), "primært økodiversitetsnivå", "PE" },
                    { new Guid("7b972e3c-f2c9-4ee6-a60e-d9ab9ca597f5"), "landformvariasjon", "LV" },
                    { new Guid("bc067a1b-756f-4141-8007-ef09e5942ef3"), "sekundært økodiversitetsnivå", "SE" },
                    { new Guid("cb1383be-2090-40b4-984a-7bc8ad8dada7"), "marine vannmasser", "MV" },
                    { new Guid("f6f4d140-7c8a-4720-8ae2-5a80e347ccf1"), "livsmedium", "LI" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori2",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("0de07b92-5d22-45a5-a607-b7ee3087ecdb"), "landformer i fast fjell og løsmasser", "FL" },
                    { new Guid("0e4388f7-00ea-4118-aa74-49dd87940914"), "natursystem", "NA" },
                    { new Guid("4e8416d0-8dca-45ee-88d0-6d5b6738686c"), "bremassiv", "BM" },
                    { new Guid("902b89c5-4b5a-4f6d-8a6f-ca077315e862"), "landskapstype", "LA" },
                    { new Guid("f24b611d-8cb9-4586-ab58-46aec19190ea"), "torvmarksmassiv", "TM" },
                    { new Guid("f938f305-7b43-44db-876d-d0ef171cd00c"), "elveløp", "EL" },
                    { new Guid("faaaae2d-a94e-4612-ac6c-3d8f8a9ec3cb"), "naturkompleks", "NK" },
                    { new Guid("faab5b3c-eb86-418a-9ec8-95415ba2ca15"), "innsjøbasseng", "IB" }
                });

            migrationBuilder.InsertData(
                table: "Typekategori3",
                columns: new[] { "Id", "Beskrivelse", "Kode" },
                values: new object[,]
                {
                    { new Guid("19713000-5712-4a91-8f87-0cb906e83004"), "vannmassesystemer", "VM" },
                    { new Guid("20c9b7ea-d683-4a3e-8fa9-87b40af1f724"), "mark- og bunnsystemer", "MB" }
                });

            migrationBuilder.InsertData(
                table: "domene",
                columns: new[] { "Id", "Navn" },
                values: new object[] { new Guid("3ce9268b-ea16-4185-a24c-44adf835e99d"), "3.0" });

            migrationBuilder.AddForeignKey(
                name: "FK_Type_Typekategori2_Typekategori2Id",
                table: "Type",
                column: "Typekategori2Id",
                principalTable: "Typekategori2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
