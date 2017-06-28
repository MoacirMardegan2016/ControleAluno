using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ControleAlunos.Models
{
    public class Aula
    {
        [Key]
        public int IdAula { get; set; }

        [DisplayName("Descrição da Aula")]
        [MaxLength(30,ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string DescricaoAula { get; set; }
    }
}