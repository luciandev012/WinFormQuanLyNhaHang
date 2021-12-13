namespace WinFormQuanLyNhaHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit_Timestamp_Type : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bills", "TimeStamp", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bills", "TimeStamp", c => c.DateTime(nullable: false));
        }
    }
}
