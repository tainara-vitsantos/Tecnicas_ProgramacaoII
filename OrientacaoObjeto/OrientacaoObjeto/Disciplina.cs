//Associação Unilateral N:N entre Disciplina e Professor
//Composição de Disciplina dentro do Curso

namespace OrientacaoObjeto
{
    public class Disciplina
    {
        public Disciplina(int id, string nome, int cargaHoraria, Professor professor, Curso curso)

        {
            Id = id;
            Nome = nome;
            CargaHoraria = cargaHoraria;
            Professores.Add( professor );
            Curso = curso;
        }

        public void InserirProfessor(Professor professor) //`Poderia ter um list ou AddRange para ter mais professores
        {
            Professores.Add(professor);
        }
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public int CargaHoraria { get; set; }

        //Atributo que é da relação N:N entre Disciplina e Professor
        // Associação N:N unilateral com Professor
        public List<Professor> Professores { get; set; } = new List<Professor>();


        //Atirbuto da relação de composição entre Curso e Disciplina

        public Curso Curso { get; set; } = null!;
    }
}
