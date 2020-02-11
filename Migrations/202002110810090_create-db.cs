namespace WebAPI_CodeFistEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        idStudent = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Age = c.Int(nullable: false),
                        BirthDay = c.DateTime(nullable: false),
                        address = c.String(maxLength: 50),
                        idRoom = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idStudent)
                .ForeignKey("dbo.Rooms", t => t.idRoom, cascadeDelete: true)
                .Index(t => t.idRoom);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        idRoom = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.idRoom);
            
            CreateTable(
                "dbo.StudentExercises",
                c => new
                    {
                        StudentExerciseID = c.Int(nullable: false, identity: true),
                        idStudent = c.Int(nullable: false),
                        idExercise = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentExerciseID)
                .ForeignKey("dbo.Exercises", t => t.idExercise, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.idStudent, cascadeDelete: true)
                .Index(t => t.idStudent)
                .Index(t => t.idExercise);
            
            CreateTable(
                "dbo.Exercises",
                c => new
                    {
                        idExercise = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.idExercise);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentExercises", "idStudent", "dbo.Students");
            DropForeignKey("dbo.StudentExercises", "idExercise", "dbo.Exercises");
            DropForeignKey("dbo.Students", "idRoom", "dbo.Rooms");
            DropIndex("dbo.StudentExercises", new[] { "idExercise" });
            DropIndex("dbo.StudentExercises", new[] { "idStudent" });
            DropIndex("dbo.Students", new[] { "idRoom" });
            DropTable("dbo.Exercises");
            DropTable("dbo.StudentExercises");
            DropTable("dbo.Rooms");
            DropTable("dbo.Students");
        }
    }
}
