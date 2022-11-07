namespace Module2_Practice2.Printers
{
    // Write data on Console
    public class ConsolePrinter : IPrinter
    {
        public void Print(string data)
        {
            Console.WriteLine($"{data}\n");
        }
    }
}
