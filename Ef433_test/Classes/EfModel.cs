using Ef433_test.Classes.Types;
using MySql.Data.EntityFramework;
using System;
using System.Data.Entity;
using System.Linq;

namespace Ef433_test.Classes
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EfModel : DbContext
    {
        private static EfModel Instance;
        public static EfModel Init() {
            if (Instance == null) {
                Instance = new EfModel();
            }
            return Instance;
        }
        // Your context has been configured to use a 'EfModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Ef433_test.Classes.EfModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EfModel' 
        // connection string in the application configuration file.
        public EfModel()
            : base("server=192.168.201.12;port=3306;user id=testuser;password=test234;characterset=utf8;database=testuser_Gibdd433_Ef2")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}