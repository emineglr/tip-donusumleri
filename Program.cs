// See https://aka.ms/new-console-template for more information

byte a = 5;
sbyte b = 30;
short c = 10;

int d = a+b+c;
Console.WriteLine("d", d);

long h = d;
Console.WriteLine("h", h);

float i = h;
Console.WriteLine("i",i);

string e = "Emine";
char f = 'k';
object g = e+f+d;
Console.WriteLine("g",g);


Console.WriteLine("********* Explicit Conversion*****");
int x = 4;
byte y =(byte)x;
Console.WriteLine("y",y);





