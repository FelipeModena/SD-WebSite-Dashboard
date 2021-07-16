﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SD_WebSite_DashBoardApi.Models.Context;

namespace SD_WebSite_DashBoardApi.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20210715205459_updatePAginaUrl")]
    partial class updatePAginaUrl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("SD_WebSite_DashBoardApi.Models.Administrador", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<string>("Usuario")
                        .HasColumnType("longtext")
                        .HasColumnName("usuario");

                    b.HasKey("Id");

                    b.ToTable("adminstrador");
                });

            modelBuilder.Entity("SD_WebSite_DashBoardApi.Models.Componente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CorBotao1")
                        .HasColumnType("longtext")
                        .HasColumnName("cor_botao_1");

                    b.Property<string>("CorSubTitulo")
                        .HasColumnType("longtext")
                        .HasColumnName("cor_sub_titulo");

                    b.Property<string>("CorTitulo")
                        .HasColumnType("longtext")
                        .HasColumnName("cor_titulo");

                    b.Property<long>("PaginaId")
                        .HasColumnType("bigint")
                        .HasColumnName("pagina_id");

                    b.Property<string>("SubTitulo")
                        .HasColumnType("longtext")
                        .HasColumnName("sub_titulo");

                    b.Property<string>("Texto")
                        .HasColumnType("longtext")
                        .HasColumnName("texto");

                    b.Property<string>("TipoComponente")
                        .HasColumnType("longtext")
                        .HasColumnName("tipo_componente");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext")
                        .HasColumnName("titulo");

                    b.Property<string>("TxtBotao1")
                        .HasColumnType("longtext")
                        .HasColumnName("txt_botao_1");

                    b.Property<string>("UrlBotao1")
                        .HasColumnType("longtext")
                        .HasColumnName("url_botao_1");

                    b.Property<string>("UrlDirecionamentoPaginas")
                        .HasColumnType("longtext")
                        .HasColumnName("url_direcionamento_paginas");

                    b.Property<string>("UrlImagem")
                        .HasColumnType("longtext")
                        .HasColumnName("url_imagem");

                    b.HasKey("Id");

                    b.HasIndex("PaginaId");

                    b.ToTable("componente");
                });

            modelBuilder.Entity("SD_WebSite_DashBoardApi.Models.Contato", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Bairro")
                        .HasColumnType("longtext")
                        .HasColumnName("bairro");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .HasColumnType("longtext")
                        .HasColumnName("complemento");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("Endereco")
                        .HasColumnType("longtext")
                        .HasColumnName("endereco");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext")
                        .HasColumnName("estado");

                    b.Property<string>("Facebook")
                        .HasColumnType("longtext")
                        .HasColumnName("facebook");

                    b.Property<string>("Instagram")
                        .HasColumnType("longtext")
                        .HasColumnName("instagram");

                    b.Property<string>("Linkedin")
                        .HasColumnType("longtext")
                        .HasColumnName("linkedin");

                    b.Property<DateTime>("Modificacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("modificacao");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext")
                        .HasColumnName("telefone");

                    b.Property<string>("Whatsapp")
                        .HasColumnType("longtext")
                        .HasColumnName("whatsapp");

                    b.Property<string>("Youtube")
                        .HasColumnType("longtext")
                        .HasColumnName("youtube");

                    b.HasKey("Id");

                    b.ToTable("contato");
                });

            modelBuilder.Entity("SD_WebSite_DashBoardApi.Models.Log", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data");

                    b.Property<string>("Error")
                        .HasColumnType("longtext")
                        .HasColumnName("error");

                    b.Property<string>("Table")
                        .HasColumnType("longtext")
                        .HasColumnName("table");

                    b.HasKey("Id");

                    b.ToTable("log");
                });

            modelBuilder.Entity("SD_WebSite_DashBoardApi.Models.Pagina", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<bool>("Ativa")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("ativa");

                    b.Property<DateTime>("Modificacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("modificacao");

                    b.Property<string>("NomePagina")
                        .HasColumnType("longtext")
                        .HasColumnName("nome_pagina");

                    b.Property<int>("Ordem")
                        .HasColumnType("int")
                        .HasColumnName("ordem");

                    b.Property<string>("Url")
                        .HasColumnType("longtext")
                        .HasColumnName("url");

                    b.HasKey("Id");

                    b.ToTable("pagina");
                });

            modelBuilder.Entity("SD_WebSite_DashBoardApi.Models.Rodape", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CorFundo")
                        .HasColumnType("longtext")
                        .HasColumnName("cor_fundo");

                    b.Property<string>("IconesRedesSociais")
                        .HasColumnType("longtext")
                        .HasColumnName("icones_redes_sociais");

                    b.Property<string>("Logo")
                        .HasColumnType("longtext")
                        .HasColumnName("logo");

                    b.Property<DateTime>("Modificacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("modificacao");

                    b.Property<bool>("RodapeAtivo")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("rodape_ativo");

                    b.HasKey("Id");

                    b.ToTable("Rodape");
                });

            modelBuilder.Entity("SD_WebSite_DashBoardApi.Models.Componente", b =>
                {
                    b.HasOne("SD_WebSite_DashBoardApi.Models.Pagina", "Pagina")
                        .WithMany("Componente")
                        .HasForeignKey("PaginaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pagina");
                });

            modelBuilder.Entity("SD_WebSite_DashBoardApi.Models.Pagina", b =>
                {
                    b.Navigation("Componente");
                });
#pragma warning restore 612, 618
        }
    }
}
