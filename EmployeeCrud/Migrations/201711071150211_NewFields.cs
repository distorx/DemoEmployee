namespace EmployeeCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "FullName", c => c.String());
            AddColumn("dbo.ServiceEquipments", "Selected", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ServiceEquipments", "Selected");
            DropColumn("dbo.Employees", "FullName");
        }
    }
}
