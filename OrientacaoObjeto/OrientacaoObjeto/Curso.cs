namespace OrientacaoObjeto
{
    public class Curso
    {
        public Curso(
            int id,
            string nome,
            int vagas,
            Aluno aluno,
            int idDisciplina,
            string nomeDisciplina,
            int cargaHorarioDisciplina,
            Professor professorDisciplina)
        {
            Id = id;
            Nome = nome;
            Vagas = vagas;

            // Associação bilateral com Aluno
            InserirAluno(aluno);

            // Composição com Disciplina
            InserirDisciplina(
                idDisciplina,
                nomeDisciplina,
                cargaHorarioDisciplina,
                professorDisciplina
            );
        }

        // Associação bilateral com Aluno
        public void InserirAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
            aluno.Cursos.Add(this);
        }

        // Composição com Disciplina
        public void InserirDisciplina(
            int idDisciplina,
            string nomeDisciplina,
            int cargaHorarioDisciplina,
            Professor professorDisciplina)
        {
            Disciplinas.Add(
                new Disciplina(
                    idDisciplina,
                    nomeDisciplina,
                    cargaHorarioDisciplina,
                    professorDisciplina,
                    this
                )
            );
        }

        public int Id { get; set; }

        public string? Nome { get; set; } = string.Empty;

        public int? Vagas { get; set; }

        // Composição com Disciplina
        public List<Disciplina> Disciplinas { get; set; }
            = new List<Disciplina>();

        // Associação N:N bilateral com Aluno
        public List<Aluno> Alunos { get; set; }
            = new List<Aluno>();
    }
}