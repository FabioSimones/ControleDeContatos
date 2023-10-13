using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Favor inserir o login do usuário.")]
        [Display(Name = "Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Favor inserir a senha do usuário.")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }
    }
}
