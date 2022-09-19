void WriteHello(string name)
{
    Console.WriteLine("Hello, " + name);
}
WriteHello(Console.ReadLine());

string HelloToWord(string name)
{
    return ("Hello, " + name);
}
String word = HelloToWord ("Tolya");
Console.WriteLine(word + " как дела?");