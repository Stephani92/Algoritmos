using System;
using System.Collections.Generic;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("teste");
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

                case "3":
                    Console.WriteLine("Quick sort");
                    List<int> num = new List<int>();

                    while (true)
                    {
                        Console.WriteLine("s(1)/n(2)");

                        var y = Convert.ToInt32(Console.ReadLine());
                        if (y == 2)
                        {
                            break;
                        }
                        Console.WriteLine("dig um numero");
                        num.Add(Convert.ToInt32(Console.ReadLine()));
                    }
                    List<int> QuickSort2(List<int> X, int inicio, int final)
                    {

                        var i = inicio;
                        var j = final - 1;
                        var pivo = X[j];
                        while (true)
                        {
                            while (X[i] < pivo)
                            {
                                i++;
                            }
                            while (X[j] > pivo)
                            {
                                j--;
                            }
                            while (i <= j)
                            {
                                var aux = X[i];
                                X[i] = X[j];
                                X[j] = aux;
                                i++;
                                j--;
                            }
                            break;

                        }
                        if (inicio < j)
                        {
                            QuickSort(X, inicio, j);
                        }
                        if (i < final)
                        {
                            QuickSort(X, i, final);
                        }
                        return X;
                    }
                    var result2 = QuickSort2(num, 0, num.Count);
                    foreach (var item in result2)
                    {
                        Console.WriteLine(item);

                    }
                    Console.ReadKey();

                    break;
            }
        }
    }
}
