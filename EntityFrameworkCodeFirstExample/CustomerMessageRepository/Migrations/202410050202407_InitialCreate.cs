﻿namespace CustomerMessageRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerMessages",
                c => new
                    {
                        IdCustomerMessage = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.IdCustomerMessage);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerMessages");
        }
    }
}
