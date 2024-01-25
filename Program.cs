// //Задача №1

void Numbers(int M, int N)
{
    if (N == M - 1)
    {
        return;
    }
    Numbers(M, N - 1);
    Console.Write($"{N} ");
}
Numbers(4, 8);

// //Задача №2

int A(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return A(m - 1, 1);
    else
        return A(m - 1, A(m, n - 1));
}
Console.Write(A(2, 3));

// //Задача №3

void ReverseNumbers(int[] array, int i = 0)
{
    if (i < array.Length)
    {
        Console.Write($"{array[array.Length - 1 - i]} ");
    }
    else
    {
        return;
    }

    ReverseNumbers(array, i + 1);

}
int[] array2 = { 34, 28, 0, 14, 6 };
ReverseNumbers(array2);

