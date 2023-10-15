using ControleDeContatos.Models;
using System.Collections.Generic;

namespace ControleDeContatos.Repositorio.Interfaces
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel BuscarPorLogin(string login);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel ListarPorId(int id);
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Apagar(int id);
        UsuarioModel BuscarPorEmailELogin(string email, string login);
        UsuarioModel AlterarSenha(AlterarSenhaModel alterarSenhaModel);
    }
}
