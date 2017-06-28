using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ControleAlunos.Models
{
    public class AlunoAula
    {
        [Key]
        [Column(Order = 1)]
        public int IdAluno { get; set; }

        [Key]
        [Column(Order = 2)]
        public int IdAula { get; set; }




        public virtual Aula Aula { get; set; }
        public virtual Aluno Aluno{ get; set; }
    }
}