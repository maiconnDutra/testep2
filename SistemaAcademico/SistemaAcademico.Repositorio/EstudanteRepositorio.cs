using SistemaAcademico.Dominio;

namespace SistemaAcademico.Repositorio
{
    public class EstudanteRepositorio : IEstudanteRepositorio
    {
        private readonly EstudanteDbContext _context;

        public EstudanteRepositorio(EstudanteDbContext context)
        {
            _context = context;
        }

        public void Salvar(Estudante estudante)
        {
            _context.Add(estudante);
            _context.SaveChanges();
        }

        public List<Estudante> ObterTodos() => _context.Estudantes.ToList();

        public Estudante ObterPorId(int id) => _context.Estudantes.FirstOrDefault(a => a.Id == id);

        public void Atualizar(Estudante estudante)
        {
            var existente = ObterPorId(estudante.Id);
            if (existente != null)
            {
                existente.Nome = estudante.Nome;
                existente.Nota = estudante.Nota;
                _context.SaveChanges();
            }
        }

        public void Remover(int id)
        {
            var estudante = ObterPorId(id);
            if (estudante != null) _context.Remove(estudante);
            _context.SaveChanges();
        }
    }
}
