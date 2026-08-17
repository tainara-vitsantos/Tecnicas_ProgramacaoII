using OrientacaoObjeto;

// ==========================================
// ALUNOS
// ==========================================

Aluno aluno1 = new Aluno(
    "12345",
    1,
    "Maria Da Silva"
);

Aluno aluno2 = new Aluno(
    "67890",
    2,
    "Pedro Oliveira"
);

Aluno aluno3 = new Aluno(
    "54321",
    3,
    "Ana Beatriz"
);


// ==========================================
// PROFESSORES
// ==========================================

Professor professor1 = new Professor(
    "Doutor",
    1,
    "Carlos Alberto"
);

Professor professor2 = new Professor(
    "Mestre",
    2,
    "Ana Paula"
);

Professor professor3 = new Professor(
    "Doutora",
    3,
    "Fernanda Souza"
);


// ==========================================
// CURSOS
// ==========================================

// Curso 1
Curso curso1 = new Curso(
    1,
    "Engenharia de Software",
    50,
    aluno1,
    1,
    "Programação Orientada a Objetos",
    60,
    professor1
);

// Curso 2
Curso curso2 = new Curso(
    2,
    "Ciência da Computação",
    40,
    aluno2,
    2,
    "Estrutura de Dados",
    60,
    professor2
);

// Curso 3
Curso curso3 = new Curso(
    3,
    "Sistemas de Informação",
    35,
    aluno3,
    3,
    "Banco de Dados",
    80,
    professor3
);


// ==========================================
// ASSOCIANDO MAIS ALUNOS AOS CURSOS
// ==========================================

// Curso 1 recebe aluno 2 e aluno 3
curso1.InserirAluno(aluno2);
curso1.InserirAluno(aluno3);

// Curso 2 recebe aluno 1 e aluno 3
curso2.InserirAluno(aluno1);
curso2.InserirAluno(aluno3);

// Curso 3 recebe aluno 1 e aluno 2
curso3.InserirAluno(aluno1);
curso3.InserirAluno(aluno2);


// ==========================================
// ADICIONANDO MAIS DISCIPLINAS
// ==========================================

// Curso 1
curso1.InserirDisciplina(
    4,
    "Desenvolvimento Web",
    80,
    professor2
);

curso1.InserirDisciplina(
    5,
    "Banco de Dados",
    60,
    professor3
);


// Curso 2
curso2.InserirDisciplina(
    6,
    "Engenharia de Software",
    80,
    professor1
);

curso2.InserirDisciplina(
    7,
    "Desenvolvimento Web",
    60,
    professor3
);


// Curso 3
curso3.InserirDisciplina(
    8,
    "Programação Mobile",
    60,
    professor1
);

curso3.InserirDisciplina(
    9,
    "Inteligência Artificial",
    80,
    professor2
);


// ==========================================
// MATRÍCULAS
// ==========================================

Matricula matricula1 = new Matricula(
    1,
    DateTime.Now,
    aluno1,
    curso1
);

Matricula matricula2 = new Matricula(
    2,
    DateTime.Now,
    aluno2,
    curso2
);

Matricula matricula3 = new Matricula(
    3,
    DateTime.Now,
    aluno3,
    curso3
);


// ==========================================
// MOSTRAR ALUNO 1
// ==========================================

Console.WriteLine("=================================");
Console.WriteLine("ALUNO 1");
Console.WriteLine("=================================");

Console.WriteLine(
    $"Id: {aluno1.Id} - Nome: {aluno1.Nome}"
);

foreach (var curso in aluno1.Cursos)
{
    Console.WriteLine(
        $"Curso: {curso.Nome} - Vagas: {curso.Vagas}"
    );

    foreach (var disciplina in curso.Disciplinas)
    {
        Console.WriteLine(
            $"Disciplina: {disciplina.Nome} - " +
            $"Carga Horária: {disciplina.CargaHoraria}"
        );

        foreach (var professor in disciplina.Professores)
        {
            Console.WriteLine(
                $"Professor: {professor.Nome} - " +
                $"Titulação: {professor.Titulacao}"
            );
        }
    }
}


// ==========================================
// MOSTRAR ALUNO 2
// ==========================================

Console.WriteLine("\n=================================");
Console.WriteLine("ALUNO 2");
Console.WriteLine("=================================");

Console.WriteLine(
    $"Id: {aluno2.Id} - Nome: {aluno2.Nome}"
);

foreach (var curso in aluno2.Cursos)
{
    Console.WriteLine(
        $"Curso: {curso.Nome} - Vagas: {curso.Vagas}"
    );

    foreach (var disciplina in curso.Disciplinas)
    {
        Console.WriteLine(
            $"Disciplina: {disciplina.Nome} - " +
            $"Carga Horária: {disciplina.CargaHoraria}"
        );

        foreach (var professor in disciplina.Professores)
        {
            Console.WriteLine(
                $"Professor: {professor.Nome} - " +
                $"Titulação: {professor.Titulacao}"
            );
        }
    }
}


// ==========================================
// MOSTRAR ALUNO 3
// ==========================================

Console.WriteLine("\n=================================");
Console.WriteLine("ALUNO 3");
Console.WriteLine("=================================");

Console.WriteLine(
    $"Id: {aluno3.Id} - Nome: {aluno3.Nome}"
);

foreach (var curso in aluno3.Cursos)
{
    Console.WriteLine(
        $"Curso: {curso.Nome} - Vagas: {curso.Vagas}"
    );

    foreach (var disciplina in curso.Disciplinas)
    {
        Console.WriteLine(
            $"Disciplina: {disciplina.Nome} - " +
            $"Carga Horária: {disciplina.CargaHoraria}"
        );

        foreach (var professor in disciplina.Professores)
        {
            Console.WriteLine(
                $"Professor: {professor.Nome} - " +
                $"Titulação: {professor.Titulacao}"
            );
        }
    }
}