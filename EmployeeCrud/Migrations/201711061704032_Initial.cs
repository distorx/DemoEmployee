namespace EmployeeCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        HiringManagerEmail = c.String(),
                        JobPositionId = c.Int(nullable: false),
                        OtherJobPosition = c.String(),
                        PersonalEmail = c.String(),
                        MobileNumber = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        AdditionalServices = c.String(),
                        CompanyId = c.Int(nullable: false),
                        CompanyOther = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .ForeignKey("dbo.JobPositions", t => t.JobPositionId, cascadeDelete: true)
                .Index(t => t.JobPositionId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.JobPositions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ServiceEquipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Employee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Employee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceEquipments", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "JobPositionId", "dbo.JobPositions");
            DropForeignKey("dbo.Employees", "CompanyId", "dbo.Companies");
            DropIndex("dbo.ServiceEquipments", new[] { "Employee_Id" });
            DropIndex("dbo.Employees", new[] { "CompanyId" });
            DropIndex("dbo.Employees", new[] { "JobPositionId" });
            DropTable("dbo.ServiceEquipments");
            DropTable("dbo.JobPositions");
            DropTable("dbo.Employees");
            DropTable("dbo.Companies");
        }
    }
}
