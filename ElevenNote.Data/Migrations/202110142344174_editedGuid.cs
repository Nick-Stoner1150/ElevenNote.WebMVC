namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editedGuid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "OwnderId", c => c.Guid(nullable: false));
            DropColumn("dbo.Note", "guid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Note", "guid", c => c.Guid(nullable: false));
            DropColumn("dbo.Note", "OwnderId");
        }
    }
}
