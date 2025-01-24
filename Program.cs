namespace C__Tasks
{
    internal class Program
    {
        #region q2
        //public static int factorial(int n)
        //{
        //    if (n<1)
        //        return 1;
        //    else
        //    {
        //        return n*factorial(n-1);

        //    }
        //}
        #endregion 
        public static void Main(string[] args)
        {
            //int sum = 0;
            #region q1
            //int n = 1;
            //do
            //{
            //    int multible = n * 5;
            //    Console.WriteLine($" {n} * 5 ={multible}");
            //    n++;

            //} while (n <= 10);
            #endregion
            #region q3
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            //Console.WriteLine($"sum = {sum}");
            #endregion
            #region q4

            //for (int i =1; i<=12; i++)
            //{
            //    for(int j =1;j<=12;j++ )
            //    {
            //        Console.WriteLine($"{j}*{i} = {i * j}");
            //    }
            //    Console.WriteLine("--------------------------");
            //}
            #endregion
            #region q7
            //Console.WriteLine("enter the 10 Number: ");
            //int[] arr = new int[10];
            //for (int  i = 0;i<10; i++)
            //{
            //    Console.Write($"Enter number {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int max = arr[0];
            //int min = arr[0];

            //for (int i=0;i<arr.Length; i++ )
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    else if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //    else continue; 
            //}
            //Console.WriteLine($"The max Number is {max}");
            //Console.WriteLine($"the min Number is {min}");
            #endregion
            #region q8
            //Console.WriteLine("Enter the length of array ");
            //int Length = int.Parse(Console.ReadLine());
            //int[] arr = new int[Length];
            //for (int i=0; i<arr.Length;i++)
            //{
            //    Console.Write($"Enter the Element {i+1} : ");
            //    arr[i] =int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("****Reversed Array ******");
            //for (int j = arr.Length -1 ; j >= 0; j--)
            //{
            //    Console.Write($"Element {j+1} : ");
            //    Console.WriteLine(arr[j]);
            //}
            #endregion
            #region q9
            //Console.WriteLine("Enter The 5 Elements ");
            //int[] arr = new int[5];
            //for (int i =0;i<arr.Length;i++)
            //{
            //    Console.Write($"Element {i+1} : ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"****** Reversed Array *****");
            //int index = arr.Length - 1;
            //while (index >= 0) 
            //{
            //    Console.WriteLine($"index[{index}]= {arr[index]}");
            //    index--;
            //}
            #endregion
            #region q10
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //        continue;

            //    Console.WriteLine(i);
            //}
            #endregion
            #region q11
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //bool isPrime = true;

            //if (number <= 1)
            //    isPrime = false;
            //else
            //{
            //    for (int i = 2; i <= Math.Sqrt(number); i++)
            //    {
            //        if (number % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //}

            //Console.WriteLine(isPrime ? "Prime" : "Not Prime");
            #endregion
            #region 12
            //int count = 0;
            //int number = 2;

            //while (count < 20)
            //{
            //    if (IsPrime(number))
            //    {
            //        Console.WriteLine(number);
            //        count++;
            //    }
            //    number++;
            //}
            #endregion
            #region q13
            //int[] array = { -3, 4, -5, 6, 0, 7, -2, 8 };
            //int evenCount = 0, oddCount = 0, positiveCount = 0, negativeCount = 0;

            //foreach (int num in array)
            //{
            //    if (num % 2 == 0)
            //        evenCount++;
            //    else
            //        oddCount++;

            //    if (num > 0)
            //        positiveCount++;
            //    else if (num < 0)
            //        negativeCount++;
            //}

            //Console.WriteLine($"Even Count: {evenCount}");
            //Console.WriteLine($"Odd Count: {oddCount}");
            //Console.WriteLine($"Positive Count: {positiveCount}");
            //Console.WriteLine($"Negative Count: {negativeCount}");
            #endregion
            #region q14
            //Console.Write("Enter the number of terms: ");
            //int terms = int.Parse(Console.ReadLine());

            //Console.WriteLine("Fibonacci Sequence:");
            //for (int i = 0; i < terms; i++)
            //{
            //    Console.WriteLine(Fibonacci(i));
            //}
            #endregion
            #region q15
            //int[] array = { 1, 2, 3, 2, 1 };
            //bool isPalindrome = true;

            //for (int i = 0; i < array.Length / 2; i++)
            //{
            //    if (array[i] != array[array.Length - 1 - i])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //Console.WriteLine(isPalindrome ? "Palindrome" : "Not Palindrome");
            #endregion
            #region q6
            ////for (int i = 1; i <= 5; i++)
            ////{
            ////    for (char c = 'a'; c < 'a' + i; c++)
            ////    {
            ////        Console.Write(c);
            ////    }
            ////    Console.WriteLine();
            ////}
            ///
            # endregion 
        }
        #region q12
        //static bool IsPrime(int number)
        //{
        //    if (number <= 1)
        //        return false;

        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //            return false;
        //    }
        //    return true;
        //}
        #endregion
        #region q14
        //static int Fibonacci(int n)
        //{
        //    if (n <1)
        //        return 1;
        //    return Fibonacci(n - 1) + Fibonacci(n - 2);
        //}
        #endregion
    }

}
