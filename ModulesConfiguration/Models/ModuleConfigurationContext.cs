using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ModuleConfiguration.Models
{
    public partial class ModuleConfigurationContext : DbContext
    {

    public ModuleConfigurationContext(DbContextOptions<ModuleConfigurationContext> options)    : base(options){ }

    public virtual DbSet<TblEmexModule> TblEmexModule { get; set; }
        public virtual DbSet<TblModuleConfig> TblModuleConfig { get; set; }
        public virtual DbSet<TblModuleControlConfig> TblModuleControlConfig { get; set; }
        public virtual DbSet<TblModuleControlRule> TblModuleControlRule { get; set; }
        public virtual DbSet<TblModuleGroupConfig> TblModuleGroupConfig { get; set; }
        public virtual DbSet<TblModuleGroupRule> TblModuleGroupRule { get; set; }
        public virtual DbSet<TblModuleGroupRuleFields> TblModuleGroupRuleFields { get; set; }
        public virtual DbSet<TblModuleGroupRuleMatrix> TblModuleGroupRuleMatrix { get; set; }
        public virtual DbSet<TblModuleRule> TblModuleRule { get; set; }
        public virtual DbSet<TblModuleRuleMatrix> TblModuleRuleMatrix { get; set; }
        public virtual DbSet<TblModuleSectionConfig> TblModuleSectionConfig { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblEmexModule>(entity =>
            {
                entity.HasKey(e => e.ModuleId);

                entity.ToTable("TBL_EmexModule");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_TBL_EmexModule")
                    .IsUnique();

                entity.Property(e => e.ModuleId).ValueGeneratedNever();

                entity.Property(e => e.DocumentEntityTypes).HasMaxLength(50);

                entity.Property(e => e.IsUsedInDocuments).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUsedInReports).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUsedInSearchGroups).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblModuleConfig>(entity =>
            {
                entity.HasKey(e => e.ModuleConfigId);

                entity.ToTable("TBL_ModuleConfig");

                entity.Property(e => e.ModuleConfigId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.TblModuleConfig)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_ModuleConfig_TBL_Module");
            });

            modelBuilder.Entity<TblModuleControlConfig>(entity =>
            {
                entity.HasKey(e => e.ModuleControlConfigId);

                entity.ToTable("TBL_ModuleControlConfig");

                entity.Property(e => e.ModuleControlConfigId).ValueGeneratedNever();

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DataUri).HasMaxLength(1000);

                entity.HasOne(d => d.ModuleGroupConfig)
                    .WithMany(p => p.TblModuleControlConfig)
                    .HasForeignKey(d => d.ModuleGroupConfigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_ModuleControlConfig_TBL_ModuleGroupConfig");

                entity.HasOne(d => d.ModuleSectionConfig)
                    .WithMany(p => p.TblModuleControlConfig)
                    .HasForeignKey(d => d.ModuleSectionConfigId)
                    .HasConstraintName("FK_TBL_ModuleControlConfig_TBL_ModuleSectionConfig");
            });

            modelBuilder.Entity<TblModuleControlRule>(entity =>
            {
                entity.HasKey(e => e.ModuleControlRuleId);

                entity.ToTable("TBL_ModuleControlRule");

                entity.Property(e => e.ModuleControlRuleId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ModuleControlConfig)
                    .WithMany(p => p.TblModuleControlRule)
                    .HasForeignKey(d => d.ModuleControlConfigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_ModuleControlRule_TBL_ModuleControlConfig");
            });

            modelBuilder.Entity<TblModuleGroupConfig>(entity =>
            {
                entity.HasKey(e => e.ModuleGroupConfigId);

                entity.ToTable("TBL_ModuleGroupConfig");

                entity.Property(e => e.ModuleGroupConfigId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.ModuleConfig)
                    .WithMany(p => p.TblModuleGroupConfig)
                    .HasForeignKey(d => d.ModuleConfigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_ModuleGroupConfig_TBL_ModuleConfig");
            });

            modelBuilder.Entity<TblModuleGroupRule>(entity =>
            {
                entity.HasKey(e => e.ModuleGroupRuleId);

                entity.ToTable("TBL_ModuleGroupRule");

                entity.Property(e => e.ModuleGroupRuleId).ValueGeneratedNever();

                entity.HasOne(d => d.ModuleGroupConfig)
                    .WithMany(p => p.TblModuleGroupRule)
                    .HasForeignKey(d => d.ModuleGroupConfigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_ModuleGroupRule_TBL_ModuleGroupConfig");
            });

            modelBuilder.Entity<TblModuleGroupRuleFields>(entity =>
            {
                entity.HasKey(e => e.ModuleGroupRuleFieldId);

                entity.ToTable("TBL_ModuleGroupRuleFields");

                entity.Property(e => e.ModuleGroupRuleFieldId).ValueGeneratedNever();

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.ModuleGroupRule)
                    .WithMany(p => p.TblModuleGroupRuleFields)
                    .HasForeignKey(d => d.ModuleGroupRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_ModuleGroupRuleFields_TBL_ModuleGroupRule");
            });

            modelBuilder.Entity<TblModuleGroupRuleMatrix>(entity =>
            {
                entity.HasKey(e => e.MatrixId);

                entity.ToTable("TBL_ModuleGroupRuleMatrix");

                entity.Property(e => e.MatrixId).ValueGeneratedNever();

                entity.HasOne(d => d.ModuleGroupRule)
                    .WithMany(p => p.TblModuleGroupRuleMatrix)
                    .HasForeignKey(d => d.ModuleGroupRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_ModuleGroupRuleMatrix_TBL_ModuleGroupRule");
            });

            modelBuilder.Entity<TblModuleRule>(entity =>
            {
                entity.HasKey(e => e.ModuleRuleId);

                entity.ToTable("TBL_ModuleRule");

                entity.Property(e => e.ModuleRuleId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.TblModuleRule)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_ModuleRule_TBL_EmexModule");
            });

            modelBuilder.Entity<TblModuleRuleMatrix>(entity =>
            {
                entity.HasKey(e => e.MatrixId);

                entity.ToTable("TBL_ModuleRuleMatrix");

                entity.Property(e => e.MatrixId).ValueGeneratedNever();

                entity.HasOne(d => d.ModuleRule)
                    .WithMany(p => p.TblModuleRuleMatrix)
                    .HasForeignKey(d => d.ModuleRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_ModuleRuleMatrix_TBL_ModuleRule");
            });

            modelBuilder.Entity<TblModuleSectionConfig>(entity =>
            {
                entity.HasKey(e => e.ModuleSectionConfigId);

                entity.ToTable("TBL_ModuleSectionConfig");

                entity.Property(e => e.ModuleSectionConfigId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });
        }
    }
}
