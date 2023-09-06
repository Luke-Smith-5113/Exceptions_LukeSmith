// See https://aka.ms/new-console-template for more information
using Exceptions_LukeSmith;

float f1 = 0.0f;
float f2 = 1.0f;
float result = 0;
Random rnd = new Random();
int ranInt = rnd.Next(2, 30);
ExceptClass e = new ExceptClass();
try
{ result = e.Divide(f2, f1); }
catch { Exception exception = new Exception(); Console.WriteLine(exception.Message); Console.WriteLine("Try inputing a non-zero floating point number");
    try { float userVal = float.Parse(Console.ReadLine()); result = e.Divide(f2, userVal); Console.WriteLine(result); }
    catch { Exception exception2 = new Exception(); Console.WriteLine(exception2.Message); }
}
finally { Console.WriteLine($"Calculations completed with a result of {result}"); }
try { e.CheckAge(ranInt); }
catch { Exception exception = new Exception(); Console.WriteLine(exception.Message); }