namespace BikeRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExtraCustomerFields : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservations", "DropoffStore_Id", "dbo.Stores");
            DropIndex("dbo.Reservations", new[] { "DropoffStore_Id" });
            AddColumn("dbo.Customers", "FirstName", c => c.String());
            AddColumn("dbo.Customers", "Lastname", c => c.String());
            AddColumn("dbo.Customers", "Zip", c => c.String());
            AddColumn("dbo.Customers", "StreetNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "Street", c => c.String());
            AddColumn("dbo.Customers", "City", c => c.String());
            DropColumn("dbo.Customers", "Name");
            DropColumn("dbo.Customers", "Gender");
            DropColumn("dbo.Reservations", "DropoffStore_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "DropoffStore_Id", c => c.Int());
            AddColumn("dbo.Customers", "Gender", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.Customers", "City");
            DropColumn("dbo.Customers", "Street");
            DropColumn("dbo.Customers", "StreetNumber");
            DropColumn("dbo.Customers", "Zip");
            DropColumn("dbo.Customers", "Lastname");
            DropColumn("dbo.Customers", "FirstName");
            CreateIndex("dbo.Reservations", "DropoffStore_Id");
            AddForeignKey("dbo.Reservations", "DropoffStore_Id", "dbo.Stores", "Id");
        }
    }
}
