//Funstions are now called as methods 
// The are set of instrutions 
// eg
// it fas name "add" , on left is return type . and on RHS in bracket (parameters)
 double Add (double a, double b) //here int is return type, and it has two parameters a&b (Arguments)
{
    double temp = a + b;
    return temp;
}
// int Add (int a, int b, int c) // using same name of functions
//  return a+b+c;

int substract (int a, int b)
{
    int temp = a - b;
    return temp;
}


int Multiply (int a, int b)
{
int temp = a * b;
    return temp;
}

int divided (int a, int b)
{
    int temp = a / b;
    return temp;

}

void print(string Message)
{
    Console.WriteLine(Message); 
}
//now calling function 
print("This is my first program. made by irfan sir ");
double result = Add(71.5 , 71.5);
Console.WriteLine($"result of addition is: {result}");  // method 1
Console.WriteLine($"result of substract is: { 386 - 243 }");  // method 2
Console.WriteLine($"result of multiply is:{Multiply(11 ,13)}"); //method 3
Console.WriteLine($"result of divided is:{286 / 2}");