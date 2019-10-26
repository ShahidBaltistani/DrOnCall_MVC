namespace DoctorOnCall.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdfghj : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Appointments", "AppointmentType", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Appointments", "AppointmentType", c => c.Boolean(nullable: false));
        }
    }
}
