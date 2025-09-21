namespace ejercicio_S2_Csharp.Services;

public class DatesHoursFunc
{
    
    // Function to create a DATETIME.
    public static DateTime BuildDate(int? year = null, int? month = null, int? day = null, int? hour = null,
        int? minute = null, int? second = null)
    {
        int y = year ?? DateTime.MinValue.Year;
        int m = month ?? DateTime.MinValue.Month;
        int d = day ?? DateTime.MinValue.Day;
        int h = hour ?? 0;
        int ms = minute ?? 0;
        int s = second ?? 0;
        return new DateTime(y, m, d, h, ms, s);
    }


    
    // Function to imput data to DateTime according to BuildDate();
    public static DateTime ReturnDate(DateTime receptoryDate)
    {
        while (true)
        {
            Console.WriteLine("Escribe los siguientes datos para establecer la fecha: ");
            
            Console.Write("\tAño (YYYY):  ");
            int year_x = GeneralFunc.TryConvertInputToNumber();

            Console.Write("\tMes (1-12):  ");
            int month_x = GeneralFunc.TryConvertInputToNumber();
        
            Console.Write("\tDía (DD):  ");
            int day_x = GeneralFunc.TryConvertInputToNumber();
        
            Console.Write("\tHora (0-23):  ");
            int hour_x = GeneralFunc.TryConvertInputToNumber();
        
            Console.Write("\tMinutos (0-59):  ");
            int minute_x = GeneralFunc.TryConvertInputToNumber();
        
            //Console.Write("Ingresa los segundos (0-59):  ");
            //int second_x = GeneralFunc.TryConvertInputToNumber();
            int second_x = 0;

            try
            {
                receptoryDate = BuildDate(year_x, month_x, day_x, hour_x, minute_x, second_x);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("La fecha ingresada es: \n" + receptoryDate.ToString("F"));
                Console.ResetColor();
                return receptoryDate;
                
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Fecha y/o hora inválidos: {ex.Message}");
                Console.ResetColor();
            }
        }
        
    }
}