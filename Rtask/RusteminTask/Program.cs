// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string message = "C# is the most popular"; string newmessage = "Programming Language in the world";
Console.Write(message); Console.Write(newmessage);
Console.WriteLine(message); Console.WriteLine(newmessage);
//task 3

string name1 = "Rustam"; byte age = 21;
Console.WriteLine(name1 + age);

//task 3.2
int number = default(int); Console.WriteLine(number);
double number2 = default(double); Console.WriteLine(number2);
bool number3 = default(bool); Console.WriteLine(number3);
char number4 = default(char);
Console.WriteLine(number4); string? number5 = default;
Console.WriteLine(number5);

//task 4.1
int r = 4; var L = 4 * r * Math.PI;
Console.WriteLine(L);

//task 4.2
int R = 5; var S = 5 * R * R * Math.PI;
Console.WriteLine(S);

//task 4.3
/*int A = 15;
int B = 23;int C = 35;
Console.WriteLine(A + B + C);*/

//task 4.4int a = 4;
int b = 9; int c = a;
a = b; b = c;
Console.WriteLine(a); Console.WriteLine(b);

//task 4.5
/*int A = 3;int b = 7;
int c = 10;
Console.WriteLine(A*b%c);
//task 5string name = "Rustam";
string surname = "Nagiyev";Console.WriteLine($"{name} + {surname}");
*/