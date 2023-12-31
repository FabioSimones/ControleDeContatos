﻿using ControleDeContatos.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class UsuarioSemSenhaModel
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

        [Required(ErrorMessage = "Favor inserir o email do usuário.")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Favor digitar um email válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Favor inserir o perfil do usuário.")]
        public PerfilEnum? Perfil { get; set; }
    }
}
