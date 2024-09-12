using System.Globalization;
using Repository;

namespace AppClientes;
class Program
{
    static ClienteRepository _clienteRepository = new ClienteRepository();
    static void Main(string[] args)
    {
        var culture = new CultureInfo("pt-BR");
        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = culture;

        while (true)
        {
        Menu();

        Console.ReadKey();
        }
    }
    static void Menu()
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

        EscolherOpcao();
    }
    static void EscolherOpcao()
    {
        Console.WriteLine("Selecione uma opção: ");

        var opt = Console.ReadLine();

        if (opt == "") 
        {
            Console.Clear();
            Console.WriteLine("Opção inválida!! [Pressione qualquer tecla para continuar]");
            Console.ReadKey();
            Menu();
        }

        switch (int.Parse(opt))
        {
            case 1:
                _clienteRepository.CadastratCliente();
                Menu();
                break;
            case 2:
                _clienteRepository.ExibirClientes();
                Menu();
                break;
            case 3:
                _clienteRepository.EditarCliente();
                Menu();
                break;
            case 4:
                _clienteRepository.ExcluirCliente();
                Menu();
                break;
            case 5:
            Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.WriteLine("Opção inváldia!! [Pressione qualquer tecla para continuar]");
                break;
        }
    }
}
