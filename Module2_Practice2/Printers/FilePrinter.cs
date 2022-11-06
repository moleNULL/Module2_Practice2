namespace Module2_Practice2.Printers
{
    public class FilePrinter : IPrinter
    {
        private string _path;

        public FilePrinter(string path)
        {
            _path = path;
        }

        public void Print(string data)
        {
            File.WriteAllText(_path, data);

            Console.WriteLine($"Data has been successfully written into {_path}");
        }
    }
}
