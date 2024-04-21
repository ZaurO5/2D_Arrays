//task 1

//int[,] array =
//{
//    { 10, 20, 30},
//    { 40, 50, 60}
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        Console.Write(array[i,y] + " ");
//    }
//    Console.WriteLine();
//}

//task 2 

//int[,] array =
//{
//    { 10, 20, 30},
//    { 40, 50, 60}
//};

//int sum = 0;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        sum += array[i, y];
//    }
//}
//Console.WriteLine(sum);

//task 3

//int[,] array =
//{
//    { 10, 20, 30},
//    { 40, 50, 60},
//    { 70, 80 ,90}
//};
//int i = 0;
//int sum = 0;
//for (int y = 0; y < array.GetLength(0); y++)
//{
//    sum += array[y, i];
//}
//Console.WriteLine(sum);

//task 4


//int[,] array =
//{
//    { 10, -20, 30},
//    { -40, 50, 60},
//    { 70, 80 ,-90}
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        if (array[i, y]<0)
//        {
//            Console.WriteLine(array[i, y]);

//        }
//    }
//}

//task 5

//int[,] array =
//{
//    { 10, 20, 30},
//    { 40, 50, 60}
//};

//int min = array[0,0];
//int max = array[0,0];
//int a;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        {
//            a = array[i, y];
//            // min = Math.min(min, a);
//            if (a < min)
//            {
//                min = a;
//            }

//            a = array[i, y];
//            // max = Math.Max(max, a);
//            if (a > max)
//            {
//                max = a;
//            }
//        }
//    }
//}

//Console.WriteLine(min);
//Console.WriteLine(max);

//task 6

//int[,] array =
//{
//    { 1, -20, 3},
//    { 40, -5, 60}
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        if (array[i, y] > 0 && array[i, y] % 2 == 0)
//        {
//            array[i, y] = 2;
//        }
//        else if (array[i, y] > 0 && array[i, y] % 2 == 1)
//        {
//            array[i, y] = 1;
//        }
//        else if (array[i, y] < 0 && array[i, y] % 2 == 0)
//        {
//            array[i, y] = -2;
//        }
//        else if (array[i, y] < 0 && array[i, y] % 2 != 1)
//        {
//            array[i, y] = -1;
//        }
//    }
//}
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        Console.Write(array[i, y] + " ");
//    }
//    Console.WriteLine();
//}

//task 7


//int[,] array =
//{
//    { 10, 20, 30, 40},
//    { 50, 60, 70, 80},
//    { 90, 100, 110, 120},
//    { 130, 140, 150, 160 }
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        if (i == 1)
//        {
//            array[i, y] = 0;
//        }
//    }
//}

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        Console.Write(array[i, y] + " ");
//    }
//    Console.WriteLine();
//}

//task 8

//int[,] array =
//{
//    { 10, 20, 30},
//    { 40, 50, 60},
//    { 70, 80, 90}
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        if (y == 2)
//        {
//            array[i, y] = 0;
//        }
//    }
//}

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        Console.Write(array[i, y] + " ");
//    }
//    Console.WriteLine();
//}

//task 9

//int[,] array =
//{
//    { 10, 20, 30},
//    { 40, 50, 60},
//    { 70, 80, 90}
//};

//int sum = 0;

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = i; y < array.GetLength(1); y++)
//    {
//        if (i == y)
//        { 
//         sum += array[i, y];
//        }
//    }
//}
//Console.WriteLine(sum);

//task 10

//int[,] array =
//{
//    { 10, 20, 30},
//    { 40, 50, 60},
//    { 70, 80, 90}
//};

//int sum = 0;

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (i + j == array.GetLength(0) - 1)
//        {
//            sum += array[i, j];
//        }
//    }
//}

//Console.WriteLine(sum);


//task 11


//int[,] array =
//{
//    { 10, 20, 30, 40, 50},
//    { 60, 70, 80, 90, 100},
//    { 110, 120, 130, 140, 150},
//    { 160, 170, 180, 190, 200 },
//    { 210, 220, 230, 240, 250 }
//};



//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        if (y < i)
//        {
//            array[i, y] = 0;
//        }
//    }
//}

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        Console.Write(array[i, y] + " ");
//    }
//    Console.WriteLine();
//}

