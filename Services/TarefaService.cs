using TrilhaApiDesafio.Models;
using TrilhaNetApiDesafio.Repositories;

namespace trilhaNetApiDesafio.Services
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepository _tarefaRepository;

        public TarefaService(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository ?? throw new ArgumentNullException(nameof(tarefaRepository));
        }

        public Tarefa ObterPorId(int id)
        {
            var tarefa = _tarefaRepository.ObterPorId(id);
            return tarefa;
        }
        public bool AddTarefa(Tarefa tarefa)
        {
            var tarefaAdicionada = _tarefaRepository.Adicionar(tarefa);
            return tarefaAdicionada;
        }

        public List<Tarefa> ObterTodos()
        {
            return _tarefaRepository.ObterTodos();
        }

        public IEnumerable<Tarefa> ObterPorTitulo(string titulo)
        {
            var tarefa = _tarefaRepository.ObterPorTitulo(titulo);
            return tarefa;
        }
        public bool DeletarTarefa(Tarefa tarefa)
        {
            var result = _tarefaRepository.Deletar(tarefa);
            return result;
        }
        public bool AtualizarTarefa(Tarefa tarefa)
        {
            var result = _tarefaRepository.AtualizarTarefa(tarefa);
            return result;
        }

        public IEnumerable<Tarefa> ObterPorStatus(EnumStatusTarefa status)
        {
            var tarefa = _tarefaRepository.ObterPorStatus(status);
            return tarefa;
        }

        public IEnumerable<Tarefa> ObterPorData(DateTime data)
        {
            var tarefa = _tarefaRepository.ObterPorData(data);
            return tarefa;
        }
    }
}