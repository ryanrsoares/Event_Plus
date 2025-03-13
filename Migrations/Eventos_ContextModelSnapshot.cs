﻿// <auto-generated />
using System;
using Event_plus.Context_;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Event_plus.Migrations
{
    [DbContext(typeof(Eventos_Context))]
    partial class Eventos_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Event_plus.Domains.ComentariosEventos", b =>
                {
                    b.Property<Guid>("ComentariosEventosID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Decricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EventosID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Exibe")
                        .HasColumnType("BIT");

                    b.Property<Guid>("UsuarioID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ComentariosEventosID");

                    b.HasIndex("EventosID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("ComentariosEventos");
                });

            modelBuilder.Entity("Event_plus.Domains.Eventos", b =>
                {
                    b.Property<Guid>("EventoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataEvento")
                        .HasColumnType("DATE");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("InstituicaoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeEvento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<Guid>("TipoEventoID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EventoID");

                    b.HasIndex("InstituicaoID");

                    b.HasIndex("TipoEventoID");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("Event_plus.Domains.Instituicoes", b =>
                {
                    b.Property<Guid>("InstituicaoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("VARCHAR(14)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.HasKey("InstituicaoID");

                    b.HasIndex("CNPJ")
                        .IsUnique();

                    b.ToTable("Instituicoes");
                });

            modelBuilder.Entity("Event_plus.Domains.PresencasEventos", b =>
                {
                    b.Property<Guid>("IdPresenca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EventoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Situacao")
                        .HasColumnType("BIT");

                    b.Property<Guid>("UsuarioID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdPresenca");

                    b.HasIndex("EventoID")
                        .IsUnique();

                    b.HasIndex("UsuarioID");

                    b.ToTable("PresencasEventos");
                });

            modelBuilder.Entity("Event_plus.Domains.TiposEventos", b =>
                {
                    b.Property<Guid>("TipoEventoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TituloTipoEvento")
                        .IsRequired()
                        .HasColumnType("VARCHAR (100)");

                    b.HasKey("TipoEventoID");

                    b.ToTable("TiposEventos");
                });

            modelBuilder.Entity("Event_plus.Domains.TiposUsuarios", b =>
                {
                    b.Property<Guid>("TipoUsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TituloTipoUsuario")
                        .IsRequired()
                        .HasColumnType("VARCHAR (15)");

                    b.HasKey("TipoUsuarioID");

                    b.ToTable("TiposUsuarios");
                });

            modelBuilder.Entity("Event_plus.Domains.Usuarios", b =>
                {
                    b.Property<Guid>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<Guid>("TipoUsuarioID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("VARCHAR(60)");

                    b.HasKey("UsuarioID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("TipoUsuarioID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Event_plus.Domains.ComentariosEventos", b =>
                {
                    b.HasOne("Event_plus.Domains.Eventos", "Eventos")
                        .WithMany()
                        .HasForeignKey("EventosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Event_plus.Domains.Usuarios", "Usuarios")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Eventos");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Event_plus.Domains.Eventos", b =>
                {
                    b.HasOne("Event_plus.Domains.Instituicoes", "InstuicoesID")
                        .WithMany()
                        .HasForeignKey("InstituicaoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Event_plus.Domains.TiposEventos", "TipoEvento")
                        .WithMany()
                        .HasForeignKey("TipoEventoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InstuicoesID");

                    b.Navigation("TipoEvento");
                });

            modelBuilder.Entity("Event_plus.Domains.PresencasEventos", b =>
                {
                    b.HasOne("Event_plus.Domains.Eventos", "Eventos")
                        .WithOne("PresencasEventos")
                        .HasForeignKey("Event_plus.Domains.PresencasEventos", "EventoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Event_plus.Domains.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Eventos");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Event_plus.Domains.Usuarios", b =>
                {
                    b.HasOne("Event_plus.Domains.TiposUsuarios", "TiposUsuarios")
                        .WithMany()
                        .HasForeignKey("TipoUsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TiposUsuarios");
                });

            modelBuilder.Entity("Event_plus.Domains.Eventos", b =>
                {
                    b.Navigation("PresencasEventos");
                });
#pragma warning restore 612, 618
        }
    }
}
