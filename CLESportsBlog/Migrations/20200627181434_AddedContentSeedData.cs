﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CLESportsBlog.Migrations
{
    public partial class AddedContentSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Body", "PublishDate" },
                values: new object[] { "Lebron James", "Billions upon billions! Globular star cluster tendrils of gossamer clouds Vangelis dream of the mind’s eye network of wormholes a very small stage in a vast cosmic arena worldlets take root and flourish stirred by starlight, Flatland concept of the number one. Dispassionate extraterrestrial observer of brilliant syntheses not a sunrise but a galaxyrise intelligent beings, rings of Uranus tingling of the spine shores of the cosmic ocean gathered by gravity. Emerged into consciousness encyclopaedia galactica rich in heavy atoms, billions upon billions are creatures of the cosmos, the ash of stellar alchemy consciousness tingling of the spine ship of the imagination.", new DateTime(2020, 6, 27, 14, 14, 33, 832, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Body", "PublishDate", "TeamId", "Title" },
                values: new object[] { "Cedi Osman", "Are creatures of the cosmos. Citizens of distant epochs Flatland tendrils of gossamer clouds ship of the imagination Jean-FranÃƒÂ§ois Champollion hundreds of thousands at the edge of forever Orion’s sword decipherment muse about, cosmos from which we spring consciousness citizens of distant epochs Orion’s sword another world Vangelis star stuff harvesting star light explorations finite but unbounded concept of the number one intelligent beings tingling of the spine.", new DateTime(2020, 6, 27, 14, 14, 33, 836, DateTimeKind.Local).AddTicks(361), 1, "Cavs" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Body", "PublishDate", "TeamId", "Title" },
                values: new object[] { "Matthew Dellavadova", "The only home we’ve ever known preserve and cherish that pale blue dot. Cosmic fugue, circumnavigated descended from astronomers decipherment, permanence of the stars science Euclid muse about! A still more glorious dawn awaits Euclid, tendrils of gossamer clouds extraplanetary muse about vastness is bearable only through love Cambrian explosion! Extraordinary claims require extraordinary evidence of brilliant syntheses? Take root and flourish, stirred by starlight billions upon billions Drake Equation.", new DateTime(2020, 6, 27, 14, 14, 33, 836, DateTimeKind.Local).AddTicks(450), 1, "Cavs" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "PublishDate", "TeamId", "Title" },
                values: new object[,]
                {
                    { 4, "Francisco Lindor", "Baseball ipsum dolor sit amet bag squeeze chin music cy young base on balls. Rookie take bag 4-bagger assist rally squeeze silver slugger. Hey batter rookie 1-2-3 hitter sabremetrics, tigers grand slam mendoza line away. Unearned run wrigley catcher mitt fair bench sacrifice fly. Manager unearned run around the horn bases loaded shutout run double switch foul curve. Second base hot dog streak slugging world series practice balk.", new DateTime(2020, 6, 27, 14, 14, 33, 836, DateTimeKind.Local).AddTicks(462), 2, "Indians" },
                    { 5, "Corey Kluber", "Doubleheader relay balk slider pinch hit, grass rubber game. In the hole backstop hey batter 4-bagger strikeout club base. Mendoza line grounder season double switch interleague bandbox pine tar run batted in 4-6-3. Red sox hitter pine tar count walk off interleague loogy reds balk. Earned run third base starter slider dead ball era double play bush league. Bleeder corner no-hitter away game rubber game.", new DateTime(2020, 6, 27, 14, 14, 33, 836, DateTimeKind.Local).AddTicks(469), 2, "Indians" },
                    { 6, "Carlos Santana", "Lineup pickoff season sacrifice sweep, umpire no-hitter. Sport no-hitter hall of fame catcher rip first baseman shift balk. Hall of fame fall classic line drive breaking ball base moneyball basehit perfect game golden sombrero. Suicide squeeze rubber small ball moneyball extra innings pinch hit win ground rule double hardball. League choke up yankees bush league error nubber bases loaded bullpen. On deck stadium reds glove wild pitch center fielder mendoza line baseball.", new DateTime(2020, 6, 27, 14, 14, 33, 836, DateTimeKind.Local).AddTicks(475), 2, "Indians" },
                    { 7, "Myles Garrett", "Every man who has lotted here over the centuries, has looked up to the light and imagined climbing to freedom. So easy, so simple! And like shipwrecked men turning to seawater foregoing uncontrollable thirst, many have died trying. And then here there can be no true despair without hope. So as I terrorize Gotham, I will feed its people hope to poison their souls. I will let them believe that they can survive so that you can watch them climbing over each other to stay in the sun. You can watch me torture an entire city. And then when you’ve truly understood the depth of your failure, we will fulfill Ra’s Al Ghul’s destiny. We will destroy Gotham. And then, when that is done, and Gotham is… ashes Then you have my permission to die.", new DateTime(2020, 6, 27, 14, 14, 33, 836, DateTimeKind.Local).AddTicks(480), 3, "Browns" },
                    { 8, "Baker Mayfield", "But we’ve met before. That was a long time ago, I was a kid at St. Swithin’s, It used to be funded by the Wayne Foundation. It’s an orphanage. My mum died when I was small, it was a car accident. I don’t remember it. My dad got shot a couple of years later for a gambling debt. Oh I remember that one just fine. Not a lot of people know what it feels like to be angry in your bones. I mean they understand. The fosters parents. Everybody understands, for a while. Then they want the angry little kid to do something he knows he can’t do, move on. After a while they stop understanding. They send the angry kid to a boy’s home, I figured it out too late. Yeah I learned to hide the anger, and practice smiling in the mirror. It’s like putting on a mask. So you showed up this one day, in a cool car, pretty girl on your arm. We were so excited! Bruce Wayne, a billionaire orphan? ", new DateTime(2020, 6, 27, 14, 14, 33, 836, DateTimeKind.Local).AddTicks(485), 3, "Browns" },
                    { 9, "Bernie Kosar", "We used to make up stories about you man, legends and you know with the other kids, that’s all it was, just stories, but right when I saw you, I knew who you really were. I’d seen that look on your face before. It’s the same one I taught myself. I don’t why you took the fault for Dent’s murder but I’m still a believer in the Batman. Even if you’re not…", new DateTime(2020, 6, 27, 14, 14, 33, 836, DateTimeKind.Local).AddTicks(490), 3, "Browns" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_TeamId",
                table: "Contents",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Teams_TeamId",
                table: "Contents",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Teams_TeamId",
                table: "Contents");

            migrationBuilder.DropIndex(
                name: "IX_Contents_TeamId",
                table: "Contents");

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Body", "PublishDate" },
                values: new object[] { "Lebron", "Cavs Post", new DateTime(2020, 6, 26, 21, 36, 26, 632, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Body", "PublishDate", "TeamId", "Title" },
                values: new object[] { "Lindor", "Indinas Post", new DateTime(2020, 6, 26, 21, 36, 26, 636, DateTimeKind.Local).AddTicks(4640), 2, "Indians" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Body", "PublishDate", "TeamId", "Title" },
                values: new object[] { "Kosar", "Browns Post", new DateTime(2020, 6, 26, 21, 36, 26, 636, DateTimeKind.Local).AddTicks(4763), 3, "Browns" });
        }
    }
}
