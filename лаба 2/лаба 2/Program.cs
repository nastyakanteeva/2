using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        int min = 0;
        int min21 = 0;
        int min2 = 0;
        int min1 = 0;
        Random rnd = new Random();
        int[] array = new int[1000];
        for (int i = 0; i < array.Length; i++)
            array[i] = rnd.Next(1, 10000);
        for (int i = 0; i < array.Length; i++)
        {

            if (array[i] % 21 == 0 && array[i] < min21) min21 = array[i];

            if (array[i] % 2 == 0 && array[i] < min2) min2 = array[i];

            if (array[i] % 1 == 0 && array[i] < min1) min1 = array[i];

            if (array[i] > min) min = array[i];
        }
        if (min21 < min2 && min21 < min2 && min21 < min &&
        min2 < min21 && min2 < min1 && min2 < min &&
        min1 < min21 && min1 < min2 && min1 < min &&
        min < min21 && min < min2 && min < min1)
        {
            Console.WriteLine("есть");
        }
        else
        {
            Console.WriteLine("-1");
        }
    }
}