using Aula.Enums;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Aula.Models
{
	public class ClienteModel
    {
        [Display(Name = "Nome Fantasia"), Required]
        public string NomeFantasia { get; set; }

        [Display(Name = "Razão Social"), Required]
        public string RazaoSocial { get; set; }

		[Display(Name = "Inscrição Federal"), Required]
        public string InscricaoFederal { get; set; }

		[Display(Name = "Inscrição Estadual")]
		public string InscricaoEstadual { get; set; }

		[Display(Name = "Tributação")]
		public TributacaoEnum Tributacao { get; set; }

        public EnderecoModel Endereco { get; set; }

        public bool Ativo { get; set; }

    }
}
