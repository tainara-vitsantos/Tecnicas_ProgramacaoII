//Herança

namespace OrientacaoObjeto
{
    public class Professor: Pessoa 
    {
        public Professor(string titulacao, int id, string nome)
            : base(id, nome)
        {
            Titulacao = titulacao;
        }
        public string Titulacao { get; set; } = string.Empty;
    }
}
