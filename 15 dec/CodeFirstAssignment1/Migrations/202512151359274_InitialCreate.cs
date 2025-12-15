namespace CodeFirstAssignment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employeeclasses",
                c => new
                    {
                        Empid = c.String(nullable: false, maxLength: 10, unicode: false),
                        EmpName = c.String(nullable: false, maxLength: 20, unicode: false),
                        DepartmentName = c.String(nullable: false, maxLength: 20, unicode: false),
                        Salary = c.Int(nullable: false),
                        Year_Of_Join = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Empid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employeeclasses");
        }
    }
}
