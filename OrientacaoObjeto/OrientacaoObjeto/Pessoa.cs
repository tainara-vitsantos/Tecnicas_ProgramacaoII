
namespace OrientacaoObjeto
{
    public class Pessoa 
    {

        public Pessoa()
        {
            
        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(int id, string nome)
        {
            Id = Id;
            Nome = Nome;
        }
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;
    }
}

//Construtor e ctor