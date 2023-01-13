// See https://aka.ms/new-console-template for more information
using ConsoleCoreApp.Day4;
using ConsoleCoreApp.OOPS;
/*
Console.WriteLine("Hello, World!");
int x = 20;
Console.WriteLine($"value of x:{x}");
ConsoleCoreApp.Day4.Test.Main();
Test.Main();
*/

//ReadKey
/*
Console.WriteLine("Press any Key");
//ConsoleKeyInfo ck=Console.ReadKey();
ConsoleKeyInfo ck = Console.ReadKey(true);
Console.WriteLine("*");
//ck.Key =>ConsoleKey
//ck.Key =>char
Console.WriteLine($"Pressed key:{ck.Key}");
Console.WriteLine($"Pressed key keychar:{ck.KeyChar}");
*/
/*
String password = "";
Console.WriteLine("Enter your Password:");
*/
//logic goes here
/*
ConsoleKeyInfo  ck= Console.ReadKey(true);
while (ck.Key!= ConsoleKey.Enter)
{
    Console.Write("*");
    password += ck.KeyChar;
    ck= Console.ReadKey(true);
}
*/
/*
do
{
    ConsoleKeyInfo ck= Console.ReadKey(true);
    Console.WriteLine("*");
    if (ck.Key != ConsoleKey.Enter)
        password += ck.KeyChar;
    else
        break;
    } while (true);
Console.WriteLine($"Password is : {password}");
*/

/*
//using foreach
int[] arr = new int[5] { 1, 2, 3, 4, 5 };
Console.WriteLine("Array elements are:");
*/
/*
//forward only
//readonly
//foreach(type identifier in collection/array-name){
    //statements
}
*/
/*
foreach(int item in arr)
{
    //item=item+20; //invaalid
    Console.WriteLine(item);
}
*/
/*
//Boxing & UnBoxing
int num = 30;
object obj = num; //boxing
Console.WriteLine(obj);
int y =(int)obj;//unboxing
Console.WriteLine(y);
//float z = (float)obj;
//Console.WriteLine(z);

//object,var,dynamic
var v = num;
var a = v;
Console.WriteLine(v);
Console.WriteLine(a);

dynamic dvar = num;
int b = dvar;
Console.WriteLine(dvar);
Console.WriteLine(b);

int[] arr = new int[5] { 10, 20, 30, 40, 50 };
foreach (dynamic item in arr)   //var,object and dynamic is used but var & dynamic is preffered and var ia available in only local
{
    if (item == 20)
    {
        Console.WriteLine(arr);
    }
}
*/

/*
string s = "";
Console.WriteLine("Enter any Digit");
do
{
    ConsoleKeyInfo ck = Console.ReadKey(true);
    
    if (ck.Key != ConsoleKey.Enter)
    {
        s += ck.KeyChar;
    }
    else
        break;
}while(true);
Console.WriteLine($"String is :{s}");
*/
//------------------------------------------------------------------------------------------------
//12-1-2023
//------------------------------------------------------------------------------------------------

//Object Creation
/*
Employees employees = new Employees();
//Member Calling
employees.DisplayEmployeeDetails();//0,null,0
employees.SetEmployeeDetails(1000, "Gowtham", 250000.0f);
employees.DisplayEmployeeDetails();//1000

Employees emp2 = employees;
emp2.DisplayEmployeeDetails();//1000
emp2.SetEmployeeDetails(1001, "Sudarshan", 250000.0f);

employees.DisplayEmployeeDetails();//1001
emp2.DisplayEmployeeDetails();//1001

var emp3 = new Employees();
emp3.DisplayEmployeeDetails();//0,null,0
emp3.SetEmployeeDetails(1002, "Shubham", 254620.0f);
emp3.DisplayEmployeeDetails();//1002

dynamic emp4 = new Employees();


Employees emp5 = new();
emp5.DisplayEmployeeDetails();
*/

//Method Calling
//MethodCalling obj = new (); //or
/*
MethodCalling obj = new MethodCalling();
int num1 = 30, num2 = 50,sum,multi,div;
Console.WriteLine($"Num1:{num1}\tNum:{num2}");//30,50
obj.CallByValue(num1, num2);           //50,80
Console.WriteLine($"Num1:{num1}\tNum2:{num2}");//30,50

//obj.CallByRef(ref num1, ref num2);
//Console.WriteLine($"Num1:{num1}\tNum2:{num2}");//50,80

obj.CallByOutput(num1, num2, out sum, out multi, out div); //methodd returning multiple values
Console.WriteLine($"Sum:{sum}\tMultiplication:{multi}\tDivision:{div}");

obj.CallByNamedOptional(101, "Gowtham", "Budati", 50000.0f);

obj.CallByNamedOptional(fname: "Gowtham", surname: "Budati", id: 101);

obj.CallByNamedOptional(fname: "Gowtham", id:101,salary: 56789.0f);

obj.CallByNamedOptional(fname:"Gowtham",surname: "Budati",id:101,salary:56789.0f);
*/

//--------------------------------------------------------------------------------------------------------
//13-1-2023
//--------------------------------------------------------------------------------------------------------
/*
Employees emp1 = new Employees();
Employees emp2 = new();
Employees emp3 = new(101, "Gowtham", 75000);
Employees emp4 = new(102, "Sudarshan", 75000);
Employees emp5 = new(103, 75000);

emp1.DisplayEmployeeDetails();
emp2.DisplayEmployeeDetails();
emp3.DisplayEmployeeDetails();
emp4.DisplayEmployeeDetails();
emp5.DisplayEmployeeDetails();
GC.Collect(0
*/
/*
//Using Point Class
Point p1 = new Point(20, 30);
Point p2 = new Point(20, 30);

Point p3 = p1 + p2;
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

Point p4 = p1 - p2;
Console.WriteLine(p4);

if (p1==p2)
{
    Console.WriteLine("Both are same");
}
else
{
    Console.WriteLine("Both are Different");
}
*/
/*
//Using StaticDemo
StaticDemo s1 = new StaticDemo();
StaticDemo s2 = new StaticDemo();
StaticDemo s3 = new StaticDemo();
s3.DisplayId();//2
//s2.DisplayCount();  invalid
StaticDemo.DisplayCount();//3
s1.DisplayId();//0
*/

SingleTonPattern obj = SingleTonPattern.GetObject();
obj.Display();