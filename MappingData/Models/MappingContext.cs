using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MappingData.Models
{
    public class MappingContext : DbContext
    {
        public MappingContext()
        {
        }

        public MappingContext(DbContextOptions<MappingContext> options)
            : base(options)
        {
        }
        public virtual DbSet<TaMatMaterial> MatMaterial { get; set; }
        public virtual DbSet<TaMatMaterialDetail> MatMaterialDetail { get; set; }
        public virtual DbSet<TaMatPrice> MatPricing { get; set; }
        public virtual DbSet<TaMatStock> MatStock { get; set; }
        public virtual DbSet<TaMatStockIo> MatStockIo { get; set; }
        public virtual DbSet<TaMatUnit> MatUnit { get; set; }
        public virtual DbSet<TaMatWarehouse> MatWarehouse { get; set; }
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=198lytutrong.hnvgrp.com,1444;Initial Catalog=shop;Persist Security Info=True;User ID=thienphat;Password=thienphat");
            }
        }
    }
}
