using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cscrud.models
{
    public class Premium
    {

        [Key]
        [DisplayName("Id")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Digite o titulo do Premium")]
        [StringLength(80, ErrorMessage = "O título deve conter ao menos 80 caracteres")]
        [MinLength(10, ErrorMessage = "O título deve conter ao menos 10 caracteres")]
        [DisplayName("Título")]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        [DisplayName("Ínicio")]
        public DateTime StartDate { get; set; }


        [DataType(DataType.DateTime)]
        [DisplayName("Término")]
        public DateTime EndDate { get; set; }

        [DisplayName("Aluno")]
        [Required(ErrorMessage = "Aluno inválido")]
        public Guid StudentId { get; set; }

        public Student? Student { get; set; }
    }
}