

namespace AppClientes;
class Program
{
    static async Task Main(string[] args)
    {
        await Menu();
    }
    static async Task Menu()
    {
        Console.Clear();

        Console.WriteLine(" Cadastro de Clientes");
        Console.WriteLine("-----------------------");
        Console.WriteLine("1 - Cadastrar CLiente |");
        Console.WriteLine("2 - Exibir Clientes   |");
        Console.WriteLine("3 - Editar Cliente    |");
        Console.WriteLine("4 - Excluir Cliente   |");
        Console.WriteLine("5 - Sair              |");
        Console.WriteLine("-----------------------");

        Console.WriteLine("Selecione a opção que deseja: ");
        var opt = Console.ReadLine();

        switch (opt)
        {
            case "1":
                CadastrarCliente();
                break;
            case "2":
                ExibirClientes();
                break;
            case "3":
                EditarCliente();
                break;
            case "4":
                ExcluirCliente();
                break;
            case "5":
                Sair();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Opção inváldia!");
                await Task.Delay(1000);
                await Menu();
                break;
        }
    }
    static void CadastrarCliente()
    {
        Console.Clear();

    }
    static void ExibirClientes()
    {
        Console.Clear();

    }
    static void EditarCliente()
    {
        Console.Clear();

    }
    static void ExcluirCliente()
    {
        Console.Clear();

    }
    static void Sair()
    {
        Console.Clear();
        Console.WriteLine("Saindo...");
        Environment.Exit(0);

    }
}
