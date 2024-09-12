using System.ComponentModel;

namespace Cadastro
{
    public static class Calculos
    {
        public static int SomarNumeros(int a, int b)
        {
            return a + b;
        }
    }
    public class Produto
    {
        private int Id;
        public string? Descricao { get; set; }
        // public readonly int? Estoque;
        public int? Estoque { get; }
        public Produto()
        {
            Estoque = 1;
        }
        public void ImprimirDescricao()
        {
            Console.WriteLine(GetId() + " - " + Descricao);
        }
        public void SetId(int id)
        {
            Id = id;
        }
        public int GetId()
        {
            return Id;

        }
    }
    public class Pessoa
    {
        public int Id { get; set; }
        public string? Endereco { get; set; }
        public string? Cidade { get; set; }
        public string? Cep { get; set; }
        public void ImprimirDados()
        {
            Console.WriteLine("Codigo: " + Id);
            Console.WriteLine("Endereco: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("CEP: " + Cep);
        }
    }
    public class PessoaFisica : Pessoa
    {
        public string? Cpf { get; set; }
        public void ImprimirCpf()
        {
            Console.WriteLine("CPF: " + Cpf);
        }
    }
    public class Funcionario : PessoaFisica
    {
        public string? Matricula { get; set; }
        public void ImprimirMatricula()
        {
            Console.WriteLine("Matricula: " + Matricula);
        }
    }
    public sealed class Configuracao
    {
        public string? Host { get; set; }
    }
    public abstract class Animal
    {
        public string? Nome { get; set; }
        public abstract string GetInformacoes();
        public void ImprimirDados()
        {
            Console.WriteLine("Nome animal: " + Nome);
            Console.WriteLine("Informações: " + GetInformacoes());
        }
    }
    public class Cachorro : Animal
    {
        public override string GetInformacoes()
        {
            return Nome + " é uma boa amiga!";
        }
    }
    public record Curso(int Id, string Descricao);
    public class CursoTeste
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
    }
    /*
    public record Curso
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is Curso curso)
            {
                return Id == curso.Id && Descricao == curso.Descricao;
            }
            return base.Equals(obj);
        }
        public static bool operator ==(Curso a, Curso b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Curso a, Curso b)
        {
            return !(a == b);
        }
    }
    */

    public interface INotificacao
    {
        string? Descricao { get; set; }
        void Notificar();
    }
    public class NotificacaoCliente : INotificacao
    {
#pragma warning disable CS8766 // Nullability of reference types in return type doesn't match implicitly implemented member (possibly because of nullability attributes).
        public string? Descricao { get; set; }
#pragma warning restore CS8766 

        public void Notificar()
        {
            Console.WriteLine("Notificando cliente!");
        }
        public void NotificarOutros()
        {
            Console.WriteLine("Notificando outros!");
        }
    }
    public class NotificacaoFuncionario : INotificacao
    {
#pragma warning disable CS8766 // Nullability of reference types in return type doesn't match implicitly implemented member (possibly because of nullability attributes).
        public string? Descricao { get; set; }
#pragma warning restore CS8766

        public void Notificar()
        {
            Console.WriteLine("Notificando funcionário!");
        }
        public void NotificarOutros()
        {
            Console.WriteLine("Notificando outros!");
        }
    }
}