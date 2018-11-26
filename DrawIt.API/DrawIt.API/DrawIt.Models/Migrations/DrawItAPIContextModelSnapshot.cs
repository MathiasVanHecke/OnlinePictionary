﻿// <auto-generated />
using System;
using DrawIt.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DrawIt.Models.Migrations
{
    [DbContext(typeof(DrawItAPIContext))]
    partial class DrawItAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DrawIt.Models.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("DrawIt.Models.Data.Categorie", b =>
                {
                    b.Property<Guid>("categorieId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("categorieEng");

                    b.Property<string>("categorieNl");

                    b.HasKey("categorieId");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("DrawIt.Models.Data.Word", b =>
                {
                    b.Property<int>("wordId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DNGuessed");

                    b.Property<int>("Guessed");

                    b.Property<int>("dislikes");

                    b.Property<int>("likes");

                    b.Property<string>("wordEng");

                    b.Property<string>("wordNl");

                    b.HasKey("wordId");

                    b.ToTable("Word");

                    b.HasData(
                        new { wordId = 1, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Desktop", wordNl = "Computer" },
                        new { wordId = 2, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Popcorn", wordNl = "Popcorn" },
                        new { wordId = 3, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Island", wordNl = "Eiland" },
                        new { wordId = 4, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "SantaClaus", wordNl = "Kerstman" },
                        new { wordId = 5, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Toothbrush", wordNl = "Tandenborstel" },
                        new { wordId = 6, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Shoppingcart", wordNl = "Winkelwagen" },
                        new { wordId = 7, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Trafficlight", wordNl = "Koptelefoon" },
                        new { wordId = 8, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Heater", wordNl = "Verwarming" },
                        new { wordId = 9, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Sunglasses", wordNl = "Zonnebril" },
                        new { wordId = 10, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Ferriswheel", wordNl = "Reuzenrad" },
                        new { wordId = 11, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Lamppost", wordNl = "Lantaarnpaal" },
                        new { wordId = 12, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Red", wordNl = "Rood" },
                        new { wordId = 13, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Desktop", wordNl = "Computer" },
                        new { wordId = 14, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Curtain", wordNl = "Gordijn" },
                        new { wordId = 15, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Desktop", wordNl = "Computer" },
                        new { wordId = 16, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Sleigh", wordNl = "Slee" },
                        new { wordId = 17, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Brain", wordNl = "Hersens" },
                        new { wordId = 18, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Clothespin", wordNl = "Wasknijper" },
                        new { wordId = 19, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Sandwich", wordNl = "Boterham" },
                        new { wordId = 20, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Diaper", wordNl = "Luier" },
                        new { wordId = 21, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Country", wordNl = "Land" },
                        new { wordId = 22, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Pie", wordNl = "Taart" },
                        new { wordId = 23, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Airport", wordNl = "Luchthaven" },
                        new { wordId = 24, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Pencil", wordNl = "Potlood" },
                        new { wordId = 25, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Pasword", wordNl = "Paswoord" },
                        new { wordId = 26, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Angel", wordNl = "Engel" },
                        new { wordId = 27, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Alarm", wordNl = "Alarm" },
                        new { wordId = 28, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Archery", wordNl = "Boogschieten" },
                        new { wordId = 29, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Armpit", wordNl = "Oksel" },
                        new { wordId = 30, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Artist", wordNl = "Artiest" },
                        new { wordId = 31, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Avatar", wordNl = "Avatar" },
                        new { wordId = 32, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Baby", wordNl = "Baby" },
                        new { wordId = 33, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Backflip", wordNl = "Koprol" },
                        new { wordId = 34, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Backpack", wordNl = "Rugzak" },
                        new { wordId = 35, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Balcony", wordNl = "Balkon" },
                        new { wordId = 36, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Balloon", wordNl = "Ballon" },
                        new { wordId = 37, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Banana", wordNl = "Banaan" },
                        new { wordId = 38, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Crook", wordNl = "Boef" },
                        new { wordId = 39, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Barber", wordNl = "Kapper" },
                        new { wordId = 40, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Barn", wordNl = "Schuur" },
                        new { wordId = 41, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Battery", wordNl = "Batterij" },
                        new { wordId = 42, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Bed", wordNl = "Bed" },
                        new { wordId = 43, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Butter", wordNl = "Boter" },
                        new { wordId = 101, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Bridge", wordNl = "Brug" },
                        new { wordId = 44, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Bullet", wordNl = "Kogel" },
                        new { wordId = 45, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Burger", wordNl = "Burger" },
                        new { wordId = 46, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Camera", wordNl = "Camera" },
                        new { wordId = 47, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Candy", wordNl = "Snoep" },
                        new { wordId = 48, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Car", wordNl = "Auto" },
                        new { wordId = 49, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Carrot", wordNl = "Wortel" },
                        new { wordId = 50, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Castle", wordNl = "Kasteel" },
                        new { wordId = 51, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Camp", wordNl = "Kamp" },
                        new { wordId = 52, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Church", wordNl = "Kerk" },
                        new { wordId = 53, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Circus", wordNl = "Circus" },
                        new { wordId = 54, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Cloud", wordNl = "Wolk" },
                        new { wordId = 55, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Clock", wordNl = "Klok" },
                        new { wordId = 56, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Cofee", wordNl = "Koffie" },
                        new { wordId = 57, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Cow", wordNl = "Koe" },
                        new { wordId = 58, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Crab", wordNl = "Krab" },
                        new { wordId = 59, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Crossbow", wordNl = "Kruisboog" },
                        new { wordId = 60, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Diamond", wordNl = "Diamand" },
                        new { wordId = 61, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Dog", wordNl = "Hond" },
                        new { wordId = 62, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Dream", wordNl = "Droom" },
                        new { wordId = 63, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Dog", wordNl = "Hond" },
                        new { wordId = 64, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "East", wordNl = "Oost" },
                        new { wordId = 65, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Earth", wordNl = "Aarde" },
                        new { wordId = 66, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Earring", wordNl = "Oorbel" },
                        new { wordId = 67, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Eye", wordNl = "Oog" },
                        new { wordId = 68, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Face", wordNl = "Gezicht" },
                        new { wordId = 69, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Feather", wordNl = "Veer" },
                        new { wordId = 70, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Firefox", wordNl = "Firefox" },
                        new { wordId = 71, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Fish", wordNl = "Vis" },
                        new { wordId = 72, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Flamingo", wordNl = "Flamingo" },
                        new { wordId = 73, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Flower", wordNl = "Bloem" },
                        new { wordId = 74, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Fork", wordNl = "Vork" },
                        new { wordId = 75, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Fountain", wordNl = "Fontijn" },
                        new { wordId = 76, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "France", wordNl = "Frankrijk" },
                        new { wordId = 77, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Fruit", wordNl = "Fruit" },
                        new { wordId = 78, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Giraffe", wordNl = "Giraf" },
                        new { wordId = 79, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Fruit", wordNl = "Fruit" },
                        new { wordId = 80, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Girl", wordNl = "Meisje" },
                        new { wordId = 81, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Ghost", wordNl = "Geest" },
                        new { wordId = 82, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Glue", wordNl = "Lijm" },
                        new { wordId = 83, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Goldfish", wordNl = "Goudvis" },
                        new { wordId = 84, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Fruit", wordNl = "Fruit" },
                        new { wordId = 85, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Grass", wordNl = "Gras" },
                        new { wordId = 86, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Grenade", wordNl = "Granaat" },
                        new { wordId = 87, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Guitar", wordNl = "Gitaar" },
                        new { wordId = 88, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Horse", wordNl = "Paard" },
                        new { wordId = 89, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Iceberg", wordNl = "Ijsberg" },
                        new { wordId = 90, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Ketchup", wordNl = "Ketchup" },
                        new { wordId = 91, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Jump", wordNl = "Springen" },
                        new { wordId = 92, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Key", wordNl = "Sleutel" },
                        new { wordId = 93, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Keyboard", wordNl = "Toetsenbord" },
                        new { wordId = 94, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Ladder", wordNl = "Ladder" },
                        new { wordId = 95, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Lava", wordNl = "Lava" },
                        new { wordId = 96, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Lighter", wordNl = "Aansteker" },
                        new { wordId = 97, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Lion", wordNl = "Leeuw" },
                        new { wordId = 98, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Love", wordNl = "Liefde" },
                        new { wordId = 99, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Medusa", wordNl = "Medusa" },
                        new { wordId = 100, DNGuessed = 0, Guessed = 0, dislikes = 0, likes = 0, wordEng = "Mermaid", wordNl = "Zeemeermin" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DrawIt.Models.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DrawIt.Models.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DrawIt.Models.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DrawIt.Models.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
