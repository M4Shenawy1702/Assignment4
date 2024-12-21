namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //int Num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= Num; i++) Console.WriteLine($" {i}");
            #endregion
            #region 2- Write a program that allows the user to insert an integer then prin amultiplication table up to 12.
            //int Num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++) Console.Write($"{i* Num} ");
            #endregion
            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //int Num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= Num; i++)
            //     if (i % 2 == 0) Console.Write($"{i} ");
            #endregion
            #region 4- Write a program that takes two integers then prints the power.
            //int Num1 = int.Parse(Console.ReadLine());
            //int Num2 = int.Parse(Console.ReadLine());

            //double Res = Math.Pow(Num2, Num1);
            //Console.WriteLine(Res);
            #endregion
            #region 5- Write a program to allow the user to enter a string and print the REVERSE of it.
            //string Str = Console.ReadLine();

            //char[] charArray = Str.ToCharArray();
            //Array.Reverse(charArray);
            //string reversedString = new string(charArray);

            //Console.WriteLine(reversedString);
            #endregion
            #region 6- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //int Num1 = int.Parse(Console.ReadLine());
            //int Num2 = int.Parse(Console.ReadLine());

            //bool flage = true;

            //for (int i = Num1; i <= Num2; i++)
            //{
            //    flage = true;
            //    if (i <= 1) continue;

            //    for (int j = 2; j <= i/2; j++)
            //    {
            //        if (i % j == 0)
            //        { 
            //            flage = false;
            //            break;
            //        } 
            //    }
            //    if(flage)Console.WriteLine(i);
            //}

            #endregion
            #region 7-Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //int Num = int.Parse(Console.ReadLine());
            //string Binary = "";

            //if (Num == 0) 
            //    Console.WriteLine(0);

            //while (Num > 0) {
            //    int rem = Num % 2;
            //    Binary = rem + Binary;
            //    Num = Num / 2;
            //}
            //Console.WriteLine(Binary);
            #endregion
            #region 8-Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < num; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region 9- Write C# program that Extract a substring from a given string.
            //string str = Console.ReadLine();

            //string substring = str.Substring(1);

            //Console.WriteLine(substring);
            #endregion
            #region 10- Write C# program that take two string variables and print them as one variable
            //string str1 = Console.ReadLine();
            //string str2 = Console.ReadLine();

            //string str3 = $"{str1} {str2}";
            //Console.WriteLine(str3);
            #endregion
            #region 12- Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] nums = [1,2,3,4,5,6,7,8,9];  
            //int sum = nums.Sum();
            //Console.WriteLine(sum);
            #endregion
            #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int[] nums = [1,2,3]; 
            //int[] nums2 = [4,5,6];

            //int[] mergedArray = new int[2 * nums.Length];
            //nums.CopyTo(mergedArray, 0);
            //nums2.CopyTo(mergedArray, nums.Length);

            //Array.Sort(mergedArray);

            //Array.ForEach(mergedArray,X=>Console.Write($" {X}"));

            #endregion
            #region 14- Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] Nums = [1,1,5,4,6,6];
            //int[] frequency = new int[Nums.Length];

            //for (int i = 0; i < Nums.Length; i++)
            //{

            //    if (frequency[i] == 0)
            //    {
            //        int count = 1; 
            //        for (int j = i + 1; j < Nums.Length; j++)
            //        {
            //            if (Nums[i] == Nums[j])
            //            {
            //                count++;
            //                frequency[j] = -1;
            //            }
            //        }
            //        frequency[i] = count;
            //    }
            //}

            //for (int i = 0; i < Nums.Length; i++)
            //{
            //    if (frequency[i] > 0)
            //        Console.WriteLine($"Element {Nums[i]} occurs {frequency[i]} time(s).");
            //}
            #endregion
            #region 15- Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            //Console.WriteLine($"the min value {nums.Min()}");
            //Console.WriteLine($"the max value {nums.Max()}");
            #endregion
            #region 16- Write a program in C# Sharp to find the second largest element in an array.
            //int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            //int max = nums.Max();

            //nums.SetValue(0, Array.FindIndex(nums, X => X == max));

            //int secondlargestelement = nums.Max();

            //Console.WriteLine(secondlargestelement);
            #endregion
            #region 17-. Consider an Array of Integer values with size N, having values as in this Example
            //int num = int.Parse(Console.ReadLine());
            //int[] numbers = new int[num];

            //for (int i = 0; i < num; i++)
            //    numbers[i] = int.Parse(Console.ReadLine());

            //int distance = 0;
            //int Number = 0;
            //int index1 = 0;
            //int index2 = 0;

            //for (int i = 0;i < num; i++)
            //{
            //    for (int j = 0;j<i;j++)
            //    {
            //        if (numbers[j] == numbers[i])
            //        {
            //            int res = i - (j + 1);

            //            if (distance < res)
            //            {
            //                distance = res;
            //                Number = numbers[i];
            //                index1 = i;
            //                index2 = j;
            //            }
            //        }      
            //    }
            //}
            //Console.WriteLine($"the longest distance between index {index1} and {index2} of number {Number} is {distance}");
            #endregion
            #region 18- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter the number of columns: ");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] array1 = new int[rows, cols];
            //int[,] array2 = new int[rows, cols];

            //Console.WriteLine("Enter the elements for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Element [{i},{j}]: ");
            //        array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Array.Copy(array1, array2, array1.Length);

            //Console.WriteLine("\nThe second array after copying elements from the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(array2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region 19- Write a Program to Print One Dimensional Array in Reverse Order
            //int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            //Array.Reverse(nums);

            //Array.ForEach(nums, i => Console.WriteLine(i)); 
            #endregion
            #region Demo
            #region Loop statment 

            //Console.WriteLine("1");
            //Console.WriteLine("2"); 
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");
            /************************/

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}



            #endregion

            #region for - foreach 
            //int[] Numbers = { 1, 2, 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10 };

            //for (int i = 0; i < Numbers.Length; i++)
            //{   

            //    Numbers[i] += 10; /*valid because we can change the indexes inisde our array  */

            //    if (Numbers[i] == 5)
            //    {
            //        break ; /* it will print until 4 and stop */
            //    }

            //    if (Numbers[i] == 5)
            //    {
            //        continue; /* it will print all except 5  */
            //    }

            //    Console.WriteLine(Numbers[i]);
            //    Console.WriteLine(Numbers[i] + 10) ; /*we can change normally in the the way of printing */
            //}

            /******************************************/

            //foreach (int Number in Numbers)
            //{
            //    Numbers += 10;              /*Invalid in for each to do operation inside our array because it take copy of array not changeing the original one */ 
            //    Console.WriteLine(Number);
            //    Console.WriteLine(Number + 10); /*we can change normally in the the way of printing */
            //}
            #endregion

            #region while - do while 
            //int Number;
            //bool Flag;
            //do
            //{
            //    Console.WriteLine("Enter Even number ");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //} while (Number % 2 == 1 || !Flag );

            //Console.WriteLine($"{Number} is Even number ");

            /*****************************************************************/
            //int Number = 3; 
            //bool Flag = false;
            //while (Number%2 == 1 || !Flag)
            //{
            //    Console.WriteLine("Enter Even Number");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //}

            //Console.WriteLine($"{Number} is Even Number");

            #endregion

            #region String 
            //string name01 = "Ahmed";
            //string name02 = "Ahmed";
            //Console.WriteLine(name01);
            //Console.WriteLine($"name01 => {name01.GetHashCode()}");
            //Console.WriteLine(name02);
            //Console.WriteLine($"name02 => {name02.GetHashCode()}");

            ///*****************************************************************/
            //Console.WriteLine("****///////****");

            //name01 = name02;
            //Console.WriteLine(name01);
            //Console.WriteLine($"name01 => {name01.GetHashCode()}");
            //Console.WriteLine(name02);
            //Console.WriteLine($"name02 => {name02.GetHashCode()}");

            ///*****************************************************************/
            //name01 = "mostafa";
            //Console.WriteLine($"name01 => {name01.GetHashCode()}");
            //Console.WriteLine(name02);
            //Console.WriteLine($"name02 => {name02.GetHashCode()}");

            ///****************************************************************/
            //string name = "Hello"; 
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());

            //name += " Route "; 
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetHashCode());

            #endregion

            #region stringbuilder 
            //StringBuilder Name ;
            //Name = new StringBuilder("hello");

            //Console.WriteLine(Name);
            //Console.WriteLine(name.GetHashCode());

            //Name += "Route";  /*not allowed */
            //Name.Append("Route"); /*instead of it */

            //Console.WriteLine(Name);
            //Console.WriteLine(name.GetHashCode());

            #endregion

            #region stringbuilder method 
            //StringBuilder message = new StringBuilder();

            //message.Append("to route");
            //message.AppendLine("mostafa");
            //message.AppendLine("hany");

            //message.Remove("0,7");
            //message.Insert(0, "hellp");
            //Console.WriteLine(message);


            //int age = 20;
            //string name = "ali";
            //message.AppendFormat("Name , {0} , {1} " , name , age);
            //Console.WriteLine(message);

            //message.AppendJoin("/","mohamed","Hany","mahmoud");



            #endregion

            #region Array 1 D 
            //int[] Numbers = new int[3] { 1, 2, 3 };
            //int[] Numbers = new int[] { 1, 2, 3 };
            //int[] Numbers = { 1, 2, 3, 4, 5}; 

            //int[] numbers = new int[3];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($" Enter Element Number {i +1}");
            //    numbers[i] = int.Parse( Console.ReadLine() );

            //}
            //for (int i = 0;i < numbers.Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine(numbers.Length);
            //Console.WriteLine(numbers.Rank);

            #endregion

            #region Array 2 D 

            //int[,] marks = new int[3 , 5];
            //Console.WriteLine(marks.Length);
            //Console.WriteLine(marks.Rank);
            //Console.WriteLine(marks.GetLength(0));
            //Console.WriteLine(marks.GetLength(1));

            //for(int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter subject ({i + 1})");
            //    for (int k = 0; k < marks.GetLength(1); k++)
            //    {
            //        bool  Flag;
            //        Console.WriteLine($"Enter grade ({k + 1})");
            //       Flag = int.TryParse(Console.ReadLine(), out marks[i,k]);

            //        if ( Flag && marks[i,k] >=0 )
            //        {
            //            k++;
            //        }
            //        k = Flag && marks[i,k] >= 0 ? ++k : k;
            //    }
            //}


            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"grades subject ({i + 1})");
            //    for (int k = 0; k < marks.GetLength(1); k++)
            //    {
            //        Console.WriteLine($"grade subject ({k + 1})");
            //        Console.WriteLine(marks[i, k]);
            //    }
            //}
            #endregion

            #region judged array 
            //int[][] number = new int [3][];

            //number[0] = new int[3] {1,2,3};
            //number[1] = new int[2] { 3, 4 };
            //number[2] = new int [1] { 6 };

            //for (int i = 0; i < number.Length; i++)
            //{
            //    for (int j = 0; j < number[i].Length; j++)
            //    {
            //        Console.WriteLine(number[i][j]);
            //    }
            //}


            #endregion
            #endregion
        }
    }
}
