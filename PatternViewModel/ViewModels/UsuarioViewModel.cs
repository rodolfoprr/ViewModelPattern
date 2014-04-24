using System.ComponentModel.DataAnnotations;

namespace PatternViewModel.ViewModels
{
    public class AutenticacaoViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        public bool ManterConectado { get; set; }
    }

    public class AlteracaoSenhaViewModel
    {
        [Required]
        public string Senha { get; set; }

        [Required]
        public string NovaSenha { get; set; }

        [Required]
        public string NovaSenhaConfirmacao { get; set; }
    }
}