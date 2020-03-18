namespace MVCAttendanceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDepartmentTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Departments values('Workers')");
            Sql("insert into Departments values('SD')");
            Sql("insert into Departments values('OS')");
            Sql("insert into Departments values('SA')");
            Sql("insert into Departments values('Mobile')");
        }
        
        public override void Down()
        {
        }
    }
}
