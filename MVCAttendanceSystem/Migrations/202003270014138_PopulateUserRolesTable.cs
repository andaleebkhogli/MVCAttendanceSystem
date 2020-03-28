namespace MVCAttendanceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUserRolesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'd49c9206-6e1b-479a-b2b5-d7b28f1163f6', N'c95745f9-bedb-48f1-a226-d563343acb54')");
            Sql("INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'06f5f9bc-151c-4e17-91bf-0e76d89e6f6a', N'c9dbc89d-c98f-4985-bb71-225dac13a14f')");
            Sql("INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'1a754523-5259-41a3-8027-ae8a9e084c48', N'c9dbc89d-c98f-4985-bb71-225dac13a14f')");
            Sql("INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'4a68d14f-be1d-4e52-88af-7699957bb879', N'c9dbc89d-c98f-4985-bb71-225dac13a14f')");
            Sql("INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'a47b5d50-5b3e-4944-a9e8-2a35c620fbd2', N'c9dbc89d-c98f-4985-bb71-225dac13a14f')");
            Sql("INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'a4a22a5b-1401-4c00-8bc7-1d7b96830e0f', N'c9dbc89d-c98f-4985-bb71-225dac13a14f')");
            Sql("INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'a8731f76-0ee0-47bc-9940-98cb43b8952a', N'c9dbc89d-c98f-4985-bb71-225dac13a14f')");
            Sql("INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'c2fbc2ad-489e-4c9f-9617-5807c80799ff', N'c9dbc89d-c98f-4985-bb71-225dac13a14f')");
            Sql("INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'd6a7bc90-e40f-4d90-8596-eb6e5d4644e4', N'c9dbc89d-c98f-4985-bb71-225dac13a14f')");
            Sql("INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'abff978d-8bd3-4e8b-b307-013460c7b583', N'f96c1562-3778-4d02-91d8-94e5ceef7ec1')");

        }

    public override void Down()
        {
        }
    }
}
