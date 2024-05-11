﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kaufer_comex.Models;

#nullable disable

namespace kaufer_comex.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240509122544_AddNomeUsuario-NotaItemTemps")]
    partial class AddNomeUsuarioNotaItemTemps
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("kaufer_comex.Models.AgenteDeCarga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomeAgenteCarga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AgenteDeCargas");
                });

            modelBuilder.Entity("kaufer_comex.Models.CadastroDespesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomeDespesa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CadastroDespesa");
                });

            modelBuilder.Entity("kaufer_comex.Models.CadastroDespesaDCE", b =>
                {
                    b.Property<int>("CadastroDespesaId")
                        .HasColumnType("int");

                    b.Property<int>("DCEId")
                        .HasColumnType("int");

                    b.HasKey("CadastroDespesaId", "DCEId");

                    b.HasIndex("DCEId");

                    b.ToTable("Despesa-DCE");
                });

            modelBuilder.Entity("kaufer_comex.Models.DCE", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CadastroDespesaId")
                        .HasColumnType("int");

                    b.Property<int>("FornecedorServicoId")
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessoId")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ProcessoId");

                    b.ToTable("DCE");
                });

            modelBuilder.Entity("kaufer_comex.Models.Despachante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomeDespachante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Despachantes");
                });

            modelBuilder.Entity("kaufer_comex.Models.Despacho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CodPais")
                        .HasColumnType("int");

                    b.Property<string>("ConhecimentoEmbarque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataAverbacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataConhecimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDue")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataExportacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumeroDue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Parametrizacao")
                        .HasColumnType("int");

                    b.Property<int>("ProcessoId")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProcessoId");

                    b.ToTable("Despacho");
                });

            modelBuilder.Entity("kaufer_comex.Models.Destino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomePais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Destino");
                });

            modelBuilder.Entity("kaufer_comex.Models.Documento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CertificadoOrigem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertificadoSeguro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataEnvioOrigem")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataEnvioSeguro")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProcessoId")
                        .HasColumnType("int");

                    b.Property<string>("TrackinCourier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProcessoId");

                    b.ToTable("Documentos");
                });

            modelBuilder.Entity("kaufer_comex.Models.EmbarqueRodoviario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AgenteDeCargaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ChegadaDestino")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataEmbarque")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProcessoId")
                        .HasColumnType("int");

                    b.Property<string>("TransitTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transportadora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AgenteDeCargaId");

                    b.HasIndex("ProcessoId");

                    b.ToTable("EmbarqueRodoviario");
                });

            modelBuilder.Entity("kaufer_comex.Models.ExpImp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoExpImp")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ExpImp");
                });

            modelBuilder.Entity("kaufer_comex.Models.FornecedorServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoServico")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FornecedorServico");
                });

            modelBuilder.Entity("kaufer_comex.Models.FornecedorServicoDCE", b =>
                {
                    b.Property<int>("FornecedorServicoId")
                        .HasColumnType("int");

                    b.Property<int>("DCEId")
                        .HasColumnType("int");

                    b.HasKey("FornecedorServicoId", "DCEId");

                    b.HasIndex("DCEId");

                    b.ToTable("Fornecedor-DCE");
                });

            modelBuilder.Entity("kaufer_comex.Models.Fronteira", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomeFronteira")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fronteiras");
                });

            modelBuilder.Entity("kaufer_comex.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("AreaM2")
                        .HasColumnType("real");

                    b.Property<string>("CodigoProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Comprimento")
                        .HasColumnType("real");

                    b.Property<string>("DescricaoProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Diametro")
                        .HasColumnType("real");

                    b.Property<float>("Expressura")
                        .HasColumnType("real");

                    b.Property<string>("Familia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Largura")
                        .HasColumnType("real");

                    b.Property<float>("LarguraAparente")
                        .HasColumnType("real");

                    b.Property<float>("PesoBruto")
                        .HasColumnType("real");

                    b.Property<float>("PesoLiquido")
                        .HasColumnType("real");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<float>("VolumeM2")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("kaufer_comex.Models.Nota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BaseNota")
                        .HasColumnType("datetime2");

                    b.Property<string>("CertificadoQualidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmbarqueRodoviarioId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Emissao")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumeroNf")
                        .HasColumnType("int");

                    b.Property<float>("PesoBruto")
                        .HasColumnType("real");

                    b.Property<float>("PesoLiq")
                        .HasColumnType("real");

                    b.Property<float>("TaxaCambial")
                        .HasColumnType("real");

                    b.Property<float>("ValorCif")
                        .HasColumnType("real");

                    b.Property<float>("ValorFob")
                        .HasColumnType("real");

                    b.Property<float>("ValorFrete")
                        .HasColumnType("real");

                    b.Property<float>("ValorSeguro")
                        .HasColumnType("real");

                    b.Property<int>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmbarqueRodoviarioId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("kaufer_comex.Models.NotaItem", b =>
                {
                    b.Property<int>("NotaId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<double>("Quantidade")
                        .HasColumnType("float");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("NotaId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("NotaItens");
                });

            modelBuilder.Entity("kaufer_comex.Models.NotaItemTemp", b =>
                {
                    b.Property<int>("NotaItemTempId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotaItemTempId"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("Quantidade")
                        .HasColumnType("float");

                    b.HasKey("NotaItemTempId");

                    b.HasIndex("ItemId");

                    b.ToTable("NotaItemTemps");
                });

            modelBuilder.Entity("kaufer_comex.Models.Processo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodProcessoExportacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataInicioProcesso")
                        .HasColumnType("datetime2");

                    b.Property<int>("DespachanteId")
                        .HasColumnType("int");

                    b.Property<int>("DestinoId")
                        .HasColumnType("int");

                    b.Property<int>("ExportadorId")
                        .HasColumnType("int");

                    b.Property<int>("FronteiraId")
                        .HasColumnType("int");

                    b.Property<int>("ImportadorId")
                        .HasColumnType("int");

                    b.Property<int>("Incoterm")
                        .HasColumnType("int");

                    b.Property<int>("Modal")
                        .HasColumnType("int");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PedidosRelacionados")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PrevisaoColeta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PrevisaoCruze")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PrevisaoEntrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PrevisaoPagamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PrevisaoProducao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Proforma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DespachanteId");

                    b.HasIndex("DestinoId");

                    b.HasIndex("FronteiraId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("VendedorId");

                    b.ToTable("Processo");
                });

            modelBuilder.Entity("kaufer_comex.Models.ProcessoExpImp", b =>
                {
                    b.Property<int>("ProcessoId")
                        .HasColumnType("int");

                    b.Property<int>("ExpImpId")
                        .HasColumnType("int");

                    b.HasKey("ProcessoId", "ExpImpId");

                    b.HasIndex("ExpImpId");

                    b.ToTable("Processo-Exportador-Importador");
                });

            modelBuilder.Entity("kaufer_comex.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("StatusAtual")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("kaufer_comex.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFuncionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("kaufer_comex.Models.ValorProcesso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("FreteInternacional")
                        .HasColumnType("real");

                    b.Property<int>("Moeda")
                        .HasColumnType("int");

                    b.Property<int>("ProcessoId")
                        .HasColumnType("int");

                    b.Property<float>("SeguroInternaciona")
                        .HasColumnType("real");

                    b.Property<float>("ValorExw")
                        .HasColumnType("real");

                    b.Property<float>("ValorFobFca")
                        .HasColumnType("real");

                    b.Property<float>("ValorTotalCif")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ProcessoId");

                    b.ToTable("ValorProcessos");
                });

            modelBuilder.Entity("kaufer_comex.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Motorista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("kaufer_comex.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomeVendedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("kaufer_comex.Models.CadastroDespesaDCE", b =>
                {
                    b.HasOne("kaufer_comex.Models.CadastroDespesa", "CadastroDespesa")
                        .WithMany("CadastroDespesaDCEs")
                        .HasForeignKey("CadastroDespesaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.DCE", "DCE")
                        .WithMany("CadastroDespesas")
                        .HasForeignKey("DCEId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CadastroDespesa");

                    b.Navigation("DCE");
                });

            modelBuilder.Entity("kaufer_comex.Models.DCE", b =>
                {
                    b.HasOne("kaufer_comex.Models.Processo", "Processo")
                        .WithMany("DCES")
                        .HasForeignKey("ProcessoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Processo");
                });

            modelBuilder.Entity("kaufer_comex.Models.Despacho", b =>
                {
                    b.HasOne("kaufer_comex.Models.Processo", "Processo")
                        .WithMany()
                        .HasForeignKey("ProcessoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Processo");
                });

            modelBuilder.Entity("kaufer_comex.Models.Documento", b =>
                {
                    b.HasOne("kaufer_comex.Models.Processo", "Processo")
                        .WithMany()
                        .HasForeignKey("ProcessoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Processo");
                });

            modelBuilder.Entity("kaufer_comex.Models.EmbarqueRodoviario", b =>
                {
                    b.HasOne("kaufer_comex.Models.AgenteDeCarga", "AgenteDeCarga")
                        .WithMany()
                        .HasForeignKey("AgenteDeCargaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.Processo", "Processo")
                        .WithMany()
                        .HasForeignKey("ProcessoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AgenteDeCarga");

                    b.Navigation("Processo");
                });

            modelBuilder.Entity("kaufer_comex.Models.FornecedorServicoDCE", b =>
                {
                    b.HasOne("kaufer_comex.Models.DCE", "DCE")
                        .WithMany("FornecedorServicos")
                        .HasForeignKey("DCEId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.FornecedorServico", "FornecedorServico")
                        .WithMany("FornecedorServicoDCEs")
                        .HasForeignKey("FornecedorServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DCE");

                    b.Navigation("FornecedorServico");
                });

            modelBuilder.Entity("kaufer_comex.Models.Nota", b =>
                {
                    b.HasOne("kaufer_comex.Models.EmbarqueRodoviario", "EmbarqueRodoviario")
                        .WithMany()
                        .HasForeignKey("EmbarqueRodoviarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.Veiculo", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmbarqueRodoviario");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("kaufer_comex.Models.NotaItem", b =>
                {
                    b.HasOne("kaufer_comex.Models.Item", "Item")
                        .WithMany("NotaItem")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.Nota", "Nota")
                        .WithMany("NotaItem")
                        .HasForeignKey("NotaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Nota");
                });

            modelBuilder.Entity("kaufer_comex.Models.NotaItemTemp", b =>
                {
                    b.HasOne("kaufer_comex.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("kaufer_comex.Models.Processo", b =>
                {
                    b.HasOne("kaufer_comex.Models.Despachante", "Despachante")
                        .WithMany()
                        .HasForeignKey("DespachanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.Destino", "Destino")
                        .WithMany("Processos")
                        .HasForeignKey("DestinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.Fronteira", "Fronteira")
                        .WithMany()
                        .HasForeignKey("FronteiraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.Vendedor", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Despachante");

                    b.Navigation("Destino");

                    b.Navigation("Fronteira");

                    b.Navigation("Status");

                    b.Navigation("Usuario");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("kaufer_comex.Models.ProcessoExpImp", b =>
                {
                    b.HasOne("kaufer_comex.Models.ExpImp", "ExpImp")
                        .WithMany("ProcessoExpImps")
                        .HasForeignKey("ExpImpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kaufer_comex.Models.Processo", "Processo")
                        .WithMany("ExpImps")
                        .HasForeignKey("ProcessoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpImp");

                    b.Navigation("Processo");
                });

            modelBuilder.Entity("kaufer_comex.Models.ValorProcesso", b =>
                {
                    b.HasOne("kaufer_comex.Models.Processo", "Processo")
                        .WithMany()
                        .HasForeignKey("ProcessoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Processo");
                });

            modelBuilder.Entity("kaufer_comex.Models.CadastroDespesa", b =>
                {
                    b.Navigation("CadastroDespesaDCEs");
                });

            modelBuilder.Entity("kaufer_comex.Models.DCE", b =>
                {
                    b.Navigation("CadastroDespesas");

                    b.Navigation("FornecedorServicos");
                });

            modelBuilder.Entity("kaufer_comex.Models.Destino", b =>
                {
                    b.Navigation("Processos");
                });

            modelBuilder.Entity("kaufer_comex.Models.ExpImp", b =>
                {
                    b.Navigation("ProcessoExpImps");
                });

            modelBuilder.Entity("kaufer_comex.Models.FornecedorServico", b =>
                {
                    b.Navigation("FornecedorServicoDCEs");
                });

            modelBuilder.Entity("kaufer_comex.Models.Item", b =>
                {
                    b.Navigation("NotaItem");
                });

            modelBuilder.Entity("kaufer_comex.Models.Nota", b =>
                {
                    b.Navigation("NotaItem");
                });

            modelBuilder.Entity("kaufer_comex.Models.Processo", b =>
                {
                    b.Navigation("DCES");

                    b.Navigation("ExpImps");
                });
#pragma warning restore 612, 618
        }
    }
}
