namespace Modulo12;

public class TrabalhandoComExcecoes
{
    public void AulaGerandoException()
    {
        while (true)
        {
            Console.Write("Informe um numero: ");
            var numero = Console.ReadLine()!;
            var resultado = 500 / int.Parse(numero);
            Console.WriteLine("Resultado: " + resultado);
        }
    }
    public void AulaTratandoException()
    {
        while (true)
        {
            try
            {
                Console.Write("Informe um numero: ");
                var numero = Console.ReadLine()!;
                var resultado = 500 / int.Parse(numero);
                Console.WriteLine("Resultado: " + resultado);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("Erro de divisao: " + exception.Message);
                Console.WriteLine("Stack: " + exception.StackTrace);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Erro: " + exception.Message);
                Console.WriteLine("Stack: " + exception.StackTrace);
            }
        }
    }
}