using System;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {



            Random rand = new Random();
            int n = 20;
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10, 10);
                Console.Write("{0,3} ", arr[i]);
            }
            Console.WriteLine();
            int j = 0;
            while (j < arr.Length)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int f = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = f;
                    }
                }
                j++;
            }
            for (int i = 0; i < arr.Length; i++)

                Console.Write("{0,3} ", arr[i]);

            Console.WriteLine();
            {
                Console.WriteLine("Esli hotite povtorit vvod, vvedite 1, inache lubuyu dr cifru");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1) Main();
                return;
            }
            Console.ReadLine();

        }
    }
}
