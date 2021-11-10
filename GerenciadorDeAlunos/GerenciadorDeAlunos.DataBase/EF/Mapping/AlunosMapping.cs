using GerenciadorDeAlunos.Models.Entity;
using System.Data.Entity.ModelConfiguration;

namespace GerenciadorDeAlunos.DataBase.EF.Mapping
{
    public class AlunosMapping : EntityTypeConfiguration<Alunos>
    {
        public AlunosMapping()
        {
            this.ToTable("Alunos");
            this.HasKey(t => t.ID);

            this.Property(t => t.ID).IsRequired().HasColumnName("ID");
            this.Property(t => t.Nome).IsRequired().HasMaxLength(100).HasColumnName("NomeCompleto");
            this.Property(t => t.Nascimento).IsRequired().HasColumnName("DataNascimento");
            this.Property(t => t.Responsavel).HasMaxLength(100).HasColumnName("NomeResponsavel");
            this.Property(t => t.Telefone).IsRequired().HasMaxLength(25).HasColumnName("Telefone");
            this.Property(t => t.Sexo).IsRequired().HasMaxLength(1).HasColumnName("Sexo");
            this.Property(t => t.Graduacao).IsRequired().HasDatabaseGeneratedOption(0).HasColumnName("Graduacao");
            this.Property(t => t.Status).IsRequired().HasMaxLength(1).HasColumnName("Stt");
            this.Property(t => t.Endereco).IsRequired().HasMaxLength(100).HasColumnName("Endereco");
        }
    }
}
