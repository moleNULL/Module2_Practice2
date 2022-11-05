namespace Module2_Practice2
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string data)
        {
            Console.WriteLine(data + '\n');
        }
    }
}
