namespace VidlyExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4d9b83e9-0c56-4ef3-8887-e85adf630335', N'guest@vidly.com', 0, N'AAipjkIa5fbKS1U+gA+oVNbSmo79pKgGBhvAc48M7cL4LFrVjYBscl9txQGWtxwgKw==', N'bdd9cc44-4291-427d-9875-6523da854832', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c1da056a-0a2c-4863-a82c-2bb55f49533d', N'admin3@vidly.com', 0, N'AIyyWdz4QpPSLxBxtz9qHpSwEZL+Yw4/qHEsvfQppZxkcGdGUS+O1zf76NY9Yj+loA==', N'2198f8fb-a0f7-49e8-9a01-8318fe933af1', NULL, 0, 0, NULL, 1, 0, N'admin3@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b41345f4-69cb-4387-86a5-7c602a5645e5', N'CanManageMovie')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c1da056a-0a2c-4863-a82c-2bb55f49533d', N'b41345f4-69cb-4387-86a5-7c602a5645e5')
");
        }
        
        public override void Down()
        {
        }
    }
}
