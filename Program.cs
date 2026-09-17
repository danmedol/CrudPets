
PetController controller = new PetController();

bool executarPrograma = true;

while (executarPrograma == true)
{

Console.WriteLine($"Escolha uma opção:\n1 - Cadastrar Pet\n2 - Listar pet\n3 - Editar pet\n4 - Adicionar vacina\n5 - Adicionar procedimento\n6 - Deletar pet\n7 - Sair");

int opcao = Convert.ToInt32(Console.ReadLine());
Menu opcaoMenu = (Menu)opcao;

switch(opcaoMenu)
{
case Menu.CadastrarPet:
{
controller.CadastrarPet();
break;
}
case Menu.ListarPets:
{
controller.ListarPets();
break;
}
case Menu.EditarPet:
{
Console.WriteLine("Em construção");
break;
}
case Menu.AdicionarVacina:
{
controller.AdicionarVacina();
break;
}
case Menu.AdicionarProcedimento:
{
Console.WriteLine("Em construção");
break;
}
case Menu.DeletarPet:
{
Console.WriteLine("Em construção");
break;
}
case Menu.Sair:
{
executarPrograma = false;
break;
}
}
}
