namespace EmployeeCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewFields2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "OtherServiceEquipment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "OtherServiceEquipment");
        }
    }
}
