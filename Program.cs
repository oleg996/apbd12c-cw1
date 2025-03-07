// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
for (int i = 0; i < 100; i++)
{
    for (int b = 0; b < 100; b++)
    Console.Write((char)(i+(b*100)));
    
    Console.WriteLine("");
}