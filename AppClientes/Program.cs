using Repository;

namespace AppClientes;
class Program
{
    static ClienteRepository _clienteRepository = new ClienteRepository();
    static void Main(string[] args)
    {
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
    // static void CadastrarCliente()
    // {
    //     Console.Clear();

    //     var escrever = new StreamWriter("Registro_De_Clientes.txt", true);
    //     var cliente = new Cadastro.Cliente();

    //     cliente.Id = Random.Shared.Next(1, 100);
    //     cliente.CadastradoEm = DateTime.Now;

    //     Console.Write("Nome do Cliente: ");
    //     cliente.Nome = Console.ReadLine();

    //     Console.Write("Data de Nascimento: ");
    //     cliente.DataNascimento = DateOnly.Parse(Console.ReadLine());

    //     Console.Write("Desconto: ");
    //     cliente.Desconto = decimal.Parse(Console.ReadLine());


    //     escrever.WriteLine("ID: " + cliente.Id);
    //     escrever.WriteLine("Nome: " + cliente.Nome);
    //     escrever.WriteLine("Data de Nascimento: " + cliente.DataNascimento);
    //     escrever.WriteLine("Desconto: " + cliente.Desconto);
    //     escrever.WriteLine("Cadastrado em: " + cliente.CadastradoEm);
    //     escrever.WriteLine("----------------------------------------");
    //     escrever.Close();
    //     Console.WriteLine("Cadastrado com sucesso!");
    // }
    // static void ExibirClientes()
    // {
    //     Console.Clear();
    //     var ler = new StreamReader("Registro_De_Clientes.txt");
    //     while (!ler.EndOfStream)
    //     {
    //         var linha = ler.ReadLine();
    //         Console.WriteLine(linha);
    //     }
    // }
    // static void EditarCliente()
    // {
    //     Console.Clear();

    // }
    // static void ExcluirCliente()
    // {
    //     Console.Clear();

    // }
    // static void Sair()
    // {
    //     Console.Clear();
    //     Console.WriteLine("Saindo...");
    //     Environment.Exit(0);

    // }
}
