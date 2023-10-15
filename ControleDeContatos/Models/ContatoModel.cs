using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Favor inserir o nome do contato.")]
        [Display(Name = "Nome")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Favor inserir o email do contato.")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Favor digitar um email válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Favor inserir o celular do contato.")]
        [Display(Name = "Celular")]
        [Phone(ErrorMessage ="O celular informado não é válido.")]
        public string Celular { get; set; }

        public int? UsuarioId { get; set; }
        public UsuarioModel Usuario { get; set; }  
    }
}
