﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data
{
    public class CleanersNextDoorContext : DbContext, ICleanersNextDoorContext
    {
        public bool EnsureCreated()
        {
            return Database.EnsureCreated();
        }
        public CleanersNextDoorContext(DbContextOptions<CleanersNextDoorContext> options) : base(options) { }
       
        public DbSet<Authorization> Authorizations { get; set; }
        public DbSet<AuthorizationType> AuthorizationTypes { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<CashEvent> CashEvents { get; set; }
        public DbSet<CashEventType> CashEventTypes { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<DrivingSession> DrivingSessions { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<MerchantType> MerchantTypes { get; set; }
        public DbSet<MerchantUser> MerchantUsers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatusType> OrderStatusTypes { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentStatusType> PaymentStatusTypes { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PriceType> PriceTypes { get; set; }
        public DbSet<Refund> Refunds { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<ServiceRequestStatusType> ServiceRequestStatusTypes { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<TaxRate> TaxRates { get; set; }
        public DbSet<TaxType> TaxTypes { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VoidReasonType> VoidReasonTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authorization>();
            modelBuilder.Entity<AuthorizationType>();
            modelBuilder.Entity<CardType>();
            modelBuilder.Entity<CashEvent>();
            modelBuilder.Entity<CashEventType>();
            modelBuilder.Entity<Credit>();
            modelBuilder.Entity<Customer>();
            modelBuilder.Entity<Discount>();
            modelBuilder.Entity<DrivingSession>();
            modelBuilder.Entity<Item>();
            modelBuilder.Entity<ItemType>();
            modelBuilder.Entity<LineItem>();
            modelBuilder.Entity<Merchant>();
            modelBuilder.Entity<MerchantType>();
            modelBuilder.Entity<MerchantUser>();
            modelBuilder.Entity<Order>();
            modelBuilder.Entity<OrderStatusType>();
            modelBuilder.Entity<Payment>();
            modelBuilder.Entity<PaymentStatusType>();
            modelBuilder.Entity<PaymentType>();
            modelBuilder.Entity<Permission>();
            modelBuilder.Entity<PriceType>();
            modelBuilder.Entity<Refund>();
            modelBuilder.Entity<Role>();
            modelBuilder.Entity<RolePermission>();
            modelBuilder.Entity<ServiceRequest>();
            modelBuilder.Entity<ServiceRequestStatusType>();
            modelBuilder.Entity<State>();
            modelBuilder.Entity<TaxRate>();
            modelBuilder.Entity<TaxType>();
            modelBuilder.Entity<UnitType>();
            modelBuilder.Entity<User>();
            modelBuilder.Entity<VoidReasonType>();

            modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys())
                .ToList()
                .ForEach(r => r.DeleteBehavior = DeleteBehavior.Restrict);
        }
    }
}
