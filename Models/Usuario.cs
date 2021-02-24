using System.ComponentModel.DataAnnotations;

namespace TodoList.Models {

    public class Usuario {

        [Key]
        public int Id { get; set; }

        [MinLength(3, ErrorMessage = "O nome deve conter no mínimo 3 caracteres.")]
        [MaxLength(40, ErrorMessage = "O nome deve conter no máximo 40 caracteres.")]
        public string Nome { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "A senha deve conter no mínimo 8 caracteres.")]
        public string Senha { get; set; }

    }

}
