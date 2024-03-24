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

static int CalculateMax(int[] array)
{
    if (array == null)
    {
        throw new ArgumentException("Tablica nie moze byc pusta");
    }
    
    int max = array[0];

    foreach (int num in array)
    {
        if (max < num)
            max = num;
    }

    return max;
}

int[] numbers = { 3, 4, 55, 10, 5 };
double average = CalculateAverage(numbers);
int max = CalculateMax(numbers);
Console.WriteLine("Średnia: " + average);
Console.WriteLine("Maksymalna liczba: " + max);