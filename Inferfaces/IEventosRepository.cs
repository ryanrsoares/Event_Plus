using Event_plus.Domains;

namespace Event_plus.Inferfaces
{
    public interface IEventosRepository
    {
        List<Eventos> Listar();

        void Cadastrar (Eventos eventos);

        void Atualizar(Guid id, Eventos eventos);

        void Deletar(Guid id);

        Eventos ListarPorId (Guid id);

        Eventos BuscarPorId (Guid id);

        Eventos ListarProximosEventos (Guid id);
    }
}
