using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Context;
using TrilhaApiDesafio.Models;
using TrilhaNetApiDesafio.Repositories;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TrilhaApiDesafio.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly OrganizadorContext _context;

        public TarefaRepository(OrganizadorContext context)
        {
            _context = context;
        }

        public bool Adicionar(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
            int linhasAfetadas = _context.SaveChanges();
            return linhasAfetadas > 0;
        }


        public Tarefa ObterPorId(int id)
        {
            return _context.Tarefas.Find(id);

        }

        public List<Tarefa> ObterTodos()
        {
            return _context.Tarefas.ToList();
        }

        public bool Deletar(Tarefa tarefa)
        {
            _context.Tarefas.Remove(tarefa);
            var linhasAfetadas = _context.SaveChanges();
            return linhasAfetadas > 0;
        }

        public IEnumerable<Tarefa> ObterPorTitulo(string titulo)
        {
            return _context.Tarefas.Where(x => x.Titulo == titulo);
        }

        public bool AtualizarTarefa(Tarefa tarefa)
        {
            _context.Tarefas.Update(tarefa);
            var linhasAfetadas = _context.SaveChanges();
            return linhasAfetadas > 0;
        }

        public IEnumerable<Tarefa> ObterPorStatus(EnumStatusTarefa status)
        {
            return _context.Tarefas.Where(x => x.Status == status);
        }

        public IEnumerable<Tarefa> ObterPorData(DateTime data)
        {
            return _context.Tarefas.Where(x => x.Data.Date == data.Date);
        }
    }
}
