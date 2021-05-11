namespace AspDotNet.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Dal : DbContext
    {
        // Your context has been configured to use a 'Employee' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'AspDotNet.Models.Employee' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Employee' 
        // connection string in the application configuration file.
        public Dal()
            : base("name=DefaultConnection")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Employee> MyEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("tblEmployee");
            modelBuilder.Entity<Employee>().HasKey(x => x.EmployeeId);
        }
    }

}