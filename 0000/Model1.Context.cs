﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DIPROJECT._0000
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class APTYPEntities : DbContext
    {
        private static APTYPEntities _context;
        public static APTYPEntities GetContext()
        {
            if (_context == null)
                _context = new APTYPEntities();
            return _context;
        }
        public APTYPEntities()
            : base("name=APTYPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Аккаунт> Аккаунт { get; set; }
        public virtual DbSet<Заказы> Заказы { get; set; }
        public virtual DbSet<Историязаказов> Историязаказов { get; set; }
        public virtual DbSet<Клиенты> Клиенты { get; set; }
        public virtual DbSet<Платежи> Платежи { get; set; }
        public virtual DbSet<Поставщики> Поставщики { get; set; }
        public virtual DbSet<Роль> Роль { get; set; }
    }
}