//task 12


//int[,] array =
//{
//    { 10, 20, 30, 40, 50},
//    { 60, 70, 80, 90, 100},
//    { 110, 120, 130, 140, 150},
//    { 160, 170, 180, 190, 200 },
//    { 210, 220, 230, 240, 250 }
//};



//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        if (y > i)
//        {
//            array[i, y] = 0;
//        }
//    }
//}

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        Console.Write(array[i, y] + " ");
//    }
//    Console.WriteLine();
//}

//task 13


//int[,] arr1 =
//{
//    { 10, 20, 30},
//    { 40, 50, 60},
//    { 70, 80 ,90}
//};

//int[,] arr2 =
//{
//    { 10, 20, 30},
//    { 40, 50, 60},
//    { 70, 80 ,90}
//};

//int[,] arr3 = new int[3, 3];

//for (int i = 0; i < arr3.GetLength(0); i++)
//{
//    for (int y = 0; y < arr3.GetLength(1); y++)
//    {
//        arr3[i, y] = arr1[i, y] + arr2[i, y]; 
//    }
//}

//for (int i = 0; i < arr3.GetLength(0); i++)
//{
//    for (int y = 0; y < arr3.GetLength(1); y++)
//    {
//        Console.Write(arr3[i, y] + " ");
//    }
//    Console.WriteLine();
//}

//task 14

//int[,] array =
//{
//    { 10, 20, 30},
//    { 40, 50, 60},
//    { 70, 80 ,90}
//};

//for (int x = 0; x < array.GetLength(0); x++)
//{
//    int sum = 0;
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        sum += array[x, y]; 
//    }
//    Console.WriteLine(sum);
//}

//task 15

//int[,] array =
//{
//    { 10, 20, 30},
//    { 40, 50, 60},
//    { 70, 80 ,90}
//};

//for (int x = 0; x < array.GetLength(0); x++)
//{
//    int sum = 0;
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        sum += array[y, x];
//    }
//    Console.WriteLine(sum);
//}

//task 16

//int[,] arr =
//{
//    { 1, 1, 5, 0, 1, 1 },
//    { 1, 1, 2, 0, 1, 1 },
//    { 1, 1, 3, 0, 1, 1 },
//    { 1, 1, 4, 0, 1, 1 }
//};

//int shift = 3;

//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = arr.GetLength(1) - 1; j >= 0; j--)
//    {
//        if (j - shift >= 0)
//        {
//            arr[i, j] = arr[i, j - shift];
//        }
//        else
//            arr[i, j] = 0;
//    }
//}

//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        Console.Write($"{arr[i, j]}  ");
//    }

//    Console.WriteLine();
//}

// task 17

//int[,] arr1 =
//{
//    { 10, 20, 30},
//    { 40, 50, 60},
//    { 70, 80 ,90}
//};

//int[,] arr2 =
//{
//    { 10, 20, 30},
//    { 40, 50, 60},
//    { 70, 80 ,90}
//};

//int[,] arr3 = new int[3, 3];

//for (int i = 0; i < arr3.GetLength(0); i++)
//{
//    for (int y = 0; y < arr3.GetLength(1); y++)
//    {
//        arr3[i, y] = arr1[i, y] * arr2[i, y];
//    }
//}

//for (int i = 0; i < arr3.GetLength(0); i++)
//{
//    for (int y = 0; y < arr3.GetLength(1); y++)
//    {
//        Console.Write(arr3[i, y] + " ");
//    }
//    Console.WriteLine();
//}

//task 18

//bool iscomplex = false;
//int[,] array =
//{
//    {  1, 2, 3 },
//    { 4, 5, 6 },
//    { 7, 8, 9 }
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        if (array[i, j] <= 1)
//        {
//            continue;
//        }
//        else
//        {

//            iscomplex = false;
//            int squareroot = Convert.ToInt32(Math.Sqrt(array[i, j]));
//            for (int k = 2; k < squareroot; k++)
//            {
//                if (array[i, j] % k == 0)
//                {
//                    iscomplex = true;
//                }
//            }
//            if (!iscomplex)
//            {
//                Console.WriteLine(array[i, j]);
//            }
//        }
//    }
//}