int n = 6;
int[] numbers = new int[n];
int[] lowestNumbers = new int[3];
int[] biggestNumbers = new int[3];
Console.WriteLine("20 adet pozitif sayı giriniz...");
for (int i = 0; i < n; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    numbers[i] = number;
}
if (numbers.Count() != 0)
{
    Array.Sort(numbers);
    int j = numbers.Count() - 1;
    for (int i = 0; i < 3; i++)
    {
        lowestNumbers[i] = numbers[i];
        biggestNumbers[i] = numbers[j];
        j--;
    }
    if (lowestNumbers.Count() != 0 && biggestNumbers.Count() != 0)
    {
        double lowestAverage = 0;
        double biggestAverage = 0;
        for (int i = 0; i < 3; i++)
        {
            lowestAverage = lowestAverage + lowestNumbers[i];
            biggestAverage = biggestAverage + biggestNumbers[i];
        }
        lowestAverage = lowestAverage/lowestNumbers.Count();
        biggestAverage = biggestAverage/biggestNumbers.Count();
        double totalAverage = lowestAverage + biggestAverage;
        Console.WriteLine("Girilen sayılardan en küçüklerinin ortalamaları : " + lowestAverage);
        Console.WriteLine("Girilen sayılardan en büyüklerinin ortalamaları : " + biggestAverage);
        Console.WriteLine("En büyüklerinin ve en küçüklerinin ortalama toplamları : " + totalAverage);
    }
}