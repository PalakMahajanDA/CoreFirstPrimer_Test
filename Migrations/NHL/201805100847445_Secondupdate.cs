namespace CoreFirstPrimer.Migrations.NHL
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Secondupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "Country");
        }
    }
}
