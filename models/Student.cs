using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cscrud.models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        [DisplayName("Id")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(70, ErrorMessage = "O nome deve conter até 70 caracteres")]
        [MinLength(3, ErrorMessage = "O nome deve conter ao menos 3 caracteres")]
        [DisplayName("Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o Email")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [DisplayName("Email Address")]
        public string Email { get; set; } = string.Empty;


        public List<Premium> Premiuns { get; set; } = new();






    }
}