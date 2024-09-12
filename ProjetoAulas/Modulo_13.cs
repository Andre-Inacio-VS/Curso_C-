namespace Modulo13;

public class TrabalhandoComArquivos
{
    public void AulaCriandoArquivo()
    {
        var escrever = new StreamWriter("Cadastro.txt", true);
        Console.Write("Informe um nome: ");
        var nome = Console.ReadLine();
        escrever.WriteLine("ID...: " + Random.Shared.Next(1, 100));
        escrever.WriteLine("Nome.: " + nome);
        escrever.WriteLine("------------------------------");
        escrever.Close();
        Console.WriteLine("Cadastrado com sucesso!");
    }
    public void AulaLendoArquivo()
    {
        // var conteudo = File.ReadAllText("Cadastro.txt");
        // Console.WriteLine(conteudo);

        var ler = new StreamReader("Cadastro.txt");
        while (!ler.EndOfStream)
        {
            var linha = ler.ReadLine();
            Console.WriteLine(linha);
        }
        ler.Close();
    }
    public void AulaExcluindoArquivo()
    {
        Console.Write("Digite o arquivo que deseja excluir: ");
        var arquivo = Console.ReadLine();
        if (File.Exists(arquivo))
        {
            File.Delete(arquivo);
            Console.WriteLine("Arquivo " + arquivo + " excluido com sucesso!!");
        }
        else
        {
            Console.WriteLine("O arquivo " + arquivo + " nao foi encontrado");
        }
    }
}