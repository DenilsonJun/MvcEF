using GerenciadorDeAlunos.Models.Entity;
using GerenciadorDeAlunos.DataBase.EF.Mapping;
using System.Data.Entity;

namespace GerenciadorDeAlunos.DataBase.EF.Context
{
    public class DataBaseContext : DbContext
    {
        static DataBaseContext()
        {
            Database.SetInitializer<DataBaseContext>(null);
        }

        public DataBaseContext() : base("name=DataBaseContext")
        {

        }
        public virtual DbSet<Alunos> Alunos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlunosMapping());
        }

        public override int SaveChanges()
        {

            return base.SaveChanges();
        }
    }
}
