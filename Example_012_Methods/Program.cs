// Вид 1
void Method1()
{
    System.Console.WriteLine("Vit");
}
//Method1();

// Вид2
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
//Method2("Текст сообщения");

//Вид3

int Method3()
{
    return DateTime.Now.Year;
}

int Year = Method3();
//System.Console.WriteLine(Year);

// Вид4
string Method4(int count, string text)
{
    
    string result = String.Empty;
    for(int i = 0; i<count; i++)
    {
        result = result + text;
    }
    return result;
}
//string res = Method4(10, "asdf");
//System.Console.WriteLine(res);

//Цикл в уикле

for(int i = 2; i <= 10; i++)
{
    for( int j = 2; j <= 10; j ++)
    {
        System.Console.WriteLine($"{i} * {j} = {i * j}");
    }
    System.Console.WriteLine();
}