// See https://aka.ms/new-console-template for more information
using Discussion1;
//using Discussion10;


Tasks t1 = new Tasks();

//discussion 10 tasks.............
//TaskDiscussion task=new TaskDiscussion();
//task.ArrayTask();

//Write a program to find whether a given year is a leap year or not.
System.Console.WriteLine("Enter the year:");
string yearString = System.Console.ReadLine();
int year = System.Convert.ToInt32(yearString);
System.Console.WriteLine(t1.IsLeapYear(number));



//Write a program to read the value of an integer m and display the value of n as 1 when m is larger than 0, 0 when m is 0, and -1 when m is less than 0.

System.Console.WriteLine("Enter number for which you want Identification:");
string second = System.Console.ReadLine();
int number2 = System.Convert.ToInt32(second);
System.Console.WriteLine(t1.NumberIdentification(number2));

//WAP to find the largest and smallest of three numbers.

int[] arr = new int[3];
for (int i = 1; i <= 3; i++)
{
    System.Console.WriteLine("Enter {0} th value", i);
    string third = System.Console.ReadLine();
    int number3 = System.Convert.ToInt32(third);
    arr[i - 1] = number3;
}
int[] ans = t1.getHighestLowest(arr);
//int Highest = ans.Split('')[0];
//int lowest = ans.Split(' ')[1];
System.Console.WriteLine("Highest value:{0}  lowest value:{1}", ans[0], ans[1]);


//WAP to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
System.Console.WriteLine("Enter x and y Cordinates:");
string xStr = System.Console.ReadLine();
int x = System.Convert.ToInt32(xStr);

string yStr = System.Console.ReadLine();
int y = System.Convert.ToInt32(yStr);
System.Console.WriteLine(t1.GetQuadrant(x, y));


//WAP to accept the marks of a student in Phy, Chem, and Maths. Calculate the total marks and the grade.
System.Console.WriteLine("Enter physics marks:");
string phyStr = System.Console.ReadLine();
int phy = System.Convert.ToInt32(phyStr);

System.Console.WriteLine("Enter Chemistry marks:");
string chemStr = System.Console.ReadLine();
int chem = System.Convert.ToInt32(chemStr);

System.Console.WriteLine("Enter Mathe,atics marks:");
string mathStr = System.Console.ReadLine();
int math = System.Convert.ToInt32(mathStr);

int[] marks = new int[3];
marks[0] = phy;
marks[1] = chem;
marks[2] = math;

System.Console.WriteLine(t1.GetGradeTotalMark(marks));


//WAP to take 3 sides of a triangle as input and find out if it is Equilateral, Isosceles, or Scalene.
System.Console.WriteLine("enter 3 sides of trainagle:");
string firstStr = System.Console.ReadLine();
int firstSide = System.Convert.ToInt32(firstStr);

string secondStr = System.Console.ReadLine();
int secondSide = System.Convert.ToInt32(secondStr);

string thirdStr = System.Console.ReadLine();
int thirdSide = System.Convert.ToInt32(thirdStr);

int[] sides = new int[3];
sides[0] = firstSide;
sides[1] = secondSide;
sides[2] = thirdSide;

System.Console.WriteLine(t1.GetTriangle(sides));



//WAP to take a single-digit positive number as input and print it in words.

System.Console.WriteLine("enter single digit number:");
int singledigit = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(t1.getDigitInstring(singledigit));







//task 1
// System.Console.WriteLine("Enter number for which you want sum:");
// string n = System.Console.ReadLine();
// int number = System.Convert.ToInt32(n);
// System.Console.WriteLine(t1.SumOfNumber(number));
