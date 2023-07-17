using System;
using System.Data.Entity;
using System.Linq;
using System.Xml;

namespace FIT5032_Week03_Codefirst.Models
{
    public class Week03_CodeFirst : DbContext
    {
        // Your context has been configured to use a 'Week03_CodeFirst' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'FIT5032_Week03_Codefirst.Models.Week03_CodeFirst' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Week03_CodeFirst' 
        // connection string in the application configuration file.
        public Week03_CodeFirst()
            : base("name=Week03-CodeFirst")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Student> Student { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
    public class Student
    {
       public int Id { get; set; }
        public string Name { get; set; }
    }
}