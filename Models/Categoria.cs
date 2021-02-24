using System.ComponentModel.DataAnnotations;

namespace TodoList.Models {

    public class Categoria {

        [Key]
        public int Id { get; set; }

        [MinLength(3, ErrorMessage = "O nome da categoria deve conter no mínimo 3 caracteres.")]
        [MaxLength(40, ErrorMessage = "O nome da categoria deve conter no máximo 40 caracteres.")]
        public string Nome { get; set; }
    }

}
