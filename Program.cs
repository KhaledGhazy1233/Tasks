namespace C__Tasks
{
    internal class Program
    {
        #region 
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
            #region
            //int n = 1;
            //do
            //{
            //    int multible = n * 5;
            //    Console.WriteLine($" {n} * 5 ={multible}");
            //    n++;

            //} while (n <= 10);
            #endregion
            #region 
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
            #region 

            //for (int i =1; i<=12; i++)
            //{
            //    for(int j =1;j<=12;j++ )
            //    {
            //        Console.WriteLine($"{j}*{i} = {i * j}");
            //    }
            //    Console.WriteLine("--------------------------");
            //}
            #endregion
            #region
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
            #region
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
            Console.WriteLine("Enter The 5 Elements ");
            int[] arr = new int[5];
            for (int i =0;i<arr.Length;i++)
            {
                Console.Write($"Element {i+1} : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"****** Reversed Array *****");
            int index = arr.Length - 1;
            while (index >= 0) 
            {
                Console.WriteLine($"index[{index}]= {arr[index]}");
                index--;
            }
        }
    }
}
