namespace Lab11_MYSELF.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Lab11_MyselfDB : DbContext
    {
        public Lab11_MyselfDB()
            : base("name=Lab11_MyselfDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Magazine> Magazine { get; set; }
        public virtual DbSet<Weapon> Weapon { get; set; }
        public virtual DbSet<WeaponMagazine> WeaponMagazine { get; set; }
    }
}
