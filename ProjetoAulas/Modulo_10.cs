using System.ComponentModel.Design.Serialization;

namespace Modulo10;

public class TrabalhandoComStrings
{
    public void ConverterParaLetrasMinusculas()
    {
        Console.Write("Favor digitar alguma informacao: ");
        var linha = Console.ReadLine();

        Console.WriteLine(linha!.ToLower());
    }
    public void ConverterParaLetrasMaiusculas()
    {
        Console.Write("Favor digitar alguma informacao: ");
        var linha = Console.ReadLine();

        Console.WriteLine(linha!.ToUpper());
    }
    public void AulaSubstring()
    {
        Console.Write("Favor digitar alguma informacao: ");
        var linha = Console.ReadLine();

        Console.WriteLine(linha!.Substring(0));
    }
    public void AulaRange()
    {
        string nomeArquivo = "2022_12_01_backup.bak";
        string ano = nomeArquivo[..4];
        Console.WriteLine(ano);

        string extensao = nomeArquivo[^4..];
        Console.WriteLine(extensao);

        string nome = nomeArquivo[11..^4];
        Console.WriteLine(nome);

        string apenasNome = nomeArquivo[..^4];
        Console.WriteLine(apenasNome);
    }
    public void AulaContains()
    {
        string nomeArquivo = "2022_12_01_backup.bak";
        if (nomeArquivo.Contains("backup_teste"))
        {
            Console.WriteLine("Palavra encontrada");
        }
        else
        {
            Console.WriteLine("Palavra nao encontrada");
        }
    }
    public void AulaTrim()
    {
        string teste = "**ANDRE INACIO**";
        Console.WriteLine("Trim Total: " + teste.Trim('*'));
        Console.WriteLine("Trim Inicio: " + teste.TrimStart('*'));
        Console.WriteLine("Trim Final: " + teste.TrimEnd('*'));
    }
    public void AulaStartsWithEndsWith()
    {
        string teste = "Curso Csharp";

        Console.WriteLine("Inicio: " + teste.StartsWith("Curso"));
        Console.WriteLine("Final: " + teste.EndsWith("Csharp02"));
    }
    public void AulaReplace()
    {
        string teste = "Curso Csharp";
        Console.WriteLine(teste);
        Console.WriteLine(teste.Replace("Csharp", "C#"));
    }
    public void AulaLength()
    {
        Console.Write("Digite a palavra ou frase que deseja descobrir seu tamanho: ");
        string teste = Console.ReadLine()!;
        Console.WriteLine("Entrada: " + teste);
        Console.WriteLine("Tamanho da Entrada: " + teste.Length);
    }
}