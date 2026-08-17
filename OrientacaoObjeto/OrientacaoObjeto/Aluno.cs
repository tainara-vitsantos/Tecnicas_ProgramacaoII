// Herança
// Associação Bilateral com Curso

namespace OrientacaoObjeto
{
    public class Aluno : Pessoa
    {
        public Aluno(string ra, int id, string nome)
            : base(id, nome)
        {
            Ra = ra;
        }

        //Metodo para inserir curso na lista de cursos do aluno e adicionar o aluno na lista de alunos do curso
        public void InserirCurso(Curso curso) 
        {
            Cursos.Add(curso);
        }
        public string Ra { get; set; }

        // Associação N:N com Curso
        //Novo atributo com a classe curso
        public List<Curso> Cursos { get; set; } = new List<Curso>();
    }
}