﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hcs.Model
{
    // ++++++++++++
    public partial class HcsContext : DbContext
    {
        public HcsContext()
        {
        }

        public HcsContext(DbContextOptions<HcsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountCloseRequest> AccountCloseRequest { get; set; }
        public virtual DbSet<AccountCloseResult> AccountCloseResult { get; set; }
        public virtual DbSet<AccountCloseResultAccount> AccountCloseResultAccount { get; set; }
        public virtual DbSet<AccountCloseResultAccountError> AccountCloseResultAccountError { get; set; }
        public virtual DbSet<AccountExportRequest> AccountExportRequest { get; set; }
        public virtual DbSet<AccountExportResult> AccountExportResult { get; set; }
        public virtual DbSet<AccountExportResultPercentPremise> AccountExportResultPercentPremise { get; set; }
        public virtual DbSet<AccountImportRequest> AccountImportRequest { get; set; }
        public virtual DbSet<AccountImportRequestPayer> AccountImportRequestPayer { get; set; }
        public virtual DbSet<AccountImportRequestPercentPremise> AccountImportRequestPercentPremise { get; set; }
        public virtual DbSet<AccountImportRequestReason> AccountImportRequestReason { get; set; }
        public virtual DbSet<AccountImportResult> AccountImportResult { get; set; }
        public virtual DbSet<AccountImportResultError> AccountImportResultError { get; set; }
        public virtual DbSet<AckImportCancellationRequest> AckImportCancellationRequest { get; set; }
        public virtual DbSet<AckImportRequest> AckImportRequest { get; set; }
        public virtual DbSet<AckImportResult> AckImportResult { get; set; }
        public virtual DbSet<AckImportResultError> AckImportResultError { get; set; }
        public virtual DbSet<ContractImportRequest> ContractImportRequest { get; set; }
        public virtual DbSet<ContractImportRequestAttachment> ContractImportRequestAttachment { get; set; }
        public virtual DbSet<ContractImportRequestObjectAddress> ContractImportRequestObjectAddress { get; set; }
        public virtual DbSet<ContractImportRequestObjectServiceResource> ContractImportRequestObjectServiceResource { get; set; }
        public virtual DbSet<ContractImportRequestParty> ContractImportRequestParty { get; set; }
        public virtual DbSet<ContractImportRequestSubject> ContractImportRequestSubject { get; set; }
        public virtual DbSet<ContractImportRequestSubjectQualityIndicator> ContractImportRequestSubjectQualityIndicator { get; set; }
        public virtual DbSet<ContractImportResult> ContractImportResult { get; set; }
        public virtual DbSet<ContractImportResultError> ContractImportResultError { get; set; }
        public virtual DbSet<DeviceExportRequest> DeviceExportRequest { get; set; }
        public virtual DbSet<DeviceExportResult> DeviceExportResult { get; set; }
        public virtual DbSet<DeviceExportResultAccount> DeviceExportResultAccount { get; set; }
        public virtual DbSet<DeviceExportResultAddress> DeviceExportResultAddress { get; set; }
        public virtual DbSet<DeviceImportArchiveRequest> DeviceImportArchiveRequest { get; set; }
        public virtual DbSet<DeviceImportReplaceRequest> DeviceImportReplaceRequest { get; set; }
        public virtual DbSet<DeviceImportReplaceRequestValue> DeviceImportReplaceRequestValue { get; set; }
        public virtual DbSet<DeviceImportRequest> DeviceImportRequest { get; set; }
        public virtual DbSet<DeviceImportRequestAccount> DeviceImportRequestAccount { get; set; }
        public virtual DbSet<DeviceImportRequestAddress> DeviceImportRequestAddress { get; set; }
        public virtual DbSet<DeviceImportRequestLinkedDevice> DeviceImportRequestLinkedDevice { get; set; }
        public virtual DbSet<DeviceImportRequestValue> DeviceImportRequestValue { get; set; }
        public virtual DbSet<DeviceImportResult> DeviceImportResult { get; set; }
        public virtual DbSet<DeviceImportResultError> DeviceImportResultError { get; set; }
        public virtual DbSet<DeviceValueExportRequest> DeviceValueExportRequest { get; set; }
        public virtual DbSet<DeviceValueExportRequestDevice> DeviceValueExportRequestDevice { get; set; }
        public virtual DbSet<DeviceValueExportRequestDeviceType> DeviceValueExportRequestDeviceType { get; set; }
        public virtual DbSet<DeviceValueExportRequestMunicipalResource> DeviceValueExportRequestMunicipalResource { get; set; }
        public virtual DbSet<DeviceValueExportResult> DeviceValueExportResult { get; set; }
        public virtual DbSet<DeviceValueImportRequest> DeviceValueImportRequest { get; set; }
        public virtual DbSet<DeviceValueImportResult> DeviceValueImportResult { get; set; }
        public virtual DbSet<DeviceValueImportResultError> DeviceValueImportResultError { get; set; }
        public virtual DbSet<HouseExportRequest> HouseExportRequest { get; set; }
        public virtual DbSet<HouseExportResult> HouseExportResult { get; set; }
        public virtual DbSet<HouseExportResultBlock> HouseExportResultBlock { get; set; }
        public virtual DbSet<HouseExportResultEntrance> HouseExportResultEntrance { get; set; }
        public virtual DbSet<HouseExportResultLivingRoom> HouseExportResultLivingRoom { get; set; }
        public virtual DbSet<HouseExportResultPremise> HouseExportResultPremise { get; set; }
        public virtual DbSet<HouseImportRequest> HouseImportRequest { get; set; }
        public virtual DbSet<HouseImportRequestBlock> HouseImportRequestBlock { get; set; }
        public virtual DbSet<HouseImportRequestEntrance> HouseImportRequestEntrance { get; set; }
        public virtual DbSet<HouseImportRequestLivingRoom> HouseImportRequestLivingRoom { get; set; }
        public virtual DbSet<HouseImportRequestPremise> HouseImportRequestPremise { get; set; }
        public virtual DbSet<HouseImportResult> HouseImportResult { get; set; }
        public virtual DbSet<HouseImportResultBlock> HouseImportResultBlock { get; set; }
        public virtual DbSet<HouseImportResultBlockError> HouseImportResultBlockError { get; set; }
        public virtual DbSet<HouseImportResultEntrance> HouseImportResultEntrance { get; set; }
        public virtual DbSet<HouseImportResultEntranceError> HouseImportResultEntranceError { get; set; }
        public virtual DbSet<HouseImportResultError> HouseImportResultError { get; set; }
        public virtual DbSet<HouseImportResultLivingRoom> HouseImportResultLivingRoom { get; set; }
        public virtual DbSet<HouseImportResultLivingRoomError> HouseImportResultLivingRoomError { get; set; }
        public virtual DbSet<HouseImportResultPremise> HouseImportResultPremise { get; set; }
        public virtual DbSet<HouseImportResultPremiseError> HouseImportResultPremiseError { get; set; }
        public virtual DbSet<NotificationImportDeleteRequest> NotificationImportDeleteRequest { get; set; }
        public virtual DbSet<NotificationImportRequest> NotificationImportRequest { get; set; }
        public virtual DbSet<NotificationImportRequestAccountDebt> NotificationImportRequestAccountDebt { get; set; }
        public virtual DbSet<NotificationImportResult> NotificationImportResult { get; set; }
        public virtual DbSet<NotificationImportResultError> NotificationImportResultError { get; set; }
        public virtual DbSet<NsiExportRequest> NsiExportRequest { get; set; }
        public virtual DbSet<NsiExportResult> NsiExportResult { get; set; }
        public virtual DbSet<NsiExportResultField> NsiExportResultField { get; set; }
        public virtual DbSet<OrderImportCancellationRequest> OrderImportCancellationRequest { get; set; }
        public virtual DbSet<OrderImportRequest> OrderImportRequest { get; set; }
        public virtual DbSet<OrderImportResult> OrderImportResult { get; set; }
        public virtual DbSet<OrderImportResultError> OrderImportResultError { get; set; }
        public virtual DbSet<OrganizationExportRequest> OrganizationExportRequest { get; set; }
        public virtual DbSet<OrganizationExportRequestData> OrganizationExportRequestData { get; set; }
        public virtual DbSet<OrganizationExportResult> OrganizationExportResult { get; set; }
        public virtual DbSet<OrganizationExportResultEntp> OrganizationExportResultEntp { get; set; }
        public virtual DbSet<OrganizationExportResultLegal> OrganizationExportResultLegal { get; set; }
        public virtual DbSet<OrganizationExportResultRole> OrganizationExportResultRole { get; set; }
        public virtual DbSet<PaymentExportRequest> PaymentExportRequest { get; set; }
        public virtual DbSet<PaymentExportRequestAccount> PaymentExportRequestAccount { get; set; }
        public virtual DbSet<PaymentExportRequestDocument> PaymentExportRequestDocument { get; set; }
        public virtual DbSet<PaymentExportResult> PaymentExportResult { get; set; }
        public virtual DbSet<PaymentImportRequest> PaymentImportRequest { get; set; }
        public virtual DbSet<PaymentImportRequestChargesMunicipalService> PaymentImportRequestChargesMunicipalService { get; set; }
        public virtual DbSet<PaymentImportRequestChargesMunicipalServiceNorm> PaymentImportRequestChargesMunicipalServiceNorm { get; set; }
        public virtual DbSet<PaymentImportRequestDebtMunicipalService> PaymentImportRequestDebtMunicipalService { get; set; }
        public virtual DbSet<PaymentImportRequestPenaltyAndCourtCost> PaymentImportRequestPenaltyAndCourtCost { get; set; }
        public virtual DbSet<PaymentImportResult> PaymentImportResult { get; set; }
        public virtual DbSet<PaymentImportResultError> PaymentImportResultError { get; set; }
        public virtual DbSet<PaymentImportWithdrawRequest> PaymentImportWithdrawRequest { get; set; }
        public virtual DbSet<SettlementImportAnnulmentRequest> SettlementImportAnnulmentRequest { get; set; }
        public virtual DbSet<SettlementImportRequest> SettlementImportRequest { get; set; }
        public virtual DbSet<SettlementImportRequestPeriod> SettlementImportRequestPeriod { get; set; }
        public virtual DbSet<SettlementImportRequestPeriodAnnulment> SettlementImportRequestPeriodAnnulment { get; set; }
        public virtual DbSet<SettlementImportRequestPeriodInfo> SettlementImportRequestPeriodInfo { get; set; }
        public virtual DbSet<SettlementImportResult> SettlementImportResult { get; set; }
        public virtual DbSet<SettlementImportResultError> SettlementImportResultError { get; set; }
        public virtual DbSet<SysOperation> SysOperation { get; set; }
        public virtual DbSet<SysParams> SysParams { get; set; }
        public virtual DbSet<SysTransaction> SysTransaction { get; set; }
        public virtual DbSet<SysTransactionLog> SysTransactionLog { get; set; }
        public virtual DbSet<SysTransactionObject> SysTransactionObject { get; set; }
        public virtual DbSet<SysTransactionObjectError> SysTransactionObjectError { get; set; }
        public virtual DbSet<SysTransactionState2> SysTransactionState2 { get; set; }
        public virtual DbSet<SysTransactionStateType> SysTransactionStateType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountCloseRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_AccountCloseRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AccountNumber).IsUnicode(false);

                entity.Property(e => e.CloseDescription).IsUnicode(false);

                entity.Property(e => e.CloseReasonCode).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AccountCloseResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_AccountCloseResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AccountCloseResultAccount>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_AccountCloseResultAccount")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AccountNumber).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.AccountCloseTransportGU)
                    .WithMany(p => p.AccountCloseResultAccounts)
                    .HasForeignKey(d => d.AccountCloseTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountCloseResultAccount_AccountCloseResult");
            });

            modelBuilder.Entity<AccountCloseResultAccountError>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_AccountCloseResultAccountError")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.AccountCloseAccountTransportGU)
                    .WithMany(p => p.AccountCloseResultAccountErrors)
                    .HasForeignKey(d => d.AccountCloseAccountTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountCloseResultAccountError_AccountCloseResultAccount");
            });

            modelBuilder.Entity<AccountExportRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_AccountExportRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AccountExportResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_AccountExportResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AccountCloseReasonCode).IsUnicode(false);

                entity.Property(e => e.AccountNumber).IsUnicode(false);

                entity.Property(e => e.CloseDescription).IsUnicode(false);

                entity.Property(e => e.ServiceID).IsUnicode(false);

                entity.Property(e => e.UnifiedAccountNumber).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AccountExportResultPercentPremise>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_AccountExportResultPercentPremise")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.AccountExportTransportGU)
                    .WithMany(p => p.AccountExportResultPercentPremises)
                    .HasForeignKey(d => d.AccountExportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountExportResultPercentPremise_AccountExportResult");
            });

            modelBuilder.Entity<AccountImportRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_AccountImportRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AccountCloseReasonCode).IsUnicode(false);

                entity.Property(e => e.AccountNumber).IsUnicode(false);

                entity.Property(e => e.CloseDescription).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AccountImportRequestPayer>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_AccountImportRequestPayer")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.DocumentTypeCode).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.Number).IsUnicode(false);

                entity.Property(e => e.Patronymic).IsUnicode(false);

                entity.Property(e => e.SNILS).IsUnicode(false);

                entity.Property(e => e.Series).IsUnicode(false);

                entity.Property(e => e.Sex).IsUnicode(false);

                entity.Property(e => e.Surname).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.TransportGU)
                    .WithOne(p => p.AccountImportRequestPayer)
                    .HasForeignKey<AccountImportRequestPayer>(d => d.TransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountImportRequestPayer_AccountImportRequest");
            });

            modelBuilder.Entity<AccountImportRequestPercentPremise>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_AccountImportRequestPercentPremise")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.AccountImportTransportGU)
                    .WithMany(p => p.AccountImportRequestPercentPremises)
                    .HasForeignKey(d => d.AccountImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountImportRequestPercentPremise_AccountImportRequest");
            });

            modelBuilder.Entity<AccountImportRequestReason>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_AccountImportRequestReason")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.AccountImportTransportGUID, e.ContractGUID })
                    .HasName("UQ_AccountImportRequestReason1")
                    .IsUnique();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.AccountImportTransportGU)
                    .WithMany(p => p.AccountImportRequestReasons)
                    .HasForeignKey(d => d.AccountImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountImportRequestReason_AccountImportRequest");
            });

            modelBuilder.Entity<AccountImportResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_AccountImportResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ServiceID).IsUnicode(false);

                entity.Property(e => e.UnifiedAccountNumber).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AccountImportResultError>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_AccountImportResultError")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.AccountImportTransportGU)
                    .WithMany(p => p.AccountImportResultErrors)
                    .HasForeignKey(d => d.AccountImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountImportResultError_AccountImportResult");
            });

            modelBuilder.Entity<AckImportCancellationRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_AckImportCancellationRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.PaymentDocumentID).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AckImportRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_AckImportRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AckImpossibleReason).IsUnicode(false);

                entity.Property(e => e.AdditionalServiceCode).IsUnicode(false);

                entity.Property(e => e.BankBIK).IsUnicode(false);

                entity.Property(e => e.HousingServiceCode).IsUnicode(false);

                entity.Property(e => e.MainMunicipalServiceCode).IsUnicode(false);

                entity.Property(e => e.MunicipalServiceCode).IsUnicode(false);

                entity.Property(e => e.OperatingAccountNumber).IsUnicode(false);

                entity.Property(e => e.PaymentDocumentID).IsUnicode(false);

                entity.Property(e => e.PenaltyAndCourtCostCode).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AckImportResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_AckImportResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.UniqueNumber).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AckImportResultError>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_AckImportResultError")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.AckImportTransportGU)
                    .WithMany(p => p.AckImportResultErrors)
                    .HasForeignKey(d => d.AckImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AckImportResultError_AckImportResult");
            });

            modelBuilder.Entity<ContractImportRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_ContractImportRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AccrualProcedure).IsUnicode(false);

                entity.Property(e => e.BillingDateType).IsUnicode(false);

                entity.Property(e => e.ContractConclusionReasonCode).IsUnicode(false);

                entity.Property(e => e.ContractNumber).IsUnicode(false);

                entity.Property(e => e.CountingResource).IsUnicode(false);

                entity.Property(e => e.PaymentDateType).IsUnicode(false);

                entity.Property(e => e.PlannedVolumeType).IsUnicode(false);

                entity.Property(e => e.ProvidingInformationDateType).IsUnicode(false);

                entity.Property(e => e.SpecifyingQualityIndicators).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ContractImportRequestAttachment>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_ContractImportRequestAttachment")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AttachmentHASH).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.ContractImportTransportGU)
                    .WithMany(p => p.ContractImportRequestAttachments)
                    .HasForeignKey(d => d.ContractImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractImportRequestAttachment_ContractImportRequest");
            });

            modelBuilder.Entity<ContractImportRequestObjectAddress>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_ContractImportRequestObjectAddress")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ApartmentNumber).IsUnicode(false);

                entity.Property(e => e.RoomNumber).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.ContractImportTransportGU)
                    .WithMany(p => p.ContractImportRequestObjectAddresses)
                    .HasForeignKey(d => d.ContractImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractImportRequestObjectAddress_ContractImportRequest");
            });

            modelBuilder.Entity<ContractImportRequestObjectServiceResource>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_ContractImportRequestObjectServiceResource")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.CentralizedOrNot).IsUnicode(false);

                entity.Property(e => e.OpenOrNot).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.ContractImportObjectAddressTransportGU)
                    .WithMany(p => p.ContractImportRequestObjectServiceResources)
                    .HasForeignKey(d => d.ContractImportObjectAddressTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractImportRequestObjectServiceResource_ContractImportRequestObjectAddress");

                entity.HasOne(d => d.ContractImportSubjectTransportGU)
                    .WithMany(p => p.ContractImportRequestObjectServiceResources)
                    .HasForeignKey(d => d.ContractImportSubjectTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractImportRequestObjectServiceResource_ContractImportRequestSubject");
            });

            modelBuilder.Entity<ContractImportRequestParty>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_ContractImportRequestParty")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.DocumentTypeCode).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.Number).IsUnicode(false);

                entity.Property(e => e.Patronymic).IsUnicode(false);

                entity.Property(e => e.PlaceBirth).IsUnicode(false);

                entity.Property(e => e.SNILS).IsUnicode(false);

                entity.Property(e => e.Series).IsUnicode(false);

                entity.Property(e => e.Sex).IsUnicode(false);

                entity.Property(e => e.Surname).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.TransportGU)
                    .WithOne(p => p.ContractImportRequestParty)
                    .HasForeignKey<ContractImportRequestParty>(d => d.TransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractImportRequestParty_ContractImportRequest");
            });

            modelBuilder.Entity<ContractImportRequestSubject>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_ContractImportRequestSubject")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ChargeableResourceCode).IsUnicode(false);

                entity.Property(e => e.FeedingMode).IsUnicode(false);

                entity.Property(e => e.MunicipalServiceCode).IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.ContractImportTransportGU)
                    .WithMany(p => p.ContractImportRequestSubjects)
                    .HasForeignKey(d => d.ContractImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractImportRequestSubject_ContractImportRequest");
            });

            modelBuilder.Entity<ContractImportRequestSubjectQualityIndicator>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_ContractImportRequestSubjectQualityIndicator")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.IndicatorName).IsUnicode(false);

                entity.Property(e => e.OKEI).IsUnicode(false);

                entity.Property(e => e.QualityIndicatorCode).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.ContractImportObjectAddressTransportGU)
                    .WithMany(p => p.ContractImportRequestSubjectQualityIndicators)
                    .HasForeignKey(d => d.ContractImportObjectAddressTransportGUID)
                    .HasConstraintName("FK_ContractImportRequestSubjectQualityIndicator_ContractImportRequestObjectAddress");

                entity.HasOne(d => d.ContractImportSubjectTransportGU)
                    .WithMany(p => p.ContractImportRequestSubjectQualityIndicators)
                    .HasForeignKey(d => d.ContractImportSubjectTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractImportRequestSubjectQualityIndicator_ContractImportRequestSubject");
            });

            modelBuilder.Entity<ContractImportResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_ContractImportResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ContractImportResultError>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_ContractImportResultError")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.ContractImportTransportGU)
                    .WithMany(p => p.ContractImportResultErrors)
                    .HasForeignKey(d => d.ContractImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractImportResultError_ContractImportResult");
            });

            modelBuilder.Entity<DeviceExportRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceExportRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DeviceExportResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceExportResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.DeviceCalibrationIntervalCode).IsUnicode(false);

                entity.Property(e => e.DeviceModel).IsUnicode(false);

                entity.Property(e => e.DeviceNumber).IsUnicode(false);

                entity.Property(e => e.DeviceStamp).IsUnicode(false);

                entity.Property(e => e.RemoteMeteringInfo).IsUnicode(false);

                entity.Property(e => e.StatusRootDoc).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DeviceExportResultAccount>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceExportResultAccount")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.DeviceExportTransportGU)
                    .WithMany(p => p.DeviceExportResultAccounts)
                    .HasForeignKey(d => d.DeviceExportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceExportResultAccount_DeviceExportResult");
            });

            modelBuilder.Entity<DeviceExportResultAddress>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceExportResultAddress")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.DeviceExportTransportGU)
                    .WithMany(p => p.DeviceExportResultAddresses)
                    .HasForeignKey(d => d.DeviceExportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceExportResultAddress_DeviceExportResult");
            });

            modelBuilder.Entity<DeviceImportArchiveRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceImportArchiveRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.DeviceArchivingReasonCode).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DeviceImportReplaceRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceImportReplaceRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.DeviceFaultReasonCode).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DeviceImportReplaceRequestValue>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceImportReplaceRequestValue")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.MunicipalResourceCode).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.DeviceImportReplaceTransportGU)
                    .WithMany(p => p.DeviceImportReplaceRequestValues)
                    .HasForeignKey(d => d.DeviceImportReplaceTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceImportReplaceRequestValue_DeviceImportReplaceRequest");
            });

            modelBuilder.Entity<DeviceImportRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceImportRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.DeviceCalibrationIntervalCode).IsUnicode(false);

                entity.Property(e => e.DeviceModel).IsUnicode(false);

                entity.Property(e => e.DeviceNumber).IsUnicode(false);

                entity.Property(e => e.DeviceStamp).IsUnicode(false);

                entity.Property(e => e.InstallationPlace).IsUnicode(false);

                entity.Property(e => e.PressureSensingElementInfo).IsUnicode(false);

                entity.Property(e => e.RemoteMeteringInfo).IsUnicode(false);

                entity.Property(e => e.TemperatureSensingElementInfo).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DeviceImportRequestAccount>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceImportRequestAccount")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.DeviceImportTransportGUID, e.AccountGUID })
                    .HasName("UQ_DeviceImportRequestAccount1")
                    .IsUnique();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.DeviceImportTransportGU)
                    .WithMany(p => p.DeviceImportRequestAccounts)
                    .HasForeignKey(d => d.DeviceImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceImportRequestAccount_DeviceImportRequest");
            });

            modelBuilder.Entity<DeviceImportRequestAddress>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceImportRequestAddress")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.DeviceImportTransportGUID, e.AddressGUID })
                    .HasName("UQ_DeviceImportRequestAddress1")
                    .IsUnique();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.DeviceImportTransportGU)
                    .WithMany(p => p.DeviceImportRequestAddresses)
                    .HasForeignKey(d => d.DeviceImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceImportRequestAddress_DeviceImportRequest");
            });

            modelBuilder.Entity<DeviceImportRequestLinkedDevice>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceImportRequestLinkedDevice")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.DeviceImportTransportGUID, e.DeviceVersionGUID })
                    .HasName("UQ_DeviceImportRequestLinkedDevice1")
                    .IsUnique();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.DeviceImportTransportGU)
                    .WithMany(p => p.DeviceImportRequestLinkedDevices)
                    .HasForeignKey(d => d.DeviceImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceImportRequestLinkedDevice_DeviceImportRequest");
            });

            modelBuilder.Entity<DeviceImportRequestValue>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceImportRequestValue")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.MunicipalResourceCode).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.DeviceImportTransportGU)
                    .WithMany(p => p.DeviceImportRequestValues)
                    .HasForeignKey(d => d.DeviceImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceImportRequestValue_DeviceImportRequest");
            });

            modelBuilder.Entity<DeviceImportResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceImportResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.DeviceUniqueNumber).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DeviceImportResultError>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceImportResultError")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.DeviceImportTransportGU)
                    .WithMany(p => p.DeviceImportResultErrors)
                    .HasForeignKey(d => d.DeviceImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceImportResultError_DeviceImportResult");
            });

            modelBuilder.Entity<DeviceValueExportRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceValueExportRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DeviceValueExportRequestDevice>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceValueExportRequestDevice")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.DeviceValueExportTransportGU)
                    .WithMany(p => p.DeviceValueExportRequestDevices)
                    .HasForeignKey(d => d.DeviceValueExportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceValueExportRequestDevice_DeviceValueExportRequest");
            });

            modelBuilder.Entity<DeviceValueExportRequestDeviceType>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceValueExportRequestDeviceType")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.DeviceTypeCode).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.DeviceValueExportTransportGU)
                    .WithMany(p => p.DeviceValueExportRequestDeviceTypes)
                    .HasForeignKey(d => d.DeviceValueExportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceValueExportRequestDeviceType_DeviceValueExportRequest");
            });

            modelBuilder.Entity<DeviceValueExportRequestMunicipalResource>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceValueExportRequestMunicipalResource")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.MunicipalResourceCode).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.DeviceValueExportTransportGU)
                    .WithMany(p => p.DeviceValueExportRequestMunicipalResources)
                    .HasForeignKey(d => d.DeviceValueExportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceValueExportRequestMunicipalResource_DeviceValueExportRequest");
            });

            modelBuilder.Entity<DeviceValueExportResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceValueExportResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.MunicipalResourceCode).IsUnicode(false);

                entity.Property(e => e.ReadingsSource).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DeviceValueImportRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceValueImportRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.MunicipalResourceCode).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DeviceValueImportResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceValueImportResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DeviceValueImportResultError>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_DeviceValueImportResultError")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.DeviceValueImportTransportGU)
                    .WithMany(p => p.DeviceValueImportResultErrors)
                    .HasForeignKey(d => d.DeviceValueImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceValueImportResultError_DeviceValueImportResult");
            });

            modelBuilder.Entity<HouseExportRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseExportRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HouseExportResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseExportResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AnnulmentInfo).IsUnicode(false);

                entity.Property(e => e.AnnulmentReasonCode).IsUnicode(false);

                entity.Property(e => e.CadastralNumber).IsUnicode(false);

                entity.Property(e => e.HouseUniqueNumber).IsUnicode(false);

                entity.Property(e => e.OKTMO).IsUnicode(false);

                entity.Property(e => e.OlsonTZCode).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HouseExportResultBlock>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseExportResultBlock")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AnnulmentInfo).IsUnicode(false);

                entity.Property(e => e.AnnulmentReasonCode).IsUnicode(false);

                entity.Property(e => e.BlockNum).IsUnicode(false);

                entity.Property(e => e.BlockUniqueNumber).IsUnicode(false);

                entity.Property(e => e.CadastralNumber).IsUnicode(false);

                entity.Property(e => e.ResidentPremiseTypeCode).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HouseExportTransportGU)
                    .WithMany(p => p.HouseExportResultBlocks)
                    .HasForeignKey(d => d.HouseExportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseExportResultBlock_HouseExportResult");
            });

            modelBuilder.Entity<HouseExportResultEntrance>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseExportResultEntrance")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AnnulmentInfo).IsUnicode(false);

                entity.Property(e => e.AnnulmentReasonCode).IsUnicode(false);

                entity.Property(e => e.EntranceNum).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HouseExportTransportGU)
                    .WithMany(p => p.HouseExportResultEntrances)
                    .HasForeignKey(d => d.HouseExportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseExportResultEntrance_HouseExportResult");
            });

            modelBuilder.Entity<HouseExportResultLivingRoom>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseExportResultLivingRoom")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AnnulmentInfo).IsUnicode(false);

                entity.Property(e => e.AnnulmentReasonCode).IsUnicode(false);

                entity.Property(e => e.CadastralNumber).IsUnicode(false);

                entity.Property(e => e.LivingRoomUniqueNumber).IsUnicode(false);

                entity.Property(e => e.RoomNumber).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HouseExportBlockTransportGU)
                    .WithMany(p => p.HouseExportResultLivingRooms)
                    .HasForeignKey(d => d.HouseExportBlockTransportGUID)
                    .HasConstraintName("FK_HouseExportResultLivingRoom_HouseExportResultBlock");

                entity.HasOne(d => d.HouseExportPremiseTransportGU)
                    .WithMany(p => p.HouseExportResultLivingRooms)
                    .HasForeignKey(d => d.HouseExportPremiseTransportGUID)
                    .HasConstraintName("FK_HouseExportResultLivingRoom_HouseExportResultPremise");

                entity.HasOne(d => d.HouseExportTransportGU)
                    .WithMany(p => p.HouseExportResultLivingRooms)
                    .HasForeignKey(d => d.HouseExportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseExportResultLivingRoom_HouseExportResult");
            });

            modelBuilder.Entity<HouseExportResultPremise>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseExportResultPremise")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AnnulmentInfo).IsUnicode(false);

                entity.Property(e => e.AnnulmentReasonCode).IsUnicode(false);

                entity.Property(e => e.CadastralNumber).IsUnicode(false);

                entity.Property(e => e.PremisesNum).IsUnicode(false);

                entity.Property(e => e.PremisesUniqueNumber).IsUnicode(false);

                entity.Property(e => e.ResidentPremiseTypeCode).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HouseExportEntranceTransportGU)
                    .WithMany(p => p.HouseExportResultPremises)
                    .HasForeignKey(d => d.HouseExportEntranceTransportGUID)
                    .HasConstraintName("FK_HouseExportResultPremise_HouseExportResultEntrance");

                entity.HasOne(d => d.HouseExportTransportGU)
                    .WithMany(p => p.HouseExportResultPremises)
                    .HasForeignKey(d => d.HouseExportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseExportResultPremise_HouseExportResult");
            });

            modelBuilder.Entity<HouseImportRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseImportRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.CadastralNumber).IsUnicode(false);

                entity.Property(e => e.OKTMO).IsUnicode(false);

                entity.Property(e => e.OlsonTZCode).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HouseImportRequestBlock>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseImportRequestBlock")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AnnulmentInfo).IsUnicode(false);

                entity.Property(e => e.AnnulmentReasonCode).IsUnicode(false);

                entity.Property(e => e.BlockNum).IsUnicode(false);

                entity.Property(e => e.CadastralNumber).IsUnicode(false);

                entity.Property(e => e.ResidentPremiseTypeCode).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HouseImportTransportGU)
                    .WithMany(p => p.HouseImportRequestBlocks)
                    .HasForeignKey(d => d.HouseImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseImportRequestBlock_HouseImportRequest");
            });

            modelBuilder.Entity<HouseImportRequestEntrance>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseImportRequestEntrance")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AnnulmentInfo).IsUnicode(false);

                entity.Property(e => e.AnnulmentReasonCode).IsUnicode(false);

                entity.Property(e => e.EntranceNum).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HouseImportTransportGU)
                    .WithMany(p => p.HouseImportRequestEntrances)
                    .HasForeignKey(d => d.HouseImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseImportRequestEntrance_HouseImportRequest");
            });

            modelBuilder.Entity<HouseImportRequestLivingRoom>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseImportRequestLivingRoom")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AnnulmentInfo).IsUnicode(false);

                entity.Property(e => e.AnnulmentReasonCode).IsUnicode(false);

                entity.Property(e => e.CadastralNumber).IsUnicode(false);

                entity.Property(e => e.RoomNumber).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HouseImportBlockTransportGU)
                    .WithMany(p => p.HouseImportRequestLivingRooms)
                    .HasForeignKey(d => d.HouseImportBlockTransportGUID)
                    .HasConstraintName("FK_HouseImportRequestLivingRoom_HouseImportRequestBlock");

                entity.HasOne(d => d.HouseImportPremiseTransportGU)
                    .WithMany(p => p.HouseImportRequestLivingRooms)
                    .HasForeignKey(d => d.HouseImportPremiseTransportGUID)
                    .HasConstraintName("FK_HouseImportRequestLivingRoom_HouseImportRequestPremise");

                entity.HasOne(d => d.HouseImportTransportGU)
                    .WithMany(p => p.HouseImportRequestLivingRooms)
                    .HasForeignKey(d => d.HouseImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseImportRequestLivingRoom_HouseImportRequest");
            });

            modelBuilder.Entity<HouseImportRequestPremise>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseImportRequestPremise")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AnnulmentInfo).IsUnicode(false);

                entity.Property(e => e.AnnulmentReasonCode).IsUnicode(false);

                entity.Property(e => e.CadastralNumber).IsUnicode(false);

                entity.Property(e => e.PremisesNum).IsUnicode(false);

                entity.Property(e => e.ResidentPremiseTypeCode).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HouseImportEntranceTransportGU)
                    .WithMany(p => p.HouseImportRequestPremises)
                    .HasForeignKey(d => d.HouseImportEntranceTransportGUID)
                    .HasConstraintName("FK_HouseImportRequestPremise_HouseImportRequestEntrance");

                entity.HasOne(d => d.HouseImportTransportGU)
                    .WithMany(p => p.HouseImportRequestPremises)
                    .HasForeignKey(d => d.HouseImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseImportRequestPremise_HouseImportRequest");
            });

            modelBuilder.Entity<HouseImportResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseImportResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.HouseUniqueNumber).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HouseImportResultBlock>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseImportResultBlock")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.BlockUniqueNumber).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HouseImportTransportGU)
                    .WithMany(p => p.HouseImportResultBlocks)
                    .HasForeignKey(d => d.HouseImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseImportResultBlock_HouseImportResult");
            });

            modelBuilder.Entity<HouseImportResultBlockError>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseImportResultBlockError")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HouseImportBlockTransportGU)
                    .WithMany(p => p.HouseImportResultBlockErrors)
                    .HasForeignKey(d => d.HouseImportBlockTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseImportResultBlockError_HouseImportResultBlock");
            });

            modelBuilder.Entity<HouseImportResultEntrance>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseImportResultEntrance")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HouseImportTransportGU)
                    .WithMany(p => p.HouseImportResultEntrances)
                    .HasForeignKey(d => d.HouseImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseImportResultEntrance_HouseImportResult");
            });

            modelBuilder.Entity<HouseImportResultEntranceError>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseImportResultEntranceError")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HouseImportEntranceTransportGU)
                    .WithMany(p => p.HouseImportResultEntranceErrors)
                    .HasForeignKey(d => d.HouseImportEntranceTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseImportResultEntranceError_HouseImportResultEntrance");
            });

            modelBuilder.Entity<HouseImportResultError>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseImportResultError")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HouseImportTransportGU)
                    .WithMany(p => p.HouseImportResultErrors)
                    .HasForeignKey(d => d.HouseImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseImportResultError_HouseImportResult");
            });

            modelBuilder.Entity<HouseImportResultLivingRoom>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseImportResultLivingRoom")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.LivingRoomUniqueNumber).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HouseImportTransportGU)
                    .WithMany(p => p.HouseImportResultLivingRooms)
                    .HasForeignKey(d => d.HouseImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseImportResultLivingRoom_HouseImportResult");
            });

            modelBuilder.Entity<HouseImportResultLivingRoomError>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseImportResultLivingRoomError")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HouseImportLivingRoomTransportGU)
                    .WithMany(p => p.HouseImportResultLivingRoomErrors)
                    .HasForeignKey(d => d.HouseImportLivingRoomTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseImportResultLivingRoomError_HouseImportResultLivingRoom");
            });

            modelBuilder.Entity<HouseImportResultPremise>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseImportResultPremise")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.PremisesUniqueNumber).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HouseImportTransportGU)
                    .WithMany(p => p.HouseImportResultPremises)
                    .HasForeignKey(d => d.HouseImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseImportResultPremise_HouseImportResult");
            });

            modelBuilder.Entity<HouseImportResultPremiseError>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_HouseImportResultPremiseError")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HouseImportPremiseTransportGU)
                    .WithMany(p => p.HouseImportResultPremiseErrors)
                    .HasForeignKey(d => d.HouseImportPremiseTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HouseImportResultPremiseError_HouseImportResultPremise");
            });

            modelBuilder.Entity<NotificationImportDeleteRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_NotificationImportDeleteRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<NotificationImportRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_NotificationImportRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.Content).IsUnicode(false);

                entity.Property(e => e.Topic).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<NotificationImportRequestAccountDebt>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_NotificationImportRequestAccountDebt")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.UnifiedAccountNumber).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.NotificationImportTransportGU)
                    .WithMany(p => p.NotificationImportRequestAccountDebts)
                    .HasForeignKey(d => d.NotificationImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationImportRequestAccountDebt_NotificationImportRequest");
            });

            modelBuilder.Entity<NotificationImportResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_NotificationImportResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<NotificationImportResultError>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_NotificationImportResultError")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.NotificationImportTransportGU)
                    .WithMany(p => p.NotificationImportResultErrors)
                    .HasForeignKey(d => d.NotificationImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationImportResultError_NotificationImportResult");
            });

            modelBuilder.Entity<NsiExportRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_NsiExportRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<NsiExportResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_NsiExportResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<NsiExportResultField>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_NsiExportResultField")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.NsiExportTransportGU)
                    .WithMany(p => p.NsiExportResultFields)
                    .HasForeignKey(d => d.NsiExportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NsiExportResultField_NsiExportResult");
            });

            modelBuilder.Entity<OrderImportCancellationRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_OrderImportCancellationRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.OrderID).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OrderImportRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_OrderImportRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.PaymentDocumentID).IsUnicode(false);

                entity.Property(e => e.ServiceID).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OrderImportResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_OrderImportResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.OrderID).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OrderImportResultError>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_OrderImportResultError")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.OrderImportTransportGU)
                    .WithMany(p => p.OrderImportResultErrors)
                    .HasForeignKey(d => d.OrderImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderImportResultError_OrderImportResult");
            });

            modelBuilder.Entity<OrganizationExportRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_OrganizationExportRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OrganizationExportRequestData>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_OrganizationExportRequestData")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.KPP).IsUnicode(false);

                entity.Property(e => e.OGRN).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.OrganizationExportTransportGU)
                    .WithMany(p => p.OrganizationExportRequestData)
                    .HasForeignKey(d => d.OrganizationExportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizationExportRequestData_OrganizationExportRequest");
            });

            modelBuilder.Entity<OrganizationExportResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_OrganizationExportResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.RegistryOrganizationStatus).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OrganizationExportResultEntp>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_OrganizationExportResultEntp")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.INN).IsUnicode(false);

                entity.Property(e => e.OGRN).IsUnicode(false);

                entity.Property(e => e.Patronymic).IsUnicode(false);

                entity.Property(e => e.Sex).IsUnicode(false);

                entity.Property(e => e.Surname).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.TransportGU)
                    .WithOne(p => p.OrganizationExportResultEntp)
                    .HasForeignKey<OrganizationExportResultEntp>(d => d.TransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizationExportResultEntp_OrganizationExportResult");
            });

            modelBuilder.Entity<OrganizationExportResultLegal>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_OrganizationExportResultLegal")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.CommercialName).IsUnicode(false);

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.INN).IsUnicode(false);

                entity.Property(e => e.KPP).IsUnicode(false);

                entity.Property(e => e.OGRN).IsUnicode(false);

                entity.Property(e => e.OKOPF).IsUnicode(false);

                entity.Property(e => e.ShortName).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.TransportGU)
                    .WithOne(p => p.OrganizationExportResultLegal)
                    .HasForeignKey<OrganizationExportResultLegal>(d => d.TransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizationExportResultLegal_OrganizationExportResult");
            });

            modelBuilder.Entity<OrganizationExportResultRole>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_OrganizationExportResultRole")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.OrganizationRoleCode).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.OrganizationExportTransportGU)
                    .WithMany(p => p.OrganizationExportResultRoles)
                    .HasForeignKey(d => d.OrganizationExportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizationExportResultRole_OrganizationExportResult");
            });

            modelBuilder.Entity<PaymentExportRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_PaymentExportRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PaymentExportRequestAccount>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_PaymentExportRequestAccount")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AccountNumber).IsUnicode(false);

                entity.Property(e => e.ServiceID).IsUnicode(false);

                entity.Property(e => e.UnifiedAccountNumber).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.PaymentExportTransportGU)
                    .WithMany(p => p.PaymentExportRequestAccounts)
                    .HasForeignKey(d => d.PaymentExportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentExportRequestAccount_PaymentExportRequest");
            });

            modelBuilder.Entity<PaymentExportRequestDocument>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_PaymentExportRequestDocument")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.PaymentDocumentID).IsUnicode(false);

                entity.Property(e => e.PaymentDocumentNumber).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.PaymentExportTransportGU)
                    .WithMany(p => p.PaymentExportRequestDocuments)
                    .HasForeignKey(d => d.PaymentExportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentExportRequestDocument_PaymentExportRequest");
            });

            modelBuilder.Entity<PaymentExportResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_PaymentExportResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.PaymentDocumentID).IsUnicode(false);

                entity.Property(e => e.PaymentDocumentNumber).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PaymentImportRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_PaymentImportRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.AdditionalInformation).IsUnicode(false);

                entity.Property(e => e.BankBIK).IsUnicode(false);

                entity.Property(e => e.OperatingAccountNumber).IsUnicode(false);

                entity.Property(e => e.PaymentDocumentID).IsUnicode(false);

                entity.Property(e => e.PaymentDocumentNumber).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PaymentImportRequestChargesMunicipalService>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_PaymentImportRequestChargesMunicipalService")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.CalcExplanation).IsUnicode(false);

                entity.Property(e => e.DeterminingMethodI).IsUnicode(false);

                entity.Property(e => e.DeterminingMethodO).IsUnicode(false);

                entity.Property(e => e.MainMunicipalServiceCode).IsUnicode(false);

                entity.Property(e => e.RecalculationReason).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.PaymentImportTransportGU)
                    .WithMany(p => p.PaymentImportRequestChargesMunicipalServices)
                    .HasForeignKey(d => d.PaymentImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentImportRequestChargesMunicipalService_PaymentImportRequest");
            });

            modelBuilder.Entity<PaymentImportRequestChargesMunicipalServiceNorm>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_PaymentImportRequestChargesMunicipalServiceNorm")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.TransportGU)
                    .WithOne(p => p.PaymentImportRequestChargesMunicipalServiceNorm)
                    .HasForeignKey<PaymentImportRequestChargesMunicipalServiceNorm>(d => d.TransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentImportRequestChargesMunicipalServiceNorm_PaymentImportRequestChargesMunicipalService");
            });

            modelBuilder.Entity<PaymentImportRequestDebtMunicipalService>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_PaymentImportRequestDebtMunicipalService")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.MainMunicipalServiceCode).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.PaymentImportTransportGU)
                    .WithMany(p => p.PaymentImportRequestDebtMunicipalServices)
                    .HasForeignKey(d => d.PaymentImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentImportRequestDebtMunicipalService_PaymentImportRequest");
            });

            modelBuilder.Entity<PaymentImportRequestPenaltyAndCourtCost>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_PaymentImportRequestPenaltyAndCourtCost")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.Cause).IsUnicode(false);

                entity.Property(e => e.PenaltyAndCourtCostCode).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.PaymentImportTransportGU)
                    .WithMany(p => p.PaymentImportRequestPenaltyAndCourtCosts)
                    .HasForeignKey(d => d.PaymentImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentImportRequestPenaltyAndCourtCost_PaymentImportRequest");
            });

            modelBuilder.Entity<PaymentImportResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_PaymentImportResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.PaymentDocumentID).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PaymentImportResultError>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_PaymentImportResultError")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.PaymentImportTransportGU)
                    .WithMany(p => p.PaymentImportResultErrors)
                    .HasForeignKey(d => d.PaymentImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentImportResultError_PaymentImportResult");
            });

            modelBuilder.Entity<PaymentImportWithdrawRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_PaymentImportWithdrawRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.PaymentDocumentID).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SettlementImportAnnulmentRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_SettlementImportAnnulmentRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ReasonOfAnnulment).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SettlementImportRequest>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_SettlementImportRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SettlementImportRequestPeriod>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_SettlementImportRequestPeriod")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.SettlementImportTransportGUID, e.Month, e.Year })
                    .HasName("UQ_SettlementImportRequestPeriod1")
                    .IsUnique();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.SettlementImportTransportGU)
                    .WithMany(p => p.SettlementImportRequestPeriods)
                    .HasForeignKey(d => d.SettlementImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKSettlementImportRequestPeriod_SettlementImportRequest");
            });

            modelBuilder.Entity<SettlementImportRequestPeriodAnnulment>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_SettlementImportRequestPeriodAnnulment")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ReasonOfAnnulment).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.TransportGU)
                    .WithOne(p => p.SettlementImportRequestPeriodAnnulment)
                    .HasForeignKey<SettlementImportRequestPeriodAnnulment>(d => d.TransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SettlementImportRequestPeriodAnnulment_SettlementImportRequestPeriod");
            });

            modelBuilder.Entity<SettlementImportRequestPeriodInfo>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_SettlementImportRequestPeriodInfo")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.TransportGU)
                    .WithOne(p => p.SettlementImportRequestPeriodInfo)
                    .HasForeignKey<SettlementImportRequestPeriodInfo>(d => d.TransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SettlementImportRequestPeriodInfo_SettlementImportRequestPeriod");
            });

            modelBuilder.Entity<SettlementImportResult>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_SettlementImportResult")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SettlementImportResultError>(entity =>
            {
                entity.HasKey(e => e.TransportGUID)
                    .IsClustered(false);

                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.HasIndex(e => e.uniqueId)
                    .HasName("UQ_SettlementImportResultrror")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.TransportGUID).ValueGeneratedNever();

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.uniqueId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.SettlementImportTransportGU)
                    .WithMany(p => p.SettlementImportResultErrors)
                    .HasForeignKey(d => d.SettlementImportTransportGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SettlementImportResultError_SettlementImportResult");
            });

            modelBuilder.Entity<SysOperation>(entity =>
            {
                entity.Property(e => e.OperationId).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.OperationName).IsUnicode(false);
            });

            modelBuilder.Entity<SysParams>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasComputedColumnSql("((1))")
                    .ValueGeneratedNever();

                entity.Property(e => e.VersionNumber).IsUnicode(false);
            });

            modelBuilder.Entity<SysTransaction>(entity =>
            {
                entity.Property(e => e.TransactionGUID).ValueGeneratedNever();

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.TransactionData).IsUnicode(false);

                entity.HasOne(d => d.Operation)
                    .WithMany(p => p.SysTransactions)
                    .HasForeignKey(d => d.OperationId)
                    .HasConstraintName("FK_SysTransaction_SysOperation");
            });

            modelBuilder.Entity<SysTransactionLog>(entity =>
            {
                entity.HasIndex(e => new { e.TransactionGUID, e.LogDate })
                    .HasName("IX_SysTransactionLog");

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDescription).IsUnicode(false);

                entity.Property(e => e.ErrorStackTrace).IsUnicode(false);

                entity.Property(e => e.LogData).IsUnicode(false);

                entity.HasOne(d => d.TransactionGU)
                    .WithMany(p => p.SysTransactionLogs)
                    .HasForeignKey(d => d.TransactionGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SysTransactionLog_SysTransaction");
            });

            modelBuilder.Entity<SysTransactionObject>(entity =>
            {
                entity.HasIndex(e => new { e.TransactionGUID, e.objectId })
                    .HasName("IX_SysTransactionObject")
                    .IsUnique();

                entity.Property(e => e.comment).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);

                entity.Property(e => e.param).IsUnicode(false);
            });

            modelBuilder.Entity<SysTransactionObjectError>(entity =>
            {
                entity.HasIndex(e => new { e.TransactionGUID, e.objectId })
                    .HasName("IX_SysTransactionObjectError");

                entity.Property(e => e.errorCode).IsUnicode(false);

                entity.Property(e => e.errorDescription).IsUnicode(false);

                entity.Property(e => e.objectId).IsUnicode(false);
            });

            modelBuilder.Entity<SysTransactionState2>(entity =>
            {
                entity.HasIndex(e => e.TransactionGUID)
                    .HasName("IX_TransactionGUID");

                entity.Property(e => e.StateData).IsUnicode(false);

                entity.HasOne(d => d.Operation)
                    .WithMany(p => p.SysTransactionState2s)
                    .HasForeignKey(d => d.OperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SysTransactionState2_SysOperation");

                entity.HasOne(d => d.StateType)
                    .WithMany(p => p.SysTransactionState2s)
                    .HasForeignKey(d => d.StateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SysTransactionState2_SysTransactionStateType");

                entity.HasOne(d => d.TransactionGU)
                    .WithMany(p => p.SysTransactionState2s)
                    .HasForeignKey(d => d.TransactionGUID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SysTransactionState2_SysTransaction");
            });

            modelBuilder.Entity<SysTransactionStateType>(entity =>
            {
                entity.Property(e => e.TransactionStateTypeName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=SQL2008;Initial Catalog=GIS_HCS_main_156;user id=test;password=123;multipleactiveresultsets=True;");
            }
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}