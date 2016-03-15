namespace AppointmentManager.Repository.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        MobileNumber = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        LastModificationDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        LastModifiedBy = c.String(),
                        Address = c.String(),
                        Title = c.String(),
                        StreetAddress1 = c.String(),
                        StreetAddress2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        CountryID = c.String(),
                        ZipCode = c.String(),
                        BusinessTelephoneNumber = c.String(),
                        WebSite = c.String(),
                        TaxIdentificationNumber = c.String(),
                        LicenseNumber = c.String(),
                        IsAvailableSaturday = c.Boolean(),
                        IsAvailableSunday = c.Boolean(),
                        IsAvailableMonday = c.Boolean(),
                        IsAvailableTuesday = c.Boolean(),
                        IsAvailableWednesday = c.Boolean(),
                        IsAvailableThursday = c.Boolean(),
                        IsAvailableFriday = c.Boolean(),
                        Country_ID = c.Int(),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Countries", t => t.Country_ID)
                .Index(t => t.Country_ID);
            
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ServiceProviderID = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        CustomerProfileId = c.Int(nullable: false),
                        AppointmentStatusId = c.Int(nullable: false),
                        TimeSlotId = c.Int(nullable: false),
                        AppointmentTime = c.DateTime(nullable: false),
                        DurationInMinutes = c.Int(nullable: false),
                        IsPaidByProvider = c.Boolean(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        LastModificationDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        LastModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AppointmentStatus", t => t.AppointmentStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.ServiceProviderID, cascadeDelete: false)
                .ForeignKey("dbo.CustomerProfiles", t => t.CustomerProfileId, cascadeDelete: true)
                .ForeignKey("dbo.TimeSlots", t => t.TimeSlotId, cascadeDelete: true)
                .Index(t => t.ServiceProviderID)
                .Index(t => t.CustomerID)
                .Index(t => t.CustomerProfileId)
                .Index(t => t.AppointmentStatusId)
                .Index(t => t.TimeSlotId);
            
            CreateTable(
                "dbo.AppointmentStatus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        LastModificationDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        LastModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CustomerProfiles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CustomerID = c.String(),
                        ServiceTypeID = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        LastModificationDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        LastModifiedBy = c.String(),
                        Customer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.Customer_ID)
                .ForeignKey("dbo.ServiceTypes", t => t.ServiceTypeID, cascadeDelete: true)
                .Index(t => t.ServiceTypeID)
                .Index(t => t.Customer_ID);
            
            CreateTable(
                "dbo.CustomerProfileAttributes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerProfileID = c.Int(nullable: false),
                        ServiceTypeAttributeID = c.Int(nullable: false),
                        AttributeValue = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        LastModificationDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        LastModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CustomerProfiles", t => t.CustomerProfileID, cascadeDelete: true)
                .ForeignKey("dbo.ServiceTypeAttributes", t => t.ServiceTypeAttributeID, cascadeDelete: true)
                .Index(t => t.CustomerProfileID)
                .Index(t => t.ServiceTypeAttributeID);
            
            CreateTable(
                "dbo.ServiceTypeAttributes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ServiceTypeID = c.Int(nullable: false),
                        AttributeName = c.String(),
                        LookupValues = c.String(),
                        ServiceAttributeTypeID = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        LastModificationDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        LastModifiedBy = c.String(),
                        AttributeType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AttributeTypes", t => t.AttributeType_ID)
                .ForeignKey("dbo.ServiceTypes", t => t.ServiceTypeID, cascadeDelete: false)
                .Index(t => t.ServiceTypeID)
                .Index(t => t.AttributeType_ID);
            
            CreateTable(
                "dbo.AttributeTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        LastModificationDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        LastModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ServiceTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        LastModificationDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        LastModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TimeSlots",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Value_StartTime = c.DateTime(nullable: false),
                        Value_DurationInMinutes = c.Int(nullable: false),
                        ServiceProvider_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.ServiceProvider_ID)
                .Index(t => t.ServiceProvider_ID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        LastModificationDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        LastModifiedBy = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ServiceProviderReviews",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        ServiceProviderID = c.String(),
                        Rating = c.Int(nullable: false),
                        AppointmentId = c.Int(nullable: false),
                        CustomerId = c.String(),
                        Comment = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        LastModificationDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        LastModifiedBy = c.String(),
                        Customer_ID = c.Int(),
                        ServiceProvider_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Appointments", t => t.ID)
                .ForeignKey("dbo.Users", t => t.Customer_ID)
                .ForeignKey("dbo.Users", t => t.ServiceProvider_ID)
                .Index(t => t.ID)
                .Index(t => t.Customer_ID)
                .Index(t => t.ServiceProvider_ID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ServiceTypeID = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        LastModificationDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        LastModifiedBy = c.String(),
                        Appointment_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ServiceTypes", t => t.ServiceTypeID, cascadeDelete: true)
                .ForeignKey("dbo.Appointments", t => t.Appointment_ID)
                .Index(t => t.ServiceTypeID)
                .Index(t => t.Appointment_ID);
            
            CreateTable(
                "dbo.ServiceProviderServiceTypes",
                c => new
                    {
                        ServiceProvider_ID = c.Int(nullable: false),
                        ServiceType_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ServiceProvider_ID, t.ServiceType_ID })
                .ForeignKey("dbo.Users", t => t.ServiceProvider_ID, cascadeDelete: true)
                .ForeignKey("dbo.ServiceTypes", t => t.ServiceType_ID, cascadeDelete: true)
                .Index(t => t.ServiceProvider_ID)
                .Index(t => t.ServiceType_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "TimeSlotId", "dbo.TimeSlots");
            DropForeignKey("dbo.Services", "Appointment_ID", "dbo.Appointments");
            DropForeignKey("dbo.Appointments", "CustomerProfileId", "dbo.CustomerProfiles");
            DropForeignKey("dbo.CustomerProfiles", "ServiceTypeID", "dbo.ServiceTypes");
            DropForeignKey("dbo.CustomerProfiles", "Customer_ID", "dbo.Users");
            DropForeignKey("dbo.CustomerProfileAttributes", "ServiceTypeAttributeID", "dbo.ServiceTypeAttributes");
            DropForeignKey("dbo.ServiceTypeAttributes", "ServiceTypeID", "dbo.ServiceTypes");
            DropForeignKey("dbo.Services", "ServiceTypeID", "dbo.ServiceTypes");
            DropForeignKey("dbo.ServiceProviderServiceTypes", "ServiceType_ID", "dbo.ServiceTypes");
            DropForeignKey("dbo.ServiceProviderServiceTypes", "ServiceProvider_ID", "dbo.Users");
            DropForeignKey("dbo.ServiceProviderReviews", "ServiceProvider_ID", "dbo.Users");
            DropForeignKey("dbo.ServiceProviderReviews", "Customer_ID", "dbo.Users");
            DropForeignKey("dbo.ServiceProviderReviews", "ID", "dbo.Appointments");
            DropForeignKey("dbo.Users", "Country_ID", "dbo.Countries");
            DropForeignKey("dbo.TimeSlots", "ServiceProvider_ID", "dbo.Users");
            DropForeignKey("dbo.Appointments", "ServiceProviderID", "dbo.Users");
            DropForeignKey("dbo.ServiceTypeAttributes", "AttributeType_ID", "dbo.AttributeTypes");
            DropForeignKey("dbo.CustomerProfileAttributes", "CustomerProfileID", "dbo.CustomerProfiles");
            DropForeignKey("dbo.Appointments", "CustomerID", "dbo.Users");
            DropForeignKey("dbo.Appointments", "AppointmentStatusId", "dbo.AppointmentStatus");
            DropIndex("dbo.ServiceProviderServiceTypes", new[] { "ServiceType_ID" });
            DropIndex("dbo.ServiceProviderServiceTypes", new[] { "ServiceProvider_ID" });
            DropIndex("dbo.Services", new[] { "Appointment_ID" });
            DropIndex("dbo.Services", new[] { "ServiceTypeID" });
            DropIndex("dbo.ServiceProviderReviews", new[] { "ServiceProvider_ID" });
            DropIndex("dbo.ServiceProviderReviews", new[] { "Customer_ID" });
            DropIndex("dbo.ServiceProviderReviews", new[] { "ID" });
            DropIndex("dbo.TimeSlots", new[] { "ServiceProvider_ID" });
            DropIndex("dbo.ServiceTypeAttributes", new[] { "AttributeType_ID" });
            DropIndex("dbo.ServiceTypeAttributes", new[] { "ServiceTypeID" });
            DropIndex("dbo.CustomerProfileAttributes", new[] { "ServiceTypeAttributeID" });
            DropIndex("dbo.CustomerProfileAttributes", new[] { "CustomerProfileID" });
            DropIndex("dbo.CustomerProfiles", new[] { "Customer_ID" });
            DropIndex("dbo.CustomerProfiles", new[] { "ServiceTypeID" });
            DropIndex("dbo.Appointments", new[] { "TimeSlotId" });
            DropIndex("dbo.Appointments", new[] { "AppointmentStatusId" });
            DropIndex("dbo.Appointments", new[] { "CustomerProfileId" });
            DropIndex("dbo.Appointments", new[] { "CustomerID" });
            DropIndex("dbo.Appointments", new[] { "ServiceProviderID" });
            DropIndex("dbo.Users", new[] { "Country_ID" });
            DropTable("dbo.ServiceProviderServiceTypes");
            DropTable("dbo.Services");
            DropTable("dbo.ServiceProviderReviews");
            DropTable("dbo.Countries");
            DropTable("dbo.TimeSlots");
            DropTable("dbo.ServiceTypes");
            DropTable("dbo.AttributeTypes");
            DropTable("dbo.ServiceTypeAttributes");
            DropTable("dbo.CustomerProfileAttributes");
            DropTable("dbo.CustomerProfiles");
            DropTable("dbo.AppointmentStatus");
            DropTable("dbo.Appointments");
            DropTable("dbo.Users");
        }
    }
}
