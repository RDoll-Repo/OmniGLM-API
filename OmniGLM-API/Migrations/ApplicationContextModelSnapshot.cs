﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OmniGLM_API.db;

#nullable disable

namespace OmniGLM_API.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OmniGLM_API.Models.Console", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_console");

                    b.ToTable("console", (string)null);
                });

            modelBuilder.Entity("OmniGLM_API.Models.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("ConsoleId")
                        .HasColumnType("uuid")
                        .HasColumnName("console_id");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_added");

                    b.Property<DateTime?>("DateCompleted")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_completed");

                    b.Property<int>("Format")
                        .HasColumnType("integer")
                        .HasColumnName("format");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uuid")
                        .HasColumnName("genre_id");

                    b.Property<int>("Length")
                        .HasColumnType("integer")
                        .HasColumnName("length");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_games");

                    b.HasIndex("ConsoleId")
                        .HasDatabaseName("ix_games_console_id");

                    b.HasIndex("GenreId")
                        .HasDatabaseName("ix_games_genre_id");

                    b.ToTable("games", (string)null);
                });

            modelBuilder.Entity("OmniGLM_API.Models.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_genre");

                    b.ToTable("genre", (string)null);
                });

            modelBuilder.Entity("OmniGLM_API.Models.Game", b =>
                {
                    b.HasOne("OmniGLM_API.Models.Console", "Console")
                        .WithMany()
                        .HasForeignKey("ConsoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_games_console_console_id");

                    b.HasOne("OmniGLM_API.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_games_genre_genre_id");

                    b.Navigation("Console");

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}
