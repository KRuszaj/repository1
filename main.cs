using System.IO;
using System;

class Program
{
    /// <summary>
    /// Wywoluje metode, ktora podnosi, do potegi a nastepnie metode, ktora sumuje cyfry otrzymanego wyniku
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Magiczne Liczenie");
        Program.AddDigitalNumber(Program.Power());
        
    }
    
    /// <summary>
    /// Podnosze liczbe 2 do potegi 30 i zapisuje do zmiennej power typu long
    /// </summary>
    /// <returns> zwraca potege zadanej liczby </returns>
    public static long Power(){
         long power = (long)Math.Pow(2,15);
         Console.WriteLine("2^30 wynosi: {0}", power);
         return power;
    }
     
     /// <summary>
    /// Podnosze liczbe 2 do potegi 30 i zapisuje do zmiennej power typu long
    /// </summary>
    /// <param name="power> podaje liczbe, ktorej poszczegolne cyfry chce zsumowac </param>
     public static void AddDigitalNumber(long number){
        long addPower = 0;
        while(number != 0){
            addPower += number % 10;
            number /= 10;
        }
        
        Console.WriteLine("Suma cyfr tej potegi wynosi: {0}", addPower);
     }

}
