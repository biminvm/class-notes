//// See https://aka.ms/new-console-template for more information
//using Microsoft.VisualBasic;
//using System;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.Diagnostics;
//using System.Diagnostics.CodeAnalysis;
//using System.Drawing;
//using System.Globalization;
//using System.Runtime.Intrinsics.X86;
//using System.Security.Claims;
//using System.Security.Cryptography;

////Console.WriteLine("Hello, World!");
////string name = Console.ReadLine();
////Console.WriteLine("hello" + name);

////string Lastname = "doe";
////Console.WriteLine(res);


////november 8

////int x = 1;
////int y = 2;
//// string res = $"{x} + {y} = {x + y}";
////Console.WriteLine(res);

////string s = ""; IServiceProvider dynamically aloted

////int myNum = 5;               // Integer (whole number)
////double myDoubleNum = 5.99D;  // Floating point number
////char myLetter = 'D';         // Character
////bool myBool = true;          // Boolean
////string myText = "Hello";     // String

////The following data types are all of value type:

////bool
////byte
////char
////decimal
////double
////enum
////float
////int
////long
////sbyte
////short
////struct
////uint
////ulong
////ushort


////The followings are reference type data types:

////String
////Arrays(even if their elements are value types)
////Class
////Delegate

////heap and stack memory


////evrey thing comes from basic datatype 

////object a = "Rohatash Kumar"; IServiceProvider all reference type
////string a1 = a.ToString();

////Object: When we use the object keyword with a variable it can create a
////    problem at run time if the stored value is not converted to the appropriate
////    data type. It cannot show an error at compile time but it will show an error on run time.  wraped


////    dynamic  a = "Rohatash Kumar";
////string a1 = a;
////Dynamic: Casting is not required but you need to know the properties and methods related to the 
////    stored type.


////Array ...............................................................................................

////string[] cars;

////string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
////int[] myNum = { 10, 20, 30, 40 };



////var numbers = new int[5];
////numbers[0] = 1;
////numbers[1] = 2;
////numbers[3] = 3;
////numbers[4] = 4;
////numbers[5] = 5;

////for (int i = 0; i < numbers. Length; i++)
////{
////    Console .WriteLine(numbers[i]);
////}

////foreach(var item in numbers)
////{
////    Console.WriteLine(item);
////}

////int[] arr = new int[5];
////int i;


////for (i = 0; i < arr.Length; i++)
////{
////    Console.Write("enter  num : ");
////    arr[i] = int.Parse(Console.ReadLine());



////}

////foreach (var number in arr)

////{
////    if (number % 2 == 0)
////        Console.WriteLine(number);
////}

/////*Console*/.WriteLine(string.Join(".",arr));
/////



////conditios.................................................
////string i= "Two";
////int j = 2;

//////string res = i > j ? "i" : "j";

//////Console.WriteLine(res);


////switch (i.ToUpper())
////{
////    case "ONE":

////        Console.WriteLine("one");

////        break;
////    case "TWO":
////        Console.WriteLine("two");
////        break;
////    default:
////        Console.WriteLine("unknown");
////        break;

////}

////string @for = " thi is a text";
////foreach (char c in @for)
////{
////    Console.WriteLine(c);
////}


////string word = "raju";

////for (var i= word.Length - 1 ; i >=0 ; i--)
////{
////    Console.Write(word[i]);
////}


////string s = "this is a string";
//////s = s.ToUpper();
/////*Console.WriteLine(s)*/;

////Console.WriteLine(s.StartsWith("this", true, null));
////Console.WriteLine(s.StartsWith("this", StringComparison.InvariantCultureIgnoreCase));

////Console.WriteLine(s.Replace("a","the" , true, null));

////string name = null;
//////Console.WriteLine(data?.ToUpper());    null coaliasing operator

////name ??= "unknown";
////Console.WriteLine(name);

////int[] num = { 1, 1, 2, 3, 3, 4, 4, 5, 5, };

//// for(int i =0;i<=num.Length;i++)
////{
////    for(int j=i;j<num.Length;j++)

////        if (j ==i )
////    {

////            Console.WriteLine(num[j]);
////    }

////}


////Console.WriteLine("enter the word");
////var str = Console.ReadLine();

////for(int i=0;i<= str.Length;i++)
////{
////    for (int j = str.Length - 1; j >= 0; j--)

