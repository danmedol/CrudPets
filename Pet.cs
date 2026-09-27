public class Pet
{
    public string Nome{get; private set;}
    public string Especie{get; private set;}
    public int Idade{get; private set;}
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

    public void EditarNome(string novoNome)
    {
        Nome = novoNome;
    }

    public void EditarEspecie(string novaEspecie)
    {
        Especie = novaEspecie;
    }

    public void EditarIdade(int novaIdade)
    {
        Idade = novaIdade;
    }






}