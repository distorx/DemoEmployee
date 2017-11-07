namespace EmployeeCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BuildingAndOtherStuff : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Selected = c.Boolean(nullable: false),
                        Employee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Employee_Id);
            
            AddColumn("dbo.Employees", "OtherBuilding", c => c.String());
            AddColumn("dbo.Employees", "RestrictedAccess", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Buildings", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.Buildings", new[] { "Employee_Id" });
            DropColumn("dbo.Employees", "RestrictedAccess");
            DropColumn("dbo.Employees", "OtherBuilding");
            DropTable("dbo.Buildings");
        }
    }
}
