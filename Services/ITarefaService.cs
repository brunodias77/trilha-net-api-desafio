using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrilhaApiDesafio.Models;

namespace trilhaNetApiDesafio.Services
{
    public interface ITarefaService
    {
        Tarefa ObterPorId(int id);
        bool AddTarefa(Tarefa tarefa);
        List<Tarefa> ObterTodos();
        IEnumerable<Tarefa> ObterPorTitulo(string titulo);
        bool DeletarTarefa(Tarefa tarefa);
        bool AtualizarTarefa(Tarefa tarefa);
        IEnumerable<Tarefa> ObterPorStatus(EnumStatusTarefa status);
        IEnumerable<Tarefa> ObterPorData(DateTime data);
    }
}