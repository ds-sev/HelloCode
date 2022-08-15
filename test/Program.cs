int MyMethod(int a, int b)
{
    
    int result;
    result = a + b;
    return result;
}

Console.WriteLine("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Summ of this numbers: ");

int res = MyMethod(a, b);
Console.WriteLine(res);