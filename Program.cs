using System;
using System.Collections.Generic;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Bubble sort - 1\n Quick sort - 2");
            var x = Console.ReadLine();
            switch (x)
            {
                case "1":
                    Console.WriteLine("Bubble sort");
                    Console.WriteLine("Crescente(1)/ Decrecente(2)");
                    var w = Convert.ToInt32(Console.ReadLine());
                    List<int> numeros = new List<int>();

                    while (true)
                    {
                        Console.WriteLine("Continuar(1)/Finalizar(2)");

                        var y = Convert.ToInt32(Console.ReadLine());
                        if (y == 2)
                        {
                            break;
                        }
                        Console.WriteLine("dig um numero");
                        numeros.Add(Convert.ToInt32(Console.ReadLine()));

                    }
                    for (int i = 0; i < numeros.Count; i++)
                    {
                        for (int j = 0; j < numeros.Count; j++)
                        {

                            if (w == 1)
                            {
                                if (numeros[i] < numeros[j])
                                {
                                    Console.WriteLine(numeros[i] + " < " + numeros[j]);
                                    var aux = numeros[i];
                                    numeros[i] = numeros[j];
                                    numeros[j] = aux;
                                }
                            }
                            else
                            {
                                if (numeros[i] > numeros[j])
                                {
                                    Console.WriteLine(numeros[i] + " > " + numeros[j]);
                                    var aux = numeros[i];
                                    numeros[i] = numeros[j];
                                    numeros[j] = aux;
                                }
                            }
                        }
                    }
                    Console.WriteLine("\n");
                    foreach (var item in numeros)
                    {
                        Console.WriteLine(item);

                    }
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Quick sort");
                    List<int> nums = new List<int>();


                    while (true)
                    {
                        Console.WriteLine("Continuar(1)/Finalizar(2)");

                        var y = Convert.ToInt32(Console.ReadLine());
                        if (y == 2)
                        {
                            break;
                        }
                        Console.WriteLine("dig um numero");
                        nums.Add(Convert.ToInt32(Console.ReadLine()));
                    }
                    void QuickSort(List<int> X, int inicio, int final)
                    {

                        var i = inicio;
                        var j = final;
                        ;
                        var pivo = X[(i + j) / 2];
                        while (i <= j)
                        {
                            while (X[i] < pivo)
                            {
                                i++;
                            }
                            while (X[j] > pivo)
                            {
                                j--;
                            }
                            while (i <= j )
                            {
                                var aux = X[i];
                                X[i] = X[j];
                                X[j] = aux;
                                i++;
                                j--;
                            }
                            
                        }
                        if (inicio < j)
                        {
                            QuickSort(X, inicio, j);
                        }
                        if (i < final)
                        {
                            QuickSort(X, i, final);
                        }
                    }
                    QuickSort(nums, 0, nums.Count-1);
                    foreach (var item in nums)
                    {
                        Console.WriteLine(item);

                    }
                    Console.ReadKey();

                    break;
            }
        }
    }
}
