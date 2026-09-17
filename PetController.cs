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
                if (idade >= min && idade <= max)
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
        string nome = "";
        while (string.IsNullOrWhiteSpace(nome))
        {
        Console.WriteLine("Insira o nome do pet:");
        nome = Console.ReadLine() ?? "";
        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("O campo nome não pode ficar vazio");
        }
        else
        {
            nome = char.ToUpper(nome[0]) + nome.Substring(1).ToLower();
        }
        }
        
        string especie = "";
        while(string.IsNullOrWhiteSpace(especie))
        {
        Console.WriteLine("Insira a espécie");
        especie = Console.ReadLine() ?? "";
        if (string.IsNullOrWhiteSpace(especie))
        {
            Console.WriteLine("O campo espécie não pode ficar vazio");
        }
        else
        {
            especie = char.ToUpper(especie[0]) + especie.Substring(1).ToLower();
        }
        }

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

    public void AdicionarVacina()
    {
        bool listaValida = false;
        while (!listaValida)
        {
            if (_pets.Count > 0)
            {
                Console.WriteLine("Selecione o pet:");
                for (int i = 0; i < _pets.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {_pets[i].Nome}");
                }
                listaValida = true;
            }
            else
            {
                Console.WriteLine("A lista de pets está vazia.");
            }

            int petSelecionado = 0;

            bool petValido = false;
            while(!petValido)
            {
                string input = Console.ReadLine() ?? "";
                if (int.TryParse(input, out petSelecionado))
                {
                    if (petSelecionado > 0 && petSelecionado <= _pets.Count)
                    {
                        Console.WriteLine("Insira o nome da vacina:");
                        string vacinaNome = Console.ReadLine() ?? "";
                        Console.WriteLine("Insira a data da vacina (dd/mm/aaaa)");
                        string vacinaData = Console.ReadLine() ?? "";
                        DateTime dataConvertida;
                        if (DateTime.TryParse(vacinaData, out dataConvertida))
                        {
                        Vacina vacina = new Vacina(nome: vacinaNome, data: dataConvertida);
                        _pets[petSelecionado - 1].Vacinas.Add(vacina);
                        Console.WriteLine("Vacina adicionada com sucesso");
                        petValido = true;
                        }
                        else
                        {
                            Console.WriteLine("Data inválida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Seleção inválida.");
                    }
                }
                else
                {
                    Console.WriteLine("A seleção não pode ficar vazia.");
                }

            }
        }
    }
}