using ControleAlunos.Models;
using System.Data.Entity;

namespace ControleAlunos.Context
{
    public class ControleAlunosContext: DbContext
    {
        //=== Criando o construtor da classe de Context
        public ControleAlunosContext()
            :base("Name=ControleAlunosContext")
        {
            
        }

        //=== Declarando as classes que se tornaram tabela
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Aula> Aula { get; set; }
        public DbSet<AlunoAula> AlunoAula { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}