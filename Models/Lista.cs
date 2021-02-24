using System.ComponentModel.DataAnnotations;

namespace TodoList.Models {

    public class Lista {

        [Key]
        public int Id { get; set; }

        [MinLength(3, ErrorMessage = "A lista deve conter no mínimo 3 caracteres.")]
        [MaxLength(40, ErrorMessage = "A lista deve conter no máximo 40 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O id da categoria é obrigatório.")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "O campo Lista Concluída é obrigatório.")]
        public bool Concluida { get; set; }

    }

}
