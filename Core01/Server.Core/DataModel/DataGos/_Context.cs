//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Server.Core.Context
{
    using Microsoft.EntityFrameworkCore;
    using Server.Core.Model;
    
    public partial class EntityContext : DbContext
    {
        public virtual DbSet<Partners> Partners { get; set; }//;
        public virtual DbSet<payerlive> payerlive { get; set; }//;
        public virtual DbSet<rgn> rgn { get; set; }//;
        public virtual DbSet<street> street { get; set; }//;
        public virtual DbSet<type_street> type_street { get; set; }//;
        public virtual DbSet<type_village> type_village { get; set; }//;
        public virtual DbSet<village> village { get; set; }//;
        // 
        // Create navigation props
        private void createNavigations(ModelBuilder builder)
        {
            // 
            // FK_Partners_rgn__ml_rgn_id_PK_rgn [2]
            builder.Entity<Partners>().HasOne(u => u.rgn2).WithMany(t => t.Partners2).HasForeignKey(t => t.ml_rgn_id);//();
            // 
            // FK_Partners_rgn__ph_rgn_id_PK_rgn [3]
            builder.Entity<Partners>().HasOne(u => u.rgn3).WithMany(t => t.Partners3).HasForeignKey(t => t.ph_rgn_id);//();
            // 
            // FK_Partners_rgn__rgn_id_PK_rgn [4]
            builder.Entity<Partners>().HasOne(u => u.rgn4).WithMany(t => t.Partners4).HasForeignKey(t => t.rgn_id);//();
            // 
            // FK_street_partners__ph_street_id_PK_street []
            builder.Entity<Partners>().HasOne(u => u.street).WithMany(t => t.Partners).HasForeignKey(t => t.ph_street_id);//();
            // 
            // FK_street_partners__street_id_PK_street [1]
            builder.Entity<Partners>().HasOne(u => u.street1).WithMany(t => t.Partners1).HasForeignKey(t => t.street_id);//();
            // 
            // FK_village_partners__village_id_PK_village []
            builder.Entity<Partners>().HasOne(u => u.village).WithMany(t => t.Partners).HasForeignKey(t => t.village_id);//();
            // 
            // FK_village_partners__ph_village_id_PK_village [1]
            builder.Entity<Partners>().HasOne(u => u.village1).WithMany(t => t.Partners1).HasForeignKey(t => t.ph_village_id);//();
            // 
            // FK_payerlive_partners__reciever_id_PK_partners []
            builder.Entity<payerlive>().HasOne(u => u.Partners).WithMany(t => t.payerlive).HasForeignKey(t => t.reciever_id);//();
            // 
            // FK_payerlive_partners__payer_id_PK_partners [1]
            builder.Entity<payerlive>().HasOne(u => u.Partners1).WithMany(t => t.payerlive1).HasForeignKey(t => t.payer_id);//();
            // 
            // FK_village_street__village_id_PK_village []
            builder.Entity<street>().HasOne(u => u.village).WithMany(t => t.street).HasForeignKey(t => t.village_id);//();
            // 
            // FK_type_street_street__tstreet_id_PK_type_street []
            builder.Entity<street>().HasOne(u => u.type_street).WithMany(t => t.street).HasForeignKey(t => t.tstreet_id);//();
            // 
            // FK_village_rgn []
            builder.Entity<village>().HasOne(u => u.rgn).WithMany(t => t.village).HasForeignKey(t => t.rgn_id);//();
            // 
            // FK_type_village_village__tvillage_id_PK_type_village []
            builder.Entity<village>().HasOne(u => u.type_village).WithMany(t => t.village).HasForeignKey(t => t.tvillage_id);//();
        }
    }
}
