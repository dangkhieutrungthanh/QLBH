namespace QLBH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Student : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        TenKH = c.String(nullable: false, maxLength: 50, fixedLength: true),
                        Address = c.String(maxLength: 10, fixedLength: true),
                        SDT = c.String(maxLength: 15, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        TenStudent = c.String(nullable: false, maxLength: 50, fixedLength: true),
                        Address = c.String(maxLength: 10, fixedLength: true),
                        SDT = c.String(maxLength: 15, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student");
            DropTable("dbo.KhachHang");
        }
    }
}
