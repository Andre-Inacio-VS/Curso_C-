namespace Conversores;

public class Conversor
{
    public void ConvertAndParse()
    {
        // int numero = int.Parse("1"); => 1
        // int numero = Convert.ToInt32("1");=> 1
        // int numero = Convert.ToInt32(null); => 0
        bool verdadeiro = bool.Parse("true");
        Console.WriteLine(verdadeiro);
    }
    public void AulaTryParse()
    {
        var numero = "123456";

        int numeroConvertido;

        if (int.TryParse(numero, out numeroConvertido))
        {
            Console.WriteLine("O numero '" + numero + "' foi convertido para " + numeroConvertido);
        }
    }
}