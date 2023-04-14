using Aula.Enums;
using System.ComponentModel.DataAnnotations;

namespace Aula.Models
{
    public class ClienteModel
    {
        [Required]
        public string Nome { get; set; }

        [MaxLength(18)]
        public string Senha { get; set; }

        public SexoEnum Sexo { get; set; }

    }
}
