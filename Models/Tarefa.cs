using System.ComponentModel.DataAnnotations;

namespace TodoList.Models {

    public class Tarefa {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O id da lista é obrigatório.")]
        public int ListaId { get; set; }

        [MinLength(3, ErrorMessage = "A lista deve conter no mínimo 3 caracteres.")]
        [MaxLength(40, ErrorMessage = "A lista deve conter no máximo 40 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Tarefa Concluída é obrigatório.")]
        public bool Concluida { get; set; }

        [Required(ErrorMessage = "O id do usuário é obrigatório.")]
        public int UsuarioId { get; set; }

    }

}
