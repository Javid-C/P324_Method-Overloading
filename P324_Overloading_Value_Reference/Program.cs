using System;

namespace P324_Overloading_Value_Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework and Classwork
            //Console.WriteLine("Please enter first number:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter second number");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter operator");
            //char op = Convert.ToChar(Console.ReadLine());
            //Calc(number, num2, op);

            //string[] words = { "Lenova", "MSI", "HP", "Asus", "Acer", "Mac", "Dell" };

            //foreach (string word in words)
            //{
            //    if(word.Length >= 3)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}


            //int num = 21674;
            //int sum = 0;
            //while (num !=0)
            //{
            //    int remainder = num % 10;
            //    num /= 10;
            //    sum += remainder;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Method overloading
            //int number = int.Parse("8");
            //Console.WriteLine("Please enter\n");
            //Console.WriteLine("Test");
            //Console.WriteLine();
            //Add(5);
            //int num = Add(5);
            //Console.WriteLine(num);
            #endregion
        }


        #region Classwork
        //public static void Calc(int num1, int num2, char op)
        //{
        //    switch (op)
        //    {
        //        case '+':
        //            Console.WriteLine("Toplam: " + (num1 + num2));
        //            break;
        //        case '-':
        //            Console.WriteLine("Cixma: " + (num1 - num2));
        //            break;
        //        case '/':
        //            Console.WriteLine("Bolme: " + num1 / num2);
        //            break;
        //        case '*':
        //            Console.WriteLine("Vurma: " + num1 * num2);
        //            break;
        //        default:
        //            Console.WriteLine("Please choose valid operator");
        //            break;
        //    }
        //}
        #endregion

        #region Method Overloading
        //public static void Add()
        //{
        //    Console.WriteLine(5+10);
        //}
        //public static void Add(byte Bnum)
        //{
        //    Console.WriteLine("byte");
        //    Console.WriteLine(Bnum + 50);
        //}
        //public static void Add(int num=10)
        //{
        //    Console.WriteLine("int");
        //    Console.WriteLine(num + 10);
        //}

        //public static void Add(string str)
        //{
        //    Console.WriteLine(5 + str);
        //}

        //public static void Add(string name, string surname)
        //{
        //    Console.WriteLine(name + " " + surname);
        //}

        //public static void Add(string name, int age)
        //{
        //    Console.WriteLine(name + " " + age);
        //}


        //public static void Add(string surname, string name) // Error
        //{

        //}

        //public static void Add(int age, string name)
        //{

        //}

        //public static void Add(string name, string surname, int age)
        //{
        //    Console.WriteLine(name + " " + surname + " " + age);
        //}

        //public static void Add(int[] arr)
        //{
        //    foreach (var item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        // Methodun return type-i onun imzasi sayilmir
        //public static int Add(int num) //Error
        //{
        //    return num;
        //}

        //public static string Add(int Num) //Error
        //{
        //    return Num.ToString();
        //} 

        #endregion

    }
}
