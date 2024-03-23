// See https://aka.ms/new-console-template for more information

static double CalculateAverage(int[] array)
{

    if (array == null)
    {
        throw new ArgumentException("Tablica nie moze byc pusta");
    }
    
    int sum = 0;
    
    foreach (int num in array)
        sum += num;

    return (double) sum / array.Length;
}

int[] numbers = { 3, 4, 55, 10, 5 };
double average = CalculateAverage(numbers);
Console.WriteLine("Średnia: " + average);