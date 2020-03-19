namespace MVCAttendanceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTablePermission : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Permissions", "IsChecked", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Permissions", "IsChecked");
        }
    }
}
