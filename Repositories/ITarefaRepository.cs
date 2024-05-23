using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrilhaApiDesafio.Models;

namespace TrilhaNetApiDesafio.Repositories
{
    public interface ITarefaRepository
    {
        bool Adicionar(Tarefa tarefa);
        bool Deletar(Tarefa tarefa);
        Tarefa ObterPorId(int id);
        List<Tarefa> ObterTodos();
        IEnumerable<Tarefa> ObterPorTitulo(string titulo);
        bool AtualizarTarefa(Tarefa tarefa);
        IEnumerable<Tarefa> ObterPorStatus(EnumStatusTarefa status);
        IEnumerable<Tarefa> ObterPorData(DateTime data);
    }
}