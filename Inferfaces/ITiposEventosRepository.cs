using Event_plus.Domains;

namespace Event_plus.Inferfaces
{
    public interface ITiposEventosRepository
    {
        void Cadastrar(TiposEventos novoTipoEventos);
        List<TiposEventos> Listar();
        void Atualizar(Guid id, TiposEventos tiposeventos);
        void Deletar (Guid id);
        TiposEventos BuscarPorId(Guid id);
    }
}
