int a = 20;
int b = 4;

Add(a, b);
Add(10, 100);
Add(56583, 658686);

Multiply(a, b);
Multiply(10, 100);
Multiply(56583, 658686);


Substract(a, b);
Divide(a, b);;
static void Add(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x+y}");
}

static void Multiply(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}

static void Substract(int x, int y)
{
    Console.WriteLine($"{x} - {y} = {x - y}");
}

static void Divide(int x, int y)
{
    Console.WriteLine($"{x} / {y} = {x / y}");
}

