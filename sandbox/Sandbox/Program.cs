using System;
class Program
{
    static void Main(string[] args)
    {
        List<string> spinner = new List<string>
        {
            "|", "/", "-", "\\"
        };
        Console.WriteLine("5 Second Countdown");
        Thread.Sleep(3000);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");
            i++;
            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine("Time's up!");
        Console.WriteLine("Exiting the program.");
        

    }
}
