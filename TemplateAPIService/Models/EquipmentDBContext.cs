using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EquipmentAPIService.Models
{
  public partial class EquipmentDBContext : DbContext
  {
    public EquipmentDBContext(DbContextOptions<EquipmentDBContext> options) : base(options) { }

    public virtual DbSet<TblEquipmentConfig> TblEquipmentConfig { get; set; }
    public virtual DbSet<TblEquipmentConfigControl> TblEquipmentConfigControl { get; set; }
    public virtual DbSet<TblEquipmentConfigControlProperty> TblEquipmentConfigControlProperty { get; set; }
    public virtual DbSet<TblEquipmentItem> TblEquipmentItem { get; set; }
    public virtual DbSet<TblEquipmentItemLease> TblEquipmentItemLease { get; set; }
    public virtual DbSet<TblEquipmentItemLinkedEntity> TblEquipmentItemLinkedEntity { get; set; }
    public virtual DbSet<TblEquipmentLocation> TblEquipmentLocation { get; set; }
    public virtual DbSet<TblEquipmentLocationLinkedEntity> TblEquipmentLocationLinkedEntity { get; set; }
    public virtual DbSet<TblEquipmentMaintenance> TblEquipmentMaintenance { get; set; }
    public virtual DbSet<TblEquipmentMaintenanceGroup> TblEquipmentMaintenanceGroup { get; set; }
    public virtual DbSet<TblEquipmentMaintenanceLinkedEntity> TblEquipmentMaintenanceLinkedEntity { get; set; }
    public virtual DbSet<TblEquipmentMaintenanceSchedule> TblEquipmentMaintenanceSchedule { get; set; }
    public virtual DbSet<TblEquipmentMaintenanceScheduleLinkedEntity> TblEquipmentMaintenanceScheduleLinkedEntity { get; set; }
    public virtual DbSet<TblEquipmentModel> TblEquipmentModel { get; set; }
    public virtual DbSet<TblEquipmentModelConfig> TblEquipmentModelConfig { get; set; }
    public virtual DbSet<TblGroup> TblGroup { get; set; }
    public virtual DbSet<TblLocation> TblLocation { get; set; }
    public virtual DbSet<TblLocationAddress> TblLocationAddress { get; set; }
    public virtual DbSet<TblLocationLevel> TblLocationLevel { get; set; }
    public virtual DbSet<TblLocationMatrix> TblLocationMatrix { get; set; }
    public virtual DbSet<TblMasterListValue> TblMasterListValue { get; set; }
    public virtual DbSet<TblMasterListValueMatrix> TblMasterListValueMatrix { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<TblEquipmentConfig>(entity =>
      {
        entity.HasKey(e => e.ConfigId);

        entity.ToTable("TBL_EquipmentConfig");

        entity.Property(e => e.ConfigId).ValueGeneratedNever();

        entity.Property(e => e.Code)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.CodeValue).HasMaxLength(4000);

        entity.HasOne(d => d.EquipmentModel)
                  .WithMany(p => p.TblEquipmentConfig)
                  .HasForeignKey(d => d.EquipmentModelId)
                  .HasConstraintName("FK__TBL_EquipmentConfig__TBL_EquipmentModel__EquipmentModelId");
      });

      modelBuilder.Entity<TblEquipmentConfigControl>(entity =>
      {
        entity.HasKey(e => e.EquipmentConfigControlId);

        entity.ToTable("TBL_EquipmentConfigControl");

        entity.Property(e => e.EquipmentConfigControlId).ValueGeneratedNever();

        entity.Property(e => e.ControlId)
                  .IsRequired()
                  .HasMaxLength(50);

        entity.Property(e => e.ControlPath)
                  .IsRequired()
                  .HasMaxLength(255);

        entity.HasOne(d => d.EquipmentModel)
                  .WithMany(p => p.TblEquipmentConfigControl)
                  .HasForeignKey(d => d.EquipmentModelId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK__TBL_EquipmentConfigControl__TBL_EquipmentModel__EquipmentModelId");
      });

      modelBuilder.Entity<TblEquipmentConfigControlProperty>(entity =>
      {
        entity.HasKey(e => e.EquipmentConfigControlPropertyId);

        entity.ToTable("TBL_EquipmentConfigControlProperty");

        entity.Property(e => e.EquipmentConfigControlPropertyId).ValueGeneratedNever();

        entity.Property(e => e.PropertyName)
                  .IsRequired()
                  .HasMaxLength(255);

        entity.Property(e => e.PropertyType)
                  .IsRequired()
                  .HasMaxLength(50);

        entity.Property(e => e.PropertyValue).IsRequired();

        entity.HasOne(d => d.EquipmentConfigControl)
                  .WithMany(p => p.TblEquipmentConfigControlProperty)
                  .HasForeignKey(d => d.EquipmentConfigControlId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK__TBL_EquipmentConfigControlProperty__TBL_EquipmentConfigControl__EquipmentConfigControlId");
      });

      modelBuilder.Entity<TblEquipmentItem>(entity =>
      {
        entity.HasKey(e => e.EquipmentItemId);

        entity.ToTable("TBL_EquipmentItem");

        entity.Property(e => e.EquipmentItemId).ValueGeneratedNever();

        entity.Property(e => e.AddressArealText).HasMaxLength(2000);

        entity.Property(e => e.AddressDistrictText).HasMaxLength(2000);

        entity.Property(e => e.AssetHolder).HasMaxLength(255);

        entity.Property(e => e.AssetNumber).HasMaxLength(255);

        entity.Property(e => e.BenefitValue).HasColumnType("decimal(18, 0)");

        entity.Property(e => e.CategoryId).HasComputedColumnSql("([dbo].[GetEquipmentItemCategoryId]([EquipmentItemId]))");

        entity.Property(e => e.CategoryName)
                  .HasMaxLength(4000)
                  .HasComputedColumnSql("([dbo].[GetEquipmentItemCategoryName]([EquipmentItemId]))");

        entity.Property(e => e.CertificateExpiryDate).HasColumnType("datetime");

        entity.Property(e => e.ChasisNumber).HasMaxLength(50);

        entity.Property(e => e.Co2Output).HasColumnType("decimal(18, 0)");

        entity.Property(e => e.Colour).HasMaxLength(50);

        entity.Property(e => e.Condition).HasMaxLength(255);

        entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");

        entity.Property(e => e.CreatedDate).HasColumnType("datetime");

        entity.Property(e => e.DisposalCost).HasColumnType("decimal(18, 0)");

        entity.Property(e => e.DisposalDate).HasColumnType("datetime");

        entity.Property(e => e.DisposalMileage).HasColumnType("decimal(18, 0)");

        entity.Property(e => e.EngineSize).HasMaxLength(50);

        entity.Property(e => e.FinanceBudget).HasMaxLength(255);

        entity.Property(e => e.FleetNumber).HasMaxLength(50);

        entity.Property(e => e.GaapcodeId).HasColumnName("GAAPcodeId");

        entity.Property(e => e.KeyNumber).HasMaxLength(50);

        entity.Property(e => e.LatestDistance).HasColumnType("decimal(18, 0)");

        entity.Property(e => e.LatestDistanceDate).HasColumnType("datetime");

        entity.Property(e => e.LicenseBudget).HasColumnType("decimal(18, 0)");

        entity.Property(e => e.LicensedExpiryDate).HasColumnType("datetime");

        entity.Property(e => e.LocationId).HasComputedColumnSql("([dbo].[GetEquipmentItemLocationIdForToday]([EquipmentItemId]))");

        entity.Property(e => e.LocationName)
                  .HasMaxLength(4000)
                  .HasComputedColumnSql("([dbo].[GetEquipmentItemLocationNameForToday]([EquipmentItemId]))");

        entity.Property(e => e.MaintenanceBudget).HasColumnType("decimal(18, 0)");

        entity.Property(e => e.ManufactureYear).HasMaxLength(50);

        entity.Property(e => e.Name)
                  .IsRequired()
                  .HasMaxLength(255);

        entity.Property(e => e.OperatorsLicense).HasMaxLength(50);

        entity.Property(e => e.PlatingDate).HasColumnType("datetime");

        entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

        entity.Property(e => e.Quantity).HasMaxLength(255);

        entity.Property(e => e.RegisteredDate).HasColumnType("datetime");

        entity.Property(e => e.RegistrationNumber).HasMaxLength(50);

        entity.Property(e => e.ReplacementDate).HasColumnType("datetime");

        entity.Property(e => e.SerialNumber).HasMaxLength(255);

        entity.Property(e => e.ServiceDateLast)
                  .HasColumnType("datetime")
                  .HasComputedColumnSql("([dbo].[GetEquipmentItemServiceDateLast]([EquipmentItemId]))");

        entity.Property(e => e.ServiceDateNext)
                  .HasColumnType("datetime")
                  .HasComputedColumnSql("([dbo].[GetEquipmentItemServiceDateNext]([EquipmentItemId]))");

        entity.Property(e => e.SpeedoAdjustment).HasMaxLength(255);

        entity.Property(e => e.StartDate).HasColumnType("datetime");

        entity.Property(e => e.StartDistance).HasColumnType("decimal(18, 0)");

        entity.Property(e => e.SubTypeId).HasComputedColumnSql("([dbo].[GetEquipmentItemSubTypeId]([EquipmentItemId]))");

        entity.Property(e => e.SubTypeName)
                  .HasMaxLength(4000)
                  .HasComputedColumnSql("([dbo].[GetEquipmentItemSubTypeName]([EquipmentItemId]))");

        entity.Property(e => e.TaxExpiryDate).HasColumnType("datetime");

        entity.Property(e => e.TypeId).HasComputedColumnSql("([dbo].[GetEquipmentItemTypeId]([EquipmentItemId]))");

        entity.Property(e => e.TypeName)
                  .HasMaxLength(4000)
                  .HasComputedColumnSql("([dbo].[GetEquipmentItemTypeName]([EquipmentItemId]))");

        entity.Property(e => e.VehicleMake).HasMaxLength(50);

        entity.Property(e => e.VehicleModel).HasMaxLength(50);
      });

      modelBuilder.Entity<TblEquipmentItemLease>(entity =>
      {
        entity.HasKey(e => e.EquipmentItemLeaseId);

        entity.ToTable("TBL_EquipmentItemLease");

        entity.Property(e => e.EquipmentItemLeaseId).ValueGeneratedNever();

        entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");

        entity.Property(e => e.DateFrom).HasColumnType("datetime");

        entity.Property(e => e.DateTo).HasColumnType("datetime");

        entity.Property(e => e.PeriodFixedCharge).HasColumnType("decimal(18, 0)");

        entity.Property(e => e.PeriodManagementFee).HasColumnType("decimal(18, 0)");

        entity.Property(e => e.ReplacementDate).HasColumnType("datetime");

        entity.Property(e => e.ReplacementTerm).HasMaxLength(50);

        entity.HasOne(d => d.EquipmentItem)
                  .WithMany(p => p.TblEquipmentItemLease)
                  .HasForeignKey(d => d.EquipmentItemId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK__TBL_EquipmentItemLease__TBL_EquipmentItem__EquipmentItemId");
      });

      modelBuilder.Entity<TblEquipmentItemLinkedEntity>(entity =>
      {
        entity.HasKey(e => e.EquipmentItemLinkedEntityId);

        entity.ToTable("TBL_EquipmentItemLinkedEntity");

        entity.Property(e => e.EquipmentItemLinkedEntityId).ValueGeneratedNever();

        entity.HasOne(d => d.EquipmentItem)
                  .WithMany(p => p.TblEquipmentItemLinkedEntity)
                  .HasForeignKey(d => d.EquipmentItemId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK__TBL_EquipmentItemLinkedEntity__TBL_EquipmentItem__EquipmentItemId");
      });

      modelBuilder.Entity<TblEquipmentLocation>(entity =>
      {
        entity.HasKey(e => e.EquipmentLocationId);

        entity.ToTable("TBL_EquipmentLocation");

        entity.Property(e => e.EquipmentLocationId).ValueGeneratedNever();

        entity.Property(e => e.DateOff).HasColumnType("datetime");

        entity.Property(e => e.DateOn).HasColumnType("datetime");

        entity.HasOne(d => d.EquipmentItem)
                  .WithMany(p => p.TblEquipmentLocation)
                  .HasForeignKey(d => d.EquipmentItemId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK__TBL_EquipmentLocation__TBL_EquipmentItem__EquipmentItemId");
      });

      modelBuilder.Entity<TblEquipmentLocationLinkedEntity>(entity =>
      {
        entity.HasKey(e => e.EquipmentLocationLinkedEntityId);

        entity.ToTable("TBL_EquipmentLocationLinkedEntity");

        entity.Property(e => e.EquipmentLocationLinkedEntityId).ValueGeneratedNever();

        entity.HasOne(d => d.EquipmentLocation)
                  .WithMany(p => p.TblEquipmentLocationLinkedEntity)
                  .HasForeignKey(d => d.EquipmentLocationId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK__TBL_EquipmentLocationLinkedEntity__TBL_EquipmentLocation__EquipmentLocationId");
      });

      modelBuilder.Entity<TblEquipmentMaintenance>(entity =>
      {
        entity.HasKey(e => e.EquipmentMaintenanceId);

        entity.ToTable("TBL_EquipmentMaintenance");

        entity.Property(e => e.EquipmentMaintenanceId).ValueGeneratedNever();

        entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");

        entity.Property(e => e.CreatedDate).HasColumnType("datetime");

        entity.Property(e => e.EquipmentCategoryId).HasComputedColumnSql("([dbo].[GetEquipmentCategoryId]([MaintenanceType]))");

        entity.Property(e => e.EquipmentCategoryName)
                  .HasMaxLength(2000)
                  .HasComputedColumnSql("([dbo].[GetEquipmentCategoryName]([MaintenanceType]))");

        entity.Property(e => e.EquipmentItemLocationId).HasComputedColumnSql("([dbo].[GetEquipmentItemLocationIdForToday]([EquipmentItemId]))");

        entity.Property(e => e.EquipmentItemLocationName)
                  .HasMaxLength(4000)
                  .HasComputedColumnSql("([dbo].[GetEquipmentItemLocationNameForToday]([EquipmentItemId]))");

        entity.Property(e => e.EquipmentItemSubTypeId).HasComputedColumnSql("([dbo].[GetEquipmentItemSubTypeId]([EquipmentItemId]))");

        entity.Property(e => e.EquipmentItemSubTypeName)
                  .HasMaxLength(4000)
                  .HasComputedColumnSql("([dbo].[GetEquipmentItemSubTypeName]([EquipmentItemId]))");

        entity.Property(e => e.EquipmentItemTypeId).HasComputedColumnSql("([dbo].[GetEquipmentItemTypeId]([EquipmentItemId]))");

        entity.Property(e => e.EquipmentItemTypeName)
                  .HasMaxLength(4000)
                  .HasComputedColumnSql("([dbo].[GetEquipmentItemTypeName]([EquipmentItemId]))");

        entity.Property(e => e.MaintenanceDate).HasColumnType("datetime");

        entity.Property(e => e.Mileage).HasColumnType("decimal(18, 0)");

        entity.Property(e => e.ScheduleType)
                  .HasMaxLength(255)
                  .HasComputedColumnSql("([dbo].[GetEquipmentMaintenanceScheduleType]([EquipmentMaintenanceScheduleId]))");

        entity.HasOne(d => d.EquipmentItem)
                  .WithMany(p => p.TblEquipmentMaintenance)
                  .HasForeignKey(d => d.EquipmentItemId)
                  .HasConstraintName("FK__TBL_EquipmentMaintenance__TBL_EquipmentItem__EquipmentItemId");

        entity.HasOne(d => d.EquipmentMaintenanceGroup)
                  .WithMany(p => p.TblEquipmentMaintenance)
                  .HasForeignKey(d => d.EquipmentMaintenanceGroupId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK__TBL_EquipmentMaintenance__TBL_EquipmentMaintenanceGroup__EquipmentMaintenanceGroupId");

        entity.HasOne(d => d.EquipmentMaintenanceSchedule)
                  .WithMany(p => p.TblEquipmentMaintenance)
                  .HasForeignKey(d => d.EquipmentMaintenanceScheduleId)
                  .HasConstraintName("FK__TBL_EquipmentMaintenance__TBL_EquipmentMaintenanceSchedule__EquipmentMaintenanceScheduleId");
      });

      modelBuilder.Entity<TblEquipmentMaintenanceGroup>(entity =>
      {
        entity.HasKey(e => e.EquipmentMaintenanceGroupId);

        entity.ToTable("TBL_EquipmentMaintenanceGroup");

        entity.Property(e => e.EquipmentMaintenanceGroupId).ValueGeneratedNever();
      });

      modelBuilder.Entity<TblEquipmentMaintenanceLinkedEntity>(entity =>
      {
        entity.HasKey(e => e.EquipmentMaintenanceLinkedEntityId);

        entity.ToTable("TBL_EquipmentMaintenanceLinkedEntity");

        entity.Property(e => e.EquipmentMaintenanceLinkedEntityId).ValueGeneratedNever();

        entity.HasOne(d => d.EquipmentMaintenance)
                  .WithMany(p => p.TblEquipmentMaintenanceLinkedEntity)
                  .HasForeignKey(d => d.EquipmentMaintenanceId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK__TBL_EquipmentMaintenanceLinkedEntity__TBL_EquipmentMaintenance__EquipmentMaintenanceId");
      });

      modelBuilder.Entity<TblEquipmentMaintenanceSchedule>(entity =>
      {
        entity.HasKey(e => e.EquipmentMaintenanceScheduleId);

        entity.ToTable("TBL_EquipmentMaintenanceSchedule");

        entity.Property(e => e.EquipmentMaintenanceScheduleId).ValueGeneratedNever();

        entity.Property(e => e.CreatedDate).HasColumnType("datetime");

        entity.Property(e => e.MaintenanceDate).HasColumnType("datetime");

        entity.HasOne(d => d.EquipmentItem)
                  .WithMany(p => p.TblEquipmentMaintenanceSchedule)
                  .HasForeignKey(d => d.EquipmentItemId)
                  .HasConstraintName("FK__TBL_EquipmentMaintenanceSchedule__TBL_EquipmentItem__EquipmentItemId");

        entity.HasOne(d => d.EquipmentMaintenanceGroup)
                  .WithMany(p => p.TblEquipmentMaintenanceSchedule)
                  .HasForeignKey(d => d.EquipmentMaintenanceGroupId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK__TBL_EquipmentMaintenanceSchedule__TBL_EquipmentMaintenanceGroup__EquipmentMaintenanceGroupId");
      });

      modelBuilder.Entity<TblEquipmentMaintenanceScheduleLinkedEntity>(entity =>
      {
        entity.HasKey(e => e.EquipmentMaintenanceScheduleLinkedEntityId);

        entity.ToTable("TBL_EquipmentMaintenanceScheduleLinkedEntity");

        entity.Property(e => e.EquipmentMaintenanceScheduleLinkedEntityId).ValueGeneratedNever();

        entity.HasOne(d => d.EquipmentMaintenanceSchedule)
                  .WithMany(p => p.TblEquipmentMaintenanceScheduleLinkedEntity)
                  .HasForeignKey(d => d.EquipmentMaintenanceScheduleId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK__TBL_EquipmentMaintenanceScheduleLinkedEntity__TBL_EquipmentMaintenanceSchedule__EquipmentMaintenanceScheduleId");
      });

      modelBuilder.Entity<TblEquipmentModel>(entity =>
      {
        entity.HasKey(e => e.EquipmentModelId);

        entity.ToTable("TBL_EquipmentModel");

        entity.Property(e => e.EquipmentModelId).ValueGeneratedNever();

        entity.Property(e => e.Description).IsRequired();

        entity.Property(e => e.Name)
                  .IsRequired()
                  .HasMaxLength(50);
      });

      modelBuilder.Entity<TblEquipmentModelConfig>(entity =>
      {
        entity.HasKey(e => e.ConfigId);

        entity.ToTable("TBL_EquipmentModelConfig");

        entity.Property(e => e.ConfigId).ValueGeneratedNever();

        entity.Property(e => e.Code)
                  .IsRequired()
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.CodeValue).HasMaxLength(4000);

        entity.HasOne(d => d.EquipmentModel)
                  .WithMany(p => p.TblEquipmentModelConfig)
                  .HasForeignKey(d => d.EquipmentModelId)
                  .HasConstraintName("FK__TBL_EquipmentModelConfig__TBL_EquipmentModel__EquipmentModelId");
      });

      modelBuilder.Entity<TblGroup>(entity =>
      {
        entity.HasKey(e => e.GroupId);

        entity.ToTable("TBL_Group");

        entity.Property(e => e.GroupId).ValueGeneratedNever();

        entity.Property(e => e.ActivityCodeIds)
                  .HasMaxLength(4000)
                  .HasComputedColumnSql("([dbo].[GetGroupActivityCodeIds]([GroupId]))");

        entity.Property(e => e.ActivityCodeTitles)
                  .HasMaxLength(4000)
                  .HasComputedColumnSql("([dbo].[GetGroupActivityCodeTitles]([GroupId]))");

        entity.Property(e => e.Code1).HasMaxLength(100);

        entity.Property(e => e.Code2).HasMaxLength(100);

        entity.Property(e => e.Code3).HasMaxLength(100);

        entity.Property(e => e.Email).HasMaxLength(255);

        entity.Property(e => e.EndDate).HasColumnType("datetime");

        entity.Property(e => e.EstabilishmentName).HasMaxLength(300);

        entity.Property(e => e.Fax).HasMaxLength(255);

        entity.Property(e => e.GroupHierarchy)
                  .HasMaxLength(4000)
                  .HasComputedColumnSql("([dbo].[ShowGroupHierarchy]([GroupId],[GroupName]))");

        entity.Property(e => e.GroupLevel01)
                  .HasColumnName("GroupLevel_01")
                  .HasMaxLength(255)
                  .HasComputedColumnSql("([dbo].[ShowGroupHierarchyForLevel]([GroupId],(1)))");

        entity.Property(e => e.GroupLevel02)
                  .HasColumnName("GroupLevel_02")
                  .HasMaxLength(255)
                  .HasComputedColumnSql("([dbo].[ShowGroupHierarchyForLevel]([GroupId],(2)))");

        entity.Property(e => e.GroupLevel03)
                  .HasColumnName("GroupLevel_03")
                  .HasMaxLength(255)
                  .HasComputedColumnSql("([dbo].[ShowGroupHierarchyForLevel]([GroupId],(3)))");

        entity.Property(e => e.GroupLevel04)
                  .HasColumnName("GroupLevel_04")
                  .HasMaxLength(255)
                  .HasComputedColumnSql("([dbo].[ShowGroupHierarchyForLevel]([GroupId],(4)))");

        entity.Property(e => e.GroupLevel05)
                  .HasColumnName("GroupLevel_05")
                  .HasMaxLength(255)
                  .HasComputedColumnSql("([dbo].[ShowGroupHierarchyForLevel]([GroupId],(5)))");

        entity.Property(e => e.GroupLevel06)
                  .HasColumnName("GroupLevel_06")
                  .HasMaxLength(255)
                  .HasComputedColumnSql("([dbo].[ShowGroupHierarchyForLevel]([GroupId],(6)))");

        entity.Property(e => e.GroupLevel07)
                  .HasColumnName("GroupLevel_07")
                  .HasMaxLength(255)
                  .HasComputedColumnSql("([dbo].[ShowGroupHierarchyForLevel]([GroupId],(7)))");

        entity.Property(e => e.GroupLevel08)
                  .HasColumnName("GroupLevel_08")
                  .HasMaxLength(255)
                  .HasComputedColumnSql("([dbo].[ShowGroupHierarchyForLevel]([GroupId],(8)))");

        entity.Property(e => e.GroupLevel09)
                  .HasColumnName("GroupLevel_09")
                  .HasMaxLength(255)
                  .HasComputedColumnSql("([dbo].[ShowGroupHierarchyForLevel]([GroupId],(9)))");

        entity.Property(e => e.GroupLevel10)
                  .HasColumnName("GroupLevel_10")
                  .HasMaxLength(255)
                  .HasComputedColumnSql("([dbo].[ShowGroupHierarchyForLevel]([GroupId],(10)))");

        entity.Property(e => e.GroupName)
                  .IsRequired()
                  .HasMaxLength(255);

        entity.Property(e => e.HierarchyLevelNumber).HasComputedColumnSql("([dbo].[GetGroupHierarchyLevelNumber]([GroupId]))");

        entity.Property(e => e.Iso14001).HasColumnName("ISO14001");

        entity.Property(e => e.Iso2).HasColumnName("ISO2");

        entity.Property(e => e.Iso9001).HasColumnName("ISO9001");

        entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

        entity.Property(e => e.LogoData).HasColumnType("image");

        entity.Property(e => e.LogoPath).HasMaxLength(255);

        entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

        entity.Property(e => e.MapLevel1Code)
                  .IsRequired()
                  .HasMaxLength(255);

        entity.Property(e => e.MapLevel2Subregion)
                  .IsRequired()
                  .HasMaxLength(255);

        entity.Property(e => e.MapLevel3Region)
                  .IsRequired()
                  .HasMaxLength(255);

        entity.Property(e => e.MapLevel4Country)
                  .IsRequired()
                  .HasMaxLength(255);

        entity.Property(e => e.Ohsas18001).HasColumnName("OHSAS18001");

        entity.Property(e => e.Phone1).HasMaxLength(255);

        entity.Property(e => e.Phone2).HasMaxLength(255);

        entity.Property(e => e.Reference).HasMaxLength(50);

        entity.Property(e => e.StartDate).HasColumnType("datetime");

        entity.HasOne(d => d.Iso14001Navigation)
                  .WithMany(p => p.TblGroupIso14001Navigation)
                  .HasForeignKey(d => d.Iso14001)
                  .HasConstraintName("FK_TBL_Group_TBL_MasterListValue5");

        entity.HasOne(d => d.Iso2Navigation)
                  .WithMany(p => p.TblGroupIso2Navigation)
                  .HasForeignKey(d => d.Iso2)
                  .HasConstraintName("FK_TBL_Group_TBL_MasterListValue3");

        entity.HasOne(d => d.Iso9001Navigation)
                  .WithMany(p => p.TblGroupIso9001Navigation)
                  .HasForeignKey(d => d.Iso9001)
                  .HasConstraintName("FK_TBL_Group_TBL_MasterListValue6");

        entity.HasOne(d => d.LocaleNavigation)
                  .WithMany(p => p.TblGroupLocaleNavigation)
                  .HasForeignKey(d => d.Locale)
                  .HasConstraintName("FK_TBL_Group_TBL_MasterListValue");

        entity.HasOne(d => d.LocationNavigation)
                  .WithMany(p => p.TblGroupLocationNavigation)
                  .HasForeignKey(d => d.Location)
                  .HasConstraintName("FK_TBL_Group_TBL_MasterListValue1");

        entity.HasOne(d => d.Ohsas18001Navigation)
                  .WithMany(p => p.TblGroupOhsas18001Navigation)
                  .HasForeignKey(d => d.Ohsas18001)
                  .HasConstraintName("FK_TBL_Group_TBL_MasterListValue4");

        entity.HasOne(d => d.PlantSubType)
                  .WithMany(p => p.TblGroupPlantSubType)
                  .HasForeignKey(d => d.PlantSubTypeId)
                  .HasConstraintName("FK_TBL_Group_TBL_MasterListValue8");

        entity.HasOne(d => d.UnitType)
                  .WithMany(p => p.TblGroupUnitType)
                  .HasForeignKey(d => d.UnitTypeId)
                  .HasConstraintName("FK_TBL_Group_TBL_MasterListValue7");

        entity.HasOne(d => d.WorkGroupStatusNavigation)
                  .WithMany(p => p.TblGroupWorkGroupStatusNavigation)
                  .HasForeignKey(d => d.WorkGroupStatus)
                  .HasConstraintName("FK_TBL_Group_TBL_MasterListValue2");
      });

      modelBuilder.Entity<TblLocation>(entity =>
      {
        entity.HasKey(e => e.LocationId);

        entity.ToTable("TBL_Location");

        entity.HasIndex(e => new { e.ParentLocationId, e.LocationId })
                  .HasName("IX_TBL_Location_1")
                  .IsUnique();

        entity.Property(e => e.LocationId).ValueGeneratedNever();

        entity.Property(e => e.LocationPath)
                  .HasMaxLength(4000)
                  .HasComputedColumnSql("([dbo].[GetLocationPath]([LocationId],[Name]))");

        entity.Property(e => e.Name)
                  .IsRequired()
                  .HasMaxLength(255);

        entity.HasOne(d => d.LocationLevel)
                  .WithMany(p => p.TblLocation)
                  .HasForeignKey(d => d.LocationLevelId)
                  .HasConstraintName("FK_TBL_Location_TBL_LocationLevel");

        entity.HasOne(d => d.ParentLocation)
                  .WithMany(p => p.InverseParentLocation)
                  .HasForeignKey(d => d.ParentLocationId)
                  .HasConstraintName("FK_TBL_Location_TBL_Location");
      });

      modelBuilder.Entity<TblLocationAddress>(entity =>
      {
        entity.HasKey(e => e.AddressId);

        entity.ToTable("TBL_LocationAddress");

        entity.Property(e => e.AddressId)
                  .HasColumnName("AddressID")
                  .ValueGeneratedNever();

        entity.Property(e => e.Address)
                  .IsRequired()
                  .HasMaxLength(50);

        entity.Property(e => e.Address2).HasMaxLength(50);

        entity.Property(e => e.Address3).HasMaxLength(50);

        entity.Property(e => e.Address4).HasMaxLength(50);

        entity.Property(e => e.LocationId).HasColumnName("LocationID");

        entity.HasOne(d => d.AddressTypeNavigation)
                  .WithMany(p => p.TblLocationAddressAddressTypeNavigation)
                  .HasForeignKey(d => d.AddressType)
                  .OnDelete(DeleteBehavior.ClientSetNull);

        entity.HasOne(d => d.CityNavigation)
                  .WithMany(p => p.TblLocationAddressCityNavigation)
                  .HasForeignKey(d => d.City);

        entity.HasOne(d => d.CountryNavigation)
                  .WithMany(p => p.TblLocationAddressCountryNavigation)
                  .HasForeignKey(d => d.Country)
                  .OnDelete(DeleteBehavior.ClientSetNull);

        entity.HasOne(d => d.CountyNavigation)
                  .WithMany(p => p.TblLocationAddressCountyNavigation)
                  .HasForeignKey(d => d.County)
                  .OnDelete(DeleteBehavior.ClientSetNull);

        entity.HasOne(d => d.Location)
                  .WithMany(p => p.TblLocationAddress)
                  .HasForeignKey(d => d.LocationId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_TBL_LocationAddress_TBL_Location");
      });

      modelBuilder.Entity<TblLocationLevel>(entity =>
      {
        entity.HasKey(e => e.LocationLevelId);

        entity.ToTable("TBL_LocationLevel");

        entity.HasIndex(e => e.LocationLevelNumber)
                  .HasName("IX_TBL_LocationLevel_1")
                  .IsUnique();

        entity.HasIndex(e => e.Name)
                  .HasName("IX_TBL_LocationLevel")
                  .IsUnique();

        entity.Property(e => e.LocationLevelId).ValueGeneratedNever();

        entity.Property(e => e.Name)
                  .IsRequired()
                  .HasMaxLength(50);
      });

      modelBuilder.Entity<TblLocationMatrix>(entity =>
      {
        entity.HasKey(e => e.LocationMatrixId);

        entity.ToTable("TBL_LocationMatrix");

        entity.Property(e => e.LocationMatrixId).ValueGeneratedNever();

        entity.HasOne(d => d.Location)
                  .WithMany(p => p.TblLocationMatrix)
                  .HasForeignKey(d => d.LocationId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_TBL_LocationMatrix_TBL_Location");
      });

      modelBuilder.Entity<TblMasterListValue>(entity =>
      {
        entity.HasKey(e => e.ValueId)
                  .ForSqlServerIsClustered(false);

        entity.ToTable("TBL_MasterListValue");

        entity.HasIndex(e => e.ValueId)
                  .HasName("IX_TBL_MasterListValue")
                  .IsUnique();

        entity.Property(e => e.ValueId)
                  .HasColumnName("ValueID")
                  .HasDefaultValueSql("(newid())");

        entity.Property(e => e.AccessPermission).HasDefaultValueSql("((0))");

        entity.Property(e => e.Code)
                  .HasMaxLength(50)
                  .IsUnicode(false);

        entity.Property(e => e.MasterListId)
                  .HasColumnName("MasterListID")
                  .HasDefaultValueSql("((0))");

        entity.Property(e => e.ParentValueId).HasColumnName("ParentValueID");

        entity.Property(e => e.Title)
                  .IsRequired()
                  .HasMaxLength(2000)
                  .HasDefaultValueSql("('')");

        entity.Property(e => e.Version).HasDefaultValueSql("((0))");

        entity.HasOne(d => d.ParentValue)
                  .WithMany(p => p.InverseParentValue)
                  .HasForeignKey(d => d.ParentValueId)
                  .HasConstraintName("FK__TBL_MasterListValue__TBL_MasterListValue__ParentValueID");
      });

      modelBuilder.Entity<TblMasterListValueMatrix>(entity =>
      {
        entity.HasKey(e => e.MasterListValueMatrixId);

        entity.ToTable("TBL_MasterListValueMatrix");

        entity.Property(e => e.MasterListValueMatrixId)
                  .HasColumnName("MasterListValueMatrixID")
                  .ValueGeneratedNever();

        entity.Property(e => e.MasterListId).HasColumnName("MasterListID");

        entity.Property(e => e.MasterListValueId).HasColumnName("MasterListValueID");

        entity.HasOne(d => d.MasterListValue)
                  .WithMany(p => p.TblMasterListValueMatrix)
                  .HasForeignKey(d => d.MasterListValueId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_TBL_MasterListValueMatrix_TBL_MasterListValue");
      });
    }
  }
}
