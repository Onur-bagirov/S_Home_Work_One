Thread Time = new Thread(() =>
{
    for (int i = 0; i < 3; i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write($"\n\t Time : {DateTime.Now.ToLongTimeString()}");
        Console.ResetColor();
        Thread.Sleep(1000);
    }
});
Time.Start();

Thread Loading = new Thread(() =>
{
    for (int i = 0; i < 3; i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write($"\n\t Loading... {i+1}");
        Console.ResetColor();
        Thread.Sleep(200);
    }
});

Loading.Start();

Thread Input = new Thread(() =>
{
    for (int i = 0; i < 3; i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write($"\n\t Enter name : ");
        string input = Console.ReadLine();  
        Console.ResetColor();
        Thread.Sleep(300);
    }
});

Input.Start();