namespace MVCWebApp_Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSystemTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SystemRole",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 100),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SystemURL",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        URL = c.String(nullable: false, maxLength: 250),
                        PageName = c.String(nullable: false, maxLength: 100),
                        PageDecription = c.String(nullable: false, maxLength: 250),
                        IsOnTopMenu = c.Boolean(nullable: false),
                        IsOnMenu = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SystemURLFunction",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SystemURLParentID = c.Int(nullable: false),
                        SystemURLID = c.Int(nullable: false),
                        FunctionCode = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SystemURLMenu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SystemURLParentID = c.Int(nullable: false),
                        SystemURLID = c.Int(nullable: false),
                        IsHidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SystemUser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        IsPasswordChanged = c.Boolean(nullable: false),
                        FailedAttempts = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SystemUserRole",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SystemUserID = c.Int(nullable: false),
                        SystemRoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SystemUserRole");
            DropTable("dbo.SystemUser");
            DropTable("dbo.SystemURLMenu");
            DropTable("dbo.SystemURLFunction");
            DropTable("dbo.SystemURL");
            DropTable("dbo.SystemRole");
        }
    }
}
