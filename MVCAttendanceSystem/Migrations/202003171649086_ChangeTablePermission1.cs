namespace MVCAttendanceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTablePermission1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE [dbo].[Permissions] SET IsChecked = 'false' WHERE IsChecked IS NULL");
            AlterColumn("dbo.Permissions", "IsChecked", c => c.Boolean(nullable: false, defaultValue: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Permissions", "IsChecked", c => c.Boolean());
        }
    }
}
