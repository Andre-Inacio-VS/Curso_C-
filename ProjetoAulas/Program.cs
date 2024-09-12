// Console.WriteLine("First, Program!");

using System;
using Cadastro;
using Modulo12;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            TrabalhandoComLINQ();
        }
        private static void TrabalhandoComLINQ()
        {
            var linq = new Modulo14.TrabalhandoComLINQ();
            // linq.AulaWhere();
            // linq.AulaOrdenacao();
            // linq.AulaTake();
            // linq.AulaCount();
            linq.AulaFirstEFirstOrDefault();

        }
        private static void TrabalhandoComArquivos()
        {
            var trabalhandoComArquivos = new Modulo13.TrabalhandoComArquivos();
            // trabalhandoComArquivos.AulaCriandoArquivo();
            // trabalhandoComArquivos.AulaLendoArquivo();
            trabalhandoComArquivos.AulaExcluindoArquivo();

        }
        private static void TrabalhandoComExceptions()
        {
            var trabalhandoComExcecoes = new Modulo12.TrabalhandoComExcecoes();
            // trabalhandoComExcecoes.AulaGerandoException();
            trabalhandoComExcecoes.AulaTratandoException();
        }
        private static void TrabalhandoComDatas()
        {
            var trabalhandoComDatas = new Modulo11.TrabalhandoComDatas();
            // trabalhandoComDatas.AulaDateTime();
            // trabalhandoComDatas.AulaSubtraindoDatas();
            // trabalhandoComDatas.AulaAdicionandoDiaMesAno();
            // trabalhandoComDatas.AulaAdicionandoHorasMinutosSegundos();
            // trabalhandoComDatas.AulaDiaDaSemana();
            // trabalhandoComDatas.AulaDateOnly();
            trabalhandoComDatas.AulaTimeOnly();
        }
        private static void TrabalhandoComStrings()
        {
            var trabalhandoComStrings = new Modulo10.TrabalhandoComStrings();
            // trabalhandoComStrings.ConverterParaLetrasMinusculas();
            // trabalhandoComStrings.ConverterParaLetrasMaiusculas();
            // trabalhandoComStrings.AulaSubstring();
            // trabalhandoComStrings.AulaRange();
            // trabalhandoComStrings.AulaContains();
            // trabalhandoComStrings.AulaTrim();s
            // trabalhandoComStrings.AulaStartsWithEndsWith();
            // trabalhandoComStrings.AulaReplace();
            trabalhandoComStrings.AulaLength();
        }
        private static void Conversores()
        {
            var conversores = new Conversores.Conversor();
            conversores.ConvertAndParse();
            conversores.AulaTryParse();
        }
        private static void AulaInterface()
        {
            var notificacaoCliente = new Cadastro.NotificacaoCliente();
            notificacaoCliente.Notificar();
            notificacaoCliente.NotificarOutros();

            Cadastro.INotificacao notificacao = new Cadastro.NotificacaoFuncionario();
            notificacao.Notificar();
            // notificacao.NotificarOutros(); Não permite, pois nao tem na inteface de Notificacao
        }
        private static void AulaRecord()
        {
            // var curso1 = new Cadastro.Curso { Id = 1, Descricao = "Curso C#" };
            // var curso2 = new Cadastro.Curso { Id = 1, Descricao = "Curso C#" };

            var curso1 = new Cadastro.Curso(1, "Curso C#");
            var curso2 = curso1 with { Descricao = "Teste Novo" };

            // var curso1 = new Cadastro.CursoTeste { Id = 1, Descricao = "Curso C#" };
            // var curso2 = new Cadastro.CursoTeste();
            // curso2.Id = curso1.Id;
            // curso2.Descricao = "Novo Curso";

            Console.WriteLine(curso1.Descricao);
            Console.WriteLine(curso2.Descricao);

            // Console.WriteLine(curso1.Equals(curso2));
            // Console.WriteLine(curso1 == curso2);
        }
        private static void AulaClasseAbstrata()
        {
            var cachorro = new Cadastro.Cachorro();
            cachorro.Nome = "Dora";

            cachorro.ImprimirDados();
        }
        private static void AulaClasseSelada()
        {
            var configuracao = new Configuracao
            {
                Host = "localhost"
            };
            Console.WriteLine(configuracao.Host);
        }
        private static void AulaHeranca()
        {
            /*
            var pessoaFisica = new Cadastro.PessoaFisica();

            pessoaFisica.Id = 1;
            pessoaFisica.Endereco = "Rua Sei la";
            pessoaFisica.Cidade = "Sao jose do Rio Preto";
            pessoaFisica.Cep = "15056091";
            pessoaFisica.Cpf = "48259018837";

            pessoaFisica.ImprimirDados();
            pessoaFisica.ImprimirCpf();
            */

            var funcionario = new Cadastro.Funcionario();

            funcionario.Id = 10;
            funcionario.Endereco = "Rua Sei la";
            funcionario.Cidade = "Sao jose do Rio Preto";
            funcionario.Cep = "15056091";
            funcionario.Cpf = "48259018837";
            funcionario.Matricula = "G698550";

            funcionario.ImprimirDados();
            funcionario.ImprimirCpf();
            funcionario.ImprimirMatricula();
        }
        private static void AulaClasses()
        {
            var resultado = Cadastro.Calculos.SomarNumeros(5, 10);

            Console.WriteLine(resultado);

            // var produto = new Cadastro.Produto();

            // produto.SetId(1);

            // produto.Descricao = "Teclado";

            // produto.ImprimirDescricao();
        }
        private static void AulaPropriedadeSomenteLeitura()
        {
            var produto = new Cadastro.Produto();

            produto.Descricao = "Mouse";

            Console.WriteLine(produto.Estoque);
        }
    }
}

/*
namespace Cadastro
{
    public class Cliente
    {

    }
    public class Funcionario
    {

    }
}

namespace Financeiro
{
    public class ContasReceber
    {

    }
    public class Funcionario
    {

    }
}
*/