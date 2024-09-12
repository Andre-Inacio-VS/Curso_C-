/*
Console.WriteLine("First, Program!");

int idade = 21;
Console.WriteLine(idade);
string nome = "Andre Inacio";
Console.WriteLine(nome);
decimal valor = 200.99m;
Console.WriteLine(valor);
double valorDouble = 200.99;
Console.WriteLine(valorDouble);
float valorFloat = 200.99f;
Console.WriteLine(valorFloat);


var idadeNova = 21;
Console.WriteLine(idadeNova);

char flag = 'A';
Console.WriteLine(flag);

bool ativo = true;
Console.WriteLine(ativo);

const string descricao = "Curso C#";
Console.WriteLine(descricao);
*/
/*
int a = 1;
var b = 2;

int soma = a + b;
Console.WriteLine("Soma = " + soma);

int subtracao = a - b;
Console.WriteLine("Subtracao = " + subtracao);

int multiplicacao = a * b;
Console.WriteLine("Multiplicacao = " + multiplicacao);

int divisao = a / b;
Console.WriteLine("Divisao = " + divisao);
*/

/*
using System.Collections;

string NomeCompleto()
{
    string firstName = "Andre";
    string lastName = "Silva";
    return firstName + " " + lastName;
}

var nome = NomeCompleto();

Console.WriteLine(nome);

int SomarValores(int a, int b)
{
    return a + b;
}

var soma = SomarValores(5, 9);

Console.WriteLine(soma);
*/

/*
using System.Collections;

var arrayList = new ArrayList();

arrayList.Add(1);
arrayList.Add("Andre");
arrayList.Add(true);

arrayList.RemoveAt(1);

arrayList.Clear();

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}
*/

/*
// var arrayTipadoNumero = new int[3] { 1, 2, 3 };
var arrayTipadoNumero = new int[3];

arrayTipadoNumero[0] = 5;
arrayTipadoNumero[1] = 10;
arrayTipadoNumero[2] = 15;

// Array.Resize(ref arrayTipadoNumero, 100);

// arrayTipadoNumero[10] = 15;

foreach (var item in arrayTipadoNumero)
{
    Console.WriteLine(item);
}

// var arrayTipadoString = new string[2] { "Andre", "Inacio" };
var arrayTipadoString = new string[2];

arrayTipadoString[0] = "Andre";
arrayTipadoString[1] = "Inacio";

foreach (var item in arrayTipadoString)
{
    Console.WriteLine(item);
}
*/

/*
// var lista =  new List<string>(10) {"Andre", "Inacio"};
var lista = new List<string>(10)
{
    "Andre",
    "Inacio",
    "Curso"
};

// lista.Add("Andre");
// lista.Add("Inacio");
// lista.Add("Venancio");
// lista.Add("Silva");

lista.RemoveAt(2);

foreach (var item in lista)
{
    Console.WriteLine(item);
}
*/

/*
var dicionario = new Dictionary<int, string>();

dicionario.Add(1, "Andre");

dicionario[50] = "Curso";

var nome = dicionario[50];

// Console.WriteLine(nome);
foreach (var item in dicionario)
{
    Console.WriteLine(item.Key);
}
*/
/*
var queue = new Queue<string>();

queue.Enqueue("Andre");
queue.Enqueue("Inacio");

var nome = queue.Dequeue();
var nome1 = queue.Dequeue();

Console.WriteLine(nome);
Console.WriteLine(nome1);

// foreach (var item in queue)
// {
//     Console.WriteLine(item);
// }
*/

/*
var stack = new Stack<string>();

stack.Push("Andre");
stack.Push("Inacio");

var nome = stack.Pop();
var nome1 = stack.Pop();

Console.WriteLine(nome);
Console.WriteLine(nome1);

// foreach (var item in stack)
// {
//     Console.WriteLine(item);
// }
*/

/*
var diaDaSemana = 3;

if (diaDaSemana == 0)
{
    Console.WriteLine("Hoje é Domingo");
}
else if (diaDaSemana == 1)
{
    Console.WriteLine("Hoje é Segunda");
}
else if (diaDaSemana == 2)
{
    Console.WriteLine("Hoje é Terça");
}
else if (diaDaSemana == 3)
{
    Console.WriteLine("Hoje é Quarta");
}
else if (diaDaSemana == 4)
{
    Console.WriteLine("Hoje é Quinta");
}
else if (diaDaSemana == 5)
{
    Console.WriteLine("Hoje é Sexta");
}
else if (diaDaSemana == 6)
{
    Console.WriteLine("Hoje é Sábado");
}
else
{
    Console.WriteLine("Dia da Semana Inválido");
}
*/

/*
var diaDaSemana = 10;

switch (diaDaSemana)
{
    case 0:
        Console.WriteLine("Hoje é Domingo");
        break;
    case 1:
        Console.WriteLine("Hoje é Segunda");
        break;
    case 2:
        Console.WriteLine("Hoje é Terça");
        break;
    case 3:
        Console.WriteLine("Hoje é Quarta");
        break;
    case 4:
        Console.WriteLine("Hoje é Quinta");
        break;
    case 5:
        Console.WriteLine("Hoje é Sexta");
        break;
    case 6:
        Console.WriteLine("Hoje é Sábado");
        break;

    default:
        Console.WriteLine("Dia da Semana Inválido");
        break;
}
*/

/*
var lista = new List<string>() { "Andre", "Curso", "C#" };
var count = lista.Count;

for (var i = 0; i < count; i++)
{
    Console.WriteLine(lista[i]);
}
*/

/*
var lista = new List<string>() { "Andre", "Curso", "C#" };

foreach (string palavra in lista)
{
    foreach (char letra in palavra)
    {
        Console.WriteLine(letra);
    }
}
*/

/*
var i = 3;

while (i < 2)
{
    Console.WriteLine("var i = " + i);
    i++;
}

var j = 3;

do
{
    Console.WriteLine("var j = " + j);
    j++;
} while (j < 2);
*/
/*
var i = 0;

while (i < 5)
{
    if (i < 2)
    {
        Console.WriteLine("Continuando...");
        i++;
        continue;
    }

    Console.WriteLine("var i = " + i);
    i++;

    if (i == 2)
    {
        Console.WriteLine("Valor de i é dois (2)");
        break;
    }
}
*/
