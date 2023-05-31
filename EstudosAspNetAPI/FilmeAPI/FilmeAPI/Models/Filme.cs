using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Models
{
    public class Filme
    {
        private string nome;
        private string genero;

        [Required(ErrorMessage = "O nome do filme é obrigatório")]
        [MinLength(3, ErrorMessage = "O nome do filme tem que ter no mínimo 3 caracteres")]
        public string Nome { get => nome; set => nome = value; }

        [Required(ErrorMessage = "O gênero do filme é obrigatório")]
        [MaxLength(10, ErrorMessage = "O gênero do filme não pode ultrapassar 10 caracteres")]
        public string Genero { get => genero; set => genero = value; }

        [Required(ErrorMessage = "A duração é obrigatória")]
        [Range(80, 300, ErrorMessage = "A duração do filme tem que ser maior do que 80 e menor do que 300 minutos")]
        public int Duracao { get; set; }

        [Key]
        [Required]
        public int Id { get; set; }
    }
}
