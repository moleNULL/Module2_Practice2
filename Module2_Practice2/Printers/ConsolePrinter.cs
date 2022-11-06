namespace Module2_Practice2.Printers
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string data)
        {
            Console.WriteLine(data + '\n');
        }
    }
}
