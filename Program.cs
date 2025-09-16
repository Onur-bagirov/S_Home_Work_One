Thread Time = new Thread(() =>
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write($"\rTime: {DateTime.Now.ToLongTimeString()}   ");
    Console.ResetColor();
    Thread.Sleep(1000);
});

Thread Loading = new Thread(() =>
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write($"\n\t Loading... ");
    Console.ResetColor();
    Thread.Sleep(300);
});

Thread Input = new Thread(() =>
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("Enter name : ");
    Console.ResetColor();
    string Input = Console.ReadLine();

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(Input);
    Console.ResetColor();
});

Time.Start();
Loading.Start();
Input.Start();