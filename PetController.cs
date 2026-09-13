public class PetController
{
    private readonly List<Pet> _pets;

    public PetController()
    {
        _pets = new List<Pet>();
    }

    private int LerIdade(string mensagem, int min, int max)
    {
        int idade = 0;
        bool idadeValida = false;

        while(!idadeValida)
        {
            Console.WriteLine(mensagem);
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out idade))
            {
                if (idade > min && idade < max)
                {
                    idadeValida = true;
                    
                }
                else
                {
                    Console.WriteLine("Idade inválida. Digite um valor entre 1 e 100");
                }
            }
            else
            {
                Console.WriteLine("O campo idade não pode ficar vazio");
            }
        }
        return idade;
    }
    public void CadastrarPet()
    {
        Console.WriteLine("Insira o nome do pet:");
        string nome = Console.ReadLine() ?? "";
        Console.WriteLine("Insira a espécie");
        string especie = Console.ReadLine() ?? "";
        int idade = LerIdade(mensagem: "Insira a idade", min: 1, max: 100);

        Pet pet = new Pet(nome: nome, especie: especie, idade: idade);
        _pets.Add(pet);
        Console.WriteLine("Pet cadastrado com sucesso.");
    }

    public void ListarPets()
    {
        foreach (var pet in _pets)
        {
            Console.WriteLine($"Nome: {pet.Nome}\nEspécie: {pet.Especie}\nIdade: {pet.Idade}\nVacinas: {string.Join(",", pet.Vacinas)}\nProcedimentos: {string.Join(",", pet.Procedimentos)}");
        }
    }
}