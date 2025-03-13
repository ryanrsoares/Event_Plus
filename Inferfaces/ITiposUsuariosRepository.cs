using Event_plus.Domains;

namespace Event_plus.Inferfaces
{
    public interface ITiposUsuariosRepository
    {
        void Cadastrar(TiposUsuarios novoTipoDeUsuario);

        List<TiposUsuarios> Listar();

        void Atualizar(Guid id, TiposUsuarios tiposusuarios);

        void Deletar(Guid id);

        TiposUsuarios BuscarPorId(Guid id);
    }
}