////        if (Str[j] == str[i])
////        {
////            Console.WriteLine("paliendrome");
////        }

////}


////while(true)
////{
////    Console.WriteLine("press any key to continue");
////    Console.ReadKey();

////}









////public class StarPattern
////{
////    public static void Main(string[] args)
////    {
////        for (int row = 1; row <= 5; ++row)
////        {
////            for (int col = 1; col <= row; ++col)
////            {
////                Console.Write("*");
////            }
////            Console.WriteLine();
////        }
////    }
////}
////int size;


////Console.WriteLine("enter the size: ");
////size = Convert.ToInt32(Console.ReadLine());
////for (int i = 1; i < size; i++)

////{
////    for (int j = 0; j < size; j++)
////    {
////        if (i == 1 || i == size || j == 1 || j == size)
////        {

////            Console.Write("*");

////        }

////        else
////        {
////            Console.Write(" ");
////        }


////int n;


////Console.WriteLine("enter the num");
////n= Convert.ToInt32(Console.ReadLine());





////        int i, j, k = 0;
////        for (i = 1; i <= n; i++) 
////        {
////            // Print spaces
////            for (j = i; j < n; j++)
////            {
////                Console.Write(" ");
////            }
////            // Print #
////            while (k != (2 * i - 1))
////            {
////                if (k == 0 || k == 2 * i - 2)
////                    Console.Write("*");
////                else
////                    Console.Write(" ");
////                k++;
////                ;
////            }
////            k = 0;

////            // print next row
////            Console.WriteLine();
////        }
////        // print last row
////        for (i = 0; i < 2 * n - 1; i++)
////        {
////            Console.Write("*");
////        }


////    Console.WriteLine(" ");


////NativeOverlapped 10th,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
////Function....




////void greet(string?  name=null)
////{
////greet("john");
////    Console.WriteLine("hello  "+ name );
////}



////Add(1 , 2);

////void Add(int x, int y) => Console.WriteLine($"the result is : {x + y}");





////Add(1,2);

////Add(1 , 5 ,6);
////Add(1 , 7 ,8 ,9,12,20);
////    void Add (  int x, int y,params int[] numbers)    /*                        imppp...*/
////{
////    Console.WriteLine(numbers.Sum() + x + y);
////}


////int res = Add(1, 2);
////Console.WriteLine(res);

////int Add(int x , int y) => x+ y;
////{
////    return x + y;
////}

////List............................


////    var lst = new List<int>();
////lst.Add(10);
////lst.Add(20);    
////lst.Add(30);

////Console.WriteLine(lst[0]);


////var arr1 = new int[] { 1, 2, 3, 4 };
////var arr2 = new int[arr1.Length];
////Array.Copy(arr1,  arr2, arr1.Length);

////arr1[0] = 10;

////Console.WriteLine(String.Join(",",arr1);
////Console.WriteLine(String.Join(",",arr2);



////string email = "               bimin2gmail.com  ";
////Console.WriteLine(email.TrimStart());



////var person = new Dictionary<string,string>();
////person.Add("name", "briju");
////person.Add("planet", "earth");
////Console.WriteLine(person["name"]);


////var text = "hello";
////if(text.GetType() == typeof(string))
////{
////    Console.WriteLine("its a string");
////}
//int? i = null;

//if (i is null)
//{
//    Console.WriteLine("yes");
//}


//class......nov 11

//var s1 = new student();
//s1.name = "STUDENT 1";
//s1.mark1 = 43;
//s1.mark2 = 45;
//s1.total();






//var student1 = new student();
//student1.name = "student 1";
//student1.mark1 = 23;
//student1.mark2= 34;\


//using pro1;
//using System.Runtime.ConstrainedExecution;

//var s1 = new student();


//Console.WriteLine("enter the name");

//s1.name = Console.ReadLine();

//Console.WriteLine("enter the mark1");

//s1.mark1 = int.Parse(Console.ReadLine());


//Console.WriteLine("enter the mark2");

//s1.mark2 = int.Parse(Console.ReadLine());

//int a = s1.total();
//Console.WriteLine("total=" +a);


//if ITS A private variable  use under score

using pro1;
var s1 = new employee()
{
    fullname = "jk",
    age = 34
};
Console.WriteLine(s1.fullname);
Console.WriteLine(s1.age);


