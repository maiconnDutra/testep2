using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Repositorio
{
    public interface IEstudanteRepositorio
    {
        void Salvar(Estudante estudante);
        List<Estudante> ObterTodos();
        Estudante ObterPorId(int id);
        void Atualizar(Estudante estudante);
        void Remover(int id);
    }
}
