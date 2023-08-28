// Functions
Console.WriteLine("This is the second project");//function call
//write line is the function name
//function call
//how to call a function? 
//function_name(ingredients) parameters
string userInputStr;
//userInputStr = Console.ReadLine(); // string

// define a function
// datatype function(parameters specification)
// {
// function body
// return ; 
// }

char GetLG(double fg)
{
    if (fg >= 90)
    {
        return 'A';
    }
    else
    {
        return 'H';
    }
    return 'H';
}

char c1; // simple int double bool char
c1 = GetLG(96.6); // function call
Console.WriteLine(c1);
char c2;
c2 = GetLG(90);
Console.WriteLine(c2);

// simple vs conplex variables
// simple: not expensive, int double bool char
// complex: expensive, otherwise it is complex
int i1; // integer, simple, not expensive
int age1; // i1 is the room card
i1 = 19;// simple
int i2;
i2 = i1;


//string
string str1;// string, complex, expensive, 0
str1 = new string("MIS3033"); // 112
//str1 = "3033";
string str2;
str2 = str1;// we only have one string. But we have two cards. 


// use class to define a complex datatype
// you need to know how to define functions
// you need to know how to define a class
Person p1;// Person, complex, expensive, 0
p1 = new Person();//
p1.name = "Braden FIsher";
p1.age = 20;
p1.weight = 140.6;

Person p2;
p2 = p1;
p2.name = "Someone else";

Console.WriteLine(p2.age);
Console.WriteLine(p1.name);
Console.WriteLine(p1.GetInfo());

Person p3;
p3 = new Person();


// a datatype is design, blueprint
public class Person// new datatype, datatype name is Person, complex
{
   public string name;// by default it is private
   public int age;
   public double weight;

   public string GetInfo()
    {
        return string.Format($"Name: {name}, Age: {age}, Weight:{weight:F2}");
    }
}
