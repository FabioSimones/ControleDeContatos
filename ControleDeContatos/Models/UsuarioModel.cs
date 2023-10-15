using ControleDeContatos.Helper;
using ControleDeContatos.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Favor inserir o nome do usuário.")]
        [Display(Name = "Nome")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Favor inserir o login do usuário.")]
        [Display(Name = "Login")]
        [StringLength(50)]
        public string Login { get; set; }

        [Required(ErrorMessage = "Favor inserir a senha do usuário.")]
        [Display(Name = "Senha")]
        [StringLength(50)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Favor inserir o email do usuário.")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Favor digitar um email válido.")]
        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }
        public DateTime? DataAltualizacao { get; set; }

        [Required(ErrorMessage = "Favor inserir o perfil do usuário.")]
        public PerfilEnum? Perfil { get; set; }

        public virtual List<ContatoModel> Contatos { get; set; }

        public bool SenhaValida(string senha)
        {
            return Senha == senha.GerarHash();
        }

        public void SetSenhaHash()
        {
            Senha = Senha.GerarHash();
        }

        public void SetNovaSenha(string novaSenha)
        {
            Senha = novaSenha.GerarHash();
        }

        public string GerarNovaSenha()
        {
            string novaSenha = Guid.NewGuid().ToString().Substring(0, 8);
            Senha = novaSenha.GerarHash();
            return novaSenha;
        }

    }
}
