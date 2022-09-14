// Задача № 64 

// Console.Write("Enter M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Enter N: ");
// int N = int.Parse(Console.ReadLine()!);
// void PrintNumbers(int M, int N)
// {
//     Console.Write($"{M}" + " ");
//     if (M >= N)
//     return;
//         M++;
//         PrintNumbers(M,N);



// }
// PrintNumbers(M,N);



// Задача № 66

// Console.Write("Enter M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Enter N: ");
// int N = int.Parse(Console.ReadLine()!);
// int Amount = M;
// int Count = M;
// void CountNumbers(int M, int N, int Amount, int Count)
// {
//    if (Count == N)
//    {
    
//    Console.Write("elements amount in range from M to N = " + Amount );
//    }
//     if (M >= N)
// return;
//     Count++;
//     Amount += Count;
//     M++;
//     CountNumbers(M, N, Amount, Count);

// }
// CountNumbers(M, N, Amount, Count);


// Задача № 68 


// Console.Write("Enter M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Enter N: ");
// int n = int.Parse(Console.ReadLine()!);
// A(m,n);
//  int A(int m, int n )
// {

//     if (m == 0)

//         return n + 1;
//     else
//     if (m > 0 && n == 0)

//         return A(m - 1, 1);
//     else
//     if (m > 0 && n > 0)

//         return A(m - 1, A(m, n - 1));

//     return A(m,n);

// }
// A(m, n);
// Console.Write("A(m,n) = " + A(m,n));
