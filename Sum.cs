public class WorkWithSum
{
    public static int SumBlock()
    {
        int[] array = Enumerable.Range(0, 1000).ToArray();
        // while(true)
        // {
        int[] copy = new int[50];
        Array.Copy(array, 500, copy, 0, 2);
        Console.WriteLine(string.Join(", ", copy));
        return Sum(copy);
        // }
    }



    public static int Sum(int[] array)
    {
        int sum = 0;
        foreach (int i in array)
        {
            sum += i;
        }
        return sum;
    }

    public static int Sum(int[] array, int offset, int length)
    {
        int sum = 0;
        for (int i = offset; i < offset + length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    public static int Sum(List<int> list, int offset, int length)
    {
        int sum = 0;
        for (int i = offset; i < offset + length; i++)
        {
            sum += list[i];
        }
        return sum;
    }

    public static int Sum(Span<int> span)
    {
        int sum = 0;
        // for (int i = 0; i < span.Length; i++)
        // {
        //     sum += span[i];
        // }


        foreach (int el in span) sum += el;
        return sum;
    }
}