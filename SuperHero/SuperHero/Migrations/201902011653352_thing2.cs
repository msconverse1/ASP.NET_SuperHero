namespace SuperHero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thing2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SuperHeroes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HeroName = c.String(),
                        AlterEgoName = c.String(),
                        MainAbility = c.String(),
                        SecondaryAbility = c.String(),
                        Catchphrase = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SuperHeroes");
        }
    }
}
