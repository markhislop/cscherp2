namespace BikeRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Originalversionofmodels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bikes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Model = c.String(),
                        Brand = c.String(),
                        Gender = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Stores_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.Stores_Id)
                .Index(t => t.Stores_Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Bike_Id = c.Int(),
                        Customer_Id = c.Int(),
                        DropoffStore_Id = c.Int(),
                        PickupStore_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bikes", t => t.Bike_Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.Stores", t => t.DropoffStore_Id)
                .ForeignKey("dbo.Stores", t => t.PickupStore_Id)
                .Index(t => t.Bike_Id)
                .Index(t => t.Customer_Id)
                .Index(t => t.DropoffStore_Id)
                .Index(t => t.PickupStore_Id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Place = c.String(),
                        Capacity = c.Int(nullable: false),
                        Staff = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "PickupStore_Id", "dbo.Stores");
            DropForeignKey("dbo.Reservations", "DropoffStore_Id", "dbo.Stores");
            DropForeignKey("dbo.Bikes", "Stores_Id", "dbo.Stores");
            DropForeignKey("dbo.Reservations", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Reservations", "Bike_Id", "dbo.Bikes");
            DropIndex("dbo.Reservations", new[] { "PickupStore_Id" });
            DropIndex("dbo.Reservations", new[] { "DropoffStore_Id" });
            DropIndex("dbo.Reservations", new[] { "Customer_Id" });
            DropIndex("dbo.Reservations", new[] { "Bike_Id" });
            DropIndex("dbo.Bikes", new[] { "Stores_Id" });
            DropTable("dbo.Stores");
            DropTable("dbo.Reservations");
            DropTable("dbo.Customers");
            DropTable("dbo.Bikes");
        }
    }
}
