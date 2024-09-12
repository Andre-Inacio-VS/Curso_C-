using Cadastro;

namespace Repository;

public class ClienteRepository
{
    public List<Cliente> clientes = new List<Cliente>();
    public void CadastratCliente()
    {
        Console.Clear();

        Console.Write("Nome do Cliente: ");
        var nome = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.Write("Data de Nascimento: ");
        var dataNascimento = DateOnly.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.Write("Desconto: ");
        var desconto = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        var cliente = new Cliente();
        cliente.Id = clientes.Count + 1;
        cliente.Nome = nome;
        cliente.DataNascimento = dataNascimento;
        cliente.Desconto = desconto;
        cliente.CadastradoEm = DateTime.Now;

        clientes.Add(cliente);

        ImprimirCliente(cliente);
        Console.Write(Environment.NewLine);

        Console.WriteLine("Cliente cadastrado com sucesso!! [Pressione qualquer tecla para continuar]");
        Console.ReadKey();
    }
    public void ImprimirCliente(Cliente cliente)
    {
        Console.WriteLine("ID.....................: " + cliente.Id);
        Console.WriteLine("Nome...................: " + cliente.Nome);
        Console.WriteLine("Desconto...............: " + cliente.Desconto.ToString("0.00"));
        Console.WriteLine("Data Nascimento........: " + cliente.DataNascimento);
        Console.WriteLine("Data Cadastro..........: " + cliente.CadastradoEm);
        if (cliente.AlteradoEm != null)
        {
            Console.WriteLine("Data Alteração.........: " + cliente.AlteradoEm);
        }
        Console.WriteLine("----------------------------------------");
    }
    public void EditarCliente()
    {
        Console.Clear();

        Console.WriteLine("Digite o código do cliente que deseja editar: ");
        var codigo = Console.ReadLine();

        var cliente = clientes.FirstOrDefault(c => c.Id == int.Parse(codigo));

        if (cliente == null)
        {
            Console.WriteLine("Cliente não cadastrado! [Pressione qualquer tecla para continuar]");
            Console.ReadKey();
            return;
        }

        ImprimirCliente(cliente);

        Console.Write("Nome do Cliente: ");
        var nome = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.Write("Data de Nascimento: ");
        var dataNascimento = DateOnly.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.Write("Desconto: ");
        var desconto = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);


        cliente.Nome = nome;
        cliente.DataNascimento = dataNascimento;
        cliente.Desconto = desconto;
        cliente.AlteradoEm = DateTime.Now;

        ImprimirCliente(cliente);
        Console.Write(Environment.NewLine);

        Console.WriteLine("Cliente alterado com sucesso!! [Pressione qualquer tecla para continuar]");
        Console.ReadKey();
    }
    public void ExibirClientes()
    {
        Console.Clear();
        foreach (var cliente in clientes)
        {
            ImprimirCliente(cliente);
        }

        Console.ReadKey();
    }
    public void ExcluirCliente()
    {
        Console.Clear();

        Console.WriteLine("Digite o código do cliente que deseja excluir: ");
        var codigo = Console.ReadLine();

        var cliente = clientes.FirstOrDefault(c => c.Id == int.Parse(codigo));

        if (cliente == null)
        {
            Console.WriteLine("Cliente não cadastrado! [Pressione qualquer tecla para continuar]");
            Console.ReadKey();
            return;
        }
        ImprimirCliente(cliente);
        Console.Write(Environment.NewLine);

        clientes.Remove(cliente);

        Console.WriteLine("Cliente excluido com sucesso!! [Pressione qualquer tecla para continuar]");

        Console.ReadKey();
    }
}