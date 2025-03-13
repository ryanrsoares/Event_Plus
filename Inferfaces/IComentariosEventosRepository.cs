using Event_plus.Domains;

namespace Event_plus.Inferfaces
{
    public interface IComentariosEventosRepository
    {
        void Cadastrar(ComentariosEventos comentarioseventos);

        List<ComentariosEventos> Listar();

        void Deletar(Guid id);

        ComentariosEventos BuscarPorId(Guid id);
    }
}
