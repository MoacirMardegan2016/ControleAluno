using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleAlunos.Models
{
    public class Aluno

    {
        [Key]
        public int IdAluno { get; set; }


        [DisplayName("Aluno:")]
        [Required(ErrorMessage = "Informe o nome do Aluno")]
        [MaxLength(30,ErrorMessage= "Campo deve ter no máximo {0} caracteres!")]
        [MinLength(2,ErrorMessage = "O Campo deverá ter no minimo {0} caracteres!!!")]
        public string NomeAluno { get; set; }

        
    }
}