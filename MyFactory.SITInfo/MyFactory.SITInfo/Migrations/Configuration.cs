namespace MyFactory.SITInfo.Migrations
{
    using MyFactory.SITInfo.DbContexto;
    using MyFactory.SITInfo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyFactory.SITInfo.DbContexto.SITDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SITDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Usuarios.AddOrUpdate(
              new Usuario { Nome = "Admin", Ativo = true, Email = "admin@admin.com", Senha = "123", TipoConta = UserTipo.Admin }
            );
        }
    }
}
