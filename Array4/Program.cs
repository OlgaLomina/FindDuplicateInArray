using System;
//4.Given an array that contains numbers from 1 to n-1 and exactly 1 duplicate, find that duplicate.
namespace Array4
{
    class Program
    {
        //static void printRepeating(int[] arr, int size)
        //{
        //    int i;
        //    for (i = 0; i < size; i++)
        //    {
        //        int l = Math.Abs(arr[i]);
        //        int k = arr[l];
        //        if (arr[l] >= 0)
        //        { 
        //            arr[l] = -arr[l];
        //            Console.WriteLine("l = " + l + "  arr[" + l + "] = " + arr[l]);
        //        }
        //        else
        //        {
        //            Console.Write("The repeating elements are : ");
        //            Console.WriteLine(l + " ");
        //        }
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    int[] arr = { 1, 2, 3, 4, 5, 5, 6 };
        //    int arr_size = arr.Length;

        //    printRepeating(arr, arr_size);
        //}

        static int FindDuplicate(int[] arr, int num)
        {
            int i;
            int sum1 = 0, sum2 = 0;
            //складываем числа от 1 до 6
            for (i = 1; i <= num; i++)
            {
                sum1 += i;
            }
            //складываем все числа в массиве
            for (i = 0; i <= num; i++)
            {
                sum2 += arr[i];
            }
            int substr = sum2 - sum1;
                    
            return substr;
        }

        static void Main()
        {
            int[] arr = { 1, 2, 3, 2, 4, 5 };
            //int[] arr = { 1, 2, 3, 4, 5, 5, 6 };
            int n = arr.Length - 1; //в массиве числа от 1 до n-1
                                    //всего 7 элементов, числа в массиве от 1 до 6. 
                                    //Нам надо сложить 6 чисел по порядку от 1 до 6,  и затем все числа массива. 
                                    //вычесть разницу, получим число дубликат


            Console.WriteLine(" duplicate number is " + FindDuplicate(arr, n));
            Console.ReadLine(); ;
        }


    }
}
