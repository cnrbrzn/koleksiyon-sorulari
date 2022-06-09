using System.Collections;
ArrayList positiveNumbers = new ArrayList();
ArrayList prime = new ArrayList();
ArrayList nonPrime = new ArrayList();
int n = 20;
int[] intArray = new int[n];
Console.WriteLine("20 adet pozitif sayı giriniz...");
for (int i = 0; i < n; i++)
{
    try
    {
        intArray[i] = Convert.ToInt32(Console.ReadLine());
        if (intArray[i] > 0)
        {
            positiveNumbers.Add(intArray[i]);
        }
        else
        {
            Console.WriteLine("Lütfen pozitif sayı giriniz...");
            break;
        }
    }
    catch
    {
        Console.WriteLine("Lütfen sayı giriniz...");
        break;
    }
}
if (positiveNumbers.Count != 0)
{
    for (int i = 0; i < n; i++)
    {
        int counter = 0;
        List<int> numbers = positiveNumbers.Cast<int>().ToList();
        for (int j = 2; j < numbers[i]; j++)
        {
            if (numbers[i] % j == 0)
            {
                nonPrime.Add(numbers[i]);
                counter++;
                break;
            }
        }
        if (numbers[i] == 1)
        {
            nonPrime.Add(numbers[i]);
            counter++;
        }
        else if (!prime.Contains(numbers[i]) && counter == 0 && numbers[i] != 1)
        {
            prime.Add(numbers[i]);
        }
    }
    if (prime.Count != 0 || nonPrime.Count != 0)
    {
        double primeAverage = 0;
        double nonPrimeAverage = 0;
        nonPrime.Sort();
        nonPrime.Reverse();
        prime.Sort();
        prime.Reverse();
        Console.WriteLine("***** Asal Sayılar *****");
        foreach (var item in prime)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("***** Asal Olmayan Sayılar *****");
        foreach (var item in nonPrime)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Asal Olanların Sayısı : " + prime.Count);
        Console.WriteLine("Asal Olmayanların Sayısı : " + nonPrime.Count);
        foreach (var item in prime)
        {
            primeAverage += Convert.ToDouble(item);
        }
        if (primeAverage != 0)
            primeAverage = primeAverage / prime.Count;
        foreach (var item in nonPrime)
        {
            nonPrimeAverage += Convert.ToDouble(item);
        }
        if (nonPrimeAverage != 0)
            nonPrimeAverage = nonPrimeAverage / nonPrime.Count;
        Console.WriteLine("Asal Olanların Ortalaması : " + primeAverage);
        Console.WriteLine("Asal Olmayanların Ortalaması : " + nonPrimeAverage);
    }
}