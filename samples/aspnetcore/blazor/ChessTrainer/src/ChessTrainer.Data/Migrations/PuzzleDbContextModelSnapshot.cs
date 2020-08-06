﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MjrChess.Trainer.Data;

namespace MjrChess.Trainer.Data.Migrations
{
    [DbContext(typeof(PuzzleDbContext))]
    partial class PuzzleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MjrChess.Trainer.Data.Models.PuzzleHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset?>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("LastModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("PuzzleId")
                        .HasColumnType("int");

                    b.Property<bool>("Solved")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PuzzleId");

                    b.ToTable("PuzzleHistories");
                });

            modelBuilder.Entity("MjrChess.Trainer.Data.Models.TacticsPuzzle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlackPlayerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("GameDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("GameUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncorrectMovedFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncorrectMovedTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IncorrectPiecePromotedTo")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("LastModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MovedFrom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovedTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PiecePromotedTo")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetupMovedFrom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetupMovedTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SetupPiecePromotedTo")
                        .HasColumnType("int");

                    b.Property<string>("Site")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhitePlayerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Puzzles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BlackPlayerName = "Noobie",
                            CreatedDate = new DateTimeOffset(new DateTime(2020, 8, 6, 11, 2, 3, 198, DateTimeKind.Unspecified).AddTicks(7643), new TimeSpan(0, -4, 0, 0, 0)),
                            GameDate = new DateTimeOffset(new DateTime(2015, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            LastModifiedDate = new DateTimeOffset(new DateTime(2020, 8, 6, 11, 2, 3, 198, DateTimeKind.Unspecified).AddTicks(7800), new TimeSpan(0, -4, 0, 0, 0)),
                            MovedFrom = "f3",
                            MovedTo = "f7",
                            Position = "rnbqk1nr/pppp1ppp/8/2b1p3/2B1P3/5Q2/PPPP1PPP/RNB1K1NR b KQkq - 3 3",
                            SetupMovedFrom = "b8",
                            SetupMovedTo = "c6",
                            WhitePlayerName = "Hustler"
                        },
                        new
                        {
                            Id = 2,
                            BlackPlayerName = "aupoil",
                            CreatedDate = new DateTimeOffset(new DateTime(2020, 8, 6, 11, 2, 3, 199, DateTimeKind.Unspecified).AddTicks(1347), new TimeSpan(0, -4, 0, 0, 0)),
                            GameDate = new DateTimeOffset(new DateTime(2016, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            GameUrl = "https://lichess.org/3piQphpY",
                            LastModifiedDate = new DateTimeOffset(new DateTime(2020, 8, 6, 11, 2, 3, 199, DateTimeKind.Unspecified).AddTicks(1398), new TimeSpan(0, -4, 0, 0, 0)),
                            MovedFrom = "c6",
                            MovedTo = "a5",
                            Position = "r3r1k1/ppp2pp1/2n4p/3q4/3Pb3/B1P2N1P/P2Q1PP1/R3R1K1 w - - 4 16",
                            SetupMovedFrom = "e1",
                            SetupMovedTo = "e3",
                            Site = "lichess.org",
                            WhitePlayerName = "Vini700"
                        },
                        new
                        {
                            Id = 3,
                            BlackPlayerName = "wolfwolf",
                            CreatedDate = new DateTimeOffset(new DateTime(2020, 8, 6, 11, 2, 3, 199, DateTimeKind.Unspecified).AddTicks(4139), new TimeSpan(0, -4, 0, 0, 0)),
                            GameDate = new DateTimeOffset(new DateTime(2016, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            GameUrl = "https://lichess.org/HjVhr1Dn",
                            IncorrectMovedFrom = "f8",
                            IncorrectMovedTo = "f5",
                            LastModifiedDate = new DateTimeOffset(new DateTime(2020, 8, 6, 11, 2, 3, 199, DateTimeKind.Unspecified).AddTicks(4177), new TimeSpan(0, -4, 0, 0, 0)),
                            MovedFrom = "e7",
                            MovedTo = "b4",
                            Position = "r2q1rk1/1pp1b1pp/p7/4pp2/2PnB1P1/3PB2P/PP1Q1P2/R3K2R w KQ - 0 15",
                            SetupMovedFrom = "g4",
                            SetupMovedTo = "f5",
                            Site = "lichess.org",
                            WhitePlayerName = "toskekg"
                        },
                        new
                        {
                            Id = 4,
                            BlackPlayerName = "mjrousos",
                            CreatedDate = new DateTimeOffset(new DateTime(2020, 8, 6, 11, 2, 3, 199, DateTimeKind.Unspecified).AddTicks(7176), new TimeSpan(0, -4, 0, 0, 0)),
                            GameDate = new DateTimeOffset(new DateTime(2019, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            GameUrl = "https://lichess.org/ABBg3RuE",
                            IncorrectMovedFrom = "g4",
                            IncorrectMovedTo = "a4",
                            LastModifiedDate = new DateTimeOffset(new DateTime(2020, 8, 6, 11, 2, 3, 199, DateTimeKind.Unspecified).AddTicks(7220), new TimeSpan(0, -4, 0, 0, 0)),
                            MovedFrom = "b8",
                            MovedTo = "b1",
                            Position = "krr5/p6p/2pQ4/3pp3/N5q1/6P1/P1P2PBP/3R2K1 w - - 14 31",
                            SetupMovedFrom = "d1",
                            SetupMovedTo = "d5",
                            Site = "lichess.org",
                            WhitePlayerName = "fucilaco"
                        });
                });

            modelBuilder.Entity("MjrChess.Trainer.Data.Models.PuzzleHistory", b =>
                {
                    b.HasOne("MjrChess.Trainer.Data.Models.TacticsPuzzle", "Puzzle")
                        .WithMany("History")
                        .HasForeignKey("PuzzleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
