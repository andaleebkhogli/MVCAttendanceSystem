namespace MVCAttendanceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRolesAndUsersTable : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO[dbo].[AspNetRoles]([Id], [Name]) VALUES(N'f96c1562-3778-4d02-91d8-94e5ceef7ec1', N'Admin')");
            Sql("INSERT INTO[dbo].[AspNetRoles]([Id], [Name]) VALUES(N'c95745f9-bedb-48f1-a226-d563343acb54', N'Security')");
            Sql("INSERT INTO[dbo].[AspNetRoles]([Id], [Name]) VALUES(N'c9dbc89d-c98f-4985-bb71-225dac13a14f', N'Student')");

            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [DepartmentId], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'06f5f9bc-151c-4e17-91bf-0e76d89e6f6a', 4, N'mayar@mayar.com', 0, N'AFcByJWe77tGGVTK2ASi5hOKy3gXx2PteGDrO8fWBlHJu+HgSNSwDQMR7JiR56UPHA==', N'e8bff582-44a0-441e-8191-9e7ea5ba3336', NULL, 0, 0, NULL, 0, 0, N'mayar@mayar.com')");
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [DepartmentId], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'1a754523-5259-41a3-8027-ae8a9e084c48', 3, N'Andaleeb@andaleeb.com', 0, N'APhrFGulaUOk2tz0prnD5HAm2yVcz4RNNtTZzQIwjB/85v0UsyRcmNXT8O3/u4w9iQ==', N'c3bb6edf-b6b2-4a9f-9847-4756a51fb8ae', NULL, 0, 0, NULL, 0, 0, N'Andaleeb@andaleeb.com')");
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [DepartmentId], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'4a68d14f-be1d-4e52-88af-7699957bb879', 3, N'mina@mina.com', 0, N'AKvbCD1JQvT+Vafxg+j8YKR4scm5GXGmEAixbBLlzh46QlxaGhXqVkfcwTfLPCn03w==', N'e840c1bb-247d-4ef0-b6c6-0c420e48ca56', NULL, 0, 0, NULL, 1, 0, N'mina@mina.com')");
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [DepartmentId], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'a47b5d50-5b3e-4944-a9e8-2a35c620fbd2', 5, N'Arwa@arwa.com', 0, N'AEmJY37iikWuQs659ynJ0JdOP3G6bBkLNzXBRmsOsybawakMPpLIWPg96n/vqhXM+Q==', N'4a9cedd3-e1c7-4c3e-9693-341965e51c0a', NULL, 0, 0, NULL, 0, 0, N'Arwa@arwa.com')");
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [DepartmentId], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'a4a22a5b-1401-4c00-8bc7-1d7b96830e0f', 4, N'Abanob@abanob.com', 0, N'AL4KotvAZltjLO+cdJEJKXEnkC20I6A8a7NmUL4rsAqCzq4pBBgILlmLbvbQBfCqXw==', N'b6741ce6-8bc6-48fb-9ad8-882fb0b79a50', NULL, 0, 0, NULL, 0, 0, N'Abanob@abanob.com')");
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [DepartmentId], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'a8731f76-0ee0-47bc-9940-98cb43b8952a', 5, N'ali@ali.com', 0, N'AJt7PHw1zGxcE1pulGy8LZJubjJFzPq0rwQecQLyHgLFgXuebbG4bEZJw/+YuOU84A==', N'766c786a-7f64-453c-a98e-2f0cc43bbc04', N'0120000', 0, 0, NULL, 1, 0, N'ali@ali.com')");
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [DepartmentId], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'abff978d-8bd3-4e8b-b307-013460c7b583', 1, N'Admin@admin.com', 0, N'AE8wzwyIlsfo3kT+sWml5d8OwUpcjS2tROcdjT0ZOmGXs8ueajmdVHjnv/K0Q2sWCQ==', N'395c1347-ab7a-45f8-9f56-96b2e510d458', NULL, 0, 0, NULL, 1, 0, N'Admin@admin.com')");
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [DepartmentId], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'c2fbc2ad-489e-4c9f-9617-5807c80799ff', 2, N'shahenda@shahenda.com', 0, N'AEum3apMA4RQofnIZTBvio1i+sW42QZvqmbld0DkrUYZ4J9tLTtGDAT87wRQNC5+kw==', N'07316c6f-ffea-458b-950e-3187753a36f0', NULL, 0, 0, NULL, 0, 0, N'shahenda@shahenda.com')");
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [DepartmentId], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'd49c9206-6e1b-479a-b2b5-d7b28f1163f6', 1, N'Security@security.com', 0, N'AAQGpMT0xkdhjP/6DikisDG6ebKevHGgy0ajOQXg7/4BI0oV8qdaczFRk1jfRmqllA==', N'ecb1828f-33ba-4508-b62a-5013294a6392', NULL, 0, 0, NULL, 1, 0, N'Security@security.com')");
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [DepartmentId], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'd6a7bc90-e40f-4d90-8596-eb6e5d4644e4', 5, N'samar@samar.com', 0, N'AN0eCmy+fjxaJ0owowQ8HyiILM5CekTqpKbPRHi/3pwAS4zGZTjtluikIxXEpyruDQ==', N'18c4d3a6-ce1b-4729-8a9d-6086e292fd13', NULL, 0, 0, NULL, 0, 0, N'samar@samar.com')");

        }

    public override void Down()
        {
        }
    }
}
