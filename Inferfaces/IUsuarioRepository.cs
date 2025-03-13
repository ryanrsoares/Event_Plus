using Event_plus.Domains;

namespace Event_plus.Inferfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuarios novoUsuario);

        Usuarios BuscarPorId(Guid id);

        Usuarios BuscarPorEmailESenha(string email, string senha);
    }
}
