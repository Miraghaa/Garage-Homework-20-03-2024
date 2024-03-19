namespace Garage_Homework_.Models;

public class Forback
{
    public void Dongu(int[] arr1, int[] arr2)
    {
        int count = 0;
        int[] arr3 = { };
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                if (arr1[i] == arr2[j])
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Array.Resize(ref arr3, arr3.Length + 1);
                arr3[arr3.Length - 1] = arr1[i];
            }
            count = 0;
        }
        foreach (int item in arr3)
        {
            Console.WriteLine(item);
        }
    }
}
