using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class RedefinirSenhaModel
    {
        [Required(ErrorMessage = "Favor inserir o login do usuário.")]
        [Display(Name = "Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Favor inserir o email do usuário.")]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
