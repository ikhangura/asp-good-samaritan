namespace GoodSamaritan.Migrations.GoodSamaritanMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientModels", "Gender", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClientModels", "Gender");
        }
    }
}
