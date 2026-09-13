public class Pet
{
    public string Nome{get;}
    public string Especie{get;}
    public int Idade{get;}
    public List<Vacina> Vacinas{get; private set;}
    public List<Procedimento> Procedimentos{get; private set;}

    public Pet(string nome, string especie, int idade)
    {
        Nome = nome;
        Especie = especie;
        Idade = idade;
        Vacinas = new List<Vacina>();
        Procedimentos = new List<Procedimento>();
    }




}