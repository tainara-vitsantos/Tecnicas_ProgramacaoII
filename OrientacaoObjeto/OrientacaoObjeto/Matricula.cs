//Classe Associação Matricula

using System.Data;

namespace OrientacaoObjeto
{
    public class Matricula
    {
        public Matricula(int id, DateTime data, Aluno aluno, Curso curso)
        {
            Id = id;
            Data = data;
            Aluno = aluno;
            Curso = curso;

        }

        public void InserirAluno(Aluno aluno)
        {
            Aluno = aluno;
        }
       
        public void InserirCurso(Curso curso)
        {
            Curso = curso;
        }

        public int Id { get; set; }

        public DateTime Data { get; set; }

        // Associação com Aluno
        public int AlunoId { get; set; }

        public Aluno Aluno { get; set; } = null!;

        // Associação com Curso
        public int CursoId { get; set; }

        public Curso Curso { get; set; } = null!;
    }
}
