using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        List<int> numbers = Enumerable.Range(0, 10)
                                      .Select(x => rnd.Next(-50, 50))//-50 ile 50 arasında rastgele sayılar
                                      .ToList();

        Console.WriteLine("Rastgele Sayılar: " + string.Join(", ", numbers));

        //Çift sayılar sorgusu için kullanılacak Linq;
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Çift Sayılar: " + string.Join(", ", evenNumbers));

        //Tek sayılar sorgusu için kullanılacak Linq;
        var oddNumbers = numbers.Where(n => n % 2 != 0);
        Console.WriteLine("Tek Sayılar: " + string.Join(", ", oddNumbers));

        //Negatif sayılar sorgusu için kullanılacak Linq;
        var negativeNumbers = numbers.Where(n => n < 0);
        Console.WriteLine("Negatif Sayılar: " + string.Join(", ", negativeNumbers));

        //Pozitif  sayılar sorgusu için kullanılacak Linq;
        var positiveNumbers = numbers.Where(n => n > 0);
        Console.WriteLine("Pozitif Sayılar: " + string.Join(", ", positiveNumbers));

        //15'ten büyük ve 22'den küçük sayıların sorgusu için kullanılacak olan Linq;
        var between15And22 = numbers.Where(n => n > 15 && n < 22);
        Console.WriteLine("15'ten Büyük ve 22'den Küçük Sayılar: " + string.Join(", ", between15And22));

        //Her sayının karesini hesaplayacak olan Linq sorgusu;
        var squaredNumbers = numbers.Select(n => n * n).ToList();
        Console.WriteLine("Sayıların Kareleri: " + string.Join(", ", squaredNumbers));
    }
}
