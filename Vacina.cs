public class Vacina
{
    public string Nome{get;}
    public DateTime Data{get;}

    public Vacina(string nome, DateTime data)
    {
        Nome = nome;
        Data = data;
    }

    public override string ToString()
    {
        return $"{Nome} - {Data.ToString("dd/MM/yyyy")}";
    }
}
