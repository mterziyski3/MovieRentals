namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6efc62c7-97cb-43ae-807b-9791aafaf350', N'admin@vidly.com', 0, N'AG3+iCMgOUQhQfvwVRBc+DqpOMujcQVdH3SUXbhApwyvCRXVHNkGRkcg7JE1UYk1qQ==', N'01155b24-7480-4231-ad79-334dde7a8fad', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f69abb8a-98f6-40e0-9556-d5bc7583c723', N'guest@vidly.com', 0, N'AM6twZGdkc9QRon/npDc4dboI9Yc1CLiTSaF7Up677MKqKTNwU6G7zKxiDH+u2TNPw==', N'd801bc33-97e7-42a3-982f-2945d9dbecb0', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bc4ac5b6-40f2-4cd1-b5c3-477d0e4c83e2', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6efc62c7-97cb-43ae-807b-9791aafaf350', N'bc4ac5b6-40f2-4cd1-b5c3-477d0e4c83e2')
");
        }
        
        public override void Down()
        {
        }
    }
}
