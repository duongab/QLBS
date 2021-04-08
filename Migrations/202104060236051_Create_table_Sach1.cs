namespace QLBS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_Sach1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Donhangs", name: "Khachhang_makh", newName: "makh");
            RenameIndex(table: "dbo.Donhangs", name: "IX_Khachhang_makh", newName: "IX_makh");
            AlterColumn("dbo.Sachs", "manxb", c => c.String(maxLength: 128, unicode: false));
            AlterColumn("dbo.Sachs", "machude", c => c.String(maxLength: 128, unicode: false));
            CreateIndex("dbo.Sachs", "manxb");
            CreateIndex("dbo.Sachs", "machude");
            AddForeignKey("dbo.Sachs", "machude", "dbo.Chudes", "machude");
            AddForeignKey("dbo.Sachs", "manxb", "dbo.Nhaxuatbans", "manxb");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sachs", "manxb", "dbo.Nhaxuatbans");
            DropForeignKey("dbo.Sachs", "machude", "dbo.Chudes");
            DropIndex("dbo.Sachs", new[] { "machude" });
            DropIndex("dbo.Sachs", new[] { "manxb" });
            AlterColumn("dbo.Sachs", "machude", c => c.String(unicode: false));
            AlterColumn("dbo.Sachs", "manxb", c => c.String(unicode: false));
            RenameIndex(table: "dbo.Donhangs", name: "IX_makh", newName: "IX_Khachhang_makh");
            RenameColumn(table: "dbo.Donhangs", name: "makh", newName: "Khachhang_makh");
        }
    }
}
