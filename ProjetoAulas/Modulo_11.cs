namespace Modulo11;

public class TrabalhandoComDatas
{
    public void AulaDateTime()
    {
        var date1 = new DateTime(2024, 09, 11, 09, 08, 23);
        var date2 = DateTime.Parse("2024/09/11 09:08:23");
        var date3 = DateTime.Now;
        var date4 = DateTime.Today;

        Console.WriteLine(date1);
        Console.WriteLine(date2);
        Console.WriteLine(date3);
        Console.WriteLine(date4);

        // Formatando
        Console.WriteLine(date1.ToString("dd-MM-yyyy"));
        Console.WriteLine(date2.ToString("dd-MM-yyyy HH:mm:ss"));

        var dateOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
        Console.WriteLine(dateOffset1.LocalDateTime);
        Console.WriteLine(dateOffset1.UtcDateTime);
    }
    public void AulaSubtraindoDatas()
    {
        var date1 = DateTime.Now;
        var date2 = DateTime.Parse("2024-01-01");

        // var diff = date1 - date2;
        var diff = date1.Subtract(date2);

        Console.WriteLine((int)diff.TotalDays);
        Console.WriteLine((int)diff.TotalHours);
    }
    public void AulaAdicionandoDiaMesAno()
    {
        var date1 = DateTime.Now;

        Console.WriteLine(date1.ToString("dd-MM-yyyy HH:mm:ss"));
        Console.WriteLine(date1.AddDays(3).ToString("dd-MM-yyyy HH:mm:ss"));
        Console.WriteLine(date1.AddMonths(1).ToString("dd-MM-yyyy HH:mm:ss"));
        Console.WriteLine(date1.AddYears(2).ToString("dd-MM-yyyy HH:mm:ss"));
    }
    public void AulaAdicionandoHorasMinutosSegundos()
    {
        var date1 = DateTime.Now;

        Console.WriteLine(date1.ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddHours(1).ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddMinutes(10).ToString("HH:mm:ss"));
        Console.WriteLine(date1.AddSeconds(10).ToString("HH:mm:ss"));
    }
    public void AulaDiaDaSemana()
    {
        var date1 = DateTime.Now;

        Console.WriteLine(date1.DayOfWeek);
    }
    public void AulaDateOnly()
    {
        // var somenteData = new DateOnly(2024, 09, 11);
        var somenteData = DateOnly.Parse("2024-09-11");

        Console.WriteLine(somenteData);
        Console.WriteLine(somenteData.ToString("dd/MM/yyyy"));
        // Console.WriteLine(somenteData.ToString("dd/MM/yyyy HH:mm:ss"));
    }
    public void AulaTimeOnly()
    {
        // var somenteHora = new TimeOnly(10, 00, 20);
        var somenteHora = TimeOnly.Parse("10:00:20");

        Console.WriteLine(somenteHora);
        Console.WriteLine(somenteHora.ToString("HH:mm:ss"));
        // Console.WriteLine(somenteHora.ToString("dd/MM/yyyy HH:mm:ss"));
    }
}